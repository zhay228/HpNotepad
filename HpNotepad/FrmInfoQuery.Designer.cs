﻿namespace HpNotepad
{
    partial class FrmInfoQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoQuery));
            this.cbxKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxKey
            // 
            this.cbxKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxKey.FormattingEnabled = true;
            this.cbxKey.Location = new System.Drawing.Point(87, 37);
            this.cbxKey.Name = "cbxKey";
            this.cbxKey.Size = new System.Drawing.Size(161, 20);
            this.cbxKey.TabIndex = 2;
            this.cbxKey.TextUpdate += new System.EventHandler(this.cbxKey_TextUpdate);
            this.cbxKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxKey_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "关键字：";
            // 
            // FrmInfoQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 90);
            this.CloseDownBack = global::HpNotepad.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::HpNotepad.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::HpNotepad.Properties.Resources.btn_close_normal;
            this.Controls.Add(this.cbxKey);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::HpNotepad.Properties.Resources.btn_max_down;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 90);
            this.MaxMouseBack = global::HpNotepad.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::HpNotepad.Properties.Resources.btn_max_normal;
            this.MiniDownBack = global::HpNotepad.Properties.Resources.btn_mini_down;
            this.MinimizeBox = false;
            this.MiniMouseBack = global::HpNotepad.Properties.Resources.btn_mini_highlight;
            this.MinimumSize = new System.Drawing.Size(280, 90);
            this.MiniNormlBack = global::HpNotepad.Properties.Resources.btn_mini_normal;
            this.Name = "FrmInfoQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "FrmInfoQuery";
            this.Text = "信息查询";
            this.Activated += new System.EventHandler(this.FrmInfoQuery_Activated);
            this.Load += new System.EventHandler(this.FrmInfoQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKey;
        private System.Windows.Forms.Label label1;
    }
}