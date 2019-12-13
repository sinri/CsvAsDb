using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CsvAsDb
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> headerFieldNameMap;
        //private List<FieldFilterConfigEntity> fieldFilterConfigList;
        private PluginInterface plugin;
        private void SelectCsvDirBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                SourceDirTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void LoadCSVBtn_Click(object sender, EventArgs e)
        {
            WriteLog("Begin to load csv to database...");
            /*
            // save
            saveFileDialog1.DefaultExt = ".csv";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            */

            toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
            toolStripProgressBar1.Value = 0;
            bwForLoadCsvToDb.RunWorkerAsync();


        }
        private void bwForLoadCsvToDb_DoWork(object sender, DoWorkEventArgs e)
        {
            WriteLog("Begin");

            try
            {
                plugin = PluginInterface.buildPluginByCode(PreprocessPluginCodeTextBox.Text, this);
                WriteLog("Loaded Plugin: " + plugin);

                Dictionary<string, string> fieldFilterConfigDict = new Dictionary<string, string>();
                /*
                foreach (var item in fieldFilterConfigList)
                {
                    fieldFilterConfigDict.Add(item.ColumnName, item.FilterCode);
                    WriteLog("FILTER ITEM: " + item.ColumnName + " => " + item.FilterCode, "DEBUG");
                }
                */

                for (int i=0;i< ColumnFilterDataGridView.Rows.Count;i++)
                {
                    if (ColumnFilterDataGridView.Rows[i].Cells[0].Value == null || ColumnFilterDataGridView.Rows[i].Cells[1].Value==null) continue;
                    WriteLog("CHECK FILTER ITEM: "+i, "DEBUG");
                    fieldFilterConfigDict.Add((string)ColumnFilterDataGridView.Rows[i].Cells[0].Value, (string)ColumnFilterDataGridView.Rows[i].Cells[1].Value);
                }
                foreach(var item in fieldFilterConfigDict)
                {
                    WriteLog("FILTER ITEM: " + item.Key + " => " + item.Value, "DEBUG");
                }

                string[] files = CSVParser.ReadFilesInDir(SourceDirTextBox.Text, ".csv");

                if (files.Length <= 0)
                {
                    WriteLog("No CSV File Found", "WARNING");
                    return;
                }

                var parser = new CSVParser(
                    Convert.ToInt32(CPSColumnsLimitationNumber.Value),
                    CPSHasHeaderCheckerBox.Checked,
                    Convert.ToInt32(CPSIgnoreHeaderRowsNumber.Value),
                    Convert.ToInt32(CPSIgnoreTailRowsNumber.Value),
                    CPSIgnoreQuotesCheckerBox.Checked,
                    fieldFilterConfigDict,
                    plugin.ExtraFields()
                );

                CurrentTableName = "excel";// "table_" + (new Random()).Next();
                TheSqliteAgent = new SqliteAgent(CurrentTableName);

                Regex regexForRemoveNumbers = new Regex("[0-9]+");
                
                

                bool isFirstFile = true;
                for (int i = 0; i < files.Length; i++)
                {
                    var file = files[i];
                    WriteLog("Opening file [" + (i + 1) + "/" + files.Length + "]: " + file);
                    parser.OpenFileAndLoadFields(file);

                    List<string> headers = parser.GetCurrentHeaders();
                    List<string> fieldNames = parser.GetAutoFieldNames();
                    /*
                     * Column Title -> Field_X
                     */ 
                    headerFieldNameMap = parser.GetHeaderFieldNameDictionary();
                    /*
                    for (int j = 0; j < fieldNames.Count; j++)
                    {
                        WriteLog("PARSED HEADER: " + headers[j] + " => " + fieldNames[j],"DEBUG");
                    }
                    */

                    if (isFirstFile)
                    {
                        // create SQLite Table
                        if (headerFieldNameMap.Count > 0)
                        {
                            TheSqliteAgent.EnsureTableWithFields(new List<string>(headerFieldNameMap.Values));
                        }
                        else
                        {
                            TheSqliteAgent.EnsureTableWithFields(fieldNames);
                        }
                        // then
                        isFirstFile = false;
                    }
                    Dictionary<string, string> rowDict;
                    
                    while ((rowDict = parser.SafeReadOneRow()) != null)
                    {
                        Dictionary<string, string> dataRow = new Dictionary<string, string>();
                        foreach (var entry in rowDict)
                        {
                            //WriteLog("Entry: " + entry.Key + " => " + entry.Value,"DEBUG");
                            if (!headerFieldNameMap.ContainsKey(entry.Key))
                            {
                                continue;
                            }
                            String process_value = String.Copy(entry.Value);
                            if (fieldFilterConfigDict.Count > 0)
                            {
                                string filterCode = "ORIGINAL";
                                if (fieldFilterConfigDict.ContainsKey(entry.Key))
                                {
                                    filterCode = fieldFilterConfigDict[entry.Key];
                                }
                                switch (filterCode)
                                {
                                    case "REMOVE_NUMBERS":
                                        process_value = regexForRemoveNumbers.Replace(process_value, "");
                                        break;
                                    case "ORIGINAL":
                                    default:
                                        // do nothing
                                        break;
                                }
                            }
                            dataRow.Add(headerFieldNameMap[entry.Key], process_value);
                        }

                        // todo: preprocess
                        if (plugin != null)
                        {
                            plugin.PreprocessRawRow(dataRow, headerFieldNameMap);
                        }
                        /*
                        if (pluginCodes.Count>0)
                        {
                            //var pluginCodes=PreprocessPluginCodeTextBox.Text.Trim().Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries);
                            //WriteLog("plugin codes: " + pluginCodes,"DEBUG");
                            
                            
                            for(int pluginIndex = 0; pluginIndex < pluginCodes.Count; pluginIndex++)
                            {
                                //WriteLog("Handle plugin [" + pluginIndex + "] : " + pluginCodes[pluginIndex],"DEBUG");
                                switch (pluginCodes[pluginIndex])
                                {
                                    case "WSQ_A":
                                        if (wsq_a_target_list.Contains(dataRow[headerFieldNameMap["业务类型"]]))
                                        {
                                            dataRow[headerFieldNameMap["备注"]] = "";
                                            dataRow[headerFieldNameMap["对方账号"]] = "";
                                        }
                                        break;
                                    default:
                                        WriteLog("Not a registered plugin, ignored","WARNING");
                                        break;
                                }
                            }
                            
                        }
                        */

                        TheSqliteAgent.InsertRow(dataRow);
                    }

                    parser.CloseReader();
                    // finally
                    bwForLoadCsvToDb.ReportProgress(100 * (i + 1) / files.Length);
                }


                WriteLog("Done");
            }catch(Exception exception)
            {
                WriteLog("Exception: " + exception.Message, "ERROR");
                WriteLog("Stack: " + exception.StackTrace, "ERROR");
            }
        }

        private void bwForLoadCsvToDb_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bw_ProgressChanged(sender, e);
        }

        private void bwForLoadCsvToDb_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bw_RunWorkerCompleted(sender, e);

            if (TheSqliteAgent != null)
            {
                string x = "Table Name is " + CurrentTableName + " \r\n" +
                    "The fields are: \r\n";
                foreach(var entry in headerFieldNameMap)
                {
                    x += "> " + entry.Key + " => " + entry.Value + " \r\n";
                }
                UsableTableInfoTextBox.Text = x;

                if (plugin != null)
                {
                    QuerySqlTextBox.Text = plugin.GetSqlTemplate(CurrentTableName);
                }
                else
                {
                    QuerySqlTextBox.Text = "select * \r\nfrom " + CurrentTableName + " \r\nlimit 5";
                }
                
            }
        }
    }
}