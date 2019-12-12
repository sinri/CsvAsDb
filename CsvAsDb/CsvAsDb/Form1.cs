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

        //List<string> wsq_a_target_list { get; set; }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ColumnFilterDataGridView.Rows.Add(new object[]{ "业务类型","ORIGINAL"});
            ColumnFilterDataGridView.Rows.Add(new object[] { "备注", "REMOVE_NUMBERS" });
            ColumnFilterDataGridView.Rows.Add(new object[] { "对方账号", "ORIGINAL" });
            ColumnFilterDataGridView.Rows.Add(new object[] { "收入金额（+元）", "ORIGINAL" });
            ColumnFilterDataGridView.Rows.Add(new object[] { "支出金额（-元）", "ORIGINAL" });
            
            /*
            wsq_a_target_list = new List<string>();
            wsq_a_target_list.Add("交易付款");
            wsq_a_target_list.Add("交易退款");
            wsq_a_target_list.Add("在线支付");
            */
        }

        private void LoadCategoryDictionaryFileBtn_Click(object sender, EventArgs e)
        {
            DialogResult openResult =openFileDialog1.ShowDialog();
            if (openResult != DialogResult.OK)
            {
                WriteLog("Open File Not OK: "+ openResult.ToString());
                return;
            }

            WriteLog("Loading category dictionary file: " + openFileDialog1.FileName);

            var parser = new CSVParser(0,true,0,0,false,new Dictionary<string, string>());

            parser.OpenFileAndLoadFields(openFileDialog1.FileName);
            var headerDict=parser.GetHeaderFieldNameDictionary();

            CategoryFilterDataGridView.Rows.Clear();
            CategoryFilterDataGridView.Columns.Clear();
            CategoryFilterDataGridView.DataSource = null;

            foreach (var entry in headerDict)
            {
                CategoryFilterDataGridView.Columns.Add(entry.Key, entry.Key);
            }

            Dictionary<string, string> row;
            while ((row = parser.SafeReadOneRow())!=null)
            {
                var temp = new object[headerDict.Count];
                int i = 0;
                foreach(var entry in headerDict)
                {
                    string s;
                    row.TryGetValue(entry.Key, out s);
                    temp[i] = s;
                    i++;
                }
                
                CategoryFilterDataGridView.Rows.Add(temp);
                //CategoryFilterDataGridView.Rows[CategoryFilterDataGridView.Rows.Count-1].HeaderCell.Value = ""+ CategoryFilterDataGridView.Rows.Count;
            }

            WriteLog("Category dictionary loaded");
            
        }

        private void SaveCategoryDictionaryFileBtn_Click(object sender, EventArgs e)
        {
            var dialogResult=saveFileDialog1.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                if (dialogResult != DialogResult.OK)
                {
                    WriteLog("Target File Not OK: " + dialogResult.ToString());
                    return;
                }
            }

            WriteLog("Begin writing category dictionary to " + saveFileDialog1.FileName);

            var writer = new CSVFileOutputAgent(saveFileDialog1.FileName, false);

            List<string> headerRow = new List<string>();
            for(int i=0;i< CategoryFilterDataGridView.Columns.Count; i++)
            {
                headerRow.Add(CategoryFilterDataGridView.Columns[i].HeaderText);
            }

            writer.WriteHeaderRow(headerRow);

            for (int i = 0; i < CategoryFilterDataGridView.Rows.Count; i++)
            {
                List<string> contentRow = new List<string>();

                bool hasContent = false;

                for (int j = 0; j < CategoryFilterDataGridView.Columns.Count; j++)
                {
                    string x = (string)CategoryFilterDataGridView.Rows[i].Cells[j].Value;
                    if (x != null)
                    {
                        hasContent = true;
                    }
                    contentRow.Add(x);
                }

                if (hasContent)
                {
                    writer.WriteOneRowWithColumnIndex(contentRow);
                }
            }

            writer.FinishWrite();

            WriteLog("Finished writing category dictionary");
        }

        private void ResetCategoryDictionaryGridBtn_Click(object sender, EventArgs e)
        {
            CategoryFilterDataGridView.Rows.Clear();
            CategoryFilterDataGridView.Columns.Clear();
            CategoryFilterDataGridView.DataSource = null;
            CategoryFilterDataGridView.Columns.Add("归类", "归类");
            CategoryFilterDataGridView.Columns.Add("业务类型", "业务类型");
            CategoryFilterDataGridView.Columns.Add("备注", "备注");

            
        }
    }
}
