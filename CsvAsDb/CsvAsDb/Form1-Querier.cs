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
                var reader = TheSqliteAgent.QueryResultRows(QuerySqlTextBox.Text);


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
                        WriteLog("Field: " + reader.GetName(i));
                        WriteLog("Type: " + reader.GetDataTypeName(i));
                        WriteLog("C#T: " + reader.GetFieldType(i));

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
                        WriteLog("Value: " + value);

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
    }
}