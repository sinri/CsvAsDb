﻿using System;
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

        //List<string> wsq_a_target_list { get; set; }

        public Form1()
        {
            InitializeComponent();
        }


        public void WriteLog(string log,string level="INFO")
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            /*
            wsq_a_target_list = new List<string>();
            wsq_a_target_list.Add("交易付款");
            wsq_a_target_list.Add("交易退款");
            wsq_a_target_list.Add("在线支付");
            */

            // test on vmware
            //SourceDirTextBox.Text = @"\\vmware-host\Shared Folders\下载\ahc-201911_2088131570315721\xxx";

            richTextBox1.Text = Properties.Resources.AboutContentFile;

            this.Text = "CSV as Database Toolkit [" + Properties.Resources.ProjectVersion + "] - Leqee - Sinri Edogawa";

            PreprocessPluginCodeCombo.SelectedItem = "FREE";


        }

        private void PreprocessPluginCodeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnFilterDataGridView.Rows.Clear();
            //ColumnFilterDataGridView.Columns.Clear();
            //ColumnFilterDataGridView.DataSource = null;


            switch (PreprocessPluginCodeCombo.Text)
            {   
                case "WSQ_A":
                    {
                        ColumnFilterDataGridView.Rows.Add(new object[] { "业务类型", "ORIGINAL" });
                        ColumnFilterDataGridView.Rows.Add(new object[] { "备注", "REMOVE_NUMBERS" });
                        ColumnFilterDataGridView.Rows.Add(new object[] { "对方账号", "ORIGINAL" });
                        ColumnFilterDataGridView.Rows.Add(new object[] { "收入金额（+元）", "ORIGINAL" });
                        ColumnFilterDataGridView.Rows.Add(new object[] { "支出金额（-元）", "ORIGINAL" });

                        PluginDescriptionTextBox.Text = Properties.Resources.PluginDescWsqA;
                    }
                    break;
                case "YLN_A":
                    {
                        ColumnFilterDataGridView.Rows.Add(new object[] { "业务类型", "ORIGINAL" });
                        ColumnFilterDataGridView.Rows.Add(new object[] { "备注", "ORIGINAL" });
                        //ColumnFilterDataGridView.Rows.Add(new object[] { "对方账号", "ORIGINAL" });
                        ColumnFilterDataGridView.Rows.Add(new object[] { "收入金额（+元）", "ORIGINAL" });
                        ColumnFilterDataGridView.Rows.Add(new object[] { "支出金额（-元）", "ORIGINAL" });

                        PluginDescriptionTextBox.Text = Properties.Resources.PluginDescYlnA;
                    }
                    break;
                case "ZY_A":
                    {
                        ColumnFilterDataGridView.Rows.Add(new object[] { "业务类型", "ORIGINAL" });
                        ColumnFilterDataGridView.Rows.Add(new object[] { "备注", "ORIGINAL" });
                        //ColumnFilterDataGridView.Rows.Add(new object[] { "对方账号", "ORIGINAL" });
                        ColumnFilterDataGridView.Rows.Add(new object[] { "收入金额（+元）", "ORIGINAL" });
                        ColumnFilterDataGridView.Rows.Add(new object[] { "支出金额（-元）", "ORIGINAL" });

                        PluginDescriptionTextBox.Text = Properties.Resources.PluginDescZyA;
                    }
                    break;
                case "FREE":                    
                default:
                    PluginDescriptionTextBox.Text = "No plugin used. All configurations should be set manually.";
                    break;
            }
        }

    }
}
