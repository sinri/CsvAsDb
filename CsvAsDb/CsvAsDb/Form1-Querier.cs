using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvAsDb
{
    public partial class Form1 : Form
    {
        private void QuerySqlBtn_Click(object sender, EventArgs e)
        {
            if (TheSqliteAgent == null)
            {
                WriteLog("No SQLite Agent");
                return;
            }

            try
            {
                WriteLog("Querying sql: " + QuerySqlTextBox.Text);
                var reader = TheSqliteAgent.QueryResultRows(QuerySqlTextBox.Text);

                WriteLog("Rendering Query Result...");
                queryResultDataGridView.Rows.Clear();
                queryResultDataGridView.Columns.Clear();
                queryResultDataGridView.DataSource = null;
                //queryResultDataGridView.AutoGenerateColumns = true;

                //List<Dictionary<string, string>> allRows = new List<Dictionary<string, string>>();

                while (reader.Read())
                {
                    if (queryResultDataGridView.Columns.Count == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            queryResultDataGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                        }
                    }

                    Dictionary<string, string> oneRow = new Dictionary<string, string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        /*
                        WriteLog("Field: " + reader.GetName(i),"DEBUG");
                        WriteLog("Type: " + reader.GetDataTypeName(i), "DEBUG");
                        WriteLog("C#T: " + reader.GetFieldType(i), "DEBUG");
                        */
                        var type = reader.GetDataTypeName(i).ToUpper();
                        string value;
                        switch (type)
                        {
                            case "INTEGER":
                                value = "" + reader.GetInt64(i);
                                break;
                            case "REAL":
                                value = "" + reader.GetDouble(i);
                                break;
                            case "TEXT":
                                value = reader.GetString(i);
                                break;
                            default:
                                value = "" + reader.GetValue(i);
                                break;
                        }
                        //WriteLog("Value: " + value, "DEBUG");

                        oneRow.Add(reader.GetName(i), value);
                    }
                    queryResultDataGridView.Rows.Add(oneRow.Values.ToArray<object>());
                    //allRows.Add(oneRow);
                }
                //queryResultDataGridView.DataSource = allRows;
            }
            catch (Exception exception)
            {
                WriteLog("Exception: " + exception.Message, "ERROR");
                WriteLog("Stack: " + exception.StackTrace, "ERROR");
            }

        }

        private void ExportSqlBtn_Click(object sender, EventArgs e)
        {
            if (TheSqliteAgent == null)
            {
                WriteLog("No SQLite Agent");
                return;
            }

            saveFileDialog1.DefaultExt = ".csv";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;

            var writer = new CSVFileOutputAgent(saveFileDialog1.FileName, false);
            WriteLog("Prepared output CSV file: " + saveFileDialog1.FileName);

            try
            {
                WriteLog("Querying sql: \n\r" + QuerySqlTextBox.Text);
                var reader = TheSqliteAgent.QueryResultRows(QuerySqlTextBox.Text);

                bool isFirstRow = true;

                while (reader.Read())
                {
                    if (isFirstRow)
                    {
                        List<string> headers = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var header = reader.GetName(i);
                            headers.Add(header);
                        }
                        writer.WriteHeaderRow(headers);
                        isFirstRow = false;
                    }
                    List<string> oneRow = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {

                        var type = reader.GetDataTypeName(i).ToUpper();
                        string value;
                        switch (type)
                        {
                            case "INTEGER":
                                value = "" + reader.GetInt64(i);
                                break;
                            case "REAL":
                                value = "" + reader.GetDouble(i);
                                break;
                            case "TEXT":
                                value = reader.GetString(i);
                                break;
                            default:
                                value = "" + reader.GetValue(i);
                                break;
                        }
                        //WriteLog("Value: " + value, "DEBUG");

                        oneRow.Add(value);
                    }
                    //queryResultDataGridView.Rows.Add(oneRow.Values.ToArray<object>());
                    //allRows.Add(oneRow);

                    writer.WriteOneRowWithColumnIndex(oneRow);
                }

                writer.FinishWrite();
                WriteLog("Finished export!");
            }
            catch (Exception exception)
            {
                WriteLog("Exception: " + exception.Message, "ERROR");
                WriteLog("Stack: " + exception.StackTrace, "ERROR");
            }
        }
    }
}

/*
select Field_10 ,Field_11, Field_5,count(*) 
from excel 
group by Field_10 ,Field_11, Field_5
limit 5
;
select Field_10 as  业务类型,Field_11 as 备注,Field_5 as 对方账号,sum(Field_6) as 总收入 ,sum(Field_7) as 总支出
from excel 
group by Field_10 ,Field_11 ,Field_5 
*/
