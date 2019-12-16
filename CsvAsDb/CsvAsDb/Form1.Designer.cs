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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PreprocessPluginCodeCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UsableTableInfoTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.QuerySqlBtn = new System.Windows.Forms.Button();
            this.QuerySqlTextBox = new System.Windows.Forms.TextBox();
            this.ExportSqlBtn = new System.Windows.Forms.Button();
            this.queryResultDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColumnFilterDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilterCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CategoryFilterDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResetCategoryDictionaryGridBtn = new System.Windows.Forms.Button();
            this.SaveCategoryDictionaryFileBtn = new System.Windows.Forms.Button();
            this.LoadCategoryDictionaryFileBtn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labBtn1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bwForLoadCsvToDb = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPSIgnoreTailRowsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPSIgnoreHeaderRowsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPSColumnsLimitationNumber)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryResultDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnFilterDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryFilterDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1991, 1356);
            this.splitContainer1.SplitterDistance = 1299;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1275, 1332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.LoadCSVBtn);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.SelectCsvDirBtn);
            this.tabPage2.Controls.Add(this.SourceDirTextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1267, 1297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Load CSV Directory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.PreprocessPluginCodeCombo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(20, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1230, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preprocess Plugin Settings";
            // 
            // PreprocessPluginCodeCombo
            // 
            this.PreprocessPluginCodeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreprocessPluginCodeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreprocessPluginCodeCombo.FormattingEnabled = true;
            this.PreprocessPluginCodeCombo.Items.AddRange(new object[] {
            "FREE",
            "WSQ_A",
            "YLN_A"});
            this.PreprocessPluginCodeCombo.Location = new System.Drawing.Point(583, 33);
            this.PreprocessPluginCodeCombo.Name = "PreprocessPluginCodeCombo";
            this.PreprocessPluginCodeCombo.Size = new System.Drawing.Size(641, 29);
            this.PreprocessPluginCodeCombo.TabIndex = 2;
            this.PreprocessPluginCodeCombo.SelectedIndexChanged += new System.EventHandler(this.PreprocessPluginCodeCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(560, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Input your plugin code. Now available: WSQ_A YLN_A";
            // 
            // LoadCSVBtn
            // 
            this.LoadCSVBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadCSVBtn.Location = new System.Drawing.Point(801, 436);
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
            this.groupBox1.Size = new System.Drawing.Size(1230, 245);
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
            this.CPSIgnoreTailRowsNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
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
            this.CPSIgnoreHeaderRowsNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
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
            this.CPSColumnsLimitationNumber.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
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
            this.CPSHasHeaderCheckerBox.Checked = true;
            this.CPSHasHeaderCheckerBox.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.SelectCsvDirBtn.Location = new System.Drawing.Point(1084, 44);
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
            this.SourceDirTextBox.Size = new System.Drawing.Size(1056, 31);
            this.SourceDirTextBox.TabIndex = 1;
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
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage3.Size = new System.Drawing.Size(1267, 1297);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Querier";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(6, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel1MinSize = 100;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.queryResultDataGridView);
            this.splitContainer2.Panel2MinSize = 100;
            this.splitContainer2.Size = new System.Drawing.Size(1255, 1287);
            this.splitContainer2.SplitterDistance = 395;
            this.splitContainer2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.UsableTableInfoTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1255, 395);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UsableTableInfoTextBox
            // 
            this.UsableTableInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UsableTableInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsableTableInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsableTableInfoTextBox.Location = new System.Drawing.Point(3, 3);
            this.UsableTableInfoTextBox.Multiline = true;
            this.UsableTableInfoTextBox.Name = "UsableTableInfoTextBox";
            this.UsableTableInfoTextBox.ReadOnly = true;
            this.UsableTableInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UsableTableInfoTextBox.Size = new System.Drawing.Size(370, 393);
            this.UsableTableInfoTextBox.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.QuerySqlBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.QuerySqlTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ExportSqlBtn, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(379, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77923F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11088F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.10989F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(873, 393);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // QuerySqlBtn
            // 
            this.QuerySqlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuerySqlBtn.Location = new System.Drawing.Point(3, 308);
            this.QuerySqlBtn.Name = "QuerySqlBtn";
            this.QuerySqlBtn.Size = new System.Drawing.Size(867, 37);
            this.QuerySqlBtn.TabIndex = 1;
            this.QuerySqlBtn.Text = "Query For Quick View";
            this.QuerySqlBtn.UseVisualStyleBackColor = true;
            this.QuerySqlBtn.Click += new System.EventHandler(this.QuerySqlBtn_Click);
            // 
            // QuerySqlTextBox
            // 
            this.QuerySqlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuerySqlTextBox.Location = new System.Drawing.Point(3, 3);
            this.QuerySqlTextBox.Multiline = true;
            this.QuerySqlTextBox.Name = "QuerySqlTextBox";
            this.QuerySqlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.QuerySqlTextBox.Size = new System.Drawing.Size(867, 299);
            this.QuerySqlTextBox.TabIndex = 0;
            // 
            // ExportSqlBtn
            // 
            this.ExportSqlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExportSqlBtn.Location = new System.Drawing.Point(3, 356);
            this.ExportSqlBtn.Name = "ExportSqlBtn";
            this.ExportSqlBtn.Size = new System.Drawing.Size(867, 34);
            this.ExportSqlBtn.TabIndex = 2;
            this.ExportSqlBtn.Text = "Query and Export to CSV...";
            this.ExportSqlBtn.UseVisualStyleBackColor = true;
            this.ExportSqlBtn.Click += new System.EventHandler(this.ExportSqlBtn_Click);
            // 
            // queryResultDataGridView
            // 
            this.queryResultDataGridView.AllowUserToAddRows = false;
            this.queryResultDataGridView.AllowUserToDeleteRows = false;
            this.queryResultDataGridView.AllowUserToOrderColumns = true;
            this.queryResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryResultDataGridView.Location = new System.Drawing.Point(0, 0);
            this.queryResultDataGridView.Name = "queryResultDataGridView";
            this.queryResultDataGridView.ReadOnly = true;
            this.queryResultDataGridView.RowHeadersWidth = 72;
            this.queryResultDataGridView.RowTemplate.Height = 33;
            this.queryResultDataGridView.Size = new System.Drawing.Size(1255, 888);
            this.queryResultDataGridView.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1267, 1297);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Column Filters";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ColumnFilterDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(18, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1229, 442);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Field Filter Config";
            // 
            // ColumnFilterDataGridView
            // 
            this.ColumnFilterDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ColumnFilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnFilterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnFilterCode});
            this.ColumnFilterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnFilterDataGridView.Location = new System.Drawing.Point(3, 27);
            this.ColumnFilterDataGridView.Name = "ColumnFilterDataGridView";
            this.ColumnFilterDataGridView.RowHeadersWidth = 72;
            this.ColumnFilterDataGridView.RowTemplate.Height = 33;
            this.ColumnFilterDataGridView.Size = new System.Drawing.Size(1223, 412);
            this.ColumnFilterDataGridView.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Column Name";
            this.ColumnName.MinimumWidth = 9;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 175;
            // 
            // ColumnFilterCode
            // 
            this.ColumnFilterCode.HeaderText = "Filter Code";
            this.ColumnFilterCode.Items.AddRange(new object[] {
            "ORIGINAL",
            "REMOVE_NUMBERS"});
            this.ColumnFilterCode.MinimumWidth = 9;
            this.ColumnFilterCode.Name = "ColumnFilterCode";
            this.ColumnFilterCode.Width = 175;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1267, 1297);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Category Dictionary";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.CategoryFilterDataGridView);
            this.groupBox5.Location = new System.Drawing.Point(6, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1255, 1054);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dictionary";
            // 
            // CategoryFilterDataGridView
            // 
            this.CategoryFilterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CategoryFilterDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CategoryFilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryFilterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryFilterDataGridView.Location = new System.Drawing.Point(3, 27);
            this.CategoryFilterDataGridView.Name = "CategoryFilterDataGridView";
            this.CategoryFilterDataGridView.RowHeadersWidth = 72;
            this.CategoryFilterDataGridView.RowTemplate.Height = 33;
            this.CategoryFilterDataGridView.Size = new System.Drawing.Size(1249, 1024);
            this.CategoryFilterDataGridView.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ResetCategoryDictionaryGridBtn);
            this.groupBox4.Controls.Add(this.SaveCategoryDictionaryFileBtn);
            this.groupBox4.Controls.Add(this.LoadCategoryDictionaryFileBtn);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1255, 225);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Persistence";
            // 
            // ResetCategoryDictionaryGridBtn
            // 
            this.ResetCategoryDictionaryGridBtn.Location = new System.Drawing.Point(16, 118);
            this.ResetCategoryDictionaryGridBtn.Name = "ResetCategoryDictionaryGridBtn";
            this.ResetCategoryDictionaryGridBtn.Size = new System.Drawing.Size(493, 37);
            this.ResetCategoryDictionaryGridBtn.TabIndex = 2;
            this.ResetCategoryDictionaryGridBtn.Text = "Reset Category Dictionary Grid";
            this.ResetCategoryDictionaryGridBtn.UseVisualStyleBackColor = true;
            this.ResetCategoryDictionaryGridBtn.Click += new System.EventHandler(this.ResetCategoryDictionaryGridBtn_Click);
            // 
            // SaveCategoryDictionaryFileBtn
            // 
            this.SaveCategoryDictionaryFileBtn.Location = new System.Drawing.Point(16, 74);
            this.SaveCategoryDictionaryFileBtn.Name = "SaveCategoryDictionaryFileBtn";
            this.SaveCategoryDictionaryFileBtn.Size = new System.Drawing.Size(493, 37);
            this.SaveCategoryDictionaryFileBtn.TabIndex = 1;
            this.SaveCategoryDictionaryFileBtn.Text = "Save Category Dictionary File (CSV) ...";
            this.SaveCategoryDictionaryFileBtn.UseVisualStyleBackColor = true;
            this.SaveCategoryDictionaryFileBtn.Click += new System.EventHandler(this.SaveCategoryDictionaryFileBtn_Click);
            // 
            // LoadCategoryDictionaryFileBtn
            // 
            this.LoadCategoryDictionaryFileBtn.Location = new System.Drawing.Point(16, 30);
            this.LoadCategoryDictionaryFileBtn.Name = "LoadCategoryDictionaryFileBtn";
            this.LoadCategoryDictionaryFileBtn.Size = new System.Drawing.Size(493, 37);
            this.LoadCategoryDictionaryFileBtn.TabIndex = 0;
            this.LoadCategoryDictionaryFileBtn.Text = "Load Category Dictionary File (CSV) ...";
            this.LoadCategoryDictionaryFileBtn.UseVisualStyleBackColor = true;
            this.LoadCategoryDictionaryFileBtn.Click += new System.EventHandler(this.LoadCategoryDictionaryFileBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.labBtn1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1267, 1297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "About";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1259, 1289);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // labBtn1
            // 
            this.labBtn1.Location = new System.Drawing.Point(1112, 1245);
            this.labBtn1.Margin = new System.Windows.Forms.Padding(4);
            this.labBtn1.Name = "labBtn1";
            this.labBtn1.Size = new System.Drawing.Size(147, 44);
            this.labBtn1.TabIndex = 0;
            this.labBtn1.Text = "button1";
            this.labBtn1.UseVisualStyleBackColor = true;
            this.labBtn1.Visible = false;
            this.labBtn1.Click += new System.EventHandler(this.LabBtn1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1318);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip1.Size = new System.Drawing.Size(688, 38);
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
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(664, 1300);
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
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "CSV Files|*.csv";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1991, 1356);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CSV as Database Toolkit - Leqee - Sinri Edogawa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPSIgnoreTailRowsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPSIgnoreHeaderRowsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPSColumnsLimitationNumber)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryResultDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnFilterDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryFilterDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView queryResultDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button QuerySqlBtn;
        private System.Windows.Forms.TextBox UsableTableInfoTextBox;
        private System.Windows.Forms.TextBox QuerySqlTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExportSqlBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView CategoryFilterDataGridView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button LoadCategoryDictionaryFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SaveCategoryDictionaryFileBtn;
        private System.Windows.Forms.Button ResetCategoryDictionaryGridBtn;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ColumnFilterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnFilterCode;
        private System.Windows.Forms.ComboBox PreprocessPluginCodeCombo;
    }
}

