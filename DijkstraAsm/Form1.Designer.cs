namespace DijkstraAsm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblInputFilePath = new TextBox();
            chooseInputFileButton = new Button();
            label4 = new Label();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            generateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbPath = new TextBox();
            label1 = new Label();
            txtWightsRange = new TextBox();
            txtMinConn = new TextBox();
            txtNodesCount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            chooseDirectoryButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(566, 353);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(558, 325);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Algorithm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.9352226F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.06478F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(lblInputFilePath, 1, 0);
            tableLayoutPanel3.Controls.Add(chooseInputFileButton, 0, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.404388F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90.59561F));
            tableLayoutPanel3.Size = new Size(552, 319);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // lblInputFilePath
            // 
            lblInputFilePath.Enabled = false;
            lblInputFilePath.Location = new Point(157, 3);
            lblInputFilePath.MaximumSize = new Size(1000, 0);
            lblInputFilePath.Name = "lblInputFilePath";
            lblInputFilePath.Size = new Size(302, 23);
            lblInputFilePath.TabIndex = 10;
            // 
            // chooseInputFileButton
            // 
            chooseInputFileButton.Location = new Point(3, 33);
            chooseInputFileButton.Name = "chooseInputFileButton";
            chooseInputFileButton.RightToLeft = RightToLeft.No;
            chooseInputFileButton.Size = new Size(84, 25);
            chooseInputFileButton.TabIndex = 1;
            chooseInputFileButton.Text = "Choose file";
            chooseInputFileButton.UseVisualStyleBackColor = true;
            chooseInputFileButton.Click += chooseFileButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 3);
            label4.Margin = new Padding(3, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 0;
            label4.Text = "Select input file:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.RightToLeft = RightToLeft.No;
            tabPage2.Size = new Size(558, 325);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Generation";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.5454559F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4545441F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.9999962F));
            tableLayoutPanel2.Controls.Add(generateButton, 1, 0);
            tableLayoutPanel2.Location = new Point(6, 193);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(550, 134);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(215, 3);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(111, 38);
            generateButton.TabIndex = 7;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.56261F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.4373856F));
            tableLayoutPanel1.Controls.Add(tbPath, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtWightsRange, 1, 2);
            tableLayoutPanel1.Controls.Add(txtMinConn, 1, 1);
            tableLayoutPanel1.Controls.Add(txtNodesCount, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(chooseDirectoryButton, 0, 4);
            tableLayoutPanel1.Location = new Point(0, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5770988F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0626717F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5771F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7660351F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0170975F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(556, 181);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tbPath
            // 
            tbPath.Enabled = false;
            tbPath.Location = new Point(245, 113);
            tbPath.MaximumSize = new Size(1000, 0);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(255, 23);
            tbPath.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.MaximumSize = new Size(150, 50);
            label1.Name = "label1";
            label1.Size = new Size(142, 26);
            label1.TabIndex = 0;
            label1.Text = "Number of nodes";
            // 
            // txtWightsRange
            // 
            txtWightsRange.Location = new Point(245, 76);
            txtWightsRange.Name = "txtWightsRange";
            txtWightsRange.Size = new Size(88, 23);
            txtWightsRange.TabIndex = 5;
            // 
            // txtMinConn
            // 
            txtMinConn.Location = new Point(245, 40);
            txtMinConn.Name = "txtMinConn";
            txtMinConn.Size = new Size(88, 23);
            txtMinConn.TabIndex = 3;
            // 
            // txtNodesCount
            // 
            txtNodesCount.Location = new Point(245, 3);
            txtNodesCount.Name = "txtNodesCount";
            txtNodesCount.Size = new Size(88, 23);
            txtNodesCount.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 37);
            label2.MaximumSize = new Size(500, 50);
            label2.Name = "label2";
            label2.Size = new Size(236, 26);
            label2.TabIndex = 2;
            label2.Text = "Minimal number of connections:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 73);
            label3.MaximumSize = new Size(500, 50);
            label3.Name = "label3";
            label3.Size = new Size(131, 26);
            label3.TabIndex = 4;
            label3.Text = "Weights' range";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 110);
            label5.Name = "label5";
            label5.Size = new Size(179, 21);
            label5.TabIndex = 7;
            label5.Text = "Provide destination path";
            // 
            // chooseDirectoryButton
            // 
            chooseDirectoryButton.Location = new Point(3, 146);
            chooseDirectoryButton.Name = "chooseDirectoryButton";
            chooseDirectoryButton.Size = new Size(109, 23);
            chooseDirectoryButton.TabIndex = 8;
            chooseDirectoryButton.Text = "Choose directory";
            chooseDirectoryButton.UseVisualStyleBackColor = true;
            chooseDirectoryButton.Click += chooseDirectoryButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 411);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Dijkstra's Algorithm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbPath;
        private Label label1;
        private TextBox txtWightsRange;
        private TextBox txtMinConn;
        private TextBox txtNodesCount;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button chooseDirectoryButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Button generateButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Button chooseInputFileButton;
        private TextBox lblInputFilePath;
    }
}
