namespace HpNotepad
{
    partial class FrmTxtAarry
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
            this.btnArray = new CCWin.SkinControl.SkinButton();
            this.txtPath = new CCWin.SkinControl.SkinTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rTxtContent = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.BackColor = System.Drawing.Color.Transparent;
            this.btnArray.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnArray.DownBack = null;
            this.btnArray.Location = new System.Drawing.Point(213, 23);
            this.btnArray.MouseBack = null;
            this.btnArray.Name = "btnArray";
            this.btnArray.NormlBack = null;
            this.btnArray.Size = new System.Drawing.Size(75, 23);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "生成";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.Transparent;
            this.txtPath.DownBack = null;
            this.txtPath.Icon = null;
            this.txtPath.IconIsButton = false;
            this.txtPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPath.IsPasswordChat = '\0';
            this.txtPath.IsSystemPasswordChar = false;
            this.txtPath.Lines = new string[0];
            this.txtPath.Location = new System.Drawing.Point(87, 20);
            this.txtPath.Margin = new System.Windows.Forms.Padding(0);
            this.txtPath.MaxLength = 32767;
            this.txtPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPath.MouseBack = null;
            this.txtPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPath.Multiline = false;
            this.txtPath.Name = "txtPath";
            this.txtPath.NormlBack = null;
            this.txtPath.Padding = new System.Windows.Forms.Padding(5);
            this.txtPath.ReadOnly = false;
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPath.Size = new System.Drawing.Size(100, 28);
            // 
            // 
            // 
            this.txtPath.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.txtPath.SkinTxt.Name = "BaseText";
            this.txtPath.SkinTxt.TabIndex = 0;
            this.txtPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPath.SkinTxt.WaterText = "";
            this.txtPath.TabIndex = 1;
            this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPath.WaterText = "";
            this.txtPath.WordWrap = true;
            this.txtPath.Click += new System.EventHandler(this.txtPath_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.btnArray);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 60);
            this.panel1.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClear.DownBack = null;
            this.btnClear.Location = new System.Drawing.Point(318, 23);
            this.btnClear.MouseBack = null;
            this.btnClear.Name = "btnClear";
            this.btnClear.NormlBack = null;
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件：";
            // 
            // rTxtContent
            // 
            this.rTxtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtContent.Location = new System.Drawing.Point(0, 60);
            this.rTxtContent.Name = "rTxtContent";
            this.rTxtContent.Size = new System.Drawing.Size(911, 429);
            this.rTxtContent.TabIndex = 3;
            this.rTxtContent.Text = "";
            // 
            // FrmTxtAarry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 489);
            this.Controls.Add(this.rTxtContent);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTxtAarry";
            this.Text = "FrmTxtDeal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinTextBox txtPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTxtContent;
        private CCWin.SkinControl.SkinButton btnArray;
        private CCWin.SkinControl.SkinButton btnClear;
    }
}