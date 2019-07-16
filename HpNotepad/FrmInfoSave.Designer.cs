namespace HpNotepad
{
    partial class FrmInfoSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoSave));
            this.btnClose = new CCWin.SkinControl.SkinButton();
            this.btnSave = new CCWin.SkinControl.SkinButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtContent = new CCWin.SkinControl.SkinTextBox();
            this.txtTitle = new CCWin.SkinControl.SkinTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClose.DownBack = null;
            this.btnClose.Location = new System.Drawing.Point(252, 20);
            this.btnClose.MouseBack = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormlBack = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSave.DownBack = null;
            this.btnSave.Location = new System.Drawing.Point(46, 20);
            this.btnSave.MouseBack = null;
            this.btnSave.Name = "btnSave";
            this.btnSave.NormlBack = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 75);
            this.panel1.TabIndex = 9;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(81, 44);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(192, 20);
            this.cbxType.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 75);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "类别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "标题：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 55);
            this.panel2.TabIndex = 10;
            // 
            // txtContent
            // 
            this.txtContent.AllowDrop = true;
            this.txtContent.BackColor = System.Drawing.Color.Transparent;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.DownBack = null;
            this.txtContent.Icon = null;
            this.txtContent.IconIsButton = false;
            this.txtContent.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtContent.IsPasswordChat = '\0';
            this.txtContent.IsSystemPasswordChar = false;
            this.txtContent.Lines = new string[0];
            this.txtContent.Location = new System.Drawing.Point(4, 103);
            this.txtContent.Margin = new System.Windows.Forms.Padding(0);
            this.txtContent.MaxLength = 32767;
            this.txtContent.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtContent.MouseBack = null;
            this.txtContent.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.NormlBack = null;
            this.txtContent.Padding = new System.Windows.Forms.Padding(5);
            this.txtContent.ReadOnly = false;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(514, 211);
            // 
            // 
            // 
            this.txtContent.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.txtContent.SkinTxt.Multiline = true;
            this.txtContent.SkinTxt.Name = "BaseText";
            this.txtContent.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.txtContent.SkinTxt.TabIndex = 0;
            this.txtContent.SkinTxt.WaterColor = System.Drawing.Color.DarkGray;
            this.txtContent.SkinTxt.WaterText = "";
            this.txtContent.TabIndex = 11;
            this.txtContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContent.WaterColor = System.Drawing.Color.DarkGray;
            this.txtContent.WaterText = "";
            this.txtContent.WordWrap = true;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.DownBack = null;
            this.txtTitle.Icon = null;
            this.txtTitle.IconIsButton = false;
            this.txtTitle.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTitle.IsPasswordChat = '\0';
            this.txtTitle.IsSystemPasswordChar = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(81, 11);
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
            this.txtTitle.Size = new System.Drawing.Size(314, 28);
            // 
            // 
            // 
            this.txtTitle.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtTitle.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtTitle.SkinTxt.Name = "BaseText";
            this.txtTitle.SkinTxt.Size = new System.Drawing.Size(304, 18);
            this.txtTitle.SkinTxt.TabIndex = 0;
            this.txtTitle.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTitle.SkinTxt.WaterText = "";
            this.txtTitle.TabIndex = 7;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitle.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTitle.WaterText = "";
            this.txtTitle.WordWrap = true;
            // 
            // FrmInfoSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(522, 373);
            this.CloseDownBack = global::HpNotepad.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::HpNotepad.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::HpNotepad.Properties.Resources.btn_close_normal;
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::HpNotepad.Properties.Resources.btn_max_down;
            this.MaxMouseBack = global::HpNotepad.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::HpNotepad.Properties.Resources.btn_max_normal;
            this.MiniDownBack = global::HpNotepad.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::HpNotepad.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::HpNotepad.Properties.Resources.btn_mini_normal;
            this.Name = "FrmInfoSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "FrmInfoSave";
            this.Text = "信息保存";
            this.SizeChanged += new System.EventHandler(this.FrmInfoSave_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private CCWin.SkinControl.SkinTextBox txtContent;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label1; 
        private CCWin.SkinControl.SkinButton btnClose;
        private CCWin.SkinControl.SkinButton btnSave;
        private CCWin.SkinControl.SkinTextBox txtTitle;
    }
}