using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CsvAsDb
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> headerFieldNameMap;
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

            // save
            saveFileDialog1.DefaultExt = ".csv";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
                toolStripProgressBar1.Value = 0;
                bwForLoadCsvToDb.RunWorkerAsync();

            }
        }
        private void bwForLoadCsvToDb_DoWork(object sender, DoWorkEventArgs e)
        {
            WriteLog("Begin");

            try
            {

                var parser = new CSVParser(
                    Convert.ToInt32(CPSColumnsLimitationNumber.Value),
                    CPSHasHeaderCheckerBox.Checked,
                    Convert.ToInt32(CPSIgnoreHeaderRowsNumber.Value),
                    Convert.ToInt32(CPSIgnoreTailRowsNumber.Value),
                    CPSIgnoreQuotesCheckerBox.Checked
                );

                string[] files = parser.ReadFilesInDir(SourceDirTextBox.Text, ".csv");

                if (files.Length <= 0)
                {
                    WriteLog("No CSV File Found", "WARNING");
                    return;
                }

                CurrentTableName = "excel";// "table_" + (new Random()).Next();
                TheSqliteAgent = new SqliteAgent(CurrentTableName);

                bool isFirstFile = true;
                for (int i = 0; i < files.Length; i++)
                {
                    var file = files[i];
                    WriteLog("Opening file [" + (i + 1) + "/" + files.Length + "]: " + file);
                    parser.OpenFileAndLoadFields(file);

                    List<string> headers = parser.GetCurrentHeaders();
                    List<string> fieldNames = parser.GetAutoFieldNames();
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
                        TheSqliteAgent.EnsureTableWithFields(fieldNames);
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
                            dataRow.Add(headerFieldNameMap[entry.Key], entry.Value);
                        }
                        TheSqliteAgent.InsertRow(dataRow);
                    }

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
            }
        }
    }
}