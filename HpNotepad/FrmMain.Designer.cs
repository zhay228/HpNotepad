using CCWin.SkinControl;

namespace HpNotepad
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nfySystem = new System.Windows.Forms.NotifyIcon(this.components);
            this.cMenuSystem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuClearCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuCopyFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuCreatePath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuStartCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolmenuSystemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuSystemDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuSystemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new CCWin.SkinControl.SkinTextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuery = new CCWin.SkinControl.SkinButton();
            this.btnInput = new CCWin.SkinControl.SkinButton();
            this.btnEdit = new CCWin.SkinControl.SkinButton();
            this.btnFileDeal = new CCWin.SkinControl.SkinButton();
            this.btnAdd = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new CCWin.SkinControl.SkinButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.xc = new HpNotepad.XpCopy();
            this.cMenuSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.txtTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nfySystem
            // 
            this.nfySystem.ContextMenuStrip = this.cMenuSystem;
            this.nfySystem.Icon = ((System.Drawing.Icon)(resources.GetObject("nfySystem.Icon")));
            this.nfySystem.Text = "随手记";
            this.nfySystem.Visible = true;
            this.nfySystem.DoubleClick += new System.EventHandler(this.nfySystem_DoubleClick);
            // 
            // cMenuSystem
            // 
            this.cMenuSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuClearCopy,
            this.toolMenuCopyFiles,
            this.toolMenuCreatePath,
            this.toolMenuStartCopy,
            this.toolStripSeparator2,
            this.toolmenuSystemStart,
            this.toolStripSeparator1,
            this.toolMenuSystemDisplay,
            this.toolMenuSystemExit});
            this.cMenuSystem.Name = "cMenuSystem";
            this.cMenuSystem.Size = new System.Drawing.Size(149, 170);
            // 
            // toolMenuClearCopy
            // 
            this.toolMenuClearCopy.Name = "toolMenuClearCopy";
            this.toolMenuClearCopy.Size = new System.Drawing.Size(148, 22);
            this.toolMenuClearCopy.Text = "清理";
            this.toolMenuClearCopy.Click += new System.EventHandler(this.toolMenuClearCopy_Click);
            // 
            // toolMenuCopyFiles
            // 
            this.toolMenuCopyFiles.Name = "toolMenuCopyFiles";
            this.toolMenuCopyFiles.Size = new System.Drawing.Size(148, 22);
            this.toolMenuCopyFiles.Text = "拷贝文件";
            this.toolMenuCopyFiles.Click += new System.EventHandler(this.toolMenuCopyFiles_Click);
            // 
            // toolMenuCreatePath
            // 
            this.toolMenuCreatePath.Name = "toolMenuCreatePath";
            this.toolMenuCreatePath.Size = new System.Drawing.Size(148, 22);
            this.toolMenuCreatePath.Text = "创建更新路径";
            this.toolMenuCreatePath.Click += new System.EventHandler(this.toolMenuCreatePath_Click);
            // 
            // toolMenuStartCopy
            // 
            this.toolMenuStartCopy.Name = "toolMenuStartCopy";
            this.toolMenuStartCopy.Size = new System.Drawing.Size(148, 22);
            this.toolMenuStartCopy.Text = "开启多次粘贴";
            this.toolMenuStartCopy.Click += new System.EventHandler(this.toolMenuStartCopy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // toolmenuSystemStart
            // 
            this.toolmenuSystemStart.Checked = true;
            this.toolmenuSystemStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolmenuSystemStart.Name = "toolmenuSystemStart";
            this.toolmenuSystemStart.Size = new System.Drawing.Size(148, 22);
            this.toolmenuSystemStart.Text = "开机启动";
            this.toolmenuSystemStart.Click += new System.EventHandler(this.toolmenuSystemStart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolMenuSystemDisplay
            // 
            this.toolMenuSystemDisplay.Name = "toolMenuSystemDisplay";
            this.toolMenuSystemDisplay.Size = new System.Drawing.Size(148, 22);
            this.toolMenuSystemDisplay.Text = "显示";
            this.toolMenuSystemDisplay.Click += new System.EventHandler(this.toolMenuSystemDisplay_Click);
            // 
            // toolMenuSystemExit
            // 
            this.toolMenuSystemExit.Name = "toolMenuSystemExit";
            this.toolMenuSystemExit.Size = new System.Drawing.Size(148, 22);
            this.toolMenuSystemExit.Text = "退出";
            this.toolMenuSystemExit.Click += new System.EventHandler(this.toolMenuSystemExit_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeight = 24;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvData.Location = new System.Drawing.Point(4, 70);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(900, 385);
            this.dgvData.TabIndex = 3;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            this.dgvData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvData_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.btnInput);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnFileDeal);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 42);
            this.panel1.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.Controls.Add(this.xc);
            this.txtTitle.DownBack = null;
            this.txtTitle.Icon = null;
            this.txtTitle.IconIsButton = false;
            this.txtTitle.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTitle.IsPasswordChat = '\0';
            this.txtTitle.IsSystemPasswordChar = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(228, 4);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(0);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtTitle.MouseBack = null;
            this.txtTitle.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTitle.Multiline = false;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.NormlBack = null;
            this.txtTitle.Padding = new System.Windows.Forms.Padding(5);
            this.txtTitle.ReadOnly = false;
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.Size = new System.Drawing.Size(152, 28);
            // 
            // 
            // 
            this.txtTitle.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtTitle.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtTitle.SkinTxt.Name = "BaseText";
            this.txtTitle.SkinTxt.Size = new System.Drawing.Size(142, 18);
            this.txtTitle.SkinTxt.TabIndex = 0;
            this.txtTitle.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTitle.SkinTxt.WaterText = "";
            this.txtTitle.TabIndex = 13;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitle.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTitle.WaterText = "";
            this.txtTitle.WordWrap = true;
            // 
            // cbxType
            // 
            this.cbxType.ForeColor = System.Drawing.Color.Black;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(51, 8);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(127, 20);
            this.cbxType.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "类型：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnQuery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnQuery.DownBack = null;
            this.btnQuery.Location = new System.Drawing.Point(396, 7);
            this.btnQuery.MouseBack = null;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.NormlBack = null;
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnInput.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnInput.DownBack = null;
            this.btnInput.Location = new System.Drawing.Point(814, 7);
            this.btnInput.MouseBack = null;
            this.btnInput.Name = "btnInput";
            this.btnInput.NormlBack = null;
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 10;
            this.btnInput.Text = "导入";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEdit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnEdit.DownBack = null;
            this.btnEdit.Location = new System.Drawing.Point(562, 7);
            this.btnEdit.MouseBack = null;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NormlBack = null;
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnFileDeal
            // 
            this.btnFileDeal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFileDeal.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFileDeal.DownBack = null;
            this.btnFileDeal.Location = new System.Drawing.Point(732, 7);
            this.btnFileDeal.MouseBack = null;
            this.btnFileDeal.Name = "btnFileDeal";
            this.btnFileDeal.NormlBack = null;
            this.btnFileDeal.Size = new System.Drawing.Size(75, 23);
            this.btnFileDeal.TabIndex = 7;
            this.btnFileDeal.Text = "文件清理";
            this.btnFileDeal.UseVisualStyleBackColor = false;
            this.btnFileDeal.Click += new System.EventHandler(this.btnFileDeal_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdd.DownBack = null;
            this.btnAdd.Location = new System.Drawing.Point(477, 7);
            this.btnAdd.MouseBack = null;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormlBack = null;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "标题：";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDelete.DownBack = null;
            this.btnDelete.Location = new System.Drawing.Point(647, 7);
            this.btnDelete.MouseBack = null;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormlBack = null;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(4, 455);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(900, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // xc
            // 
            this.xc.Location = new System.Drawing.Point(154, 1);
            this.xc.Name = "xc";
            this.xc.Size = new System.Drawing.Size(10, 27);
            this.xc.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 484);
            this.CloseDownBack = global::HpNotepad.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::HpNotepad.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::HpNotepad.Properties.Resources.btn_close_normal;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::HpNotepad.Properties.Resources.btn_max_down;
            this.MaxMouseBack = global::HpNotepad.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::HpNotepad.Properties.Resources.btn_max_normal;
            this.MiniDownBack = global::HpNotepad.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::HpNotepad.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::HpNotepad.Properties.Resources.btn_mini_normal;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "随手记";
            this.MinimumSizeChanged += new System.EventHandler(this.FrmMain_MinimumSizeChanged);
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.cMenuSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.txtTitle.ResumeLayout(false);
            this.txtTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nfySystem;
        private System.Windows.Forms.ContextMenuStrip cMenuSystem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuSystemDisplay;
        private System.Windows.Forms.ToolStripMenuItem toolMenuSystemExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolmenuSystemStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolMenuStartCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolMenuClearCopy;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.DataGridView dgvData;
        private CCWin.SkinControl.SkinButton btnDelete;
        private CCWin.SkinControl.SkinButton btnQuery;
        private CCWin.SkinControl.SkinButton btnAdd;
        private CCWin.SkinControl.SkinButton btnFileDeal;
        private CCWin.SkinControl.SkinButton btnEdit;
        private CCWin.SkinControl.SkinButton btnInput;
        private SkinTextBox txtTitle;
       
        private System.Windows.Forms.ToolStripMenuItem toolMenuCreatePath;
        private System.Windows.Forms.ToolStripMenuItem toolMenuCopyFiles;
    }
}

