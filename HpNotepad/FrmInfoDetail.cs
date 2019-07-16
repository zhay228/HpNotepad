using CCWin;
using DBFactory;
using HpDAL;
using HpModel;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace HpNotepad
{
    public partial class FrmInfoDetail : CCSkinMain
    {
        MInfo model;
        public FrmInfoDetail()
        {
            InitializeComponent();
        }

        public FrmInfoDetail(string content)
        {
            InitializeComponent();
            txtContent.Text = content;
        }

        public FrmInfoDetail(MInfo _model)
        {
            model = _model;
            InitializeComponent();
            txtContent.Text = model.Content;
        }

        private void FrmInfoDetail_Load(object sender, EventArgs e)
        {
            ShortCut();
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
                                this.Hide();
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

        private void FrmInfoDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (model != null)
            //{
            //    model.Content = txtContent.Text.Trim();
            //    DInfo info = new DInfo();
            //    info.Update(model);
            //}
            //else
            //{
            //    e.Cancel = true;
            //    this.Hide();
            //}          
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (model != null)
            {
                model.Content = txtContent.Text.Trim();
                DInfo info = new DInfo();
                info.Update(model);
                base.OnClosing(e);
            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }
          
        }

        private void FrmInfoDetail_Activated(object sender, EventArgs e)
        {
            txtContent.ForeColor = Color.Black;
        }
    }
}
