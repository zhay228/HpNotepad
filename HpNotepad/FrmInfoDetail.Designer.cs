namespace HpNotepad
{
    partial class FrmInfoDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoDetail));
            this.txtContent = new CCWin.SkinControl.RtfRichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(203)))));
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.Margin = new System.Windows.Forms.Padding(0);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(651, 393);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            this.txtContent.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 393);
            this.panel1.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FrmInfoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(659, 425);
            this.CloseDownBack = global::HpNotepad.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::HpNotepad.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::HpNotepad.Properties.Resources.btn_close_normal;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::HpNotepad.Properties.Resources.btn_max_down;
            this.MaxMouseBack = global::HpNotepad.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::HpNotepad.Properties.Resources.btn_max_normal;
            this.MiniDownBack = global::HpNotepad.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::HpNotepad.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::HpNotepad.Properties.Resources.btn_mini_normal;
            this.Name = "FrmInfoDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "FrmInfoDetail";
            this.Text = "信息";
            this.Activated += new System.EventHandler(this.FrmInfoDetail_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInfoDetail_FormClosing);
            this.Load += new System.EventHandler(this.FrmInfoDetail_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.RtfRichTextBox txtContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}