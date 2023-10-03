namespace HillCipher.Forms;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        tableLayoutPanel4 = new TableLayoutPanel();
        keyBox = new GroupBox();
        tableLayoutPanel9 = new TableLayoutPanel();
        textBoxKey = new RichTextBox();
        buttonClearKey = new Button();
        buttonGenerateKey = new Button();
        tableLayoutPanel5 = new TableLayoutPanel();
        keySizeUpDown = new NumericUpDown();
        keyGridView = new DataGridView();
        alphabetBox = new GroupBox();
        tableLayoutPanel13 = new TableLayoutPanel();
        textBoxAlphabet = new RichTextBox();
        letterFrequencyBox = new GroupBox();
        tableLayoutPanel6 = new TableLayoutPanel();
        letterFrequencyGrid = new DataGridView();
        Letter = new DataGridViewTextBoxColumn();
        LetterFrequency = new DataGridViewTextBoxColumn();
        originalLetterFrequencyGrid = new DataGridView();
        OriginalLetter = new DataGridViewTextBoxColumn();
        ProcessedLetterFrequency = new DataGridViewTextBoxColumn();
        processedLetterFrequencyGrid = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        frequencyPlot = new ScottPlot.FormsPlot();
        tableLayoutPanel3 = new TableLayoutPanel();
        keyExtractionBox = new GroupBox();
        tableLayoutPanel10 = new TableLayoutPanel();
        originalExcerptBox = new GroupBox();
        textBoxOriginalExcerpt = new RichTextBox();
        cipheredExcerptBox = new GroupBox();
        textBoxCipheredExcerpt = new RichTextBox();
        tableLayoutPanel14 = new TableLayoutPanel();
        buttonExtractKey = new Button();
        processResultBox = new GroupBox();
        tableLayoutPanel7 = new TableLayoutPanel();
        textBoxProcessedOutput = new RichTextBox();
        tableLayoutPanel8 = new TableLayoutPanel();
        buttonSaveText = new Button();
        textToProcessBox = new GroupBox();
        tableLayoutPanel11 = new TableLayoutPanel();
        textBoxTextToProcess = new RichTextBox();
        tableLayoutPanel12 = new TableLayoutPanel();
        buttonCipher = new Button();
        buttonDecipher = new Button();
        buttonOpenText = new Button();
        openTextFileDialog = new OpenFileDialog();
        saveTextFileDialog = new SaveFileDialog();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        keyBox.SuspendLayout();
        tableLayoutPanel9.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)keySizeUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)keyGridView).BeginInit();
        alphabetBox.SuspendLayout();
        tableLayoutPanel13.SuspendLayout();
        letterFrequencyBox.SuspendLayout();
        tableLayoutPanel6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)letterFrequencyGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)originalLetterFrequencyGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)processedLetterFrequencyGrid).BeginInit();
        tableLayoutPanel3.SuspendLayout();
        keyExtractionBox.SuspendLayout();
        tableLayoutPanel10.SuspendLayout();
        originalExcerptBox.SuspendLayout();
        cipheredExcerptBox.SuspendLayout();
        tableLayoutPanel14.SuspendLayout();
        processResultBox.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        tableLayoutPanel8.SuspendLayout();
        textToProcessBox.SuspendLayout();
        tableLayoutPanel11.SuspendLayout();
        tableLayoutPanel12.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        tableLayoutPanel1.Size = new Size(1274, 702);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
        tableLayoutPanel2.Controls.Add(letterFrequencyBox, 1, 0);
        tableLayoutPanel2.Controls.Add(frequencyPlot, 2, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(1268, 415);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.Controls.Add(keyBox, 0, 1);
        tableLayoutPanel4.Controls.Add(alphabetBox, 0, 0);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(3, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 2;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
        tableLayoutPanel4.Size = new Size(336, 409);
        tableLayoutPanel4.TabIndex = 1;
        // 
        // keyBox
        // 
        keyBox.Controls.Add(tableLayoutPanel9);
        keyBox.Dock = DockStyle.Fill;
        keyBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        keyBox.Location = new Point(3, 84);
        keyBox.Name = "keyBox";
        keyBox.Size = new Size(330, 322);
        keyBox.TabIndex = 2;
        keyBox.TabStop = false;
        keyBox.Text = "Key";
        // 
        // tableLayoutPanel9
        // 
        tableLayoutPanel9.ColumnCount = 2;
        tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel9.Controls.Add(textBoxKey, 0, 1);
        tableLayoutPanel9.Controls.Add(buttonClearKey, 0, 2);
        tableLayoutPanel9.Controls.Add(buttonGenerateKey, 1, 2);
        tableLayoutPanel9.Controls.Add(tableLayoutPanel5, 0, 0);
        tableLayoutPanel9.Dock = DockStyle.Fill;
        tableLayoutPanel9.Location = new Point(3, 24);
        tableLayoutPanel9.Name = "tableLayoutPanel9";
        tableLayoutPanel9.RowCount = 3;
        tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
        tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel9.Size = new Size(324, 295);
        tableLayoutPanel9.TabIndex = 2;
        // 
        // textBoxKey
        // 
        textBoxKey.BackColor = SystemColors.GradientInactiveCaption;
        tableLayoutPanel9.SetColumnSpan(textBoxKey, 2);
        textBoxKey.Dock = DockStyle.Fill;
        textBoxKey.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxKey.Location = new Point(3, 209);
        textBoxKey.Name = "textBoxKey";
        textBoxKey.Size = new Size(318, 38);
        textBoxKey.TabIndex = 0;
        textBoxKey.Text = "";
        // 
        // buttonClearKey
        // 
        buttonClearKey.BackColor = Color.DarkCyan;
        buttonClearKey.Dock = DockStyle.Fill;
        buttonClearKey.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonClearKey.ForeColor = SystemColors.ButtonHighlight;
        buttonClearKey.Location = new Point(3, 253);
        buttonClearKey.Name = "buttonClearKey";
        buttonClearKey.Size = new Size(156, 39);
        buttonClearKey.TabIndex = 1;
        buttonClearKey.Text = "Clear";
        buttonClearKey.UseVisualStyleBackColor = false;
        buttonClearKey.Click += ButtonClearKey_Click;
        // 
        // buttonGenerateKey
        // 
        buttonGenerateKey.BackColor = Color.DarkCyan;
        buttonGenerateKey.Dock = DockStyle.Fill;
        buttonGenerateKey.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonGenerateKey.ForeColor = SystemColors.ButtonHighlight;
        buttonGenerateKey.Location = new Point(165, 253);
        buttonGenerateKey.Name = "buttonGenerateKey";
        buttonGenerateKey.Size = new Size(156, 39);
        buttonGenerateKey.TabIndex = 2;
        buttonGenerateKey.Text = "Generate";
        buttonGenerateKey.UseVisualStyleBackColor = false;
        buttonGenerateKey.Click += ButtonGenerateKey_Click;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 1;
        tableLayoutPanel9.SetColumnSpan(tableLayoutPanel5, 2);
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel5.Controls.Add(keySizeUpDown, 0, 0);
        tableLayoutPanel5.Controls.Add(keyGridView, 0, 1);
        tableLayoutPanel5.Dock = DockStyle.Fill;
        tableLayoutPanel5.Location = new Point(3, 3);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 2;
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 84F));
        tableLayoutPanel5.Size = new Size(318, 200);
        tableLayoutPanel5.TabIndex = 3;
        // 
        // keySizeUpDown
        // 
        keySizeUpDown.Dock = DockStyle.Fill;
        keySizeUpDown.Location = new Point(3, 3);
        keySizeUpDown.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
        keySizeUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
        keySizeUpDown.Name = "keySizeUpDown";
        keySizeUpDown.Size = new Size(312, 28);
        keySizeUpDown.TabIndex = 0;
        keySizeUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
        keySizeUpDown.ValueChanged += KeySizeUpDown_ValueChanged;
        // 
        // keyGridView
        // 
        keyGridView.AllowUserToAddRows = false;
        keyGridView.AllowUserToDeleteRows = false;
        keyGridView.BackgroundColor = SystemColors.InactiveCaption;
        keyGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        keyGridView.Dock = DockStyle.Fill;
        keyGridView.Location = new Point(3, 35);
        keyGridView.Name = "keyGridView";
        keyGridView.RowHeadersVisible = false;
        keyGridView.RowHeadersWidth = 51;
        keyGridView.RowTemplate.Height = 29;
        keyGridView.Size = new Size(312, 162);
        keyGridView.TabIndex = 1;
        keyGridView.ColumnAdded += KeyGridView_ColumnAdded;
        // 
        // alphabetBox
        // 
        alphabetBox.Controls.Add(tableLayoutPanel13);
        alphabetBox.Dock = DockStyle.Fill;
        alphabetBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        alphabetBox.Location = new Point(3, 3);
        alphabetBox.Name = "alphabetBox";
        alphabetBox.Size = new Size(330, 75);
        alphabetBox.TabIndex = 3;
        alphabetBox.TabStop = false;
        alphabetBox.Text = "Alphabet";
        // 
        // tableLayoutPanel13
        // 
        tableLayoutPanel13.ColumnCount = 1;
        tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel13.Controls.Add(textBoxAlphabet, 0, 0);
        tableLayoutPanel13.Dock = DockStyle.Fill;
        tableLayoutPanel13.Location = new Point(3, 24);
        tableLayoutPanel13.Name = "tableLayoutPanel13";
        tableLayoutPanel13.RowCount = 1;
        tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel13.Size = new Size(324, 48);
        tableLayoutPanel13.TabIndex = 0;
        // 
        // textBoxAlphabet
        // 
        textBoxAlphabet.BackColor = SystemColors.GradientInactiveCaption;
        textBoxAlphabet.Dock = DockStyle.Fill;
        textBoxAlphabet.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxAlphabet.Location = new Point(3, 3);
        textBoxAlphabet.Name = "textBoxAlphabet";
        textBoxAlphabet.Size = new Size(318, 42);
        textBoxAlphabet.TabIndex = 0;
        textBoxAlphabet.Text = "";
        textBoxAlphabet.Leave += TextBoxAlphabet_Leave;
        // 
        // letterFrequencyBox
        // 
        letterFrequencyBox.Controls.Add(tableLayoutPanel6);
        letterFrequencyBox.Dock = DockStyle.Fill;
        letterFrequencyBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        letterFrequencyBox.Location = new Point(345, 3);
        letterFrequencyBox.Name = "letterFrequencyBox";
        letterFrequencyBox.Size = new Size(349, 409);
        letterFrequencyBox.TabIndex = 5;
        letterFrequencyBox.TabStop = false;
        letterFrequencyBox.Text = "Letter Frequency";
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 3;
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel6.Controls.Add(letterFrequencyGrid, 0, 0);
        tableLayoutPanel6.Controls.Add(originalLetterFrequencyGrid, 1, 0);
        tableLayoutPanel6.Controls.Add(processedLetterFrequencyGrid, 2, 0);
        tableLayoutPanel6.Dock = DockStyle.Fill;
        tableLayoutPanel6.Location = new Point(3, 24);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 1;
        tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel6.Size = new Size(343, 382);
        tableLayoutPanel6.TabIndex = 0;
        // 
        // letterFrequencyGrid
        // 
        letterFrequencyGrid.AllowUserToAddRows = false;
        letterFrequencyGrid.AllowUserToDeleteRows = false;
        letterFrequencyGrid.BackgroundColor = SystemColors.InactiveCaption;
        letterFrequencyGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        letterFrequencyGrid.Columns.AddRange(new DataGridViewColumn[] { Letter, LetterFrequency });
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Window;
        dataGridViewCellStyle1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
        letterFrequencyGrid.DefaultCellStyle = dataGridViewCellStyle1;
        letterFrequencyGrid.Dock = DockStyle.Fill;
        letterFrequencyGrid.GridColor = Color.DarkCyan;
        letterFrequencyGrid.Location = new Point(3, 3);
        letterFrequencyGrid.Name = "letterFrequencyGrid";
        letterFrequencyGrid.ReadOnly = true;
        letterFrequencyGrid.RowHeadersVisible = false;
        letterFrequencyGrid.RowHeadersWidth = 51;
        letterFrequencyGrid.RowTemplate.Height = 29;
        letterFrequencyGrid.Size = new Size(108, 376);
        letterFrequencyGrid.TabIndex = 0;
        // 
        // Letter
        // 
        Letter.HeaderText = "L";
        Letter.MinimumWidth = 6;
        Letter.Name = "Letter";
        Letter.ReadOnly = true;
        Letter.Width = 30;
        // 
        // LetterFrequency
        // 
        LetterFrequency.HeaderText = "F";
        LetterFrequency.MinimumWidth = 6;
        LetterFrequency.Name = "LetterFrequency";
        LetterFrequency.ReadOnly = true;
        LetterFrequency.Width = 50;
        // 
        // originalLetterFrequencyGrid
        // 
        originalLetterFrequencyGrid.AllowUserToAddRows = false;
        originalLetterFrequencyGrid.AllowUserToDeleteRows = false;
        originalLetterFrequencyGrid.BackgroundColor = SystemColors.InactiveCaption;
        originalLetterFrequencyGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        originalLetterFrequencyGrid.Columns.AddRange(new DataGridViewColumn[] { OriginalLetter, ProcessedLetterFrequency });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        originalLetterFrequencyGrid.DefaultCellStyle = dataGridViewCellStyle2;
        originalLetterFrequencyGrid.Dock = DockStyle.Fill;
        originalLetterFrequencyGrid.GridColor = Color.DarkCyan;
        originalLetterFrequencyGrid.Location = new Point(117, 3);
        originalLetterFrequencyGrid.Name = "originalLetterFrequencyGrid";
        originalLetterFrequencyGrid.ReadOnly = true;
        originalLetterFrequencyGrid.RowHeadersVisible = false;
        originalLetterFrequencyGrid.RowHeadersWidth = 51;
        originalLetterFrequencyGrid.RowTemplate.Height = 29;
        originalLetterFrequencyGrid.Size = new Size(108, 376);
        originalLetterFrequencyGrid.TabIndex = 1;
        // 
        // OriginalLetter
        // 
        OriginalLetter.HeaderText = "OL";
        OriginalLetter.MinimumWidth = 6;
        OriginalLetter.Name = "OriginalLetter";
        OriginalLetter.ReadOnly = true;
        OriginalLetter.Width = 35;
        // 
        // ProcessedLetterFrequency
        // 
        ProcessedLetterFrequency.HeaderText = "F";
        ProcessedLetterFrequency.MinimumWidth = 6;
        ProcessedLetterFrequency.Name = "ProcessedLetterFrequency";
        ProcessedLetterFrequency.ReadOnly = true;
        ProcessedLetterFrequency.Width = 50;
        // 
        // processedLetterFrequencyGrid
        // 
        processedLetterFrequencyGrid.AllowUserToAddRows = false;
        processedLetterFrequencyGrid.AllowUserToDeleteRows = false;
        processedLetterFrequencyGrid.BackgroundColor = SystemColors.InactiveCaption;
        processedLetterFrequencyGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        processedLetterFrequencyGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        processedLetterFrequencyGrid.DefaultCellStyle = dataGridViewCellStyle3;
        processedLetterFrequencyGrid.Dock = DockStyle.Fill;
        processedLetterFrequencyGrid.GridColor = Color.DarkCyan;
        processedLetterFrequencyGrid.Location = new Point(231, 3);
        processedLetterFrequencyGrid.Name = "processedLetterFrequencyGrid";
        processedLetterFrequencyGrid.ReadOnly = true;
        processedLetterFrequencyGrid.RowHeadersVisible = false;
        processedLetterFrequencyGrid.RowHeadersWidth = 51;
        processedLetterFrequencyGrid.RowTemplate.Height = 29;
        processedLetterFrequencyGrid.Size = new Size(109, 376);
        processedLetterFrequencyGrid.TabIndex = 2;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.HeaderText = "PL";
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 35;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.HeaderText = "F";
        dataGridViewTextBoxColumn2.MinimumWidth = 6;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 50;
        // 
        // frequencyPlot
        // 
        frequencyPlot.Dock = DockStyle.Fill;
        frequencyPlot.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        frequencyPlot.Location = new Point(702, 4);
        frequencyPlot.Margin = new Padding(5, 4, 5, 4);
        frequencyPlot.Name = "frequencyPlot";
        frequencyPlot.Size = new Size(561, 407);
        frequencyPlot.TabIndex = 6;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 3;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel3.Controls.Add(keyExtractionBox, 0, 0);
        tableLayoutPanel3.Controls.Add(processResultBox, 1, 0);
        tableLayoutPanel3.Controls.Add(textToProcessBox, 1, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(3, 424);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Size = new Size(1268, 275);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // keyExtractionBox
        // 
        keyExtractionBox.Controls.Add(tableLayoutPanel10);
        keyExtractionBox.Dock = DockStyle.Fill;
        keyExtractionBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        keyExtractionBox.Location = new Point(3, 3);
        keyExtractionBox.Name = "keyExtractionBox";
        keyExtractionBox.Size = new Size(416, 269);
        keyExtractionBox.TabIndex = 5;
        keyExtractionBox.TabStop = false;
        keyExtractionBox.Text = "Key Crack";
        // 
        // tableLayoutPanel10
        // 
        tableLayoutPanel10.ColumnCount = 1;
        tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel10.Controls.Add(originalExcerptBox, 0, 1);
        tableLayoutPanel10.Controls.Add(cipheredExcerptBox, 0, 0);
        tableLayoutPanel10.Controls.Add(tableLayoutPanel14, 0, 2);
        tableLayoutPanel10.Dock = DockStyle.Fill;
        tableLayoutPanel10.Location = new Point(3, 24);
        tableLayoutPanel10.Name = "tableLayoutPanel10";
        tableLayoutPanel10.RowCount = 3;
        tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel10.Size = new Size(410, 242);
        tableLayoutPanel10.TabIndex = 0;
        // 
        // originalExcerptBox
        // 
        originalExcerptBox.Controls.Add(textBoxOriginalExcerpt);
        originalExcerptBox.Dock = DockStyle.Fill;
        originalExcerptBox.Location = new Point(3, 99);
        originalExcerptBox.Name = "originalExcerptBox";
        originalExcerptBox.Size = new Size(404, 90);
        originalExcerptBox.TabIndex = 1;
        originalExcerptBox.TabStop = false;
        originalExcerptBox.Text = "Original Excerpt";
        // 
        // textBoxOriginalExcerpt
        // 
        textBoxOriginalExcerpt.BackColor = SystemColors.GradientInactiveCaption;
        textBoxOriginalExcerpt.Dock = DockStyle.Fill;
        textBoxOriginalExcerpt.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxOriginalExcerpt.Location = new Point(3, 24);
        textBoxOriginalExcerpt.Name = "textBoxOriginalExcerpt";
        textBoxOriginalExcerpt.Size = new Size(398, 63);
        textBoxOriginalExcerpt.TabIndex = 1;
        textBoxOriginalExcerpt.Text = "";
        // 
        // cipheredExcerptBox
        // 
        cipheredExcerptBox.Controls.Add(textBoxCipheredExcerpt);
        cipheredExcerptBox.Dock = DockStyle.Fill;
        cipheredExcerptBox.Location = new Point(3, 3);
        cipheredExcerptBox.Name = "cipheredExcerptBox";
        cipheredExcerptBox.Size = new Size(404, 90);
        cipheredExcerptBox.TabIndex = 0;
        cipheredExcerptBox.TabStop = false;
        cipheredExcerptBox.Text = "Ciphered Excerpt";
        // 
        // textBoxCipheredExcerpt
        // 
        textBoxCipheredExcerpt.BackColor = SystemColors.GradientInactiveCaption;
        textBoxCipheredExcerpt.Dock = DockStyle.Fill;
        textBoxCipheredExcerpt.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxCipheredExcerpt.Location = new Point(3, 24);
        textBoxCipheredExcerpt.Name = "textBoxCipheredExcerpt";
        textBoxCipheredExcerpt.Size = new Size(398, 63);
        textBoxCipheredExcerpt.TabIndex = 0;
        textBoxCipheredExcerpt.Text = "";
        // 
        // tableLayoutPanel14
        // 
        tableLayoutPanel14.ColumnCount = 1;
        tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel14.Controls.Add(buttonExtractKey, 0, 0);
        tableLayoutPanel14.Dock = DockStyle.Fill;
        tableLayoutPanel14.Location = new Point(3, 195);
        tableLayoutPanel14.Name = "tableLayoutPanel14";
        tableLayoutPanel14.RowCount = 1;
        tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel14.Size = new Size(404, 44);
        tableLayoutPanel14.TabIndex = 2;
        // 
        // buttonExtractKey
        // 
        buttonExtractKey.BackColor = Color.DarkCyan;
        buttonExtractKey.Dock = DockStyle.Fill;
        buttonExtractKey.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonExtractKey.ForeColor = SystemColors.ButtonHighlight;
        buttonExtractKey.Location = new Point(3, 3);
        buttonExtractKey.Name = "buttonExtractKey";
        buttonExtractKey.Size = new Size(398, 38);
        buttonExtractKey.TabIndex = 0;
        buttonExtractKey.Text = "Extract Key";
        buttonExtractKey.UseVisualStyleBackColor = false;
        buttonExtractKey.Click += ButtonExtractKey_Click;
        // 
        // processResultBox
        // 
        processResultBox.Controls.Add(tableLayoutPanel7);
        processResultBox.Dock = DockStyle.Fill;
        processResultBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        processResultBox.Location = new Point(847, 3);
        processResultBox.Name = "processResultBox";
        processResultBox.Size = new Size(418, 269);
        processResultBox.TabIndex = 3;
        processResultBox.TabStop = false;
        processResultBox.Text = "Processed Output";
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 1;
        tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel7.Controls.Add(textBoxProcessedOutput, 0, 0);
        tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 1);
        tableLayoutPanel7.Dock = DockStyle.Fill;
        tableLayoutPanel7.Location = new Point(3, 24);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 2;
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel7.Size = new Size(412, 242);
        tableLayoutPanel7.TabIndex = 0;
        // 
        // textBoxProcessedOutput
        // 
        textBoxProcessedOutput.BackColor = SystemColors.GradientInactiveCaption;
        textBoxProcessedOutput.Dock = DockStyle.Fill;
        textBoxProcessedOutput.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxProcessedOutput.Location = new Point(3, 3);
        textBoxProcessedOutput.Name = "textBoxProcessedOutput";
        textBoxProcessedOutput.ReadOnly = true;
        textBoxProcessedOutput.Size = new Size(406, 187);
        textBoxProcessedOutput.TabIndex = 1;
        textBoxProcessedOutput.Text = "";
        // 
        // tableLayoutPanel8
        // 
        tableLayoutPanel8.ColumnCount = 1;
        tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel8.Controls.Add(buttonSaveText, 0, 0);
        tableLayoutPanel8.Dock = DockStyle.Fill;
        tableLayoutPanel8.Location = new Point(3, 196);
        tableLayoutPanel8.Name = "tableLayoutPanel8";
        tableLayoutPanel8.RowCount = 1;
        tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel8.Size = new Size(406, 43);
        tableLayoutPanel8.TabIndex = 2;
        // 
        // buttonSaveText
        // 
        buttonSaveText.BackColor = Color.MediumSeaGreen;
        buttonSaveText.Dock = DockStyle.Fill;
        buttonSaveText.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonSaveText.ForeColor = SystemColors.ButtonHighlight;
        buttonSaveText.Location = new Point(3, 3);
        buttonSaveText.Name = "buttonSaveText";
        buttonSaveText.Size = new Size(400, 37);
        buttonSaveText.TabIndex = 0;
        buttonSaveText.Text = "Save";
        buttonSaveText.UseVisualStyleBackColor = false;
        buttonSaveText.Click += ButtonSaveText_Click;
        // 
        // textToProcessBox
        // 
        textToProcessBox.Controls.Add(tableLayoutPanel11);
        textToProcessBox.Dock = DockStyle.Fill;
        textToProcessBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        textToProcessBox.Location = new Point(425, 3);
        textToProcessBox.Name = "textToProcessBox";
        textToProcessBox.Size = new Size(416, 269);
        textToProcessBox.TabIndex = 2;
        textToProcessBox.TabStop = false;
        textToProcessBox.Text = "Text to Process";
        // 
        // tableLayoutPanel11
        // 
        tableLayoutPanel11.ColumnCount = 1;
        tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel11.Controls.Add(textBoxTextToProcess, 0, 0);
        tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 1);
        tableLayoutPanel11.Dock = DockStyle.Fill;
        tableLayoutPanel11.Location = new Point(3, 24);
        tableLayoutPanel11.Name = "tableLayoutPanel11";
        tableLayoutPanel11.RowCount = 2;
        tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
        tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel11.Size = new Size(410, 242);
        tableLayoutPanel11.TabIndex = 2;
        // 
        // textBoxTextToProcess
        // 
        textBoxTextToProcess.BackColor = SystemColors.GradientInactiveCaption;
        textBoxTextToProcess.Dock = DockStyle.Fill;
        textBoxTextToProcess.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxTextToProcess.Location = new Point(3, 3);
        textBoxTextToProcess.Name = "textBoxTextToProcess";
        textBoxTextToProcess.Size = new Size(404, 187);
        textBoxTextToProcess.TabIndex = 0;
        textBoxTextToProcess.Text = "";
        // 
        // tableLayoutPanel12
        // 
        tableLayoutPanel12.ColumnCount = 3;
        tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel12.Controls.Add(buttonCipher, 1, 0);
        tableLayoutPanel12.Controls.Add(buttonDecipher, 2, 0);
        tableLayoutPanel12.Controls.Add(buttonOpenText, 0, 0);
        tableLayoutPanel12.Dock = DockStyle.Fill;
        tableLayoutPanel12.Location = new Point(3, 196);
        tableLayoutPanel12.Name = "tableLayoutPanel12";
        tableLayoutPanel12.RowCount = 1;
        tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel12.Size = new Size(404, 43);
        tableLayoutPanel12.TabIndex = 1;
        // 
        // buttonCipher
        // 
        buttonCipher.BackColor = Color.DarkCyan;
        buttonCipher.Dock = DockStyle.Fill;
        buttonCipher.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonCipher.ForeColor = SystemColors.ButtonHighlight;
        buttonCipher.Location = new Point(137, 3);
        buttonCipher.Name = "buttonCipher";
        buttonCipher.Size = new Size(128, 37);
        buttonCipher.TabIndex = 0;
        buttonCipher.Text = "Cipher";
        buttonCipher.UseVisualStyleBackColor = false;
        buttonCipher.Click += ButtonCipher_Click;
        // 
        // buttonDecipher
        // 
        buttonDecipher.BackColor = Color.DarkCyan;
        buttonDecipher.Dock = DockStyle.Fill;
        buttonDecipher.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonDecipher.ForeColor = SystemColors.ButtonHighlight;
        buttonDecipher.Location = new Point(271, 3);
        buttonDecipher.Name = "buttonDecipher";
        buttonDecipher.Size = new Size(130, 37);
        buttonDecipher.TabIndex = 1;
        buttonDecipher.Text = "Decipher";
        buttonDecipher.UseVisualStyleBackColor = false;
        buttonDecipher.Click += ButtonDecipher_Click;
        // 
        // buttonOpenText
        // 
        buttonOpenText.BackColor = Color.LightSeaGreen;
        buttonOpenText.Dock = DockStyle.Fill;
        buttonOpenText.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonOpenText.ForeColor = SystemColors.ButtonHighlight;
        buttonOpenText.Location = new Point(3, 3);
        buttonOpenText.Name = "buttonOpenText";
        buttonOpenText.Size = new Size(128, 37);
        buttonOpenText.TabIndex = 2;
        buttonOpenText.Text = "Open";
        buttonOpenText.UseVisualStyleBackColor = false;
        buttonOpenText.Click += ButtonOpenText_Click;
        // 
        // openTextFileDialog
        // 
        openTextFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        // 
        // saveTextFileDialog
        // 
        saveTextFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Azure;
        ClientSize = new Size(1274, 702);
        Controls.Add(tableLayoutPanel1);
        Name = "MainForm";
        Text = "MainForm";
        Load += MainForm_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        keyBox.ResumeLayout(false);
        tableLayoutPanel9.ResumeLayout(false);
        tableLayoutPanel5.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)keySizeUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)keyGridView).EndInit();
        alphabetBox.ResumeLayout(false);
        tableLayoutPanel13.ResumeLayout(false);
        letterFrequencyBox.ResumeLayout(false);
        tableLayoutPanel6.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)letterFrequencyGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)originalLetterFrequencyGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)processedLetterFrequencyGrid).EndInit();
        tableLayoutPanel3.ResumeLayout(false);
        keyExtractionBox.ResumeLayout(false);
        tableLayoutPanel10.ResumeLayout(false);
        originalExcerptBox.ResumeLayout(false);
        cipheredExcerptBox.ResumeLayout(false);
        tableLayoutPanel14.ResumeLayout(false);
        processResultBox.ResumeLayout(false);
        tableLayoutPanel7.ResumeLayout(false);
        tableLayoutPanel8.ResumeLayout(false);
        textToProcessBox.ResumeLayout(false);
        tableLayoutPanel11.ResumeLayout(false);
        tableLayoutPanel12.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private TableLayoutPanel tableLayoutPanel4;
    private GroupBox keyBox;
    private TableLayoutPanel tableLayoutPanel9;
    private Button buttonClearKey;
    private Button buttonGenerateKey;
    private GroupBox alphabetBox;
    private TableLayoutPanel tableLayoutPanel13;
    private RichTextBox textBoxAlphabet;
    private ScottPlot.FormsPlot frequencyPlot;
    private GroupBox letterFrequencyBox;
    private TableLayoutPanel tableLayoutPanel6;
    private DataGridView letterFrequencyGrid;
    private DataGridView originalLetterFrequencyGrid;
    private TableLayoutPanel tableLayoutPanel3;
    private GroupBox processResultBox;
    private GroupBox textToProcessBox;
    private TableLayoutPanel tableLayoutPanel11;
    private RichTextBox textBoxTextToProcess;
    private TableLayoutPanel tableLayoutPanel12;
    private Button buttonCipher;
    private Button buttonDecipher;
    private DataGridView processedLetterFrequencyGrid;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn Letter;
    private DataGridViewTextBoxColumn LetterFrequency;
    private DataGridViewTextBoxColumn OriginalLetter;
    private DataGridViewTextBoxColumn ProcessedLetterFrequency;
    private TableLayoutPanel tableLayoutPanel7;
    private RichTextBox textBoxProcessedOutput;
    private TableLayoutPanel tableLayoutPanel8;
    private Button buttonSaveText;
    private Button buttonOpenText;
    private OpenFileDialog openTextFileDialog;
    private SaveFileDialog saveTextFileDialog;
    private GroupBox keyExtractionBox;
    private TableLayoutPanel tableLayoutPanel10;
    private GroupBox originalExcerptBox;
    private GroupBox cipheredExcerptBox;
    private TableLayoutPanel tableLayoutPanel14;
    private Button buttonExtractKey;
    private RichTextBox textBoxOriginalExcerpt;
    private RichTextBox textBoxCipheredExcerpt;
    private RichTextBox textBoxKey;
    private TableLayoutPanel tableLayoutPanel5;
    private NumericUpDown keySizeUpDown;
    private DataGridView keyGridView;
}