namespace iScada
{
    partial class frmTry
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Project");
            this.cmsProj = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCreateProj = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpTree = new System.Windows.Forms.GroupBox();
            this.trvMain = new System.Windows.Forms.TreeView();
            this.tabs = new DevExpress.XtraTab.XtraTabControl();
            this.tabProj = new DevExpress.XtraTab.XtraTabPage();
            this.btnP_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP_ProjName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtP_ProjID = new System.Windows.Forms.TextBox();
            this.tabConn = new DevExpress.XtraTab.XtraTabPage();
            this.grpC_S7 = new System.Windows.Forms.GroupBox();
            this.txtC_CPUType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label26 = new System.Windows.Forms.Label();
            this.txtC_ConnType = new DevExpress.XtraEditors.LookUpEdit();
            this.label21 = new System.Windows.Forms.Label();
            this.btnC_Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC_ConnName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC_ConnID = new System.Windows.Forms.TextBox();
            this.txtC_ProjName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC_ProjID = new System.Windows.Forms.TextBox();
            this.tabDev = new DevExpress.XtraTab.XtraTabPage();
            this.tabs_Dev = new DevExpress.XtraTab.XtraTabControl();
            this.tagD_ModbusTCP = new DevExpress.XtraTab.XtraTabPage();
            this.txtD_MB_SlaveAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtD_MB_Port = new DevExpress.XtraEditors.TextEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtD_MB_IP = new System.Windows.Forms.TextBox();
            this.tagD_ModbusSr = new DevExpress.XtraTab.XtraTabPage();
            this.chkD_RTSEnable = new System.Windows.Forms.CheckBox();
            this.txtD_SL_PortName = new System.Windows.Forms.TextBox();
            this.txtD_SL_HandShake = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label34 = new System.Windows.Forms.Label();
            this.txtD_SL_StopBits = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label33 = new System.Windows.Forms.Label();
            this.txtD_SL_Parity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label32 = new System.Windows.Forms.Label();
            this.txtD_SL_DataBits = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label31 = new System.Windows.Forms.Label();
            this.txtD_SL_BaudRate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tagD_SiemensS7TCP = new DevExpress.XtraTab.XtraTabPage();
            this.txtD_S7_Port = new DevExpress.XtraEditors.TextEdit();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtD_S7_IP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtD_Delay = new DevExpress.XtraEditors.TextEdit();
            this.txtD_Timeout = new DevExpress.XtraEditors.TextEdit();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnD_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtD_DeviceName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtD_DeviceID = new System.Windows.Forms.TextBox();
            this.txtD_ConnName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtD_ConnID = new System.Windows.Forms.TextBox();
            this.txtD_ProjName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtD_ProjID = new System.Windows.Forms.TextBox();
            this.tabTag = new DevExpress.XtraTab.XtraTabPage();
            this.tabs_Tag = new DevExpress.XtraTab.XtraTabControl();
            this.tagT_ModbusTCP = new DevExpress.XtraTab.XtraTabPage();
            this.txtT_MBTRegCount = new DevExpress.XtraEditors.TextEdit();
            this.txtT_MBTRegAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtT_MBTRegTypeID = new DevExpress.XtraEditors.LookUpEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tagT_ModbusSr = new DevExpress.XtraTab.XtraTabPage();
            this.txtT_MBSRegCount = new DevExpress.XtraEditors.TextEdit();
            this.txtT_MBSRegAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtT_MBSRegTypeID = new DevExpress.XtraEditors.LookUpEdit();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tagT_SiemensS7TCP = new DevExpress.XtraTab.XtraTabPage();
            this.txtT_S7RegDataType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label42 = new System.Windows.Forms.Label();
            this.txtT_S7DataBlock = new DevExpress.XtraEditors.TextEdit();
            this.label41 = new System.Windows.Forms.Label();
            this.txtT_S7RegCount = new DevExpress.XtraEditors.TextEdit();
            this.txtT_S7RegAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtT_S7RegTypeID = new DevExpress.XtraEditors.LookUpEdit();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.txtT_IsLogged = new System.Windows.Forms.CheckBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtT_MaxVal = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.txtT_MinVal = new DevExpress.XtraEditors.TextEdit();
            this.label25 = new System.Windows.Forms.Label();
            this.txtT_Datatype = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtT_UOM = new System.Windows.Forms.TextBox();
            this.btnT_Save = new System.Windows.Forms.Button();
            this.txtT_TagName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtT_TagID = new System.Windows.Forms.TextBox();
            this.txtT_DeviceName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtT_DeviceID = new System.Windows.Forms.TextBox();
            this.txtT_ConnName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtT_ConnID = new System.Windows.Forms.TextBox();
            this.txtT_ProjName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtT_ProjID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnServStop = new System.Windows.Forms.Button();
            this.btnServStart = new System.Windows.Forms.Button();
            this.btnServRestart = new System.Windows.Forms.Button();
            this.cmsConn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCreateConn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCreateDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTags = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCreateTag = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsProj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabs)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabProj.SuspendLayout();
            this.tabConn.SuspendLayout();
            this.grpC_S7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtC_CPUType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC_ConnType.Properties)).BeginInit();
            this.tabDev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabs_Dev)).BeginInit();
            this.tabs_Dev.SuspendLayout();
            this.tagD_ModbusTCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_MB_SlaveAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_MB_Port.Properties)).BeginInit();
            this.tagD_ModbusSr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_SL_HandShake.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_SL_StopBits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_SL_Parity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_SL_DataBits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_SL_BaudRate.Properties)).BeginInit();
            this.tagD_SiemensS7TCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_S7_Port.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_Delay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_Timeout.Properties)).BeginInit();
            this.tabTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabs_Tag)).BeginInit();
            this.tabs_Tag.SuspendLayout();
            this.tagT_ModbusTCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBTRegCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBTRegAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBTRegTypeID.Properties)).BeginInit();
            this.tagT_ModbusSr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBSRegCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBSRegAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBSRegTypeID.Properties)).BeginInit();
            this.tagT_SiemensS7TCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_S7RegDataType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_S7DataBlock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_S7RegCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_S7RegAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_S7RegTypeID.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MaxVal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MinVal.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.cmsConn.SuspendLayout();
            this.cmsDevice.SuspendLayout();
            this.cmsTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsProj
            // 
            this.cmsProj.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsProj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateProj});
            this.cmsProj.Name = "cmsProj";
            this.cmsProj.Size = new System.Drawing.Size(149, 26);
            // 
            // mnuCreateProj
            // 
            this.mnuCreateProj.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCreateProj.Name = "mnuCreateProj";
            this.mnuCreateProj.Size = new System.Drawing.Size(148, 22);
            this.mnuCreateProj.Text = "Create Project";
            this.mnuCreateProj.Click += new System.EventHandler(this.mnuCreateProj_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabs);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(869, 504);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpTree
            // 
            this.grpTree.Controls.Add(this.trvMain);
            this.grpTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTree.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTree.Location = new System.Drawing.Point(0, 0);
            this.grpTree.Name = "grpTree";
            this.grpTree.Size = new System.Drawing.Size(251, 504);
            this.grpTree.TabIndex = 0;
            this.grpTree.TabStop = false;
            this.grpTree.Text = "Project Structure";
            // 
            // trvMain
            // 
            this.trvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMain.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvMain.Location = new System.Drawing.Point(3, 18);
            this.trvMain.Name = "trvMain";
            treeNode1.ContextMenuStrip = this.cmsProj;
            treeNode1.Name = "Project";
            treeNode1.Text = "Project";
            this.trvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.trvMain.Size = new System.Drawing.Size(245, 483);
            this.trvMain.TabIndex = 0;
            this.trvMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMain_AfterSelect);
            this.trvMain.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvMain_NodeMouseDoubleClick);
            // 
            // tabs
            // 
            this.tabs.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(0, 41);
            this.tabs.Name = "tabs";
            this.tabs.SelectedTabPage = this.tabProj;
            this.tabs.Size = new System.Drawing.Size(614, 463);
            this.tabs.TabIndex = 1;
            this.tabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabProj,
            this.tabConn,
            this.tabDev,
            this.tabTag});
            this.tabs.CloseButtonClick += new System.EventHandler(this.tabs_CloseButtonClick);
            // 
            // tabProj
            // 
            this.tabProj.Controls.Add(this.btnP_Save);
            this.tabProj.Controls.Add(this.label2);
            this.tabProj.Controls.Add(this.txtP_ProjName);
            this.tabProj.Controls.Add(this.label1);
            this.tabProj.Controls.Add(this.txtP_ProjID);
            this.tabProj.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProj.Name = "tabProj";
            this.tabProj.Size = new System.Drawing.Size(608, 435);
            this.tabProj.Text = "Project";
            // 
            // btnP_Save
            // 
            this.btnP_Save.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP_Save.Location = new System.Drawing.Point(515, 10);
            this.btnP_Save.Name = "btnP_Save";
            this.btnP_Save.Size = new System.Drawing.Size(75, 23);
            this.btnP_Save.TabIndex = 4;
            this.btnP_Save.Text = "Save";
            this.btnP_Save.UseVisualStyleBackColor = true;
            this.btnP_Save.Click += new System.EventHandler(this.btnP_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name:";
            // 
            // txtP_ProjName
            // 
            this.txtP_ProjName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP_ProjName.Location = new System.Drawing.Point(111, 39);
            this.txtP_ProjName.Name = "txtP_ProjName";
            this.txtP_ProjName.Size = new System.Drawing.Size(283, 22);
            this.txtP_ProjName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project ID:";
            // 
            // txtP_ProjID
            // 
            this.txtP_ProjID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP_ProjID.Location = new System.Drawing.Point(111, 13);
            this.txtP_ProjID.Name = "txtP_ProjID";
            this.txtP_ProjID.ReadOnly = true;
            this.txtP_ProjID.Size = new System.Drawing.Size(100, 22);
            this.txtP_ProjID.TabIndex = 0;
            // 
            // tabConn
            // 
            this.tabConn.Controls.Add(this.grpC_S7);
            this.tabConn.Controls.Add(this.txtC_ConnType);
            this.tabConn.Controls.Add(this.label21);
            this.tabConn.Controls.Add(this.btnC_Save);
            this.tabConn.Controls.Add(this.label4);
            this.tabConn.Controls.Add(this.txtC_ConnName);
            this.tabConn.Controls.Add(this.label5);
            this.tabConn.Controls.Add(this.txtC_ConnID);
            this.tabConn.Controls.Add(this.txtC_ProjName);
            this.tabConn.Controls.Add(this.label3);
            this.tabConn.Controls.Add(this.txtC_ProjID);
            this.tabConn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConn.Name = "tabConn";
            this.tabConn.Size = new System.Drawing.Size(608, 435);
            this.tabConn.Text = "Connection";
            // 
            // grpC_S7
            // 
            this.grpC_S7.Controls.Add(this.txtC_CPUType);
            this.grpC_S7.Controls.Add(this.label26);
            this.grpC_S7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpC_S7.Location = new System.Drawing.Point(13, 156);
            this.grpC_S7.Name = "grpC_S7";
            this.grpC_S7.Size = new System.Drawing.Size(398, 55);
            this.grpC_S7.TabIndex = 12;
            this.grpC_S7.TabStop = false;
            this.grpC_S7.Visible = false;
            // 
            // txtC_CPUType
            // 
            this.txtC_CPUType.Location = new System.Drawing.Point(116, 20);
            this.txtC_CPUType.Name = "txtC_CPUType";
            this.txtC_CPUType.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC_CPUType.Properties.Appearance.Options.UseFont = true;
            this.txtC_CPUType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtC_CPUType.Properties.Items.AddRange(new object[] {
            "S7200",
            "S7300",
            "S7400"});
            this.txtC_CPUType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtC_CPUType.Size = new System.Drawing.Size(100, 20);
            this.txtC_CPUType.TabIndex = 16;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 14);
            this.label26.TabIndex = 15;
            this.label26.Text = "CPU Type:";
            // 
            // txtC_ConnType
            // 
            this.txtC_ConnType.Enabled = false;
            this.txtC_ConnType.Location = new System.Drawing.Point(129, 115);
            this.txtC_ConnType.Name = "txtC_ConnType";
            this.txtC_ConnType.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC_ConnType.Properties.Appearance.Options.UseFont = true;
            this.txtC_ConnType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtC_ConnType.Properties.ImmediatePopup = true;
            this.txtC_ConnType.Size = new System.Drawing.Size(282, 20);
            this.txtC_ConnType.TabIndex = 11;
            this.txtC_ConnType.EditValueChanged += new System.EventHandler(this.txtC_ConnType_EditValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(10, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 14);
            this.label21.TabIndex = 10;
            this.label21.Text = "Connection Name:";
            // 
            // btnC_Save
            // 
            this.btnC_Save.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC_Save.Location = new System.Drawing.Point(516, 11);
            this.btnC_Save.Name = "btnC_Save";
            this.btnC_Save.Size = new System.Drawing.Size(75, 23);
            this.btnC_Save.TabIndex = 9;
            this.btnC_Save.Text = "Save";
            this.btnC_Save.UseVisualStyleBackColor = true;
            this.btnC_Save.Click += new System.EventHandler(this.btnC_Save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Connection Name:";
            // 
            // txtC_ConnName
            // 
            this.txtC_ConnName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC_ConnName.Location = new System.Drawing.Point(128, 86);
            this.txtC_ConnName.Name = "txtC_ConnName";
            this.txtC_ConnName.Size = new System.Drawing.Size(283, 22);
            this.txtC_ConnName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Connection ID:";
            // 
            // txtC_ConnID
            // 
            this.txtC_ConnID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC_ConnID.Location = new System.Drawing.Point(128, 60);
            this.txtC_ConnID.Name = "txtC_ConnID";
            this.txtC_ConnID.ReadOnly = true;
            this.txtC_ConnID.Size = new System.Drawing.Size(100, 22);
            this.txtC_ConnID.TabIndex = 5;
            // 
            // txtC_ProjName
            // 
            this.txtC_ProjName.Enabled = false;
            this.txtC_ProjName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC_ProjName.Location = new System.Drawing.Point(217, 12);
            this.txtC_ProjName.Name = "txtC_ProjName";
            this.txtC_ProjName.ReadOnly = true;
            this.txtC_ProjName.Size = new System.Drawing.Size(283, 22);
            this.txtC_ProjName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project ID:";
            // 
            // txtC_ProjID
            // 
            this.txtC_ProjID.Enabled = false;
            this.txtC_ProjID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC_ProjID.Location = new System.Drawing.Point(111, 12);
            this.txtC_ProjID.Name = "txtC_ProjID";
            this.txtC_ProjID.ReadOnly = true;
            this.txtC_ProjID.Size = new System.Drawing.Size(100, 22);
            this.txtC_ProjID.TabIndex = 2;
            // 
            // tabDev
            // 
            this.tabDev.Controls.Add(this.tabs_Dev);
            this.tabDev.Controls.Add(this.groupBox2);
            this.tabDev.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDev.Name = "tabDev";
            this.tabDev.Size = new System.Drawing.Size(608, 435);
            this.tabDev.Text = "Device";
            // 
            // tabs_Dev
            // 
            this.tabs_Dev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs_Dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs_Dev.Location = new System.Drawing.Point(0, 186);
            this.tabs_Dev.Name = "tabs_Dev";
            this.tabs_Dev.SelectedTabPage = this.tagD_ModbusTCP;
            this.tabs_Dev.Size = new System.Drawing.Size(608, 249);
            this.tabs_Dev.TabIndex = 17;
            this.tabs_Dev.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tagD_ModbusTCP,
            this.tagD_ModbusSr,
            this.tagD_SiemensS7TCP});
            // 
            // tagD_ModbusTCP
            // 
            this.tagD_ModbusTCP.Controls.Add(this.txtD_MB_SlaveAddress);
            this.tagD_ModbusTCP.Controls.Add(this.txtD_MB_Port);
            this.tagD_ModbusTCP.Controls.Add(this.label20);
            this.tagD_ModbusTCP.Controls.Add(this.label19);
            this.tagD_ModbusTCP.Controls.Add(this.label18);
            this.tagD_ModbusTCP.Controls.Add(this.txtD_MB_IP);
            this.tagD_ModbusTCP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagD_ModbusTCP.Name = "tagD_ModbusTCP";
            this.tagD_ModbusTCP.Size = new System.Drawing.Size(602, 221);
            this.tagD_ModbusTCP.Text = "Modbus TCP";
            // 
            // txtD_MB_SlaveAddress
            // 
            this.txtD_MB_SlaveAddress.Location = new System.Drawing.Point(110, 69);
            this.txtD_MB_SlaveAddress.Name = "txtD_MB_SlaveAddress";
            this.txtD_MB_SlaveAddress.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_MB_SlaveAddress.Properties.Appearance.Options.UseFont = true;
            this.txtD_MB_SlaveAddress.Properties.Mask.EditMask = "d";
            this.txtD_MB_SlaveAddress.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtD_MB_SlaveAddress.Properties.Mask.SaveLiteral = false;
            this.txtD_MB_SlaveAddress.Properties.Mask.ShowPlaceHolders = false;
            this.txtD_MB_SlaveAddress.Size = new System.Drawing.Size(100, 20);
            this.txtD_MB_SlaveAddress.TabIndex = 31;
            // 
            // txtD_MB_Port
            // 
            this.txtD_MB_Port.Location = new System.Drawing.Point(110, 43);
            this.txtD_MB_Port.Name = "txtD_MB_Port";
            this.txtD_MB_Port.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_MB_Port.Properties.Appearance.Options.UseFont = true;
            this.txtD_MB_Port.Properties.Mask.EditMask = "d";
            this.txtD_MB_Port.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtD_MB_Port.Size = new System.Drawing.Size(100, 20);
            this.txtD_MB_Port.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 14);
            this.label20.TabIndex = 29;
            this.label20.Text = "Slave Address:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 14);
            this.label19.TabIndex = 27;
            this.label19.Text = "Port:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(9, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 14);
            this.label18.TabIndex = 25;
            this.label18.Text = "IP Address:";
            // 
            // txtD_MB_IP
            // 
            this.txtD_MB_IP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_MB_IP.Location = new System.Drawing.Point(110, 17);
            this.txtD_MB_IP.Name = "txtD_MB_IP";
            this.txtD_MB_IP.Size = new System.Drawing.Size(100, 22);
            this.txtD_MB_IP.TabIndex = 24;
            this.txtD_MB_IP.Validating += new System.ComponentModel.CancelEventHandler(this.txtD_MB_IP_Validating);
            // 
            // tagD_ModbusSr
            // 
            this.tagD_ModbusSr.Controls.Add(this.chkD_RTSEnable);
            this.tagD_ModbusSr.Controls.Add(this.txtD_SL_PortName);
            this.tagD_ModbusSr.Controls.Add(this.txtD_SL_HandShake);
            this.tagD_ModbusSr.Controls.Add(this.label34);
            this.tagD_ModbusSr.Controls.Add(this.txtD_SL_StopBits);
            this.tagD_ModbusSr.Controls.Add(this.label33);
            this.tagD_ModbusSr.Controls.Add(this.txtD_SL_Parity);
            this.tagD_ModbusSr.Controls.Add(this.label32);
            this.tagD_ModbusSr.Controls.Add(this.txtD_SL_DataBits);
            this.tagD_ModbusSr.Controls.Add(this.label31);
            this.tagD_ModbusSr.Controls.Add(this.txtD_SL_BaudRate);
            this.tagD_ModbusSr.Controls.Add(this.label29);
            this.tagD_ModbusSr.Controls.Add(this.label30);
            this.tagD_ModbusSr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagD_ModbusSr.Name = "tagD_ModbusSr";
            this.tagD_ModbusSr.Size = new System.Drawing.Size(602, 221);
            this.tagD_ModbusSr.Text = "Modbus Serial";
            // 
            // chkD_RTSEnable
            // 
            this.chkD_RTSEnable.AutoSize = true;
            this.chkD_RTSEnable.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkD_RTSEnable.Location = new System.Drawing.Point(362, 72);
            this.chkD_RTSEnable.Name = "chkD_RTSEnable";
            this.chkD_RTSEnable.Size = new System.Drawing.Size(86, 18);
            this.chkD_RTSEnable.TabIndex = 45;
            this.chkD_RTSEnable.Text = "RTS Enable";
            this.chkD_RTSEnable.UseVisualStyleBackColor = true;
            // 
            // txtD_SL_PortName
            // 
            this.txtD_SL_PortName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_SL_PortName.Location = new System.Drawing.Point(110, 17);
            this.txtD_SL_PortName.Name = "txtD_SL_PortName";
            this.txtD_SL_PortName.Size = new System.Drawing.Size(100, 22);
            this.txtD_SL_PortName.TabIndex = 44;
            // 
            // txtD_SL_HandShake
            // 
            this.txtD_SL_HandShake.Location = new System.Drawing.Point(362, 45);
            this.txtD_SL_HandShake.Name = "txtD_SL_HandShake";
            this.txtD_SL_HandShake.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_SL_HandShake.Properties.Appearance.Options.UseFont = true;
            this.txtD_SL_HandShake.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtD_SL_HandShake.Properties.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.txtD_SL_HandShake.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtD_SL_HandShake.Size = new System.Drawing.Size(100, 20);
            this.txtD_SL_HandShake.TabIndex = 43;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(261, 46);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(72, 14);
            this.label34.TabIndex = 42;
            this.label34.Text = "Handshake:";
            // 
            // txtD_SL_StopBits
            // 
            this.txtD_SL_StopBits.Location = new System.Drawing.Point(362, 19);
            this.txtD_SL_StopBits.Name = "txtD_SL_StopBits";
            this.txtD_SL_StopBits.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_SL_StopBits.Properties.Appearance.Options.UseFont = true;
            this.txtD_SL_StopBits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtD_SL_StopBits.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.txtD_SL_StopBits.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtD_SL_StopBits.Size = new System.Drawing.Size(100, 20);
            this.txtD_SL_StopBits.TabIndex = 41;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(261, 20);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(58, 14);
            this.label33.TabIndex = 40;
            this.label33.Text = "Stop Bits:";
            // 
            // txtD_SL_Parity
            // 
            this.txtD_SL_Parity.Location = new System.Drawing.Point(110, 95);
            this.txtD_SL_Parity.Name = "txtD_SL_Parity";
            this.txtD_SL_Parity.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_SL_Parity.Properties.Appearance.Options.UseFont = true;
            this.txtD_SL_Parity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtD_SL_Parity.Properties.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.txtD_SL_Parity.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtD_SL_Parity.Size = new System.Drawing.Size(100, 20);
            this.txtD_SL_Parity.TabIndex = 39;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(9, 96);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 14);
            this.label32.TabIndex = 38;
            this.label32.Text = "Parity:";
            // 
            // txtD_SL_DataBits
            // 
            this.txtD_SL_DataBits.Location = new System.Drawing.Point(110, 69);
            this.txtD_SL_DataBits.Name = "txtD_SL_DataBits";
            this.txtD_SL_DataBits.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_SL_DataBits.Properties.Appearance.Options.UseFont = true;
            this.txtD_SL_DataBits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtD_SL_DataBits.Properties.Items.AddRange(new object[] {
            "7",
            "8"});
            this.txtD_SL_DataBits.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtD_SL_DataBits.Size = new System.Drawing.Size(100, 20);
            this.txtD_SL_DataBits.TabIndex = 37;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(9, 70);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 14);
            this.label31.TabIndex = 36;
            this.label31.Text = "Databits:";
            // 
            // txtD_SL_BaudRate
            // 
            this.txtD_SL_BaudRate.Location = new System.Drawing.Point(110, 43);
            this.txtD_SL_BaudRate.Name = "txtD_SL_BaudRate";
            this.txtD_SL_BaudRate.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_SL_BaudRate.Properties.Appearance.Options.UseFont = true;
            this.txtD_SL_BaudRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtD_SL_BaudRate.Properties.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.txtD_SL_BaudRate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtD_SL_BaudRate.Size = new System.Drawing.Size(100, 20);
            this.txtD_SL_BaudRate.TabIndex = 35;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(9, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(66, 14);
            this.label29.TabIndex = 33;
            this.label29.Text = "Baud Rate:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(9, 20);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 14);
            this.label30.TabIndex = 32;
            this.label30.Text = "COM Port:";
            // 
            // tagD_SiemensS7TCP
            // 
            this.tagD_SiemensS7TCP.Controls.Add(this.txtD_S7_Port);
            this.tagD_SiemensS7TCP.Controls.Add(this.label27);
            this.tagD_SiemensS7TCP.Controls.Add(this.label28);
            this.tagD_SiemensS7TCP.Controls.Add(this.txtD_S7_IP);
            this.tagD_SiemensS7TCP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagD_SiemensS7TCP.Name = "tagD_SiemensS7TCP";
            this.tagD_SiemensS7TCP.Size = new System.Drawing.Size(602, 221);
            this.tagD_SiemensS7TCP.Text = "Siements S7 TCP";
            // 
            // txtD_S7_Port
            // 
            this.txtD_S7_Port.Location = new System.Drawing.Point(110, 43);
            this.txtD_S7_Port.Name = "txtD_S7_Port";
            this.txtD_S7_Port.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_S7_Port.Properties.Appearance.Options.UseFont = true;
            this.txtD_S7_Port.Properties.Mask.EditMask = "d";
            this.txtD_S7_Port.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtD_S7_Port.Properties.Mask.SaveLiteral = false;
            this.txtD_S7_Port.Properties.Mask.ShowPlaceHolders = false;
            this.txtD_S7_Port.Size = new System.Drawing.Size(100, 20);
            this.txtD_S7_Port.TabIndex = 34;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(9, 46);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 14);
            this.label27.TabIndex = 33;
            this.label27.Text = "Port:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(9, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 14);
            this.label28.TabIndex = 32;
            this.label28.Text = "IP Address:";
            // 
            // txtD_S7_IP
            // 
            this.txtD_S7_IP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_S7_IP.Location = new System.Drawing.Point(110, 17);
            this.txtD_S7_IP.Name = "txtD_S7_IP";
            this.txtD_S7_IP.Size = new System.Drawing.Size(100, 22);
            this.txtD_S7_IP.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtD_Delay);
            this.groupBox2.Controls.Add(this.txtD_Timeout);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.btnD_Save);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtD_DeviceName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtD_DeviceID);
            this.groupBox2.Controls.Add(this.txtD_ConnName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtD_ConnID);
            this.groupBox2.Controls.Add(this.txtD_ProjName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtD_ProjID);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 186);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // txtD_Delay
            // 
            this.txtD_Delay.Location = new System.Drawing.Point(271, 141);
            this.txtD_Delay.Name = "txtD_Delay";
            this.txtD_Delay.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_Delay.Properties.Appearance.Options.UseFont = true;
            this.txtD_Delay.Properties.Mask.EditMask = "d";
            this.txtD_Delay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtD_Delay.Properties.Mask.SaveLiteral = false;
            this.txtD_Delay.Properties.Mask.ShowPlaceHolders = false;
            this.txtD_Delay.Size = new System.Drawing.Size(100, 20);
            this.txtD_Delay.TabIndex = 33;
            // 
            // txtD_Timeout
            // 
            this.txtD_Timeout.Location = new System.Drawing.Point(111, 141);
            this.txtD_Timeout.Name = "txtD_Timeout";
            this.txtD_Timeout.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_Timeout.Properties.Appearance.Options.UseFont = true;
            this.txtD_Timeout.Properties.Mask.EditMask = "d";
            this.txtD_Timeout.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtD_Timeout.Properties.Mask.SaveLiteral = false;
            this.txtD_Timeout.Properties.Mask.ShowPlaceHolders = false;
            this.txtD_Timeout.Size = new System.Drawing.Size(100, 20);
            this.txtD_Timeout.TabIndex = 32;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(228, 144);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 14);
            this.label23.TabIndex = 30;
            this.label23.Text = "Delay:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 144);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 14);
            this.label22.TabIndex = 28;
            this.label22.Text = "Timeout:";
            // 
            // btnD_Save
            // 
            this.btnD_Save.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD_Save.Location = new System.Drawing.Point(515, 11);
            this.btnD_Save.Name = "btnD_Save";
            this.btnD_Save.Size = new System.Drawing.Size(75, 23);
            this.btnD_Save.TabIndex = 26;
            this.btnD_Save.Text = "Save";
            this.btnD_Save.UseVisualStyleBackColor = true;
            this.btnD_Save.Click += new System.EventHandler(this.btnD_Save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "Device Name:";
            // 
            // txtD_DeviceName
            // 
            this.txtD_DeviceName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_DeviceName.Location = new System.Drawing.Point(111, 115);
            this.txtD_DeviceName.Name = "txtD_DeviceName";
            this.txtD_DeviceName.Size = new System.Drawing.Size(389, 22);
            this.txtD_DeviceName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "Device ID:";
            // 
            // txtD_DeviceID
            // 
            this.txtD_DeviceID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_DeviceID.Location = new System.Drawing.Point(111, 89);
            this.txtD_DeviceID.Name = "txtD_DeviceID";
            this.txtD_DeviceID.ReadOnly = true;
            this.txtD_DeviceID.Size = new System.Drawing.Size(100, 22);
            this.txtD_DeviceID.TabIndex = 22;
            // 
            // txtD_ConnName
            // 
            this.txtD_ConnName.Enabled = false;
            this.txtD_ConnName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_ConnName.Location = new System.Drawing.Point(217, 39);
            this.txtD_ConnName.Name = "txtD_ConnName";
            this.txtD_ConnName.ReadOnly = true;
            this.txtD_ConnName.Size = new System.Drawing.Size(283, 22);
            this.txtD_ConnName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Connection ID:";
            // 
            // txtD_ConnID
            // 
            this.txtD_ConnID.Enabled = false;
            this.txtD_ConnID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_ConnID.Location = new System.Drawing.Point(111, 39);
            this.txtD_ConnID.Name = "txtD_ConnID";
            this.txtD_ConnID.ReadOnly = true;
            this.txtD_ConnID.Size = new System.Drawing.Size(100, 22);
            this.txtD_ConnID.TabIndex = 19;
            // 
            // txtD_ProjName
            // 
            this.txtD_ProjName.Enabled = false;
            this.txtD_ProjName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_ProjName.Location = new System.Drawing.Point(217, 13);
            this.txtD_ProjName.Name = "txtD_ProjName";
            this.txtD_ProjName.ReadOnly = true;
            this.txtD_ProjName.Size = new System.Drawing.Size(283, 22);
            this.txtD_ProjName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Project ID:";
            // 
            // txtD_ProjID
            // 
            this.txtD_ProjID.Enabled = false;
            this.txtD_ProjID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD_ProjID.Location = new System.Drawing.Point(111, 13);
            this.txtD_ProjID.Name = "txtD_ProjID";
            this.txtD_ProjID.ReadOnly = true;
            this.txtD_ProjID.Size = new System.Drawing.Size(100, 22);
            this.txtD_ProjID.TabIndex = 16;
            // 
            // tabTag
            // 
            this.tabTag.Controls.Add(this.tabs_Tag);
            this.tabTag.Controls.Add(this.groupBox1);
            this.tabTag.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTag.Name = "tabTag";
            this.tabTag.Size = new System.Drawing.Size(608, 435);
            this.tabTag.Text = "Tag";
            // 
            // tabs_Tag
            // 
            this.tabs_Tag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs_Tag.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs_Tag.Location = new System.Drawing.Point(0, 223);
            this.tabs_Tag.Name = "tabs_Tag";
            this.tabs_Tag.SelectedTabPage = this.tagT_ModbusTCP;
            this.tabs_Tag.Size = new System.Drawing.Size(608, 212);
            this.tabs_Tag.TabIndex = 0;
            this.tabs_Tag.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tagT_ModbusTCP,
            this.tagT_ModbusSr,
            this.tagT_SiemensS7TCP});
            // 
            // tagT_ModbusTCP
            // 
            this.tagT_ModbusTCP.Controls.Add(this.txtT_MBTRegCount);
            this.tagT_ModbusTCP.Controls.Add(this.txtT_MBTRegAddress);
            this.tagT_ModbusTCP.Controls.Add(this.txtT_MBTRegTypeID);
            this.tagT_ModbusTCP.Controls.Add(this.label17);
            this.tagT_ModbusTCP.Controls.Add(this.label16);
            this.tagT_ModbusTCP.Controls.Add(this.label15);
            this.tagT_ModbusTCP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagT_ModbusTCP.Name = "tagT_ModbusTCP";
            this.tagT_ModbusTCP.Size = new System.Drawing.Size(602, 184);
            this.tagT_ModbusTCP.Text = "Modbus TCP";
            // 
            // txtT_MBTRegCount
            // 
            this.txtT_MBTRegCount.Location = new System.Drawing.Point(111, 75);
            this.txtT_MBTRegCount.Name = "txtT_MBTRegCount";
            this.txtT_MBTRegCount.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_MBTRegCount.Properties.Appearance.Options.UseFont = true;
            this.txtT_MBTRegCount.Properties.Mask.EditMask = "d";
            this.txtT_MBTRegCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_MBTRegCount.Properties.Mask.SaveLiteral = false;
            this.txtT_MBTRegCount.Properties.Mask.ShowPlaceHolders = false;
            this.txtT_MBTRegCount.Size = new System.Drawing.Size(100, 20);
            this.txtT_MBTRegCount.TabIndex = 2;
            // 
            // txtT_MBTRegAddress
            // 
            this.txtT_MBTRegAddress.Location = new System.Drawing.Point(110, 47);
            this.txtT_MBTRegAddress.Name = "txtT_MBTRegAddress";
            this.txtT_MBTRegAddress.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_MBTRegAddress.Properties.Appearance.Options.UseFont = true;
            this.txtT_MBTRegAddress.Properties.Mask.EditMask = "d";
            this.txtT_MBTRegAddress.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_MBTRegAddress.Properties.Mask.SaveLiteral = false;
            this.txtT_MBTRegAddress.Properties.Mask.ShowPlaceHolders = false;
            this.txtT_MBTRegAddress.Size = new System.Drawing.Size(100, 20);
            this.txtT_MBTRegAddress.TabIndex = 1;
            // 
            // txtT_MBTRegTypeID
            // 
            this.txtT_MBTRegTypeID.Location = new System.Drawing.Point(110, 20);
            this.txtT_MBTRegTypeID.Name = "txtT_MBTRegTypeID";
            this.txtT_MBTRegTypeID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_MBTRegTypeID.Properties.Appearance.Options.UseFont = true;
            this.txtT_MBTRegTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtT_MBTRegTypeID.Properties.ImmediatePopup = true;
            this.txtT_MBTRegTypeID.Size = new System.Drawing.Size(213, 20);
            this.txtT_MBTRegTypeID.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 14);
            this.label17.TabIndex = 39;
            this.label17.Text = "Register Count:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 14);
            this.label16.TabIndex = 37;
            this.label16.Text = "Register Addr:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 14);
            this.label15.TabIndex = 35;
            this.label15.Text = "Register Type:";
            // 
            // tagT_ModbusSr
            // 
            this.tagT_ModbusSr.Controls.Add(this.txtT_MBSRegCount);
            this.tagT_ModbusSr.Controls.Add(this.txtT_MBSRegAddress);
            this.tagT_ModbusSr.Controls.Add(this.txtT_MBSRegTypeID);
            this.tagT_ModbusSr.Controls.Add(this.label35);
            this.tagT_ModbusSr.Controls.Add(this.label36);
            this.tagT_ModbusSr.Controls.Add(this.label37);
            this.tagT_ModbusSr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagT_ModbusSr.Name = "tagT_ModbusSr";
            this.tagT_ModbusSr.Size = new System.Drawing.Size(602, 184);
            this.tagT_ModbusSr.Text = "Modbus Serial";
            // 
            // txtT_MBSRegCount
            // 
            this.txtT_MBSRegCount.Location = new System.Drawing.Point(111, 75);
            this.txtT_MBSRegCount.Name = "txtT_MBSRegCount";
            this.txtT_MBSRegCount.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_MBSRegCount.Properties.Appearance.Options.UseFont = true;
            this.txtT_MBSRegCount.Properties.Mask.EditMask = "d";
            this.txtT_MBSRegCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_MBSRegCount.Properties.Mask.SaveLiteral = false;
            this.txtT_MBSRegCount.Properties.Mask.ShowPlaceHolders = false;
            this.txtT_MBSRegCount.Size = new System.Drawing.Size(100, 20);
            this.txtT_MBSRegCount.TabIndex = 2;
            // 
            // txtT_MBSRegAddress
            // 
            this.txtT_MBSRegAddress.Location = new System.Drawing.Point(110, 47);
            this.txtT_MBSRegAddress.Name = "txtT_MBSRegAddress";
            this.txtT_MBSRegAddress.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_MBSRegAddress.Properties.Appearance.Options.UseFont = true;
            this.txtT_MBSRegAddress.Properties.Mask.EditMask = "d";
            this.txtT_MBSRegAddress.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_MBSRegAddress.Properties.Mask.SaveLiteral = false;
            this.txtT_MBSRegAddress.Properties.Mask.ShowPlaceHolders = false;
            this.txtT_MBSRegAddress.Size = new System.Drawing.Size(100, 20);
            this.txtT_MBSRegAddress.TabIndex = 1;
            // 
            // txtT_MBSRegTypeID
            // 
            this.txtT_MBSRegTypeID.Location = new System.Drawing.Point(110, 20);
            this.txtT_MBSRegTypeID.Name = "txtT_MBSRegTypeID";
            this.txtT_MBSRegTypeID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_MBSRegTypeID.Properties.Appearance.Options.UseFont = true;
            this.txtT_MBSRegTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtT_MBSRegTypeID.Properties.ImmediatePopup = true;
            this.txtT_MBSRegTypeID.Size = new System.Drawing.Size(213, 20);
            this.txtT_MBSRegTypeID.TabIndex = 0;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(14, 78);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 14);
            this.label35.TabIndex = 46;
            this.label35.Text = "Register Count:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(14, 50);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 14);
            this.label36.TabIndex = 45;
            this.label36.Text = "Register Addr:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(14, 23);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(82, 14);
            this.label37.TabIndex = 44;
            this.label37.Text = "Register Type:";
            // 
            // tagT_SiemensS7TCP
            // 
            this.tagT_SiemensS7TCP.Controls.Add(this.txtT_S7RegDataType);
            this.tagT_SiemensS7TCP.Controls.Add(this.label42);
            this.tagT_SiemensS7TCP.Controls.Add(this.txtT_S7DataBlock);
            this.tagT_SiemensS7TCP.Controls.Add(this.label41);
            this.tagT_SiemensS7TCP.Controls.Add(this.txtT_S7RegCount);
            this.tagT_SiemensS7TCP.Controls.Add(this.txtT_S7RegAddress);
            this.tagT_SiemensS7TCP.Controls.Add(this.txtT_S7RegTypeID);
            this.tagT_SiemensS7TCP.Controls.Add(this.label38);
            this.tagT_SiemensS7TCP.Controls.Add(this.label39);
            this.tagT_SiemensS7TCP.Controls.Add(this.label40);
            this.tagT_SiemensS7TCP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagT_SiemensS7TCP.Name = "tagT_SiemensS7TCP";
            this.tagT_SiemensS7TCP.Size = new System.Drawing.Size(602, 184);
            this.tagT_SiemensS7TCP.Text = "Siemens S7 TCP";
            // 
            // txtT_S7RegDataType
            // 
            this.txtT_S7RegDataType.Location = new System.Drawing.Point(110, 133);
            this.txtT_S7RegDataType.Name = "txtT_S7RegDataType";
            this.txtT_S7RegDataType.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_S7RegDataType.Properties.Appearance.Options.UseFont = true;
            this.txtT_S7RegDataType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtT_S7RegDataType.Properties.Items.AddRange(new object[] {
            "DWord",
            "Word",
            "Byte"});
            this.txtT_S7RegDataType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtT_S7RegDataType.Size = new System.Drawing.Size(100, 20);
            this.txtT_S7RegDataType.TabIndex = 4;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(13, 134);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(86, 14);
            this.label42.TabIndex = 52;
            this.label42.Text = "Reg Data Type:";
            // 
            // txtT_S7DataBlock
            // 
            this.txtT_S7DataBlock.Location = new System.Drawing.Point(110, 103);
            this.txtT_S7DataBlock.Name = "txtT_S7DataBlock";
            this.txtT_S7DataBlock.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_S7DataBlock.Properties.Appearance.Options.UseFont = true;
            this.txtT_S7DataBlock.Properties.Mask.EditMask = "d";
            this.txtT_S7DataBlock.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_S7DataBlock.Properties.Mask.SaveLiteral = false;
            this.txtT_S7DataBlock.Properties.Mask.ShowPlaceHolders = false;
            this.txtT_S7DataBlock.Size = new System.Drawing.Size(100, 20);
            this.txtT_S7DataBlock.TabIndex = 3;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(14, 106);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(68, 14);
            this.label41.TabIndex = 50;
            this.label41.Text = "Data block:";
            // 
            // txtT_S7RegCount
            // 
            this.txtT_S7RegCount.Location = new System.Drawing.Point(110, 75);
            this.txtT_S7RegCount.Name = "txtT_S7RegCount";
            this.txtT_S7RegCount.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_S7RegCount.Properties.Appearance.Options.UseFont = true;
            this.txtT_S7RegCount.Properties.Mask.EditMask = "d";
            this.txtT_S7RegCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_S7RegCount.Properties.Mask.SaveLiteral = false;
            this.txtT_S7RegCount.Properties.Mask.ShowPlaceHolders = false;
            this.txtT_S7RegCount.Size = new System.Drawing.Size(100, 20);
            this.txtT_S7RegCount.TabIndex = 2;
            // 
            // txtT_S7RegAddress
            // 
            this.txtT_S7RegAddress.Location = new System.Drawing.Point(110, 47);
            this.txtT_S7RegAddress.Name = "txtT_S7RegAddress";
            this.txtT_S7RegAddress.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_S7RegAddress.Properties.Appearance.Options.UseFont = true;
            this.txtT_S7RegAddress.Properties.Mask.EditMask = "d";
            this.txtT_S7RegAddress.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_S7RegAddress.Properties.Mask.SaveLiteral = false;
            this.txtT_S7RegAddress.Properties.Mask.ShowPlaceHolders = false;
            this.txtT_S7RegAddress.Size = new System.Drawing.Size(100, 20);
            this.txtT_S7RegAddress.TabIndex = 1;
            // 
            // txtT_S7RegTypeID
            // 
            this.txtT_S7RegTypeID.Location = new System.Drawing.Point(110, 20);
            this.txtT_S7RegTypeID.Name = "txtT_S7RegTypeID";
            this.txtT_S7RegTypeID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_S7RegTypeID.Properties.Appearance.Options.UseFont = true;
            this.txtT_S7RegTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtT_S7RegTypeID.Properties.ImmediatePopup = true;
            this.txtT_S7RegTypeID.Size = new System.Drawing.Size(213, 20);
            this.txtT_S7RegTypeID.TabIndex = 0;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(14, 78);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(89, 14);
            this.label38.TabIndex = 46;
            this.label38.Text = "Register Count:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(14, 50);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(83, 14);
            this.label39.TabIndex = 45;
            this.label39.Text = "Register Addr:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(14, 23);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(82, 14);
            this.label40.TabIndex = 44;
            this.label40.Text = "Register Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConn);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.txtT_IsLogged);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.txtT_MaxVal);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtT_MinVal);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtT_Datatype);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtT_UOM);
            this.groupBox1.Controls.Add(this.btnT_Save);
            this.groupBox1.Controls.Add(this.txtT_TagName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtT_TagID);
            this.groupBox1.Controls.Add(this.txtT_DeviceName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtT_DeviceID);
            this.groupBox1.Controls.Add(this.txtT_ConnName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtT_ConnID);
            this.groupBox1.Controls.Add(this.txtT_ProjName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtT_ProjID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnConn
            // 
            this.btnConn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConn.Location = new System.Drawing.Point(515, 40);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 23);
            this.btnConn.TabIndex = 49;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(10, 137);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(63, 14);
            this.label44.TabIndex = 48;
            this.label44.Text = "Tag Name:";
            // 
            // txtT_IsLogged
            // 
            this.txtT_IsLogged.AutoSize = true;
            this.txtT_IsLogged.Location = new System.Drawing.Point(389, 136);
            this.txtT_IsLogged.Name = "txtT_IsLogged";
            this.txtT_IsLogged.Size = new System.Drawing.Size(115, 18);
            this.txtT_IsLogged.TabIndex = 8;
            this.txtT_IsLogged.Text = "Logging Enabled";
            this.txtT_IsLogged.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(317, 190);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(66, 14);
            this.label43.TabIndex = 46;
            this.label43.Text = "Max Value:";
            // 
            // txtT_MaxVal
            // 
            this.txtT_MaxVal.Location = new System.Drawing.Point(400, 187);
            this.txtT_MaxVal.Name = "txtT_MaxVal";
            this.txtT_MaxVal.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_MaxVal.Properties.Appearance.Options.UseFont = true;
            this.txtT_MaxVal.Properties.Mask.EditMask = "d";
            this.txtT_MaxVal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_MaxVal.Properties.Mask.SaveLiteral = false;
            this.txtT_MaxVal.Properties.Mask.ShowPlaceHolders = false;
            this.txtT_MaxVal.Size = new System.Drawing.Size(100, 20);
            this.txtT_MaxVal.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 14);
            this.label13.TabIndex = 44;
            this.label13.Text = "Min Value:";
            // 
            // txtT_MinVal
            // 
            this.txtT_MinVal.Location = new System.Drawing.Point(111, 187);
            this.txtT_MinVal.Name = "txtT_MinVal";
            this.txtT_MinVal.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_MinVal.Properties.Appearance.Options.UseFont = true;
            this.txtT_MinVal.Properties.Mask.EditMask = "d";
            this.txtT_MinVal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_MinVal.Properties.Mask.SaveLiteral = false;
            this.txtT_MinVal.Properties.Mask.ShowPlaceHolders = false;
            this.txtT_MinVal.Size = new System.Drawing.Size(100, 20);
            this.txtT_MinVal.TabIndex = 11;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(317, 163);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 14);
            this.label25.TabIndex = 41;
            this.label25.Text = "DataType:";
            // 
            // txtT_Datatype
            // 
            this.txtT_Datatype.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_Datatype.Location = new System.Drawing.Point(400, 160);
            this.txtT_Datatype.Name = "txtT_Datatype";
            this.txtT_Datatype.Size = new System.Drawing.Size(100, 22);
            this.txtT_Datatype.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(10, 163);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 14);
            this.label24.TabIndex = 39;
            this.label24.Text = "Unit:";
            // 
            // txtT_UOM
            // 
            this.txtT_UOM.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_UOM.Location = new System.Drawing.Point(111, 160);
            this.txtT_UOM.Name = "txtT_UOM";
            this.txtT_UOM.Size = new System.Drawing.Size(100, 22);
            this.txtT_UOM.TabIndex = 9;
            // 
            // btnT_Save
            // 
            this.btnT_Save.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT_Save.Location = new System.Drawing.Point(515, 11);
            this.btnT_Save.Name = "btnT_Save";
            this.btnT_Save.Size = new System.Drawing.Size(75, 23);
            this.btnT_Save.TabIndex = 13;
            this.btnT_Save.Text = "Save";
            this.btnT_Save.UseVisualStyleBackColor = true;
            this.btnT_Save.Click += new System.EventHandler(this.btnT_Save_Click);
            // 
            // txtT_TagName
            // 
            this.txtT_TagName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_TagName.Location = new System.Drawing.Point(111, 134);
            this.txtT_TagName.Name = "txtT_TagName";
            this.txtT_TagName.Size = new System.Drawing.Size(272, 22);
            this.txtT_TagName.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 14);
            this.label14.TabIndex = 34;
            this.label14.Text = "Tag ID:";
            // 
            // txtT_TagID
            // 
            this.txtT_TagID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_TagID.Location = new System.Drawing.Point(111, 106);
            this.txtT_TagID.Name = "txtT_TagID";
            this.txtT_TagID.ReadOnly = true;
            this.txtT_TagID.Size = new System.Drawing.Size(100, 22);
            this.txtT_TagID.TabIndex = 6;
            // 
            // txtT_DeviceName
            // 
            this.txtT_DeviceName.Enabled = false;
            this.txtT_DeviceName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_DeviceName.Location = new System.Drawing.Point(217, 65);
            this.txtT_DeviceName.Name = "txtT_DeviceName";
            this.txtT_DeviceName.ReadOnly = true;
            this.txtT_DeviceName.Size = new System.Drawing.Size(283, 22);
            this.txtT_DeviceName.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 14);
            this.label12.TabIndex = 31;
            this.label12.Text = "Device ID:";
            // 
            // txtT_DeviceID
            // 
            this.txtT_DeviceID.Enabled = false;
            this.txtT_DeviceID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_DeviceID.Location = new System.Drawing.Point(111, 65);
            this.txtT_DeviceID.Name = "txtT_DeviceID";
            this.txtT_DeviceID.ReadOnly = true;
            this.txtT_DeviceID.Size = new System.Drawing.Size(100, 22);
            this.txtT_DeviceID.TabIndex = 4;
            // 
            // txtT_ConnName
            // 
            this.txtT_ConnName.Enabled = false;
            this.txtT_ConnName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_ConnName.Location = new System.Drawing.Point(217, 39);
            this.txtT_ConnName.Name = "txtT_ConnName";
            this.txtT_ConnName.ReadOnly = true;
            this.txtT_ConnName.Size = new System.Drawing.Size(283, 22);
            this.txtT_ConnName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 14);
            this.label10.TabIndex = 28;
            this.label10.Text = "Connection ID:";
            // 
            // txtT_ConnID
            // 
            this.txtT_ConnID.Enabled = false;
            this.txtT_ConnID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_ConnID.Location = new System.Drawing.Point(111, 39);
            this.txtT_ConnID.Name = "txtT_ConnID";
            this.txtT_ConnID.ReadOnly = true;
            this.txtT_ConnID.Size = new System.Drawing.Size(100, 22);
            this.txtT_ConnID.TabIndex = 2;
            // 
            // txtT_ProjName
            // 
            this.txtT_ProjName.Enabled = false;
            this.txtT_ProjName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_ProjName.Location = new System.Drawing.Point(217, 13);
            this.txtT_ProjName.Name = "txtT_ProjName";
            this.txtT_ProjName.ReadOnly = true;
            this.txtT_ProjName.Size = new System.Drawing.Size(283, 22);
            this.txtT_ProjName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 14);
            this.label11.TabIndex = 25;
            this.label11.Text = "Project ID:";
            // 
            // txtT_ProjID
            // 
            this.txtT_ProjID.Enabled = false;
            this.txtT_ProjID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_ProjID.Location = new System.Drawing.Point(111, 13);
            this.txtT_ProjID.Name = "txtT_ProjID";
            this.txtT_ProjID.ReadOnly = true;
            this.txtT_ProjID.Size = new System.Drawing.Size(100, 22);
            this.txtT_ProjID.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnServStop);
            this.groupBox3.Controls.Add(this.btnServStart);
            this.groupBox3.Controls.Add(this.btnServRestart);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 41);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnServStop
            // 
            this.btnServStop.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServStop.Location = new System.Drawing.Point(123, 12);
            this.btnServStop.Name = "btnServStop";
            this.btnServStop.Size = new System.Drawing.Size(103, 23);
            this.btnServStop.TabIndex = 3;
            this.btnServStop.Text = "Stop Services";
            this.btnServStop.UseVisualStyleBackColor = true;
            this.btnServStop.Click += new System.EventHandler(this.btnServStop_Click);
            // 
            // btnServStart
            // 
            this.btnServStart.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServStart.Location = new System.Drawing.Point(14, 12);
            this.btnServStart.Name = "btnServStart";
            this.btnServStart.Size = new System.Drawing.Size(103, 23);
            this.btnServStart.TabIndex = 2;
            this.btnServStart.Text = "Start Services";
            this.btnServStart.UseVisualStyleBackColor = true;
            this.btnServStart.Click += new System.EventHandler(this.btnServStart_Click);
            // 
            // btnServRestart
            // 
            this.btnServRestart.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServRestart.Location = new System.Drawing.Point(232, 12);
            this.btnServRestart.Name = "btnServRestart";
            this.btnServRestart.Size = new System.Drawing.Size(103, 23);
            this.btnServRestart.TabIndex = 1;
            this.btnServRestart.Text = "Restart Services";
            this.btnServRestart.UseVisualStyleBackColor = true;
            this.btnServRestart.Click += new System.EventHandler(this.btnServRestart_Click);
            // 
            // cmsConn
            // 
            this.cmsConn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsConn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateConn});
            this.cmsConn.Name = "cmsConn";
            this.cmsConn.Size = new System.Drawing.Size(173, 26);
            // 
            // mnuCreateConn
            // 
            this.mnuCreateConn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCreateConn.Name = "mnuCreateConn";
            this.mnuCreateConn.Size = new System.Drawing.Size(172, 22);
            this.mnuCreateConn.Text = "Create Connection";
            this.mnuCreateConn.Click += new System.EventHandler(this.mnuCreateConn_Click);
            // 
            // cmsDevice
            // 
            this.cmsDevice.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateDevice});
            this.cmsDevice.Name = "cmsConn";
            this.cmsDevice.Size = new System.Drawing.Size(149, 26);
            // 
            // mnuCreateDevice
            // 
            this.mnuCreateDevice.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCreateDevice.Name = "mnuCreateDevice";
            this.mnuCreateDevice.Size = new System.Drawing.Size(148, 22);
            this.mnuCreateDevice.Text = "Create Device";
            this.mnuCreateDevice.Click += new System.EventHandler(this.mnuCreateDevice_Click);
            // 
            // cmsTags
            // 
            this.cmsTags.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateTag});
            this.cmsTags.Name = "cmsConn";
            this.cmsTags.Size = new System.Drawing.Size(131, 26);
            // 
            // mnuCreateTag
            // 
            this.mnuCreateTag.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCreateTag.Name = "mnuCreateTag";
            this.mnuCreateTag.Size = new System.Drawing.Size(130, 22);
            this.mnuCreateTag.Text = "Create Tag";
            this.mnuCreateTag.Click += new System.EventHandler(this.mnuCreateTag_Click);
            // 
            // frmTry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 504);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Name = "frmTry";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.frmTry_Load);
            this.cmsProj.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabs)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabProj.ResumeLayout(false);
            this.tabProj.PerformLayout();
            this.tabConn.ResumeLayout(false);
            this.tabConn.PerformLayout();
            this.grpC_S7.ResumeLayout(false);
            this.grpC_S7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtC_CPUType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC_ConnType.Properties)).EndInit();
            this.tabDev.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabs_Dev)).EndInit();
            this.tabs_Dev.ResumeLayout(false);
            this.tagD_ModbusTCP.ResumeLayout(false);
            this.tagD_ModbusTCP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_MB_SlaveAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_MB_Port.Properties)).EndInit();
            this.tagD_ModbusSr.ResumeLayout(false);
            this.tagD_ModbusSr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_SL_HandShake.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_SL_StopBits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_SL_Parity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_SL_DataBits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_SL_BaudRate.Properties)).EndInit();
            this.tagD_SiemensS7TCP.ResumeLayout(false);
            this.tagD_SiemensS7TCP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_S7_Port.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_Delay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD_Timeout.Properties)).EndInit();
            this.tabTag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabs_Tag)).EndInit();
            this.tabs_Tag.ResumeLayout(false);
            this.tagT_ModbusTCP.ResumeLayout(false);
            this.tagT_ModbusTCP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBTRegCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBTRegAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBTRegTypeID.Properties)).EndInit();
            this.tagT_ModbusSr.ResumeLayout(false);
            this.tagT_ModbusSr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBSRegCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBSRegAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MBSRegTypeID.Properties)).EndInit();
            this.tagT_SiemensS7TCP.ResumeLayout(false);
            this.tagT_SiemensS7TCP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_S7RegDataType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_S7DataBlock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_S7RegCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_S7RegAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_S7RegTypeID.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MaxVal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_MinVal.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.cmsConn.ResumeLayout(false);
            this.cmsDevice.ResumeLayout(false);
            this.cmsTags.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpTree;
        private System.Windows.Forms.TreeView trvMain;
        private System.Windows.Forms.ContextMenuStrip cmsProj;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateProj;
        private System.Windows.Forms.ContextMenuStrip cmsConn;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateConn;
        private System.Windows.Forms.ContextMenuStrip cmsDevice;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateDevice;
        private System.Windows.Forms.ContextMenuStrip cmsTags;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateTag;
        private DevExpress.XtraTab.XtraTabControl tabs;
        private DevExpress.XtraTab.XtraTabPage tabProj;
        private System.Windows.Forms.Button btnP_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtP_ProjName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP_ProjID;
        private DevExpress.XtraTab.XtraTabPage tabConn;
        private DevExpress.XtraTab.XtraTabPage tabDev;
        private DevExpress.XtraTab.XtraTabPage tabTag;
        private System.Windows.Forms.TextBox txtC_ProjName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC_ProjID;
        private System.Windows.Forms.Button btnC_Save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC_ConnName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC_ConnID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtT_TagName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtT_TagID;
        private System.Windows.Forms.TextBox txtT_DeviceName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtT_DeviceID;
        private System.Windows.Forms.TextBox txtT_ConnName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtT_ConnID;
        private System.Windows.Forms.TextBox txtT_ProjName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtT_ProjID;
        private DevExpress.XtraTab.XtraTabControl tabs_Tag;
        private DevExpress.XtraTab.XtraTabPage tagT_ModbusTCP;
        private System.Windows.Forms.Button btnT_Save;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraTab.XtraTabControl tabs_Dev;
        private DevExpress.XtraTab.XtraTabPage tagD_ModbusTCP;
        private System.Windows.Forms.Button btnD_Save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtD_DeviceName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtD_DeviceID;
        private System.Windows.Forms.TextBox txtD_ConnName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtD_ConnID;
        private System.Windows.Forms.TextBox txtD_ProjName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtD_ProjID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtD_MB_IP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraEditors.LookUpEdit txtC_ConnType;
        private DevExpress.XtraEditors.TextEdit txtD_MB_Port;
        private DevExpress.XtraEditors.TextEdit txtD_MB_SlaveAddress;
        private DevExpress.XtraEditors.TextEdit txtD_Delay;
        private DevExpress.XtraEditors.TextEdit txtD_Timeout;
        private DevExpress.XtraEditors.LookUpEdit txtT_MBTRegTypeID;
        private DevExpress.XtraEditors.TextEdit txtT_MBTRegCount;
        private DevExpress.XtraEditors.TextEdit txtT_MBTRegAddress;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtT_UOM;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtT_Datatype;
        private DevExpress.XtraTab.XtraTabPage tagD_ModbusSr;
        private DevExpress.XtraTab.XtraTabPage tagD_SiemensS7TCP;
        private System.Windows.Forms.GroupBox grpC_S7;
        private DevExpress.XtraEditors.ComboBoxEdit txtC_CPUType;
        private System.Windows.Forms.Label label26;
        private DevExpress.XtraEditors.TextEdit txtD_S7_Port;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtD_S7_IP;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private DevExpress.XtraEditors.ComboBoxEdit txtD_SL_StopBits;
        private System.Windows.Forms.Label label33;
        private DevExpress.XtraEditors.ComboBoxEdit txtD_SL_Parity;
        private System.Windows.Forms.Label label32;
        private DevExpress.XtraEditors.ComboBoxEdit txtD_SL_DataBits;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraEditors.ComboBoxEdit txtD_SL_BaudRate;
        private DevExpress.XtraEditors.ComboBoxEdit txtD_SL_HandShake;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtD_SL_PortName;
        private System.Windows.Forms.CheckBox chkD_RTSEnable;
        private DevExpress.XtraTab.XtraTabPage tagT_ModbusSr;
        private DevExpress.XtraTab.XtraTabPage tagT_SiemensS7TCP;
        private DevExpress.XtraEditors.TextEdit txtT_MBSRegCount;
        private DevExpress.XtraEditors.TextEdit txtT_MBSRegAddress;
        private DevExpress.XtraEditors.LookUpEdit txtT_MBSRegTypeID;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private DevExpress.XtraEditors.TextEdit txtT_S7RegCount;
        private DevExpress.XtraEditors.TextEdit txtT_S7RegAddress;
        private DevExpress.XtraEditors.LookUpEdit txtT_S7RegTypeID;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private DevExpress.XtraEditors.TextEdit txtT_S7DataBlock;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private DevExpress.XtraEditors.ComboBoxEdit txtT_S7RegDataType;
        private System.Windows.Forms.Label label43;
        private DevExpress.XtraEditors.TextEdit txtT_MaxVal;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit txtT_MinVal;
        private System.Windows.Forms.CheckBox txtT_IsLogged;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnServRestart;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnServStop;
        private System.Windows.Forms.Button btnServStart;
    }
}