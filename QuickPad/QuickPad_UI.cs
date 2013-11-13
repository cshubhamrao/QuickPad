using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace QuickPad
{
    public partial class QuickPad_UI: Form
    {
        public void writeData(SaveFileDialog dialog, string extension)
        {
            string data = textBox.Text, 
                   fileName=dialog.FileName + extension;
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(data);
            writer.Close();

        }

        public QuickPad_UI()
        {
            InitializeComponent();
        }

        private void QuickPad_UI_Resize(object sender, EventArgs e)
        {
            fileName_Txt.Size = new Size(Convert.ToInt32(ext_label.Location.X)-75,
                fileName_Txt.Size.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFile_dialog.FileName = fileName_Txt.Text+ext_comboBox.SelectedText;
            saveFile_dialog.ShowDialog();
            writeData(saveFile_dialog, ext_comboBox.Text);
        }

    }
}
