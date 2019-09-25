namespace TASK_MAN
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.gcTask = new DevExpress.XtraGrid.GridControl();
            this.gvTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnAdd = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnRemove = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.tmRefresh = new System.Windows.Forms.Timer(this.components);
            this.nyMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.imMain = new System.Windows.Forms.ImageList(this.components);
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.gcTask);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(202, 37);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1003, 577);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // gcTask
            // 
            this.gcTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTask.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcTask.Location = new System.Drawing.Point(0, 0);
            this.gcTask.MainView = this.gvTask;
            this.gcTask.Name = "gcTask";
            this.gcTask.Size = new System.Drawing.Size(1003, 577);
            this.gcTask.TabIndex = 0;
            this.gcTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTask});
            // 
            // gvTask
            // 
            this.gvTask.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTask.Appearance.GroupRow.Options.UseFont = true;
            this.gvTask.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTask.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTask.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTask.Appearance.Row.Options.UseFont = true;
            this.gvTask.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn8});
            this.gvTask.GridControl = this.gcTask;
            this.gvTask.Name = "gvTask";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "PRJ";
            this.gridColumn1.FieldName = "Prj_Task";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TYPE";
            this.gridColumn2.FieldName = "Type_Task";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "PRIORITY";
            this.gridColumn3.FieldName = "Level_Task";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "DESCRIPTION";
            this.gridColumn4.FieldName = "Desc_Task";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "TASK INCHARGE";
            this.gridColumn5.FieldName = "Incharge_Task";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "PREPARED BY";
            this.gridColumn6.FieldName = "Prepared_Task";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "STATUS";
            this.gridColumn7.FieldName = "Status_Task";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "TIME STAMP";
            this.gridColumn9.DisplayFormat.FormatString = "MM-dd-yyyy HH:mm";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn9.FieldName = "Added_Task";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            this.gridColumn9.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "ID_Task";
            this.gridColumn8.FieldName = "ID_Task";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Width = 94;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnAdd,
            this.btnRemove,
            this.accordionControlSeparator1});
            this.accordionControl1.ExpandGroupOnHeaderClick = false;
            this.accordionControl1.ExpandItemOnHeaderClick = false;
            this.accordionControl1.Location = new System.Drawing.Point(0, 37);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.Size = new System.Drawing.Size(202, 577);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAdd.Text = "ADD TASK";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRemove.Text = "REMOVE TASK";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnLogin});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1205, 37);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.btnLogin, false, "", "", false, false);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnLogin
            // 
            this.btnLogin.AllowDrawArrow = false;
            this.btnLogin.AllowDrawArrowInMenu = false;
            this.btnLogin.AllowRightClickInMenu = false;
            this.btnLogin.Caption = "GUEST";
            this.btnLogin.CloseSubMenuOnClick = false;
            this.btnLogin.Id = 0;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLogin_ItemClick);
            // 
            // tmRefresh
            // 
            this.tmRefresh.Interval = 180000;
            this.tmRefresh.Tick += new System.EventHandler(this.TmRefresh_Tick);
            // 
            // nyMain
            // 
            this.nyMain.Icon = ((System.Drawing.Icon)(resources.GetObject("nyMain.Icon")));
            this.nyMain.Text = "XEL TASK MAN";
            this.nyMain.Visible = true;
            // 
            // imMain
            // 
            this.imMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imMain.ImageStream")));
            this.imMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imMain.Images.SetKeyName(0, "1.ico");
            this.imMain.Images.SetKeyName(1, "2.ico");
            this.imMain.Images.SetKeyName(2, "3.ico");
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "1.ico");
            this.imageCollection1.Images.SetKeyName(1, "2.ico");
            this.imageCollection1.Images.SetKeyName(2, "3.ico");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 614);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.EnableAcrylicAccent = false;
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Main";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEL TASK MAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAdd;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnRemove;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraGrid.GridControl gcTask;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTask;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private System.Windows.Forms.Timer tmRefresh;
        private System.Windows.Forms.NotifyIcon nyMain;
        private System.Windows.Forms.ImageList imMain;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}

