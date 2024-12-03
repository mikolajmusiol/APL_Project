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
            chooseInputFileButton = new Button();
            label4 = new Label();
            tabPage2 = new TabPage();
            textBox1 = new TextBox();
            chooseDirectoryButton = new Button();
            label5 = new Label();
            generateButton = new Button();
            txtWightsRange = new TextBox();
            label3 = new Label();
            txtMinConn = new TextBox();
            label2 = new Label();
            txtNodesCount = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chooseInputFileButton);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Algorithm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chooseInputFileButton
            // 
            chooseInputFileButton.Location = new Point(38, 31);
            chooseInputFileButton.Name = "chooseInputFileButton";
            chooseInputFileButton.RightToLeft = RightToLeft.No;
            chooseInputFileButton.Size = new Size(73, 26);
            chooseInputFileButton.TabIndex = 1;
            chooseInputFileButton.Text = "Choose file";
            chooseInputFileButton.UseVisualStyleBackColor = true;
            chooseInputFileButton.Click += chooseFileButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(3, 3);
            label4.Margin = new Padding(0, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 0;
            label4.Text = "Select input file";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(chooseDirectoryButton);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(generateButton);
            tabPage2.Controls.Add(txtWightsRange);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtMinConn);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtNodesCount);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.RightToLeft = RightToLeft.No;
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Generation";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(185, 144);
            textBox1.MaximumSize = new Size(1000, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(64, 23);
            textBox1.TabIndex = 9;
            // 
            // chooseDirectoryButton
            // 
            chooseDirectoryButton.Location = new Point(70, 183);
            chooseDirectoryButton.Name = "chooseDirectoryButton";
            chooseDirectoryButton.Size = new Size(109, 23);
            chooseDirectoryButton.TabIndex = 8;
            chooseDirectoryButton.Text = "Choose directory";
            chooseDirectoryButton.UseVisualStyleBackColor = true;
            chooseDirectoryButton.Click += chooseDirectoryButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(0, 146);
            label5.Name = "label5";
            label5.Size = new Size(179, 21);
            label5.TabIndex = 7;
            label5.Text = "Provide destination path";
            // 
            // generateButton
            // 
            generateButton.Location = new Point(58, 233);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(86, 33);
            generateButton.TabIndex = 6;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // txtWightsRange
            // 
            txtWightsRange.Location = new Point(131, 104);
            txtWightsRange.Name = "txtWightsRange";
            txtWightsRange.Size = new Size(44, 23);
            txtWightsRange.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 104);
            label3.MaximumSize = new Size(500, 50);
            label3.Name = "label3";
            label3.Size = new Size(119, 26);
            label3.TabIndex = 4;
            label3.Text = "Weights' range";
            // 
            // txtMinConn
            // 
            txtMinConn.Location = new Point(249, 62);
            txtMinConn.Name = "txtMinConn";
            txtMinConn.Size = new Size(44, 23);
            txtMinConn.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 62);
            label2.MaximumSize = new Size(500, 50);
            label2.Name = "label2";
            label2.Size = new Size(237, 26);
            label2.TabIndex = 2;
            label2.Text = "Minimal number of connections:";
            // 
            // txtNodesCount
            // 
            txtNodesCount.Location = new Point(150, 19);
            txtNodesCount.Name = "txtNodesCount";
            txtNodesCount.Size = new Size(44, 23);
            txtNodesCount.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 19);
            label1.MaximumSize = new Size(150, 50);
            label1.Name = "label1";
            label1.Size = new Size(138, 26);
            label1.TabIndex = 0;
            label1.Text = "Number of nodes";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Dijkstra's Algorithm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox txtNodesCount;
        private TextBox txtMinConn;
        private Label label2;
        private Button generateButton;
        private TextBox txtWightsRange;
        private Label label3;
        private Label label4;
        private Button chooseInputFileButton;
        private OpenFileDialog openFileDialog1;
        private Button chooseDirectoryButton;
        private Label label5;
        private SaveFileDialog saveFileDialog1;
        private TextBox textBox1;
    }
}
