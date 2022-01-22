using System;
using System.IO;
using System.Windows.Forms;

namespace Hpumper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "exe";
            openFileDialog1.Filter = "실행파일 (*.exe)|*.exe";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = @".";
            openFileDialog1.Title = "Select file to be pumped";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                path.Text = openFileDialog1.FileName;
            }
        }
        public int pumpUnit;
        private void pump(string path)
        {
            var file = File.OpenWrite(path);
            var siz = file.Seek(0, SeekOrigin.End);
            if(sizecombo.Text == "kb")
            {
                pumpUnit = 1024;
            }
            else if(sizecombo.Text == "mb")
            {
                pumpUnit = 1024 * 1024;
            }
            else if(sizecombo.Text == "gb")
            {
                pumpUnit = 1024 * 1024 * 1024;
            }
            while(siz < Convert.ToInt64(pumpSizebox.Text) * pumpUnit)
            {
                siz++;
                file.WriteByte(0);
            }
            file.Close();
            MessageBox.Show("File Pumped!");
        }
        private void pumpbutton_Click(object sender, EventArgs e)
        {
            if(path.Text == "")
            {
                MessageBox.Show("Select File!");
            }
            else
            {
                pump(path.Text);
            }
        }
    }
}
