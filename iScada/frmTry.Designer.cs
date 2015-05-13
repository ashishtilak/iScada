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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Project");
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
            this.btnC_Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC_ConnName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC_ConnID = new System.Windows.Forms.TextBox();
            this.txtC_ProjName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC_ProjID = new System.Windows.Forms.TextBox();
            this.tabDev = new DevExpress.XtraTab.XtraTabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabTag = new DevExpress.XtraTab.XtraTabPage();
            this.cmsConn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTags = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabDev.SuspendLayout();
            this.cmsConn.SuspendLayout();
            this.cmsDevice.SuspendLayout();
            this.cmsTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsProj
            // 
            this.cmsProj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateProj});
            this.cmsProj.Name = "cmsProj";
            this.cmsProj.Size = new System.Drawing.Size(149, 26);
            // 
            // mnuCreateProj
            // 
            this.mnuCreateProj.Name = "mnuCreateProj";
            this.mnuCreateProj.Size = new System.Drawing.Size(148, 22);
            this.mnuCreateProj.Text = "Create Project";
            this.mnuCreateProj.Click += new System.EventHandler(this.mnuCreateProj_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer1.Size = new System.Drawing.Size(869, 504);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpTree
            // 
            this.grpTree.Controls.Add(this.trvMain);
            this.grpTree.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.trvMain.Location = new System.Drawing.Point(3, 16);
            this.trvMain.Name = "trvMain";
            treeNode2.ContextMenuStrip = this.cmsProj;
            treeNode2.Name = "Project";
            treeNode2.Text = "Project";
            this.trvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.trvMain.Size = new System.Drawing.Size(245, 485);
            this.trvMain.TabIndex = 0;
            this.trvMain.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvMain_NodeMouseDoubleClick);
            // 
            // tabs
            // 
            this.tabs.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedTabPage = this.tabProj;
            this.tabs.Size = new System.Drawing.Size(614, 504);
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
            this.tabProj.Name = "tabProj";
            this.tabProj.Size = new System.Drawing.Size(608, 476);
            this.tabProj.Text = "Project";
            // 
            // btnP_Save
            // 
            this.btnP_Save.Location = new System.Drawing.Point(12, 86);
            this.btnP_Save.Name = "btnP_Save";
            this.btnP_Save.Size = new System.Drawing.Size(75, 23);
            this.btnP_Save.TabIndex = 4;
            this.btnP_Save.Text = "Save";
            this.btnP_Save.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name:";
            // 
            // txtP_ProjName
            // 
            this.txtP_ProjName.Location = new System.Drawing.Point(120, 39);
            this.txtP_ProjName.Name = "txtP_ProjName";
            this.txtP_ProjName.Size = new System.Drawing.Size(283, 20);
            this.txtP_ProjName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project ID:";
            // 
            // txtP_ProjID
            // 
            this.txtP_ProjID.Location = new System.Drawing.Point(120, 13);
            this.txtP_ProjID.Name = "txtP_ProjID";
            this.txtP_ProjID.Size = new System.Drawing.Size(100, 20);
            this.txtP_ProjID.TabIndex = 0;
            // 
            // tabConn
            // 
            this.tabConn.Controls.Add(this.btnC_Save);
            this.tabConn.Controls.Add(this.label4);
            this.tabConn.Controls.Add(this.txtC_ConnName);
            this.tabConn.Controls.Add(this.label5);
            this.tabConn.Controls.Add(this.txtC_ConnID);
            this.tabConn.Controls.Add(this.txtC_ProjName);
            this.tabConn.Controls.Add(this.label3);
            this.tabConn.Controls.Add(this.txtC_ProjID);
            this.tabConn.Name = "tabConn";
            this.tabConn.Size = new System.Drawing.Size(608, 476);
            this.tabConn.Text = "Connection";
            // 
            // btnC_Save
            // 
            this.btnC_Save.Location = new System.Drawing.Point(16, 133);
            this.btnC_Save.Name = "btnC_Save";
            this.btnC_Save.Size = new System.Drawing.Size(75, 23);
            this.btnC_Save.TabIndex = 9;
            this.btnC_Save.Text = "Save";
            this.btnC_Save.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Connection Name:";
            // 
            // txtC_ConnName
            // 
            this.txtC_ConnName.Location = new System.Drawing.Point(120, 86);
            this.txtC_ConnName.Name = "txtC_ConnName";
            this.txtC_ConnName.Size = new System.Drawing.Size(283, 20);
            this.txtC_ConnName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Connection ID:";
            // 
            // txtC_ConnID
            // 
            this.txtC_ConnID.Location = new System.Drawing.Point(120, 60);
            this.txtC_ConnID.Name = "txtC_ConnID";
            this.txtC_ConnID.Size = new System.Drawing.Size(100, 20);
            this.txtC_ConnID.TabIndex = 5;
            // 
            // txtC_ProjName
            // 
            this.txtC_ProjName.Enabled = false;
            this.txtC_ProjName.Location = new System.Drawing.Point(226, 15);
            this.txtC_ProjName.Name = "txtC_ProjName";
            this.txtC_ProjName.ReadOnly = true;
            this.txtC_ProjName.Size = new System.Drawing.Size(283, 20);
            this.txtC_ProjName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project ID:";
            // 
            // txtC_ProjID
            // 
            this.txtC_ProjID.Enabled = false;
            this.txtC_ProjID.Location = new System.Drawing.Point(120, 15);
            this.txtC_ProjID.Name = "txtC_ProjID";
            this.txtC_ProjID.ReadOnly = true;
            this.txtC_ProjID.Size = new System.Drawing.Size(100, 20);
            this.txtC_ProjID.TabIndex = 2;
            // 
            // tabDev
            // 
            this.tabDev.Controls.Add(this.label8);
            this.tabDev.Controls.Add(this.textBox5);
            this.tabDev.Controls.Add(this.label9);
            this.tabDev.Controls.Add(this.textBox6);
            this.tabDev.Controls.Add(this.textBox3);
            this.tabDev.Controls.Add(this.label7);
            this.tabDev.Controls.Add(this.textBox4);
            this.tabDev.Controls.Add(this.textBox1);
            this.tabDev.Controls.Add(this.label6);
            this.tabDev.Controls.Add(this.textBox2);
            this.tabDev.Name = "tabDev";
            this.tabDev.Size = new System.Drawing.Size(608, 476);
            this.tabDev.Text = "Device";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Device Name:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(283, 20);
            this.textBox5.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Device ID:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(120, 89);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(226, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(283, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Connection ID:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(120, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(226, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Project ID:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(120, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // tabTag
            // 
            this.tabTag.Name = "tabTag";
            this.tabTag.Size = new System.Drawing.Size(608, 476);
            this.tabTag.Text = "Tag";
            // 
            // cmsConn
            // 
            this.cmsConn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createConnectionToolStripMenuItem});
            this.cmsConn.Name = "cmsConn";
            this.cmsConn.Size = new System.Drawing.Size(174, 26);
            // 
            // createConnectionToolStripMenuItem
            // 
            this.createConnectionToolStripMenuItem.Name = "createConnectionToolStripMenuItem";
            this.createConnectionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.createConnectionToolStripMenuItem.Text = "Create Connection";
            // 
            // cmsDevice
            // 
            this.cmsDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsDevice.Name = "cmsConn";
            this.cmsDevice.Size = new System.Drawing.Size(147, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem1.Text = "Create Device";
            // 
            // cmsTags
            // 
            this.cmsTags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTagToolStripMenuItem});
            this.cmsTags.Name = "cmsConn";
            this.cmsTags.Size = new System.Drawing.Size(132, 26);
            // 
            // createTagToolStripMenuItem
            // 
            this.createTagToolStripMenuItem.Name = "createTagToolStripMenuItem";
            this.createTagToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.createTagToolStripMenuItem.Text = "Create Tag";
            // 
            // frmTry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 504);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTry";
            this.Text = "frmTry";
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
            this.tabDev.ResumeLayout(false);
            this.tabDev.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem createConnectionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDevice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmsTags;
        private System.Windows.Forms.ToolStripMenuItem createTagToolStripMenuItem;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
    }
}