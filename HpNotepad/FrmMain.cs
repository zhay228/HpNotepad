using CCWin;
using DBFactory;
using HpDAL;
using HpModel;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace HpNotepad
{
    public partial class FrmMain : CCSkinMain
    {
        private XpCopy xc;
        #region --构造函数---       
        public FrmMain()
        {
            InitializeComponent();
            InitalData();
            ShortCut();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
            
        }

        private void FrmMain_MinimumSizeChanged(object sender, EventArgs e)
        {
            nfySystem.Visible = true;
            this.Hide();
        }
        private void FrmMain_Activated(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;//窗体其实位置类型，manual由location指定
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width; //屏幕宽
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height; //屏幕高
            Point point = new Point(screenWidth - this.Size.Width, screenHeight - this.Size.Height);            
            this.Location = point;
        }
        
        private void InitalData()
        {
            if (bool.Parse(INI.Read_INI("SystemInfo", "ISCopyConfig")))
            {
                bool startCopy = bool.Parse(INI.Read_INI("SystemInfo", "StartCopy"));
                if (startCopy)
                {
                    this.xc = new HpNotepad.XpCopy(false);
                    xc.tsItemStart_Click(null, null);
                }
                else
                {
                    //xc.tsItemClose_Click(null, null);
                }
            }
          
            LoadData("",1);

            //this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;
            //MessageBox.Show("InitalData");
            //this.Activate();
            //this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            nfySystem.Visible = true;
            if (xc != null)
                xc.Close();
            this.Hide();
        }
         
        public void LoadData(string title,int qType)
        {
            try
            {
                if (qType == 1)
                {
                    DType type = new DType();
                    DataTable dt = type.GetAllType();
                    DataRow row = dt.NewRow();
                    row["TypeId"] = -1;
                    row["Type"] = "全部";
                    dt.Rows.Add(row);
                    cbxType.DataSource = dt;

                    cbxType.ValueMember = "TypeId";
                    cbxType.DisplayMember = "Type";
                    cbxType.SelectedValue = -1;
                    cbxType.DropDownStyle = ComboBoxStyle.DropDown;
                }

                if (Directory.Exists(SystemInfo.documentPath))
                {
                    Directory.CreateDirectory(SystemInfo.documentPath);
                }

                DInfo info = new DInfo();
                BindingSource bs = new BindingSource();
                bs.DataSource = info.GetAll(title, int.Parse(cbxType.SelectedValue.ToString()));
                bindingNavigator1.BindingSource = bs;
                dgvData.DataSource = bs;

               
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
            }
        }

        #endregion

        #region 信息处理
        private void txtTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQuery_Click(null, null);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadData(txtTitle.Text.Trim(),2);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定删除选中行吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(dgvData.SelectedRows[0].Cells[0].Value.ToString());
                    if (new DInfo().Del(id))
                    {
                        MessageBox.Show("删除成功");
                        LoadData(txtTitle.Text.Trim(),2);
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
                catch (Exception ex)
                {
                    Log.WriteErrLog(ex);
                }

            }
        }

        private void dgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvData.Columns["Id"].Visible = false;
                dgvData.Columns["序号"].Width = 60;
                dgvData.Columns["序号"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvData.Columns["类型"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvData.Columns["类型"].Width = 100;
            }
            catch (Exception ex)
            {
                Log.WriteErrLog(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmInfoSave save = new FrmInfoSave(this);
            save.ShowDialog();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("未选中任何数据");
                return;
            }
            string id = dgvData.SelectedRows[0].Cells[0].Value.ToString();
            DInfo info = new DInfo();
            MInfo model = info.GetModel(int.Parse(id));

            FrmInfoSave save = new FrmInfoSave(this, model);
            save.ShowDialog();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string fileName = dialog.FileName;
                    DInfo info = new HpDAL.DInfo();
                    DataTable dt = info.GetAllData(fileName);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        MInfo model = new MInfo();
                        model.Title = dt.Rows[i]["Title"].ToString();
                        model.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                        model.Content = dt.Rows[i]["Content"].ToString();
                        if (dt.Columns.Contains("TypeId"))
                        {
                            if (Validator.IsNumberId(dt.Rows[i]["TypeId"].ToString()))
                                model.TypeId = int.Parse(dt.Rows[i]["TypeId"].ToString());
                        }
                        else
                            model.TypeId = 9;
                        if (!info.IsExistName(model.Title))
                        {
                            info.Add(model);
                        }
                    }
                    LoadData("",1);
                    MessageBox.Show("保存成功");
                }
                catch (Exception ex)
                {
                    Log.WriteErrLog(ex);
                }
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvData.Rows.Count)
            {
                string id = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                DInfo info = new DInfo();
                MInfo model = info.GetModel(int.Parse(id));
                FrmInfoDetail detail = new FrmInfoDetail(model);
                detail.ShowDialog();
            }
        }

        private void btnFileDeal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(SystemInfo.documentPath);
        }

        #endregion 

        #region  --桌面快捷键--
        public void ShortCut()
        {
            //HotKey.KeyModifiers.Alt也可以直接使用数字1
            //HotKey.KeyModifiers.Ctrl也可以直接使用数字2来表示
            //HotKey.KeyModifiers.Shift也可以直接使用数字4来表示
            //注册热键Ctrl+Alt+D，Id号为102
            //HotKey.RegisterHotKey(Handle, 102, HotKey.KeyModifiers.Alt | HotKey.KeyModifiers.Ctrl, Keys.D);
            //注册热键F5，Id号为103。  
            //HotKey.RegisterHotKey(Handle, 103, HotKey.KeyModifiers.None, Keys.F5);

            //注册热键Alt+F ，Id号为99
            HotKey.RegisterHotKey(Handle, 99, HotKey.KeyModifiers.Alt, Keys.F);
            //注册热键Ctrl+Shif+Q ，Id号为100
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Shift | HotKey.KeyModifiers.Ctrl, Keys.Q);
            //注册热键Alt+I，Id号为101
            HotKey.RegisterHotKey(Handle, 101, HotKey.KeyModifiers.Alt, Keys.I);
            //注册热键Ctrl+Shift+D，Id号为102
            HotKey.RegisterHotKey(Handle, 102, HotKey.KeyModifiers.Shift | HotKey.KeyModifiers.Ctrl, Keys.D);
            //注册热键Alt+N，Id号为103
            HotKey.RegisterHotKey(Handle, 103, HotKey.KeyModifiers.Alt, Keys.N);
            //注册热键Alt+H，Id号为104
            HotKey.RegisterHotKey(Handle, 104, HotKey.KeyModifiers.Alt, Keys.H);
            //注册热键Alt+E，Id号为105
            //HotKey.RegisterHotKey(Handle, 105, HotKey.KeyModifiers.None, Keys.Escape);
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
                            case 99:    //按下的是Alt+F ,文件保存
                                if (IsOpen("FrmFileSave")) break;
                                FrmFileSave ff = new FrmFileSave();
                                ff.TopMost = true;
                                ff.StartPosition = FormStartPosition.Manual;//窗体其实位置类型，manual由location指定
                                point = new Point(screenWidth - ff.Size.Width, screenHeight - ff.Size.Height);
                                ff.Location = point;
                                ff.TopLevel = true;
                                ff.ShowInTaskbar = false;
                                ff.ShowDialog();
                                break;
                            case 100:    //按下的是Ctrl+Shif+Q,文件查询     
                                if (IsOpen("FrmFileQuery")) break;
                                FrmFileQuery rp = new FrmFileQuery();
                                rp.StartPosition = FormStartPosition.Manual;//窗体其实位置类型，manual由location指定
                                rp.TopMost = true;
                                point = new Point(screenWidth - rp.Size.Width, screenHeight - rp.Size.Height);
                                rp.Location = point;
                                rp.ShowInTaskbar = false;
                                rp.Show();
                                break;
                            case 101:    //按下的是Alt+I 信息保存
                                if (IsOpen("FrmInfoSave")) break;
                                FrmInfoSave fi = new FrmInfoSave();
                                fi.TopMost = true;
                                fi.StartPosition = FormStartPosition.Manual;//窗体其实位置类型，manual由location指定
                                point = new Point(screenWidth - fi.Size.Width, screenHeight - fi.Size.Height);
                                fi.Location = point;
                                fi.ShowInTaskbar = false;
                                fi.Show();
                                break;
                            case 102: //按下的是Ctrl+Shift+D  信息查询
                                if (IsOpen("FrmInfoQuery")) break;
                                FrmInfoQuery fq = new FrmInfoQuery();
                                fq.TopMost = true;
                                fq.StartPosition = FormStartPosition.Manual;//窗体其实位置类型，manual由location指定
                                point = new Point(screenWidth - fq.Size.Width, screenHeight - fq.Size.Height);
                                fq.TopLevel = true;
                                fq.Location = point;
                                fq.ShowInTaskbar = false;
                                fq.Show();
                                break;
                            case 103: //按下 Alt+N  
                                if (ShowOpen("FrmInfoDetail")) break;
                                FrmInfoDetail fd = new FrmInfoDetail();
                                fd.StartPosition = FormStartPosition.Manual;//窗体其实位置类型，manual由location指定
                                fd.Height = 360;
                                fd.Width = 300;
                                point = new Point(screenWidth - fd.Size.Width + 12, screenHeight - fd.Size.Height + 15);
                                fd.Location = point;
                                fd.TopMost = true;
                                fd.ShowInTaskbar = false;
                                fd.Show();

                                break;
                            case 104: //按下 Alt+H  
                                if (this.Visible)
                                    this.Close();
                                else
                                    toolMenuSystemDisplay_Click(null, null);
                                break;
                            case 105: //按下 Esc  
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

        private bool IsOpen(string tag)
        {
            FormCollection m_formList = Application.OpenForms;
            foreach (Form f in m_formList)
            {
                if (f.Tag != null && f.Tag.ToString() == tag)
                {
                    f.Close();
                    return true;
                }
            }
            return false;
        }

        private bool ShowOpen(string tag)
        {
            FormCollection m_formList = Application.OpenForms;
            foreach (Form f in m_formList)
            {
                if (f.Tag != null && f.Tag.ToString() == tag)
                {
                    f.Show();
                    return true;
                }
            }
            return false;
        }

        #endregion

        private void xc_Click(object sender, EventArgs e)
        {
            if (xc == null) return;
            xc.tsItemClear_Click(null, null);
            xc.Close();
        }

        #region 系统托盘
        private void toolMenuClearCopy_Click(object sender, EventArgs e)
        {
            if (xc == null) return;
            xc.tsItemClear_Click(null, null);
        }

        private void toolMenuCreatePath_Click(object sender, EventArgs e)
        {
            FrmUpdate frm = new FrmUpdate();
            frm.Show();
        }

        private void toolMenuCopyFiles_Click(object sender, EventArgs e)
        {
            FrmSelectUpdate update = new FrmSelectUpdate();
            update.Show();
        }


        private void toolMenuStartCopy_Click(object sender, EventArgs e)
        {
           
            if (toolMenuStartCopy.Text.Contains("开启"))
            {
                toolMenuStartCopy.Text = "关闭多次粘贴";

                INI.Write_INI("SystemInfo", "StartCopy", "true");
                if (xc == null) xc = new XpCopy();
                xc.tsItemStart_Click(null, null);
            }
            else
            {
                toolMenuStartCopy.Text = "开启多次粘贴";
                INI.Write_INI("SystemInfo", "StartCopy", "false");
                xc.tsItemClose_Click(null, null);
            }
        }

        private void toolMenuCloseCopy_Click(object sender, EventArgs e)
        {
            if (xc == null) return;
            xc.tsItemClose_Click(null, null);
        }

        private void toolmenuSystemStart_Click(object sender, EventArgs e)
        {
            toolmenuSystemStart.Checked = !toolmenuSystemStart.Checked;
            INI.Write_INI("SystemInfo", "SystemStart", toolmenuSystemStart.Checked.ToString());
        }

        private void toolMenuSystemDisplay_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.TopLevel = true;
            this.Show();
            //nfySystem.Visible = false;
        }

        private void toolMenuSystemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void nfySystem_DoubleClick(object sender, EventArgs e)
        {
            toolMenuSystemDisplay_Click(null, null);
        }
        #endregion    
    }
}
