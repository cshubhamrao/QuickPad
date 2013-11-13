namespace QuickPad
{
    partial class QuickPad_UI
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
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileName_Txt = new System.Windows.Forms.TextBox();
            this.fileName_label = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.ext_label = new System.Windows.Forms.Label();
            this.ext_comboBox = new System.Windows.Forms.ComboBox();
            this.saveFile_dialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.AcceptsTab = true;
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 38);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(348, 247);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(285, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileName_Txt
            // 
            this.fileName_Txt.Location = new System.Drawing.Point(69, 12);
            this.fileName_Txt.Name = "fileName_Txt";
            this.fileName_Txt.Size = new System.Drawing.Size(151, 20);
            this.fileName_Txt.TabIndex = 2;
            // 
            // fileName_label
            // 
            this.fileName_label.AutoSize = true;
            this.fileName_label.Location = new System.Drawing.Point(9, 15);
            this.fileName_label.Name = "fileName_label";
            this.fileName_label.Size = new System.Drawing.Size(54, 13);
            this.fileName_label.TabIndex = 3;
            this.fileName_label.Text = "File Name";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.Location = new System.Drawing.Point(12, 291);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ext_label
            // 
            this.ext_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ext_label.AutoSize = true;
            this.ext_label.Location = new System.Drawing.Point(226, 15);
            this.ext_label.Name = "ext_label";
            this.ext_label.Size = new System.Drawing.Size(53, 13);
            this.ext_label.TabIndex = 5;
            this.ext_label.Text = "Extension";
            // 
            // ext_comboBox
            // 
            this.ext_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ext_comboBox.FormattingEnabled = true;
            this.ext_comboBox.Items.AddRange(new object[] {
            ".qpf",
            ".bat",
            ".htm",
            ".txt"});
            this.ext_comboBox.Location = new System.Drawing.Point(285, 11);
            this.ext_comboBox.Name = "ext_comboBox";
            this.ext_comboBox.Size = new System.Drawing.Size(75, 21);
            this.ext_comboBox.TabIndex = 6;
            // 
            // saveFile_dialog
            // 
            this.saveFile_dialog.Title = "Save QuickPad file";
            // 
            // QuickPad_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 326);
            this.Controls.Add(this.ext_comboBox);
            this.Controls.Add(this.ext_label);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fileName_label);
            this.Controls.Add(this.fileName_Txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Name = "QuickPad_UI";
            this.Text = "QuickPad";
            this.Resize += new System.EventHandler(this.QuickPad_UI_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fileName_Txt;
        private System.Windows.Forms.Label fileName_label;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label ext_label;
        private System.Windows.Forms.ComboBox ext_comboBox;
        private System.Windows.Forms.SaveFileDialog saveFile_dialog;
    }
}

