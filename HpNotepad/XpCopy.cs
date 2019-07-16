using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using Microsoft.Win32;
using DBFactory;

namespace HpNotepad
{

    public partial class XpCopy : UserControl
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll")]
        public static extern bool ChangeClipboardChain(IntPtr hWndResume, IntPtr hWndNext);
        [DllImport("user32.dll")]
        protected static extern int SendMessage(IntPtr hWnd, int nMsg, IntPtr wParam, IntPtr lParam);

        private const int WM_CLIPBOARDUPDATE = 0x0318;
        private const int WM_CLIPBOARDPASTE = 0x02A2;
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30D;

        private IntPtr NextClipHwnd;

        List<string> datas = new List<string>();
        IDataObject iData;
        KeyboardHook k_hook;
        bool IsCopy = true;
        bool IsRun = false;

        public XpCopy()
        {
            InitializeComponent();
            
        }

        public XpCopy(bool start) {
            IsRun = start;
            InitializeComponent();
            if (start) {
                Clipboard.Clear();
                k_hook = new KeyboardHook();
                k_hook.KeyDownEvent += new KeyEventHandler(hook_KeyDown);//钩住键按下
                //k_hook.KeyPressEvent += new KeyPressEventHandler(hook_KeyPress);
                //k_hook.KeyUpEvent += new KeyEventHandler(hook_KeyUp);
                k_hook.Start();//安装键盘钩子     
            }
        }

        private void XpCopy_Load(object sender, EventArgs e)
        {
            if (IsRun)
            {             
                //获得观察链中下一个窗口句柄
                //NextClipHwnd = SetClipboardViewer(this.Handle);  
                NextClipHwnd = SetClipboardViewer(this.Handle);
                AddFileContextMenuItem("开启多次复制", "");
            }
        }


        private void AddFileContextMenuItem(string itemName, string associatedProgramFullPath)
        {
            //创建项：shell 
            RegistryKey shellKey = Registry.ClassesRoot.OpenSubKey(@"*\shell", true);
            if (shellKey == null)
            {
                shellKey = Registry.ClassesRoot.CreateSubKey(@"*\shell");
            }

            //创建项：右键显示的菜单名称
            RegistryKey rightCommondKey = shellKey.CreateSubKey(itemName);
            RegistryKey associatedProgramKey = rightCommondKey.CreateSubKey("command");

            //创建默认值：关联的程序
            associatedProgramKey.SetValue(string.Empty, associatedProgramFullPath);

            //刷新到磁盘并释放资源
            associatedProgramKey.Close();
            rightCommondKey.Close();
            shellKey.Close();

        }

        private void AddDirectoryContextMenuItem(string itemName, string associatedProgramFullPath)
        {
            //创建项：shell 
            RegistryKey shellKey = Registry.ClassesRoot.OpenSubKey(@"directory\shell", true);
            if (shellKey == null)
            {
                shellKey = Registry.ClassesRoot.CreateSubKey(@"*\shell");
            }

            //创建项：右键显示的菜单名称
            RegistryKey rightCommondKey = shellKey.CreateSubKey(itemName);
            RegistryKey associatedProgramKey = rightCommondKey.CreateSubKey("command");

            //创建默认值：关联的程序
            associatedProgramKey.SetValue("", associatedProgramFullPath);


            //刷新到磁盘并释放资源
            associatedProgramKey.Close();
            rightCommondKey.Close();
            shellKey.Close();
        }

        private void hook_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按下的键（Ctrl + V）
            if ((int)e.KeyChar == 118)
            {
                iData = Clipboard.GetDataObject();
                string data = (String)iData.GetData(DataFormats.Text);
                Log.WriteLog("粘贴值为：" + data);
                IsCopy = false;
                if (datas.Count < 1) return;
                Clipboard.SetDataObject(datas[0]);
                Log.WriteLog("粘贴值为：" + datas[0]);
                if (datas.Count > 1)
                    datas.RemoveAt(0);
            }
            if ((int)e.KeyChar == 99)
            {
                IsCopy = true;
            }
        }

        //3.判断输入键值（实现KeyDown事件）
        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue == (int)Keys.C | e.KeyValue == (int)Keys.C) && (int)Control.ModifierKeys == (int)Keys.Control)
            {
                IsCopy = true;
                //Copy();
            }
            //判断按下的键（Ctrl + V）
            if (e.KeyValue == (int)Keys.V && (int)Control.ModifierKeys == (int)Keys.Control)
            {
                if (!IsRun) return;
                IsCopy = false;
                if (datas.Count < 1) return;

                Clipboard.SetDataObject(datas[0]);
                if (datas.Count > 1)
                {
                    datas.RemoveAt(0);
                }
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:  //剪切板内容替换
                    Copy();
                    break;

                case WM_CHANGECBCHAIN:
                    Copy();
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
        }

        private void Copy()
        {
            if (!IsCopy) return;

            iData = Clipboard.GetDataObject();
            //检测文本
            if (iData.GetDataPresent(DataFormats.Text) | iData.GetDataPresent(DataFormats.OemText))
            {
                string data = (String)iData.GetData(DataFormats.Text);
                datas.Add(data);
                Log.WriteLog("第" + datas.Count + "个的值：" + datas[datas.Count - 1]);
            }
            //检测图像
            if (iData.GetDataPresent(DataFormats.FileDrop))
            {
                //pictureBox1.Image = Clipboard.GetImage();
                // NewClipData();
            }

            //检测自定义类型
            if (iData.GetDataPresent("myFormat"))
            {
                // MyObj myobj = (MyObj)iData.GetData("myFormat");
                //this.richTextBox1.Text = myobj.ObjName;
            }
        }

        public void Close()
        {
            //从观察链中删除本观察窗口（第一个参数：将要删除的窗口的句柄；第二个参数：//观察链中下一个窗口的句柄 ）
            ChangeClipboardChain(this.Handle, NextClipHwnd);
            //将变动消息WM_CHANGECBCHAIN消息传递到下一个观察链中的窗口 
            SendMessage(NextClipHwnd, WM_CHANGECBCHAIN, this.Handle, NextClipHwnd);
        }


        public void tsItemClear_Click(object sender, EventArgs e)
        {
            datas.Clear();
            Clipboard.Clear();
        }

        public void tsItemStart_Click(object sender, EventArgs e)
        {
            IsRun = true;
        }

        public void tsItemClose_Click(object sender, EventArgs e)
        {
            tsItemClear_Click(null, null);
            IsRun = !true;
        }

    }
}
