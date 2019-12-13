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
        private void LoadCategoryDictionaryFileBtn_Click(object sender, EventArgs e)
        {
            DialogResult openResult = openFileDialog1.ShowDialog();
            if (openResult != DialogResult.OK)
            {
                WriteLog("Open File Not OK: " + openResult.ToString());
                return;
            }

            WriteLog("Loading category dictionary file: " + openFileDialog1.FileName);

            var parser = new CSVParser(0, true, 0, 0, false, new Dictionary<string, string>(),null);

            parser.OpenFileAndLoadFields(openFileDialog1.FileName);
            var headerDict = parser.GetHeaderFieldNameDictionary();

            CategoryFilterDataGridView.Rows.Clear();
            CategoryFilterDataGridView.Columns.Clear();
            CategoryFilterDataGridView.DataSource = null;

            foreach (var entry in headerDict)
            {
                CategoryFilterDataGridView.Columns.Add(entry.Key, entry.Key);
            }

            Dictionary<string, string> row;
            while ((row = parser.SafeReadOneRow()) != null)
            {
                var temp = new object[headerDict.Count];
                int i = 0;
                foreach (var entry in headerDict)
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
            var dialogResult = saveFileDialog1.ShowDialog();
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
            for (int i = 0; i < CategoryFilterDataGridView.Columns.Count; i++)
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
                    if (x != null && !x.Equals(""))
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

        public List<Dictionary<string, string>> FetchCategoryRules(out List<string> columnNames)
        {
            columnNames = new List<string>();
            for(int i=0;i< CategoryFilterDataGridView.Columns.Count; i++)
            {
                columnNames.Add((string)(CategoryFilterDataGridView.Columns[i].HeaderCell.Value));
            }

            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            for(int i = 0; i < CategoryFilterDataGridView.Rows.Count; i++)
            {
                bool hasContent = false;
                Dictionary<string, string> contentRow = new Dictionary<string, string>();

                for (int j = 0; j < CategoryFilterDataGridView.Columns.Count; j++)
                {
                    string x = (string)CategoryFilterDataGridView.Rows[i].Cells[j].Value;
                    if (x != null && !x.Equals(""))
                    {
                        hasContent = true;
                    }
                    contentRow.Add(columnNames[j],x);
                    //WriteLog("Category Rules: " + columnNames[j] + " => <" + x+">");
                }

                if (hasContent)
                {
                    list.Add(contentRow);
                }
            }

            return list;
        }
    }
}