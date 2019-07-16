using CCWin;
using HpDAL;
using HpModel;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HpNotepad
{
    public partial class FrmInfoSave : CCSkinMain
    {
        FrmMain fMain = null;
        MInfo model = new MInfo();
        public FrmInfoSave()
        {
            InitializeComponent();
            InitalData();
        }

        public FrmInfoSave(FrmMain _m)
        {
            InitializeComponent();
            fMain = _m;
            ShortCut();
            InitalData();
        }

        public FrmInfoSave(FrmMain _m, MInfo _model)
        {
            InitializeComponent();
            fMain = _m;
            ShortCut();
            InitalData();
            txtTitle.Text = _model.Title;
            txtContent.Text = _model.Content;
            model = _model;
            InitalData();
        }

        private void InitalData()
        {
            DType type = new DType();
            DataTable dt = type.GetAllType();
            cbxType.DataSource = dt; 
            cbxType.ValueMember = "TypeId";
            cbxType.DisplayMember = "Type";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim().Length < 2)
            {
                MessageBox.Show("标题长度不能小于2");
                return;
            }
            if (txtContent.Text.Trim().Length < 6)
            {
                MessageBox.Show("内容不能为空");
                return;
            }
            DInfo info = new DInfo();
            if (info.IsExistName(txtTitle.Text.Trim()) && model.Id < 1)
            {
                MessageBox.Show("名称已经存在");
                return;

            }
            model.IsAlt = true;
            model.IsCtrl = true;
            model.IsShift = false;
            model.Key = "I";
            model.Title = txtTitle.Text.Trim();
            model.Content = txtContent.Text.Trim();
            model.UserId = SystemInfo.userId;
            if (cbxType.SelectedValue != null)
                model.TypeId = (int)cbxType.SelectedValue;
            else
            {
                MType mType = new MType();
                mType.Name = cbxType.Text.ToString();

                DType dType = new DType();

                int id = dType.Add(mType);
                if (id > 0)  model.TypeId = id;
                else model.TypeId = 9;
            }

            if (model.Id < 1)
            {
                if (info.Add(model))
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                if (info.Update(model))
                {
                    MessageBox.Show("更新成功");

                }
                else
                {
                    MessageBox.Show("更新失败");
                }
            }

            if (fMain != null)
            {
                fMain.LoadData("",1);
            }
            else
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmInfoSave_SizeChanged(object sender, EventArgs e)
        {
            txtTitle.Width = txtContent.Width - 84;
            btnSave.Location = new Point(txtContent.Width / 3, btnSave.Location.Y);
            btnClose.Location = new Point(txtContent.Width / 3 * 2, btnSave.Location.Y);
        }
    }
}
