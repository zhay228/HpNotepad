using CCWin;
using DBFactory;
using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HpNotepad
{
    public partial class FrmFileQuery : CCSkinMain
    {

        List<string> files = System.IO.Directory.GetFiles(SystemInfo.documentPath).ToList();
        List<string> fileName = new List<string>();
        public FrmFileQuery()
        {
            InitializeComponent();

        }

        private void FrmQuery_Load(object sender, EventArgs e)
        {
            Win32Utility.SetCueText(cbxKey, "请输入关键字");
            for (int i = 0; i < files.Count; i++)
            {
                fileName.Add(files[i].Substring(files[i].LastIndexOf("\\") + 1));
            }

        }

        private void FrmQuery_Activated(object sender, EventArgs e)
        {
            try
            {
                Win32Utility.SetForegroundWindow(this.Handle);
                this.Activate();
                cbxKey.Focus();
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
            }
           
        }


        private void ShortCut()
        {
            //注册热键Alt+E，Id号为201
            HotKey.RegisterHotKey(Handle, 201, HotKey.KeyModifiers.None, Keys.Escape);
        }

        protected override void WndProc(ref Message m)
        {
            try
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
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
            }           
        }

        private void cbxKey_KeyUp(object sender, KeyEventArgs e)
        {
           
            try
            {
                if (cbxKey.Text.Length < 1 || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down
              || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right) return;
                string filePath = cbxKey.Text;
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxKey.Text.Contains(".lnk"))
                    {
                        filePath = GetProgramPath(SystemInfo.documentPath + "\\" + filePath);
                        System.Diagnostics.Process.Start(filePath);
                    }
                    else
                        System.Diagnostics.Process.Start(SystemInfo.documentPath + "\\" + filePath);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
            }         
        }

        private string GetProgramPath(string fileName)
        {
            try
            {
                //快捷方式文件的路径 = @"d:\Test.lnk";
                if (System.IO.File.Exists(fileName))
                {
                    WshShell shell = new WshShell();
                    IWshShortcut wsc = (IWshShortcut)shell.CreateShortcut(fileName);
                    //快捷方式文件指向的路径.Text = 当前快捷方式文件IWshShortcut类.TargetPath;
                    //快捷方式文件指向的目标目录.Text = 当前快捷方式文件IWshShortcut类.WorkingDirectory;
                    return wsc.TargetPath;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
                return "";
            }
          
        }

        private void cbxKey_TextUpdate(object sender, EventArgs e)
        {
           
            try
            {
                if (cbxKey.Text.Length < 1) return;
                fileName = fileName.Where(t => t.Contains(cbxKey.Text.Trim())).ToList();
                cbxKey.Items.Clear();
                for (int i = 0; i < fileName.Count; i++)
                {
                    cbxKey.Items.Add(fileName[i]);
                }
                string text = this.cbxKey.Text;
                //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
                Cursor = Cursors.Default;

                //自动弹出下拉框
                this.cbxKey.DroppedDown = true;
                this.cbxKey.Text = text;
                //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
                this.cbxKey.SelectionStart = this.cbxKey.Text.Length;
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
            }           
        }
    }
}
