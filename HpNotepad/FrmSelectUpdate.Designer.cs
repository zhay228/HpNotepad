using CCWin.SkinControl;

namespace HpNotepad
{
    partial class FrmSelectUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectUpdate));
            this.txtRootPath = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.txtNewPath = new CCWin.SkinControl.SkinTextBox();
            this.sBtnClose = new CCWin.SkinControl.SkinButton();
            this.sLabSelectPath = new CCWin.SkinControl.SkinLabel();
            this.slabSelectFiles = new CCWin.SkinControl.SkinLabel();
            this.sLabTip = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // txtRootPath
            // 
            this.txtRootPath.BackColor = System.Drawing.Color.Transparent;
            this.txtRootPath.DownBack = null;
            this.txtRootPath.Icon = null;
            this.txtRootPath.IconIsButton = false;
            this.txtRootPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtRootPath.IsPasswordChat = '\0';
            this.txtRootPath.IsSystemPasswordChar = false;
            this.txtRootPath.Lines = new string[0];
            this.txtRootPath.Location = new System.Drawing.Point(88, 56);
            this.txtRootPath.Margin = new System.Windows.Forms.Padding(0);
            this.txtRootPath.MaxLength = 32767;
            this.txtRootPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtRootPath.MouseBack = null;
            this.txtRootPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtRootPath.Multiline = false;
            this.txtRootPath.Name = "txtRootPath";
            this.txtRootPath.NormlBack = null;
            this.txtRootPath.Padding = new System.Windows.Forms.Padding(5);
            this.txtRootPath.ReadOnly = true;
            this.txtRootPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRootPath.Size = new System.Drawing.Size(181, 28);
            // 
            // 
            // 
            this.txtRootPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRootPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRootPath.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtRootPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtRootPath.SkinTxt.Name = "BaseText";
            this.txtRootPath.SkinTxt.ReadOnly = true;
            this.txtRootPath.SkinTxt.Size = new System.Drawing.Size(171, 18);
            this.txtRootPath.SkinTxt.TabIndex = 0;
            this.txtRootPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtRootPath.SkinTxt.WaterText = "";
            this.txtRootPath.TabIndex = 0;
            this.txtRootPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRootPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtRootPath.WaterText = "";
            this.txtRootPath.WordWrap = true;
            this.txtRootPath.Click += new System.EventHandler(this.txtRootPath_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(33, 56);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "根路径：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(21, 95);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(68, 17);
            this.skinLabel3.TabIndex = 4;
            this.skinLabel3.Text = "路径标识：";
            // 
            // txtNewPath
            // 
            this.txtNewPath.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPath.DownBack = null;
            this.txtNewPath.Icon = null;
            this.txtNewPath.IconIsButton = false;
            this.txtNewPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtNewPath.IsPasswordChat = '\0';
            this.txtNewPath.IsSystemPasswordChar = false;
            this.txtNewPath.Lines = new string[] {
        "WebRoot"};
            this.txtNewPath.Location = new System.Drawing.Point(88, 95);
            this.txtNewPath.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPath.MaxLength = 32767;
            this.txtNewPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtNewPath.MouseBack = null;
            this.txtNewPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtNewPath.Multiline = false;
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.NormlBack = null;
            this.txtNewPath.Padding = new System.Windows.Forms.Padding(5);
            this.txtNewPath.ReadOnly = false;
            this.txtNewPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPath.Size = new System.Drawing.Size(181, 28);
            // 
            // 
            // 
            this.txtNewPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPath.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtNewPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtNewPath.SkinTxt.Name = "BaseText";
            this.txtNewPath.SkinTxt.Size = new System.Drawing.Size(171, 18);
            this.txtNewPath.SkinTxt.TabIndex = 0;
            this.txtNewPath.SkinTxt.Text = "WebRoot";
            this.txtNewPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtNewPath.SkinTxt.WaterText = "";
            this.txtNewPath.TabIndex = 3;
            this.txtNewPath.Text = "WebRoot";
            this.txtNewPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtNewPath.WaterText = "";
            this.txtNewPath.WordWrap = true;
            // 
            // sBtnClose
            // 
            this.sBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.sBtnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sBtnClose.DownBack = null;
            this.sBtnClose.Location = new System.Drawing.Point(139, 164);
            this.sBtnClose.MouseBack = null;
            this.sBtnClose.Name = "sBtnClose";
            this.sBtnClose.NormlBack = null;
            this.sBtnClose.Size = new System.Drawing.Size(75, 23);
            this.sBtnClose.TabIndex = 5;
            this.sBtnClose.Text = "确定";
            this.sBtnClose.UseVisualStyleBackColor = false;
            this.sBtnClose.Click += new System.EventHandler(this.sBtnClose_Click);
            // 
            // sLabSelectPath
            // 
            this.sLabSelectPath.AutoSize = true;
            this.sLabSelectPath.BackColor = System.Drawing.Color.Transparent;
            this.sLabSelectPath.BorderColor = System.Drawing.Color.White;
            this.sLabSelectPath.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sLabSelectPath.Location = new System.Drawing.Point(278, 61);
            this.sLabSelectPath.Name = "sLabSelectPath";
            this.sLabSelectPath.Size = new System.Drawing.Size(37, 14);
            this.sLabSelectPath.TabIndex = 6;
            this.sLabSelectPath.Text = "选择";
            this.sLabSelectPath.Click += new System.EventHandler(this.sLabSelectPath_Click);
            // 
            // slabSelectFiles
            // 
            this.slabSelectFiles.AutoSize = true;
            this.slabSelectFiles.BackColor = System.Drawing.Color.Transparent;
            this.slabSelectFiles.BorderColor = System.Drawing.Color.White;
            this.slabSelectFiles.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slabSelectFiles.Location = new System.Drawing.Point(278, 103);
            this.slabSelectFiles.Name = "slabSelectFiles";
            this.slabSelectFiles.Size = new System.Drawing.Size(67, 14);
            this.slabSelectFiles.TabIndex = 7;
            this.slabSelectFiles.Text = "选择文件";
            this.slabSelectFiles.Click += new System.EventHandler(this.slabSelectFiles_Click);
            // 
            // sLabTip
            // 
            this.sLabTip.AutoSize = true;
            this.sLabTip.BackColor = System.Drawing.Color.Transparent;
            this.sLabTip.BorderColor = System.Drawing.Color.White;
            this.sLabTip.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sLabTip.ForeColor = System.Drawing.Color.FloralWhite;
            this.sLabTip.Location = new System.Drawing.Point(85, 138);
            this.sLabTip.Name = "sLabTip";
            this.sLabTip.Size = new System.Drawing.Size(67, 14);
            this.sLabTip.TabIndex = 8;
            this.sLabTip.Text = "拷贝成功";
            // 
            // FrmSelectUpdate
            // 
            this.ClientSize = new System.Drawing.Size(364, 216);
            this.CloseDownBack = global::HpNotepad.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::HpNotepad.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::HpNotepad.Properties.Resources.btn_close_normal;
            this.Controls.Add(this.sLabTip);
            this.Controls.Add(this.slabSelectFiles);
            this.Controls.Add(this.sLabSelectPath);
            this.Controls.Add(this.sBtnClose);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.txtNewPath);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.txtRootPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::HpNotepad.Properties.Resources.btn_max_down;
            this.MaximizeBox = false;
            this.MaxMouseBack = global::HpNotepad.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::HpNotepad.Properties.Resources.btn_max_normal;
            this.MaxSize = new System.Drawing.Size(0, 0);
            this.MiniDownBack = global::HpNotepad.Properties.Resources.btn_mini_down;
            this.MinimizeBox = false;
            this.MiniMouseBack = global::HpNotepad.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::HpNotepad.Properties.Resources.btn_mini_normal;
            this.Name = "FrmSelectUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "复制文件及路径";
            this.Load += new System.EventHandler(this.FrmSelectUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
         
        private CCWin.SkinControl.SkinTextBox txtRootPath;
        private SkinLabel skinLabel2;
        private SkinLabel skinLabel3;
        private SkinTextBox txtNewPath;
        private SkinButton sBtnClose;
        private SkinLabel sLabSelectPath;
        private SkinLabel slabSelectFiles;
        private SkinLabel sLabTip;
    }
}