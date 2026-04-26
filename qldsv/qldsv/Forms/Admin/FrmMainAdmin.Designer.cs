namespace qldsv.Forms
{
    partial class FrmMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainAdmin));
            this.pnuMenuAdmin = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnuMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnuMenuAdmin
            // 
            this.pnuMenuAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.pnuMenuAdmin.Controls.Add(this.picAvatar);
            this.pnuMenuAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnuMenuAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnuMenuAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnuMenuAdmin.Name = "pnuMenuAdmin";
            this.pnuMenuAdmin.Size = new System.Drawing.Size(330, 564);
            this.pnuMenuAdmin.TabIndex = 0;
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(4, 5);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(90, 92);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // FrmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 564);
            this.Controls.Add(this.pnuMenuAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainAdmin";
            this.Text = "Hệ thống quản lý điểm sinh viên - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnuMenuAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnuMenuAdmin;
        private System.Windows.Forms.PictureBox picAvatar;
    }
}