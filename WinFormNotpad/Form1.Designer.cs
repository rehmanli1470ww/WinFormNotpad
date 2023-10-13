namespace WinFormNotpad
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
            richTextBox1 = new RichTextBox();
            comboBoxFont = new ComboBox();
            comboBoxSize = new ComboBox();
            buttonB = new Button();
            labelFont = new Label();
            label1 = new Label();
            buttonU = new Button();
            buttonI = new Button();
            label2 = new Label();
            buttonL = new Button();
            buttonC = new Button();
            buttonR = new Button();
            label3 = new Label();
            comboBoxColor = new ComboBox();
            labelColor = new Label();
            SaveTextBox = new TextBox();
            LoadTextBox = new TextBox();
            LoadButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(2, 109);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(796, 338);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // comboBoxFont
            // 
            comboBoxFont.FormattingEnabled = true;
            comboBoxFont.Location = new Point(4, 71);
            comboBoxFont.Name = "comboBoxFont";
            comboBoxFont.Size = new Size(107, 28);
            comboBoxFont.TabIndex = 1;
            comboBoxFont.SelectedIndexChanged += comboBoxFont_SelectedIndexChanged;
            // 
            // comboBoxSize
            // 
            comboBoxSize.FormattingEnabled = true;
            comboBoxSize.Location = new Point(117, 71);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(47, 28);
            comboBoxSize.TabIndex = 2;
            comboBoxSize.SelectedIndexChanged += comboBoxSize_SelectedIndexChanged;
            // 
            // buttonB
            // 
            buttonB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonB.Location = new Point(180, 70);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(33, 33);
            buttonB.TabIndex = 3;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = true;
            buttonB.Click += buttonB_Click;
            // 
            // labelFont
            // 
            labelFont.AutoSize = true;
            labelFont.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFont.Location = new Point(22, 38);
            labelFont.Name = "labelFont";
            labelFont.Size = new Size(54, 28);
            labelFont.TabIndex = 4;
            labelFont.Text = "Font";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(117, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 5;
            label1.Text = "Size";
            // 
            // buttonU
            // 
            buttonU.Font = new Font("Segoe UI Light", 9F, FontStyle.Underline, GraphicsUnit.Point);
            buttonU.Location = new Point(219, 70);
            buttonU.Name = "buttonU";
            buttonU.Size = new Size(33, 33);
            buttonU.TabIndex = 6;
            buttonU.Text = "u";
            buttonU.UseVisualStyleBackColor = true;
            buttonU.Click += buttonU_Click;
            // 
            // buttonI
            // 
            buttonI.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonI.Location = new Point(258, 70);
            buttonI.Name = "buttonI";
            buttonI.Size = new Size(33, 33);
            buttonI.TabIndex = 7;
            buttonI.Text = "I";
            buttonI.UseVisualStyleBackColor = true;
            buttonI.Click += buttonI_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(189, 38);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 8;
            label2.Text = "Font Style";
            // 
            // buttonL
            // 
            buttonL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonL.Location = new Point(317, 71);
            buttonL.Name = "buttonL";
            buttonL.Size = new Size(33, 33);
            buttonL.TabIndex = 9;
            buttonL.Text = "L";
            buttonL.UseVisualStyleBackColor = true;
            buttonL.Click += buttonL_Click;
            // 
            // buttonC
            // 
            buttonC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonC.Location = new Point(356, 70);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(33, 33);
            buttonC.TabIndex = 10;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonR
            // 
            buttonR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonR.Location = new Point(395, 70);
            buttonR.Name = "buttonR";
            buttonR.Size = new Size(33, 33);
            buttonR.TabIndex = 11;
            buttonR.Text = "R";
            buttonR.UseVisualStyleBackColor = true;
            buttonR.Click += buttonR_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(317, 38);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 12;
            label3.Text = "Alignment";
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(452, 74);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(80, 28);
            comboBoxColor.TabIndex = 13;
            comboBoxColor.SelectedIndexChanged += comboBoxColor_SelectedIndexChanged;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelColor.Location = new Point(461, 38);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(60, 28);
            labelColor.TabIndex = 14;
            labelColor.Text = "Color";
            // 
            // SaveTextBox
            // 
            SaveTextBox.Location = new Point(547, 76);
            SaveTextBox.Name = "SaveTextBox";
            SaveTextBox.Size = new Size(161, 27);
            SaveTextBox.TabIndex = 15;
            // 
            // LoadTextBox
            // 
            LoadTextBox.Location = new Point(547, 43);
            LoadTextBox.Name = "LoadTextBox";
            LoadTextBox.Size = new Size(161, 27);
            LoadTextBox.TabIndex = 16;
            // 
            // LoadButton
            // 
            LoadButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoadButton.Location = new Point(714, 43);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(84, 27);
            LoadButton.TabIndex = 17;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Location = new Point(714, 76);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(84, 27);
            SaveButton.TabIndex = 18;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveButton);
            Controls.Add(LoadButton);
            Controls.Add(LoadTextBox);
            Controls.Add(SaveTextBox);
            Controls.Add(labelColor);
            Controls.Add(comboBoxColor);
            Controls.Add(label3);
            Controls.Add(buttonR);
            Controls.Add(buttonC);
            Controls.Add(buttonL);
            Controls.Add(label2);
            Controls.Add(buttonI);
            Controls.Add(buttonU);
            Controls.Add(label1);
            Controls.Add(labelFont);
            Controls.Add(buttonB);
            Controls.Add(comboBoxSize);
            Controls.Add(comboBoxFont);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ComboBox comboBoxFont;
        private ComboBox comboBoxSize;
        private Button buttonB;
        private Label labelFont;
        private Label label1;
        private Button buttonU;
        private Button buttonI;
        private Label label2;
        private Button buttonL;
        private Button buttonC;
        private Button buttonR;
        private Label label3;
        private ComboBox comboBoxColor;
        private Label labelColor;
        private TextBox SaveTextBox;
        private TextBox LoadTextBox;
        private Button LoadButton;
        private Button SaveButton;
    }
}