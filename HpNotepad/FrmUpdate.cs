using System;
using CCWin;
using System.IO;
using System.Windows.Forms;

namespace HpNotepad
{
    public partial class FrmUpdate : CCSkinMain
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            string[] area = { "E", "D", "C" }; 
            foreach (string p in area)
            {
                if (Directory.Exists(p + ":\\"))
                {
                    txtRootPath.Text = p + ":\\";
                    break;
                }
            }
        }

        private void txtRootPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtRootPath.Text = dialog.SelectedPath;

            }
        }
        private void sLabSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtRootPath.Text = dialog.SelectedPath;

            }
        }
        private void sBtnCreatePath_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPath.Text.Trim().Length > 0)
                {
                    string[] paths = txtNewPath.Text.Split('\\');
                    string root = txtRootPath.Text.Trim();
                    string newPath = root;
                    for (int i = 0; i < paths.Length; i++)
                    {
                        string path = paths[i];
                        newPath += path;

                        if (i < paths.Length - 1)
                            newPath += "\\";

                        if (!Directory.Exists(newPath))
                            Directory.CreateDirectory(newPath);
                    }
                    
                    System.Diagnostics.Process.Start("explorer.exe", newPath);
                }                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
         
        }

        private void sBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
