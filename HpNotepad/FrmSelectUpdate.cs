using System;
using CCWin;
using System.IO;
using System.Windows.Forms;

namespace HpNotepad
{
    public partial class FrmSelectUpdate : CCSkinMain
    {
        string root = "";
        public FrmSelectUpdate()
        {
            InitializeComponent();
        }

        private void FrmSelectUpdate_Load(object sender, EventArgs e)
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

        private void slabSelectFiles_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;//该值确定是否可以选择多个文件
                dialog.Title = "请选择文件夹";
                dialog.Filter = "所有文件(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    root = txtRootPath.Text.Trim();
                    string[] files = dialog.FileNames;
                    if (files.Length > 0)
                    {
                        string basePath = txtNewPath.Text.Trim();
                        string path = dialog.FileName;
                        path = path.Substring(0, path.LastIndexOf("\\"));

                        string[] paths = path.Split('\\');
                        bool isexits = true;
                        if (!path.ToLower().Contains(basePath.ToLower()) && paths.Length > 2)
                        {
                            root += basePath + "\\";
                            if (!Directory.Exists(root))
                                Directory.CreateDirectory(root);
                            isexits = false;
                        }

                        string newPath = "";
                        for (int i = 0; i < paths.Length; i++)
                        {
                            if (newPath.Length > 0)
                            {
                                newPath += paths[i] + "\\";
                                if (!Directory.Exists(newPath))
                                    Directory.CreateDirectory(newPath);
                            }
                            if (paths[i].ToLower() == basePath.ToLower() || (!isexits && i == 1))
                            {
                                newPath = root + paths[i] + "\\";
                                if (!Directory.Exists(newPath))
                                    Directory.CreateDirectory(newPath);
                            }

                        }
                        if (newPath.Length > 0)
                        {
                            for (int i = 0; i < files.Length; i++)
                            {
                                string file = files[i];
                                string fileName = file.Substring(file.LastIndexOf("\\") + 1);
                                File.Copy(files[i], newPath + "\\" + fileName);
                            }

                        }
                        sLabTip.Visible = true;
                        sLabTip.Text = "拷贝" + files.Length + "个文件成功";

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void sBtnClose_Click(object sender, EventArgs e)
        {
            if (root.Length > 0)
            {
                //MessageBox.Show("备份完毕");
                System.Diagnostics.Process.Start("explorer.exe", root);
            }
            this.Close();
        }

    }
}
