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
        delegate void SafeSetText(string strMsg);

        protected string CurrentTableName { set; get; }
        SqliteAgent TheSqliteAgent { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void WriteLog(string log,string level="INFO")
        {
            SafeSetText objSet = delegate (string str)
            {
                logTextBox.Text += str+"\r\n";
            };
            
            logTextBox.Invoke(objSet, new object[] {
                DateTime.Now+" [" + level+"] "+ log 
            });
        }

        private void LabBtn1_Click(object sender, EventArgs e)
        {
            SqliteTest1();
        }

        

        

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Value = 100;
        }

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
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        WriteLog("Field: " + reader.GetName(i));
                        WriteLog("Type: " + reader.GetDataTypeName(i));
                        WriteLog("C#T: " + reader.GetFieldType(i));
                        /*
                         * typeof(object),   // Uninitialized (0)
      typeof(Int64),    // Int64 (1)
      typeof(Double),   // Double (2)
      typeof(string),   // Text (3)
      typeof(byte[]),   // Blob (4)
      typeof(object),   // Null (5)
      typeof(DateTime), // DateTime (10)
      typeof(object)    // None (11)
                         */
                        var type = reader.GetDataTypeName(i).ToUpper();
                        string value;
                        switch (type)
                        {
                            case "INTEGER":
                                value = ""+reader.GetInt64(i);
                                break;
                            case "REAL":
                                value = "" + reader.GetDouble(i);
                                break;
                            case "TEXT":
                                value = reader.GetString(i);
                                break;
                            default:
                                value = ""+reader.GetValue(i);
                                break;
                        }
                        WriteLog("Value: " + value);
                        
                    }
                }
            }catch(Exception exception)
            {
                WriteLog("Exception: " + exception.Message, "ERROR");
                WriteLog("Stack: " + exception.StackTrace, "ERROR");
            }
        }

    }
}
