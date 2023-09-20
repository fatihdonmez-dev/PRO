namespace PRO.Master
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.leSirket = new DevExpress.XtraEditors.LookUpEdit();
            this.E_Localizer = new PRO.Control.Localizer();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSirket.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.EnterMoveNextControl = true;
            this.txtUser.Location = new System.Drawing.Point(208, 87);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseBackColor = true;
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtUser.Size = new System.Drawing.Size(187, 22);
            toolTipTitleItem1.Text = "Kullanıcı Adı";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.txtUser.SuperTip = superToolTip1;
            this.txtUser.TabIndex = 0;
            this.txtUser.Validated += new System.EventHandler(this._userKod_Validated);
            // 
            // txtPass
            // 
            this.txtPass.EnterMoveNextControl = true;
            this.txtPass.Location = new System.Drawing.Point(208, 117);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseBackColor = true;
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(187, 22);
            toolTipTitleItem2.Text = "Şifre";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.txtPass.SuperTip = superToolTip2;
            this.txtPass.TabIndex = 1;
            // 
            // leSirket
            // 
            this.leSirket.Location = new System.Drawing.Point(208, 157);
            this.leSirket.Name = "leSirket";
            this.leSirket.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.leSirket.Properties.Appearance.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leSirket.Properties.Appearance.Options.UseBackColor = true;
            this.leSirket.Properties.Appearance.Options.UseFont = true;
            this.leSirket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.leSirket.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSirket.Properties.NullText = "";
            this.leSirket.Size = new System.Drawing.Size(187, 24);
            toolTipTitleItem3.Text = "Firma Seçimi";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.leSirket.SuperTip = superToolTip3;
            this.leSirket.TabIndex = 2;
            this.leSirket.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblUserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblUserName.LineColor = System.Drawing.Color.Transparent;
            this.lblUserName.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.lblUserName.Location = new System.Drawing.Point(350, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblUserName.Size = new System.Drawing.Size(5, 13);
            this.lblUserName.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.btnOk.Appearance.Options.UseForeColor = true;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(245, 203);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(61, 55);
            this.btnOk.TabIndex = 9;
            this.btnOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(312, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 54);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(13, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 18);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Kullanıcı Girişi";
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 294);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.leSirket);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.E_Localizer.SetDilKey(this, "_KullaniciGiris");
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSirket.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.Localizer E_Localizer;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LookUpEdit leSirket;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}