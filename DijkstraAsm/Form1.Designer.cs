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
            tableLayoutPanel4 = new TableLayoutPanel();
            label7 = new Label();
            progressBar1 = new ProgressBar();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            lblInputFilePath = new TextBox();
            chooseInputFileButton = new Button();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            generateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbPath = new TextBox();
            label1 = new Label();
            txtWightsRange = new TextBox();
            txtMinConn = new TextBox();
            txtNodesCount = new TextBox();
            label3 = new Label();
            chooseDirectoryButton = new Button();
            label2 = new Label();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            tabControl1.Location = new Point(14, 16);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(647, 471);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel4);
            tabPage1.Controls.Add(tableLayoutPanel3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(639, 438);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Algorithm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.27646F));
            tableLayoutPanel4.Controls.Add(label7, 0, 0);
            tableLayoutPanel4.Controls.Add(progressBar1, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(3, 219);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6976748F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 89.30232F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(633, 215);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Location = new Point(554, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 23);
            label7.TabIndex = 0;
            label7.Text = "Time: 1ms";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Location = new Point(3, 26);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(627, 29);
            progressBar1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.27646F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.72354F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(lblInputFilePath, 1, 1);
            tableLayoutPanel3.Controls.Add(chooseInputFileButton, 1, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 1);
            tableLayoutPanel3.Controls.Add(radioButton1, 0, 2);
            tableLayoutPanel3.Controls.Add(radioButton2, 0, 3);
            tableLayoutPanel3.Controls.Add(button1, 0, 4);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 4);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000057F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999962F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999962F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999962F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000057F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(633, 215);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 4);
            label4.Margin = new Padding(3, 4, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 39);
            label4.TabIndex = 0;
            label4.Text = "Select input file:";
            // 
            // lblInputFilePath
            // 
            lblInputFilePath.Dock = DockStyle.Left;
            lblInputFilePath.Enabled = false;
            lblInputFilePath.Location = new Point(163, 51);
            lblInputFilePath.Margin = new Padding(3, 8, 3, 4);
            lblInputFilePath.MaximumSize = new Size(1142, 4);
            lblInputFilePath.MinimumSize = new Size(362, 23);
            lblInputFilePath.Name = "lblInputFilePath";
            lblInputFilePath.Size = new Size(362, 23);
            lblInputFilePath.TabIndex = 10;
            // 
            // chooseInputFileButton
            // 
            chooseInputFileButton.Dock = DockStyle.Left;
            chooseInputFileButton.Location = new Point(163, 4);
            chooseInputFileButton.Margin = new Padding(3, 4, 3, 4);
            chooseInputFileButton.Name = "chooseInputFileButton";
            chooseInputFileButton.RightToLeft = RightToLeft.No;
            chooseInputFileButton.Size = new Size(96, 35);
            chooseInputFileButton.TabIndex = 1;
            chooseInputFileButton.Text = "Choose file";
            chooseInputFileButton.UseVisualStyleBackColor = true;
            chooseInputFileButton.Click += chooseFileButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 47);
            label6.Margin = new Padding(3, 4, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 38);
            label6.TabIndex = 11;
            label6.Text = "File path:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Dock = DockStyle.Left;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(3, 88);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 36);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "C#";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Dock = DockStyle.Top;
            radioButton2.Font = new Font("Segoe UI", 12F);
            radioButton2.Location = new Point(3, 130);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(154, 32);
            radioButton2.TabIndex = 13;
            radioButton2.Text = "ASM";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(3, 172);
            button1.Name = "button1";
            button1.Size = new Size(154, 40);
            button1.TabIndex = 14;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.RightToLeft = RightToLeft.No;
            tabPage2.Size = new Size(639, 438);
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
            tableLayoutPanel2.Location = new Point(7, 257);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(629, 179);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(245, 4);
            generateButton.Margin = new Padding(3, 4, 3, 4);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(127, 51);
            generateButton.TabIndex = 7;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.4015732F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.5984268F));
            tableLayoutPanel1.Controls.Add(tbPath, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtWightsRange, 1, 2);
            tableLayoutPanel1.Controls.Add(txtMinConn, 1, 1);
            tableLayoutPanel1.Controls.Add(txtNodesCount, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(chooseDirectoryButton, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Location = new Point(0, 8);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5770988F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0626717F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5771F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7660351F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0170975F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(635, 241);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tbPath
            // 
            tbPath.Dock = DockStyle.Left;
            tbPath.Enabled = false;
            tbPath.Location = new Point(303, 150);
            tbPath.Margin = new Padding(3, 4, 3, 4);
            tbPath.MaximumSize = new Size(1142, 4);
            tbPath.MinimumSize = new Size(351, 23);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(351, 23);
            tbPath.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.MaximumSize = new Size(171, 67);
            label1.Name = "label1";
            label1.Size = new Size(171, 35);
            label1.TabIndex = 0;
            label1.Text = "Number of nodes:";
            // 
            // txtWightsRange
            // 
            txtWightsRange.Location = new Point(303, 101);
            txtWightsRange.Margin = new Padding(3, 4, 3, 4);
            txtWightsRange.Name = "txtWightsRange";
            txtWightsRange.Size = new Size(100, 27);
            txtWightsRange.TabIndex = 5;
            // 
            // txtMinConn
            // 
            txtMinConn.Location = new Point(303, 53);
            txtMinConn.Margin = new Padding(3, 4, 3, 4);
            txtMinConn.Name = "txtMinConn";
            txtMinConn.Size = new Size(100, 27);
            txtMinConn.TabIndex = 3;
            // 
            // txtNodesCount
            // 
            txtNodesCount.Location = new Point(303, 4);
            txtNodesCount.Margin = new Padding(3, 4, 3, 4);
            txtNodesCount.Name = "txtNodesCount";
            txtNodesCount.Size = new Size(100, 27);
            txtNodesCount.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 97);
            label3.MaximumSize = new Size(571, 67);
            label3.Name = "label3";
            label3.Size = new Size(294, 35);
            label3.TabIndex = 4;
            label3.Text = "Weights' range:";
            // 
            // chooseDirectoryButton
            // 
            chooseDirectoryButton.Location = new Point(3, 195);
            chooseDirectoryButton.Margin = new Padding(3, 4, 3, 4);
            chooseDirectoryButton.Name = "chooseDirectoryButton";
            chooseDirectoryButton.Size = new Size(125, 31);
            chooseDirectoryButton.TabIndex = 8;
            chooseDirectoryButton.Text = "Choose directory:";
            chooseDirectoryButton.UseVisualStyleBackColor = true;
            chooseDirectoryButton.Click += chooseDirectoryButton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 49);
            label2.MaximumSize = new Size(571, 67);
            label2.Name = "label2";
            label2.Size = new Size(294, 31);
            label2.TabIndex = 2;
            label2.Text = "Minimal number of connections:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 146);
            label5.Name = "label5";
            label5.Size = new Size(231, 28);
            label5.TabIndex = 7;
            label5.Text = "Provide destination path:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 537);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(683, 584);
            MinimumSize = new Size(683, 584);
            Name = "Form1";
            Text = "Dijkstra's Algorithm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
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
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private ProgressBar progressBar1;
    }
}
