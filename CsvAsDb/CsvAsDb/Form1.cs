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

        
    }
}
