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
            this.fileSave_button = new System.Windows.Forms.Button();
            this.fileName_Txt = new System.Windows.Forms.TextBox();
            this.fileName_label = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.ext_label = new System.Windows.Forms.Label();
            this.ext_comboBox = new System.Windows.Forms.ComboBox();
            this.saveFile_dialog = new System.Windows.Forms.SaveFileDialog();
            this.fileOpen_button = new System.Windows.Forms.Button();
            this.openFile_dialog = new System.Windows.Forms.OpenFileDialog();
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
            // fileSave_button
            // 
            this.fileSave_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSave_button.Location = new System.Drawing.Point(285, 291);
            this.fileSave_button.Name = "fileSave_button";
            this.fileSave_button.Size = new System.Drawing.Size(75, 23);
            this.fileSave_button.TabIndex = 1;
            this.fileSave_button.Text = "Save";
            this.fileSave_button.UseVisualStyleBackColor = true;
            this.fileSave_button.Click += new System.EventHandler(this.button1_Click);
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
            // fileOpen_button
            // 
            this.fileOpen_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileOpen_button.Location = new System.Drawing.Point(204, 291);
            this.fileOpen_button.Name = "fileOpen_button";
            this.fileOpen_button.Size = new System.Drawing.Size(75, 23);
            this.fileOpen_button.TabIndex = 7;
            this.fileOpen_button.Text = "Open";
            this.fileOpen_button.UseVisualStyleBackColor = true;
            this.fileOpen_button.Click += new System.EventHandler(this.fileOpen_button_Click);
            // 
            // openFile_dialog
            // 
            this.openFile_dialog.Filter = "QuickPad Text Files|*.qtf|Batch File|*.bat, *.cmd|HTML File|*.htm,*.html|Plain Te" +
    "xt Files|*.txt|All Files|*.*";
            this.openFile_dialog.Title = "Open QuickPad file";
            // 
            // QuickPad_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 326);
            this.Controls.Add(this.fileOpen_button);
            this.Controls.Add(this.ext_comboBox);
            this.Controls.Add(this.ext_label);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fileName_label);
            this.Controls.Add(this.fileName_Txt);
            this.Controls.Add(this.fileSave_button);
            this.Controls.Add(this.textBox);
            this.Name = "QuickPad_UI";
            this.Text = "QuickPad";
            this.Resize += new System.EventHandler(this.QuickPad_UI_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button fileSave_button;
        private System.Windows.Forms.TextBox fileName_Txt;
        private System.Windows.Forms.Label fileName_label;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label ext_label;
        private System.Windows.Forms.ComboBox ext_comboBox;
        private System.Windows.Forms.SaveFileDialog saveFile_dialog;
        private System.Windows.Forms.Button fileOpen_button;
        private System.Windows.Forms.OpenFileDialog openFile_dialog;
    }
}

