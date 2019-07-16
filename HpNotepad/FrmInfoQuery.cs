using CCWin;
using DBFactory;
using HpDAL;
using HpModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HpNotepad
{
    public partial class FrmInfoQuery : CCSkinMain
    {
        List<MInfo> list = new List<MInfo>();
        //输入key之后，返回的关键词
        List<string> listNew = new List<string>();
        public FrmInfoQuery()
        {
            InitializeComponent();
        }

        private void FrmInfoQuery_Load(object sender, EventArgs e)
        {
            Win32Utility.SetCueText(cbxKey, "请输入关键字");
            //cbxKey.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ShortCut();
            InitalData();
        }

        private void InitalData()
        {
            try
            {
                DInfo info = new DInfo();
                DataTable dt = info.GetData("", SystemInfo.userId);

                List<string> infoList = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MInfo model = new MInfo();
                    model.Title = dt.Rows[i][0].ToString();
                    model.Content = dt.Rows[i][1].ToString();
                    list.Add(model);
                }
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
            }
           
        }

        private void FrmInfoQuery_Activated(object sender, EventArgs e)
        {
            try
            {
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

        private void cbxKey_KeyDown(object sender, KeyEventArgs e)
        { 
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DInfo info = new DInfo();
                    DataTable dt = info.GetData(cbxKey.Text.Trim(), SystemInfo.userId);
                    dt = info.GetData(cbxKey.Text.Trim(), SystemInfo.userId);
                    StringBuilder contents = new StringBuilder("");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        contents.Append(dt.Rows[i][1].ToString() + "\n");
                    }

                    if (dt.Rows.Count > 0)
                    {
                        FrmInfoDetail detail = new FrmInfoDetail(contents.ToString());
                        this.Close();
                        detail.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
            }


        }

        private void cbxKey_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                if (cbxKey.Text.Length < 1) return;

                cbxKey.Items.Clear();
                listNew.Clear();

                foreach (var item in list)
                {
                    if (item.Title.Contains(this.cbxKey.Text))
                    {
                        listNew.Add(item.Title);
                    }
                }
                //combobox添加已经查到的关键词
                if (listNew.Count > 0)
                {
                    this.cbxKey.Items.AddRange(listNew.ToArray());
                    string text = this.cbxKey.Text;
                    //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
                    Cursor = Cursors.Default;

                    //自动弹出下拉框
                    this.cbxKey.DroppedDown = true;
                    this.cbxKey.Text = text;
                    //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
                    this.cbxKey.SelectionStart = this.cbxKey.Text.Length;
                }
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
            }

        }
    }
}
