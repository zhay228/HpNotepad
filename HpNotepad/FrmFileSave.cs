using System;
using System.Drawing;
using System.Windows.Forms;
using XpSystem;
using CCWin;

namespace HpNotepad
{
    public partial class FrmFileSave : CCSkinMain
    {
        public FrmFileSave()
        {
            InitializeComponent();
            
        }

        private void FrmFileSave_Load(object sender, EventArgs e)
        {
            Win32Utility.SetCueText(txtFilePath, "请选择文件");
            ShortCut();
        } 

        private void ShortCut()
        {
            //注册热键Alt+E，Id号为201
            HotKey.RegisterHotKey(Handle, 201, HotKey.KeyModifiers.None, Keys.Escape);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width; //屏幕宽
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height; //屏幕高
            Point point = new Point(0, 100);
            //按快捷键   
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 201: //按下 Esc
                            this.Close();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void txtFilePath_Click(object sender, EventArgs e)
        {
            btnFile_Click(null,null);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    txtFilePath.Text = dialog.FileName;
                 
                    System.IO.File.Copy(dialog.FileName, SystemInfo.documentPath + dialog.FileName.Substring(dialog.FileName.LastIndexOf("\\")));
                    MessageBox.Show("保存成功");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Log.WriteErrLog(ex);
                }
              
               
            }
        }
         
    }
}
