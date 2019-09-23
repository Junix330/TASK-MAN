namespace TASK_MAN
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(85, 114);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUser.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUser.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtUser.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtUser.Properties.AppearanceFocused.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtUser.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtUser.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtUser.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUser.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtUser.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtUser.Properties.AutoHeight = false;
            this.txtUser.Properties.NullText = "ID";
            this.txtUser.Properties.Tag = "";
            this.txtUser.Size = new System.Drawing.Size(333, 39);
            this.txtUser.TabIndex = 23;
            this.txtUser.Tag = "Type_Task";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(85, 159);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPass.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPass.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtPass.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtPass.Properties.AppearanceFocused.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtPass.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtPass.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtPass.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPass.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtPass.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtPass.Properties.AutoHeight = false;
            this.txtPass.Properties.NullText = "Password";
            this.txtPass.Properties.Tag = "";
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(333, 39);
            this.txtPass.TabIndex = 24;
            this.txtPass.Tag = "Level_Task";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowDisposeImage = true;
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ContextButtonOptions.ShowToolTips = false;
            this.pictureEdit1.Properties.ReadOnly = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Size = new System.Drawing.Size(506, 108);
            this.pictureEdit1.TabIndex = 28;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(85, 209);
            this.btnLogin.LookAndFeel.SkinMaskColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Orange;
            this.btnLogin.LookAndFeel.SkinName = "The Bezier";
            this.btnLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(333, 34);
            this.btnLogin.TabIndex = 29;
            this.btnLogin.Text = "LOGIN";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 261);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}