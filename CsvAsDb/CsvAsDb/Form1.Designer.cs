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
            this.PluginDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PreprocessPluginCodeCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CPSIgnoreQuotesCheckerBox = new System.Windows.Forms.CheckBox();
            this.LoadCSVBtn = new System.Windows.Forms.Button();
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
            this.QuerySqlTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.QuerySqlBtn = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1.SuspendLayout();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
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
            this.splitContainer1.Size = new System.Drawing.Size(1201, 790);
            this.splitContainer1.SplitterDistance = 783;
            this.splitContainer1.SplitterWidth = 2;
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
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 776);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(761, 750);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CSV加载器";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.PluginDescriptionTextBox);
            this.groupBox3.Controls.Add(this.PreprocessPluginCodeCombo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(11, 197);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(745, 161);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "插件设定";
            // 
            // PluginDescriptionTextBox
            // 
            this.PluginDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PluginDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PluginDescriptionTextBox.Location = new System.Drawing.Point(13, 50);
            this.PluginDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PluginDescriptionTextBox.Multiline = true;
            this.PluginDescriptionTextBox.Name = "PluginDescriptionTextBox";
            this.PluginDescriptionTextBox.ReadOnly = true;
            this.PluginDescriptionTextBox.Size = new System.Drawing.Size(719, 97);
            this.PluginDescriptionTextBox.TabIndex = 3;
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
            "YLN_A",
            "ZY_A"});
            this.PreprocessPluginCodeCombo.Location = new System.Drawing.Point(494, 19);
            this.PreprocessPluginCodeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.PreprocessPluginCodeCombo.Name = "PreprocessPluginCodeCombo";
            this.PreprocessPluginCodeCombo.Size = new System.Drawing.Size(239, 20);
            this.PreprocessPluginCodeCombo.TabIndex = 2;
            this.PreprocessPluginCodeCombo.SelectedIndexChanged += new System.EventHandler(this.PreprocessPluginCodeCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "选择插件";
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
            this.groupBox1.Location = new System.Drawing.Point(11, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CSV 解析设定";
            // 
            // CPSIgnoreQuotesCheckerBox
            // 
            this.CPSIgnoreQuotesCheckerBox.AutoSize = true;
            this.CPSIgnoreQuotesCheckerBox.Location = new System.Drawing.Point(7, 109);
            this.CPSIgnoreQuotesCheckerBox.Name = "CPSIgnoreQuotesCheckerBox";
            this.CPSIgnoreQuotesCheckerBox.Size = new System.Drawing.Size(120, 16);
            this.CPSIgnoreQuotesCheckerBox.TabIndex = 7;
            this.CPSIgnoreQuotesCheckerBox.Text = "强行兼容非法引号";
            this.CPSIgnoreQuotesCheckerBox.UseVisualStyleBackColor = true;
            // 
            // LoadCSVBtn
            // 
            this.LoadCSVBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadCSVBtn.Location = new System.Drawing.Point(511, 363);
            this.LoadCSVBtn.Name = "LoadCSVBtn";
            this.LoadCSVBtn.Size = new System.Drawing.Size(245, 23);
            this.LoadCSVBtn.TabIndex = 4;
            this.LoadCSVBtn.Text = "开始加载";
            this.LoadCSVBtn.UseVisualStyleBackColor = true;
            this.LoadCSVBtn.Click += new System.EventHandler(this.LoadCSVBtn_Click);
            // 
            // CPSIgnoreTailRowsNumber
            // 
            this.CPSIgnoreTailRowsNumber.Location = new System.Drawing.Point(325, 46);
            this.CPSIgnoreTailRowsNumber.Name = "CPSIgnoreTailRowsNumber";
            this.CPSIgnoreTailRowsNumber.Size = new System.Drawing.Size(59, 21);
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
            this.label4.Location = new System.Drawing.Point(212, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "过滤尾部行数";
            // 
            // CPSIgnoreHeaderRowsNumber
            // 
            this.CPSIgnoreHeaderRowsNumber.Location = new System.Drawing.Point(131, 46);
            this.CPSIgnoreHeaderRowsNumber.Name = "CPSIgnoreHeaderRowsNumber";
            this.CPSIgnoreHeaderRowsNumber.Size = new System.Drawing.Size(59, 21);
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
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "过滤头部行数";
            // 
            // CPSColumnsLimitationNumber
            // 
            this.CPSColumnsLimitationNumber.Location = new System.Drawing.Point(131, 79);
            this.CPSColumnsLimitationNumber.Name = "CPSColumnsLimitationNumber";
            this.CPSColumnsLimitationNumber.Size = new System.Drawing.Size(59, 21);
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
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "最大检视列数";
            // 
            // CPSHasHeaderCheckerBox
            // 
            this.CPSHasHeaderCheckerBox.AutoSize = true;
            this.CPSHasHeaderCheckerBox.Checked = true;
            this.CPSHasHeaderCheckerBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CPSHasHeaderCheckerBox.Location = new System.Drawing.Point(6, 20);
            this.CPSHasHeaderCheckerBox.Name = "CPSHasHeaderCheckerBox";
            this.CPSHasHeaderCheckerBox.Size = new System.Drawing.Size(84, 16);
            this.CPSHasHeaderCheckerBox.TabIndex = 0;
            this.CPSHasHeaderCheckerBox.Text = "存在标题行";
            this.CPSHasHeaderCheckerBox.UseVisualStyleBackColor = true;
            // 
            // SelectCsvDirBtn
            // 
            this.SelectCsvDirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectCsvDirBtn.Location = new System.Drawing.Point(665, 25);
            this.SelectCsvDirBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SelectCsvDirBtn.Name = "SelectCsvDirBtn";
            this.SelectCsvDirBtn.Size = new System.Drawing.Size(91, 22);
            this.SelectCsvDirBtn.TabIndex = 2;
            this.SelectCsvDirBtn.Text = "选择文件夹...";
            this.SelectCsvDirBtn.UseVisualStyleBackColor = true;
            this.SelectCsvDirBtn.Click += new System.EventHandler(this.SelectCsvDirBtn_Click);
            // 
            // SourceDirTextBox
            // 
            this.SourceDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceDirTextBox.Location = new System.Drawing.Point(11, 26);
            this.SourceDirTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SourceDirTextBox.Name = "SourceDirTextBox";
            this.SourceDirTextBox.Size = new System.Drawing.Size(652, 21);
            this.SourceDirTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "给定CSV所在的目录";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(761, 750);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "查询器";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
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
            this.splitContainer2.Size = new System.Drawing.Size(755, 744);
            this.splitContainer2.SplitterDistance = 228;
            this.splitContainer2.SplitterWidth = 2;
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(755, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UsableTableInfoTextBox
            // 
            this.UsableTableInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UsableTableInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsableTableInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsableTableInfoTextBox.Location = new System.Drawing.Point(2, 2);
            this.UsableTableInfoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsableTableInfoTextBox.Multiline = true;
            this.UsableTableInfoTextBox.Name = "UsableTableInfoTextBox";
            this.UsableTableInfoTextBox.ReadOnly = true;
            this.UsableTableInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UsableTableInfoTextBox.Size = new System.Drawing.Size(222, 225);
            this.UsableTableInfoTextBox.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.QuerySqlTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(228, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(525, 225);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // QuerySqlTextBox
            // 
            this.QuerySqlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuerySqlTextBox.Location = new System.Drawing.Point(2, 2);
            this.QuerySqlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.QuerySqlTextBox.Multiline = true;
            this.QuerySqlTextBox.Name = "QuerySqlTextBox";
            this.QuerySqlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.QuerySqlTextBox.Size = new System.Drawing.Size(521, 176);
            this.QuerySqlTextBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.QuerySqlBtn);
            this.flowLayoutPanel1.Controls.Add(this.ExportSqlBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 182);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(521, 41);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // QuerySqlBtn
            // 
            this.QuerySqlBtn.Location = new System.Drawing.Point(2, 2);
            this.QuerySqlBtn.Margin = new System.Windows.Forms.Padding(2);
            this.QuerySqlBtn.Name = "QuerySqlBtn";
            this.QuerySqlBtn.Size = new System.Drawing.Size(73, 21);
            this.QuerySqlBtn.TabIndex = 1;
            this.QuerySqlBtn.Text = "查询";
            this.QuerySqlBtn.UseVisualStyleBackColor = true;
            this.QuerySqlBtn.Click += new System.EventHandler(this.QuerySqlBtn_Click);
            // 
            // ExportSqlBtn
            // 
            this.ExportSqlBtn.Location = new System.Drawing.Point(79, 2);
            this.ExportSqlBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExportSqlBtn.Name = "ExportSqlBtn";
            this.ExportSqlBtn.Size = new System.Drawing.Size(73, 21);
            this.ExportSqlBtn.TabIndex = 2;
            this.ExportSqlBtn.Text = "导出";
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
            this.queryResultDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.queryResultDataGridView.Name = "queryResultDataGridView";
            this.queryResultDataGridView.ReadOnly = true;
            this.queryResultDataGridView.RowHeadersWidth = 72;
            this.queryResultDataGridView.RowTemplate.Height = 33;
            this.queryResultDataGridView.Size = new System.Drawing.Size(755, 514);
            this.queryResultDataGridView.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(761, 750);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "列过滤器";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ColumnFilterDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(10, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(744, 253);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "列过滤设定";
            // 
            // ColumnFilterDataGridView
            // 
            this.ColumnFilterDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ColumnFilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnFilterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnFilterCode});
            this.ColumnFilterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnFilterDataGridView.Location = new System.Drawing.Point(2, 16);
            this.ColumnFilterDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ColumnFilterDataGridView.Name = "ColumnFilterDataGridView";
            this.ColumnFilterDataGridView.RowHeadersWidth = 72;
            this.ColumnFilterDataGridView.RowTemplate.Height = 33;
            this.ColumnFilterDataGridView.Size = new System.Drawing.Size(740, 235);
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
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(761, 750);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "分类编辑器";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.CategoryFilterDataGridView);
            this.groupBox5.Location = new System.Drawing.Point(3, 135);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(759, 622);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "分类字典";
            // 
            // CategoryFilterDataGridView
            // 
            this.CategoryFilterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CategoryFilterDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CategoryFilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryFilterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryFilterDataGridView.Location = new System.Drawing.Point(2, 16);
            this.CategoryFilterDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryFilterDataGridView.Name = "CategoryFilterDataGridView";
            this.CategoryFilterDataGridView.RowHeadersWidth = 72;
            this.CategoryFilterDataGridView.RowTemplate.Height = 33;
            this.CategoryFilterDataGridView.Size = new System.Drawing.Size(755, 604);
            this.CategoryFilterDataGridView.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ResetCategoryDictionaryGridBtn);
            this.groupBox4.Controls.Add(this.SaveCategoryDictionaryFileBtn);
            this.groupBox4.Controls.Add(this.LoadCategoryDictionaryFileBtn);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(759, 129);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "分类字典的编辑与持久化";
            // 
            // ResetCategoryDictionaryGridBtn
            // 
            this.ResetCategoryDictionaryGridBtn.Location = new System.Drawing.Point(9, 67);
            this.ResetCategoryDictionaryGridBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ResetCategoryDictionaryGridBtn.Name = "ResetCategoryDictionaryGridBtn";
            this.ResetCategoryDictionaryGridBtn.Size = new System.Drawing.Size(269, 21);
            this.ResetCategoryDictionaryGridBtn.TabIndex = 2;
            this.ResetCategoryDictionaryGridBtn.Text = "重置分类字典以供编辑";
            this.ResetCategoryDictionaryGridBtn.UseVisualStyleBackColor = true;
            this.ResetCategoryDictionaryGridBtn.Click += new System.EventHandler(this.ResetCategoryDictionaryGridBtn_Click);
            // 
            // SaveCategoryDictionaryFileBtn
            // 
            this.SaveCategoryDictionaryFileBtn.Location = new System.Drawing.Point(9, 42);
            this.SaveCategoryDictionaryFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveCategoryDictionaryFileBtn.Name = "SaveCategoryDictionaryFileBtn";
            this.SaveCategoryDictionaryFileBtn.Size = new System.Drawing.Size(269, 21);
            this.SaveCategoryDictionaryFileBtn.TabIndex = 1;
            this.SaveCategoryDictionaryFileBtn.Text = "保存当前分类字典到CSV文件";
            this.SaveCategoryDictionaryFileBtn.UseVisualStyleBackColor = true;
            this.SaveCategoryDictionaryFileBtn.Click += new System.EventHandler(this.SaveCategoryDictionaryFileBtn_Click);
            // 
            // LoadCategoryDictionaryFileBtn
            // 
            this.LoadCategoryDictionaryFileBtn.Location = new System.Drawing.Point(9, 17);
            this.LoadCategoryDictionaryFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoadCategoryDictionaryFileBtn.Name = "LoadCategoryDictionaryFileBtn";
            this.LoadCategoryDictionaryFileBtn.Size = new System.Drawing.Size(269, 21);
            this.LoadCategoryDictionaryFileBtn.TabIndex = 0;
            this.LoadCategoryDictionaryFileBtn.Text = "加载分类字典CSV文件";
            this.LoadCategoryDictionaryFileBtn.UseVisualStyleBackColor = true;
            this.LoadCategoryDictionaryFileBtn.Click += new System.EventHandler(this.LoadCategoryDictionaryFileBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.labBtn1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(761, 750);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "支持";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(757, 746);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // labBtn1
            // 
            this.labBtn1.Location = new System.Drawing.Point(607, 711);
            this.labBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.labBtn1.Name = "labBtn1";
            this.labBtn1.Size = new System.Drawing.Size(80, 25);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 768);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(416, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.Location = new System.Drawing.Point(8, 7);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(408, 759);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 790);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox PluginDescriptionTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

