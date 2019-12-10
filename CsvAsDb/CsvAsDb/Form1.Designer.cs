namespace CsvAsDb
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labBtn1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LoadCSVBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CPSIgnoreQuotesCheckerBox = new System.Windows.Forms.CheckBox();
            this.CPSIgnoreTailRowsNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CPSIgnoreHeaderRowsNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CPSColumnsLimitationNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CPSHasHeaderCheckerBox = new System.Windows.Forms.CheckBox();
            this.SelectCsvDirBtn = new System.Windows.Forms.Button();
            this.SourceDirTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.QuerySqlBtn = new System.Windows.Forms.Button();
            this.QuerySqlTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bwForLoadCsvToDb = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.UsableTableInfoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPSIgnoreTailRowsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPSIgnoreHeaderRowsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPSColumnsLimitationNumber)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.logTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1597, 882);
            this.splitContainer1.SplitterDistance = 1042;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 858);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labBtn1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1010, 823);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labBtn1
            // 
            this.labBtn1.Location = new System.Drawing.Point(6, 5);
            this.labBtn1.Margin = new System.Windows.Forms.Padding(4);
            this.labBtn1.Name = "labBtn1";
            this.labBtn1.Size = new System.Drawing.Size(147, 44);
            this.labBtn1.TabIndex = 0;
            this.labBtn1.Text = "button1";
            this.labBtn1.UseVisualStyleBackColor = true;
            this.labBtn1.Click += new System.EventHandler(this.LabBtn1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LoadCSVBtn);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.SelectCsvDirBtn);
            this.tabPage2.Controls.Add(this.SourceDirTextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1010, 823);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Load CSV Directory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LoadCSVBtn
            // 
            this.LoadCSVBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadCSVBtn.Location = new System.Drawing.Point(544, 346);
            this.LoadCSVBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LoadCSVBtn.Name = "LoadCSVBtn";
            this.LoadCSVBtn.Size = new System.Drawing.Size(449, 40);
            this.LoadCSVBtn.TabIndex = 4;
            this.LoadCSVBtn.Text = "Load CSV and Build Database";
            this.LoadCSVBtn.UseVisualStyleBackColor = true;
            this.LoadCSVBtn.Click += new System.EventHandler(this.LoadCSVBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CPSIgnoreQuotesCheckerBox);
            this.groupBox1.Controls.Add(this.CPSIgnoreTailRowsNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CPSIgnoreHeaderRowsNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CPSColumnsLimitationNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CPSHasHeaderCheckerBox);
            this.groupBox1.Location = new System.Drawing.Point(20, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(973, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CSV Parse Settings";
            // 
            // CPSIgnoreQuotesCheckerBox
            // 
            this.CPSIgnoreQuotesCheckerBox.AutoSize = true;
            this.CPSIgnoreQuotesCheckerBox.Location = new System.Drawing.Point(13, 191);
            this.CPSIgnoreQuotesCheckerBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CPSIgnoreQuotesCheckerBox.Name = "CPSIgnoreQuotesCheckerBox";
            this.CPSIgnoreQuotesCheckerBox.Size = new System.Drawing.Size(267, 25);
            this.CPSIgnoreQuotesCheckerBox.TabIndex = 7;
            this.CPSIgnoreQuotesCheckerBox.Text = "Ignore Illegal Quotes";
            this.CPSIgnoreQuotesCheckerBox.UseVisualStyleBackColor = true;
            // 
            // CPSIgnoreTailRowsNumber
            // 
            this.CPSIgnoreTailRowsNumber.Location = new System.Drawing.Point(596, 80);
            this.CPSIgnoreTailRowsNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CPSIgnoreTailRowsNumber.Name = "CPSIgnoreTailRowsNumber";
            this.CPSIgnoreTailRowsNumber.Size = new System.Drawing.Size(108, 31);
            this.CPSIgnoreTailRowsNumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ignore Tail Rows:";
            // 
            // CPSIgnoreHeaderRowsNumber
            // 
            this.CPSIgnoreHeaderRowsNumber.Location = new System.Drawing.Point(240, 80);
            this.CPSIgnoreHeaderRowsNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CPSIgnoreHeaderRowsNumber.Name = "CPSIgnoreHeaderRowsNumber";
            this.CPSIgnoreHeaderRowsNumber.Size = new System.Drawing.Size(108, 31);
            this.CPSIgnoreHeaderRowsNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ignore Header Rows:";
            // 
            // CPSColumnsLimitationNumber
            // 
            this.CPSColumnsLimitationNumber.Location = new System.Drawing.Point(240, 138);
            this.CPSColumnsLimitationNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CPSColumnsLimitationNumber.Name = "CPSColumnsLimitationNumber";
            this.CPSColumnsLimitationNumber.Size = new System.Drawing.Size(108, 31);
            this.CPSColumnsLimitationNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columns Limitation:";
            // 
            // CPSHasHeaderCheckerBox
            // 
            this.CPSHasHeaderCheckerBox.AutoSize = true;
            this.CPSHasHeaderCheckerBox.Location = new System.Drawing.Point(11, 35);
            this.CPSHasHeaderCheckerBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CPSHasHeaderCheckerBox.Name = "CPSHasHeaderCheckerBox";
            this.CPSHasHeaderCheckerBox.Size = new System.Drawing.Size(223, 25);
            this.CPSHasHeaderCheckerBox.TabIndex = 0;
            this.CPSHasHeaderCheckerBox.Text = "Header Row Exists";
            this.CPSHasHeaderCheckerBox.UseVisualStyleBackColor = true;
            // 
            // SelectCsvDirBtn
            // 
            this.SelectCsvDirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectCsvDirBtn.Location = new System.Drawing.Point(827, 44);
            this.SelectCsvDirBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SelectCsvDirBtn.Name = "SelectCsvDirBtn";
            this.SelectCsvDirBtn.Size = new System.Drawing.Size(166, 38);
            this.SelectCsvDirBtn.TabIndex = 2;
            this.SelectCsvDirBtn.Text = "Select...";
            this.SelectCsvDirBtn.UseVisualStyleBackColor = true;
            this.SelectCsvDirBtn.Click += new System.EventHandler(this.SelectCsvDirBtn_Click);
            // 
            // SourceDirTextBox
            // 
            this.SourceDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceDirTextBox.Location = new System.Drawing.Point(20, 46);
            this.SourceDirTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SourceDirTextBox.Name = "SourceDirTextBox";
            this.SourceDirTextBox.Size = new System.Drawing.Size(799, 31);
            this.SourceDirTextBox.TabIndex = 1;
            this.SourceDirTextBox.Text = "\\\\vmware-host\\Shared Folders\\下载\\ahc-201911_2088131570315721";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the directory where raw CSV files dwell...";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.UsableTableInfoTextBox);
            this.tabPage3.Controls.Add(this.QuerySqlBtn);
            this.tabPage3.Controls.Add(this.QuerySqlTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage3.Size = new System.Drawing.Size(1010, 823);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Querier";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // QuerySqlBtn
            // 
            this.QuerySqlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QuerySqlBtn.Location = new System.Drawing.Point(860, 768);
            this.QuerySqlBtn.Name = "QuerySqlBtn";
            this.QuerySqlBtn.Size = new System.Drawing.Size(141, 47);
            this.QuerySqlBtn.TabIndex = 1;
            this.QuerySqlBtn.Text = "Query";
            this.QuerySqlBtn.UseVisualStyleBackColor = true;
            this.QuerySqlBtn.Click += new System.EventHandler(this.QuerySqlBtn_Click);
            // 
            // QuerySqlTextBox
            // 
            this.QuerySqlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuerySqlTextBox.Location = new System.Drawing.Point(9, 273);
            this.QuerySqlTextBox.Multiline = true;
            this.QuerySqlTextBox.Name = "QuerySqlTextBox";
            this.QuerySqlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.QuerySqlTextBox.Size = new System.Drawing.Size(992, 302);
            this.QuerySqlTextBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 844);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip1.Size = new System.Drawing.Size(551, 38);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(183, 28);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.Location = new System.Drawing.Point(15, 12);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(527, 826);
            this.logTextBox.TabIndex = 0;
            // 
            // bwForLoadCsvToDb
            // 
            this.bwForLoadCsvToDb.WorkerReportsProgress = true;
            this.bwForLoadCsvToDb.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwForLoadCsvToDb_DoWork);
            this.bwForLoadCsvToDb.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwForLoadCsvToDb_ProgressChanged);
            this.bwForLoadCsvToDb.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwForLoadCsvToDb_RunWorkerCompleted);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CSV Files|*.csv";
            // 
            // UsableTableInfoTextBox
            // 
            this.UsableTableInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsableTableInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UsableTableInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsableTableInfoTextBox.Location = new System.Drawing.Point(9, 8);
            this.UsableTableInfoTextBox.Multiline = true;
            this.UsableTableInfoTextBox.Name = "UsableTableInfoTextBox";
            this.UsableTableInfoTextBox.ReadOnly = true;
            this.UsableTableInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UsableTableInfoTextBox.Size = new System.Drawing.Size(992, 259);
            this.UsableTableInfoTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 882);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CSV as Database Toolkit - Leqee - Sinri Edogawa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPSIgnoreTailRowsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPSIgnoreHeaderRowsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPSColumnsLimitationNumber)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button labBtn1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectCsvDirBtn;
        private System.Windows.Forms.TextBox SourceDirTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CPSHasHeaderCheckerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadCSVBtn;
        private System.Windows.Forms.CheckBox CPSIgnoreQuotesCheckerBox;
        private System.Windows.Forms.NumericUpDown CPSIgnoreTailRowsNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CPSIgnoreHeaderRowsNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CPSColumnsLimitationNumber;
        private System.Windows.Forms.TabPage tabPage3;
        private System.ComponentModel.BackgroundWorker bwForLoadCsvToDb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button QuerySqlBtn;
        private System.Windows.Forms.TextBox QuerySqlTextBox;
        private System.Windows.Forms.TextBox UsableTableInfoTextBox;
    }
}

