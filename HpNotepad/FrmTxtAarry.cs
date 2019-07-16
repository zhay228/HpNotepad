using System;
using System.Windows.Forms;

namespace HpNotepad
{
    public partial class FrmTxtAarry : Form
    {
        public FrmTxtAarry()
        {
            InitializeComponent();
        }

        private void txtPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = file.FileName;
            }
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            string str = FileOperation.ReadFile(txtPath.Text.Trim());
            string[] c = str.Replace("\n", "").Split('\r');
            string arrayStr = string.Join("\",\"", c);
            rTxtContent.AppendText(arrayStr);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rTxtContent.Clear();
        }
    }
}
