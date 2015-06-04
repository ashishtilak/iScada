using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Net;

namespace iScada
{
    public partial class frmTry : Form
    {
        public frmTry()
        {
            InitializeComponent();
        }

        private void btnC_Save_Click(object sender, EventArgs e)
        {
            if (txtC_ConnName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter connection name");
                txtC_ConnName.Focus();
                return;
            }
            try
            {
                using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
                {
                    cn.Open();
                    string q = "";
                    if (btnC_Save.Text == "Create")
                        q = "insert into MastConn (ProjectID, ConnID, ConnName, ConnTypeID) " +
                                "values (" +
                                txtC_ProjID.Text + ", " +
                                txtC_ConnID.Text + ", '" +
                                txtC_ConnName.Text + "', " +
                                txtC_ConnType.EditValue.ToString() + ")" ;
                    else
                        q = "update MastConn set " +
                             " ConnName = '" + txtC_ConnName.Text.Trim() + "' " +
                             "where ProjectID = " + txtC_ProjID.Text +
                             " and ConnID = " + txtC_ConnID.Text ;


                    MySqlCommand cmd = new MySqlCommand(q, cn);
                    int i = cmd.ExecuteNonQuery();

                    btnC_Save.Text = "Save";
                    txtC_ConnType.Enabled = false;

                    loadTree();
                    MessageBox.Show("Updated.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnD_Save_Click(object sender, EventArgs e)
        {
            if (txtD_DeviceName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter device name");
                txtD_DeviceName.Focus();
                return;
            }
            try
            {
                using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
                {
                    cn.Open();
                    string q = "";
                    if (btnD_Save.Text == "Create")
                        q = "insert into MastDevice (ProjectID, ConnID, DeviceID, DeviceName, TimeOut, Delay, " +
                                "MB_IP, MB_Port, MB_SlaveAddress" +
                                " ) " +
                                "values (" + txtD_ProjID.Text + ", " +
                                txtD_ConnID.Text + ", " +
                                txtD_DeviceID.Text + ", " +
                                "'" + txtD_DeviceName.Text.Trim() + "', " +
                                txtD_Timeout.Text + ", " +
                                txtD_Delay.Text + ", " +
                                "'" + txtD_MB_IP.Text + "', " +
                                txtD_MB_Port.Text + ", " +
                                txtD_MB_SlaveAddress.Text +
                                " )";
                    else
                        q = "update MastDevice set " +
                            "DeviceName = '" + txtD_DeviceName.Text.Trim() + "', " +
                            "Timeout = " + txtD_Timeout.Text + ", " +
                            "Delay = " + txtD_Delay.Text + ", " +
                            "MB_IP = '" + txtD_MB_IP.Text + "', " +
                            "MB_Port = " + txtD_MB_Port.Text + ", " +
                            "MB_SlaveAddress = " + txtD_MB_SlaveAddress.Text + " " +
                            "where DeviceID = " + txtD_DeviceID.Text + "";


                    MySqlCommand cmd = new MySqlCommand(q, cn);
                    int i = cmd.ExecuteNonQuery();

                    btnD_Save.Text = "Save";

                    loadTree();
                    MessageBox.Show("Updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnP_Save_Click(object sender, EventArgs e)
        {
            if (txtP_ProjName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter project name");
                txtP_ProjName.Focus();
                return;
            }

            try
            {
                using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
                {
                    cn.Open();
                    string q = "";
                    if (btnP_Save.Text == "Create")
                        q = "insert into MastProject (ProjectID, ProjectName) " +
                                "values (" + txtP_ProjID.Text + ", '" + txtP_ProjName.Text.Trim() + "')";
                    else
                        q = "update MastProject set ProjectName = '" + txtP_ProjName.Text.Trim() + "' where ProjectID = " + txtP_ProjID.Text;


                    MySqlCommand cmd = new MySqlCommand(q, cn);
                    int i = cmd.ExecuteNonQuery();

                    btnP_Save.Text = "Save";

                    loadTree();
                    MessageBox.Show("Updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnT_Save_Click(object sender, EventArgs e)
        {
            if (txtT_TagName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Tag name");
                txtT_TagName.Focus();
                return;
            }

            try
            {
                using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
                {
                    cn.Open();
                    string q = "";
                    if (btnT_Save.Text == "Create")
                        q = "insert into MastTag (ProjectID, ConnID, DeviceID, " +
                            "TagID, TagName, UOM, DataType, " + 
                            "MBRegType, MBRegAddress, MBRegCount" +
                            ") " +
                            "values (" 
                            + txtT_ProjID.Text + ", " 
                            + txtT_ConnID.Text + ", "
                            + txtT_DeviceID.Text + ", "
                            + txtT_TagID.Text + ", "
                            + "'" + txtT_TagName.Text + "', " 
                            + "'" + txtT_UOM.Text + "', "
                            + "'" + txtT_Datatype.Text + "', "
                            + txtT_RegTypeID.EditValue.ToString() + ", "
                            + txtT_RegAddress.Text + ", "
                            + txtT_RegCount.Text + " "
                            + ")";
                    else
                        q = "update MastTag set " +
                            "TagName = '" + txtT_TagName.Text.Trim() + "', "
                            + "UOM = '" + txtT_UOM.Text + "', "
                            + "Datatype = '" + txtT_Datatype.Text + "', "
                            + "MBRegType = " + txtT_RegTypeID.EditValue.ToString() + ", "
                            + "MBRegAddress = " + txtT_RegAddress.Text + ", "
                            + "MBRegCount = " + txtT_RegCount.Text + " "
                            + "where TagID = " + txtT_TagID.Text;


                    MySqlCommand cmd = new MySqlCommand(q, cn);
                    int i = cmd.ExecuteNonQuery();

                    btnP_Save.Text = "Save";

                    loadTree();
                    MessageBox.Show("Updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmTry_Load(object sender, EventArgs e)
        {
            loadTree();
            loadConnType();
            loadRegType();

            foreach (DevExpress.XtraTab.XtraTabPage t in tabs.TabPages)
            {
                t.PageVisible = false;
            }
        }

        /// <summary>
        /// Load connection of a project
        /// </summary>
        /// <param name="proj"></param>
        private void loadConn(TreeNode proj)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr.ToString()))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select ConnID, ConnName from MastConn where ProjectID = " + proj.Tag.ToString();
                    cmd.Connection = cn;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TreeNode conn = new TreeNode();
                        conn.Text = dr[1].ToString();
                        conn.Name = "conn";
                        conn.Tag = dr[0].ToString();
                        conn.ContextMenuStrip = cmsDevice;          //attach context menu

                        loadDevice(proj, conn);                     //load devices of the connection

                        proj.Nodes.Add(conn);                       //add to tree
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadConnType()
        {
            using(MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
            {
                try
                {
                    cn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("Select ConnTypeID, ConnType from KDSConnType", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "RESULT");

                    BindingSource bs = new BindingSource();
                    bs.DataSource = ds;
                    bs.DataMember = "RESULT";

                    txtC_ConnType.DataBindings.Add("EditValue", bs, "ConnTypeID");
                    txtC_ConnType.Properties.DataSource = bs;


                    txtC_ConnType.Properties.DisplayMember = "ConnType";
                    txtC_ConnType.Properties.ValueMember = "ConnTypeID";
                    txtC_ConnType.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void loadConnValues()
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
            {
                try
                {
                    cn.Open();
                    string qry = "select * from v_conn " +
                                    "where ProjectID = " + txtC_ProjID.Text + " and ConnID = " + txtC_ConnID.Text;
                    MySqlCommand cmd = new MySqlCommand(qry, cn);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        txtC_ConnName.Text = dr["ConnName"].ToString();
                        txtC_ConnType.EditValue = dr["ConnTypeID"];
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void loadDevice(TreeNode proj, TreeNode conn)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr.ToString()))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select DeviceID, DeviceName from MastDevice where ProjectID = " + proj.Tag.ToString() +
                                        " and ConnID = " + conn.Tag.ToString();
                    cmd.Connection = cn;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TreeNode dev = new TreeNode();
                        dev.Text = dr[1].ToString();
                        dev.Name = "dev";
                        dev.Tag = dr[0].ToString();
                        loadTags(proj, conn, dev);
                        dev.ContextMenuStrip = cmsTags;
                        conn.Nodes.Add(dev);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadDeviceValues()
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
            {
                try
                {
                    cn.Open();
                    string qry = "select * from v_dev " +
                                 "where DeviceID = " + txtD_DeviceID.Text + "";
                    MySqlCommand cmd = new MySqlCommand(qry, cn);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        txtD_DeviceName.Text = dr["DeviceName"].ToString();
                        txtD_Timeout.Text = dr["Timeout"].ToString();
                        txtD_Delay.Text = dr["Delay"].ToString();

                        //MODBUS Ethernet
                        txtD_MB_IP.Text = dr["IP"].ToString();
                        txtD_MB_Port.Text = dr["Port"].ToString();
                        txtD_MB_SlaveAddress.Text = dr["SlaveAddress"].ToString();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void loadRegType()
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
            {
                try
                {
                    cn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("Select RegTypeID, RegName from KDSRegtype", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "RESULT");

                    BindingSource bs = new BindingSource();
                    bs.DataSource = ds;
                    bs.DataMember = "RESULT";

                    txtT_RegTypeID.DataBindings.Add("EditValue", bs, "RegTypeID");
                    txtT_RegTypeID.Properties.DataSource = bs;

                    txtT_RegTypeID.Properties.DisplayMember = "RegName";
                    txtT_RegTypeID.Properties.ValueMember = "RegTypeID";
                    txtT_RegTypeID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        /// <summary>
        /// Load Tags in tree view.
        /// </summary>
        /// <param name="proj"></param>
        /// <param name="conn"></param>
        /// <param name="dev"></param>
        private void loadTags(TreeNode proj, TreeNode conn, TreeNode dev)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr.ToString()))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select TagID, TagName from MastTag where ProjectID = " + proj.Tag.ToString() +
                                        " and ConnID = " + conn.Tag.ToString() +
                                        " and DeviceID = " + dev.Tag.ToString();
                    cmd.Connection = cn;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TreeNode tag = new TreeNode();
                        tag.Text = dr[1].ToString();
                        tag.Name = "tag";
                        tag.Tag = dr[0].ToString();

                        dev.Nodes.Add(tag);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadTagValues()
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
            {
                try
                {
                    cn.Open();
                    string qry = "select * from v_tag " +
                                 "where TagID = " + txtT_TagID.Text + "";
                    MySqlCommand cmd = new MySqlCommand(qry, cn);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        txtT_TagName.Text = dr["TagName"].ToString();
                        txtT_UOM.Text = dr["UOM"].ToString();
                        txtT_Datatype.Text = dr["datatype"].ToString();

                        //MODBUS Ethernet
                        txtT_RegTypeID.EditValue = dr["RegTypeID"];
                        txtT_RegAddress.Text = dr["RegAddress"].ToString();
                        txtT_RegCount.Text = dr["RegCount"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void loadTree()
        {
            //clear tree

            trvMain.Nodes.Clear();

            TreeNode n = new TreeNode("Project");
            n.Text = "Project";
            n.Tag = "Project";
            n.Name = "Project";
            n.ContextMenuStrip = cmsProj;

            trvMain.Nodes.Add(n);

            //connect to mysql
            try
            {
                using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr.ToString()))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select ProjectID, ProjectName from mastProject";
                    cmd.Connection = cn;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TreeNode proj = new TreeNode();
                        proj.Text = dr[1].ToString();
                        proj.Name = "proj";
                        proj.Tag = dr[0].ToString();
                        proj.ContextMenuStrip = cmsConn;            //add context menu

                        loadConn(proj);                             //load connections of project

                        trvMain.Nodes.Add(proj);                    //add to tree
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mnuCreateConn_Click(object sender, EventArgs e)
        {
            tabConn.PageVisible = true;
            tabs.SelectedTabPage = tabConn;

            //get max conn number

            using(MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr) )
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("Select ifNull(max(ConnID),1)+1 from MastConn ", cn);
                object i = cmd.ExecuteScalar();

                txtC_ConnID.Text = i.ToString();
            }

            txtC_ProjID.Text = trvMain.SelectedNode.Tag.ToString();
            txtC_ProjName.Text = trvMain.SelectedNode.Text;
            txtC_ConnName.Text = "";
            txtC_ConnName.Focus();
            txtC_ConnType.Enabled = true;
            btnC_Save.Text = "Create";
        }

        private void mnuCreateDevice_Click(object sender, EventArgs e)
        {
            tabDev.PageVisible = true;
            tabs.SelectedTabPage = tabDev;

            //get max device number

            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("Select ifNull(max(DeviceID),1)+1 from MastDevice ", cn);
                object i = cmd.ExecuteScalar();

                txtD_DeviceID.Text = i.ToString();
            }

            txtD_ProjID.Text = trvMain.SelectedNode.Parent.Tag.ToString();
            txtD_ProjName.Text = trvMain.SelectedNode.Parent.Text;
            txtD_ConnID.Text = trvMain.SelectedNode.Tag.ToString();
            txtD_ConnName.Text = trvMain.SelectedNode.Text;
            txtD_DeviceName.Text = "";
            txtD_Timeout.Text = "";

            txtD_Delay.Text = "";
            txtD_MB_IP.Text = "";
            txtD_MB_Port.Text = "";
            txtD_MB_SlaveAddress.Text = "";
            
            btnD_Save.Text = "Create";
            txtD_DeviceName.Focus();
        }

        private void mnuCreateProj_Click(object sender, EventArgs e)
        {
            tabProj.PageVisible = true;
            tabs.SelectedTabPage = tabProj;

            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("Select ifNull(max(ProjectID),1)+1 from MastProject ", cn);
                object i = cmd.ExecuteScalar();

                txtP_ProjID.Text = i.ToString();
            }


            txtP_ProjName.Text = "";
            txtP_ProjID.Focus();
            btnP_Save.Text = "Create";
        }

        private void mnuCreateTag_Click(object sender, EventArgs e)
        {
            tabTag.PageVisible = true;
            tabs.SelectedTabPage = tabTag;

            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("Select ifNull(max(TagID),1)+1 from MastTag ", cn);
                object i = cmd.ExecuteScalar();

                txtT_TagID.Text = i.ToString();
            }


            TreeNode D = trvMain.SelectedNode;
            TreeNode C = D.Parent;
            TreeNode P = C.Parent;

            txtT_ProjID.Text = P.Tag.ToString();
            txtT_ProjName.Text = P.Text;
            txtT_ConnID.Text = C.Tag.ToString();
            txtT_ConnName.Text = C.Text;
            txtT_DeviceID.Text = D.Tag.ToString();
            txtT_DeviceName.Text = D.Text;

            txtT_TagName.Text = "";
            txtT_UOM.Text = "";
            txtT_Datatype.Text = "";
            txtT_RegAddress.Text = "";
            txtT_RegCount.Text = "";

            btnT_Save.Text = "Create";
            txtT_TagName.Focus();
        }

        private void tabs_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            (arg.Page as DevExpress.XtraTab.XtraTabPage).PageVisible = false;
        }

        private void trvMain_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!e.Node.IsExpanded)
            {
                e.Node.Expand();
            }
            else
            {
                e.Node.Collapse();
            }

            //on double click... open appropriate tab on right
            TreeNode tn = e.Node;

            //MessageBox.Show("name: " + tmp.Name.ToString() + "text:" + tmp.Text.ToString() + " Tag:" + tmp.Tag.ToString());

            switch (tn.Name.ToString())
            {
                case "proj":
                    tabProj.PageVisible = true;
                    tabs.SelectedTabPage = tabProj;
                    txtP_ProjID.Text = tn.Tag.ToString();
                    txtP_ProjName.Text = tn.Text.ToString();
                    break;

                case "conn":
                    tabConn.PageVisible = true;
                    tabs.SelectedTabPage = tabConn;

                    TreeNode pj = tn.Parent;
                    txtC_ProjID.Text = pj.Tag.ToString();
                    txtC_ProjName.Text = pj.Text.ToString();
                    txtC_ConnID.Text = tn.Tag.ToString();

                    //proc to load textboxes from db
                    loadConnValues();

                    break;

                case "dev":
                    tabDev.PageVisible = true;
                    tabs.SelectedTabPage = tabDev;

                    txtD_DeviceID.Text = tn.Tag.ToString();
                    txtD_DeviceName.Text = tn.Text.ToString();

                    TreeNode dcn = tn.Parent;
                    txtD_ConnID.Text = dcn.Tag.ToString();
                    txtD_ConnName.Text = dcn.Text.ToString();

                    TreeNode dpj = dcn.Parent;
                    txtD_ProjID.Text = dpj.Tag.ToString();
                    txtD_ProjName.Text = dpj.Text.ToString();

                    //proc to load textboxes from db
                    loadDeviceValues();
                    break;

                case "tag":
                    tabTag.PageVisible = true;
                    tabs.SelectedTabPage = tabTag;

                    txtT_TagID.Text = tn.Tag.ToString();
                    txtT_TagName.Text = tn.Text.ToString();

                    TreeNode tdev = tn.Parent;
                    txtT_DeviceID.Text = tdev.Tag.ToString();
                    txtT_DeviceName.Text = tdev.Text.ToString();

                    TreeNode tcn = tdev.Parent;
                    txtT_ConnID.Text = tcn.Tag.ToString();
                    txtT_ConnName.Text = tcn.Text.ToString();

                    TreeNode tpj = tcn.Parent;
                    txtT_ProjID.Text = tpj.Tag.ToString();
                    txtT_ProjName.Text = tpj.Text.ToString();

                    loadTagValues();
                    break;
            }
        }

        private void txtD_MB_IP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IPAddress add;
            if (!IPAddress.TryParse(txtD_MB_IP.Text, out add))
            {
                MessageBox.Show("Invalid IP address.");
                e.Cancel = true;
            }
            else
                txtD_MB_IP.Text = add.ToString();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            frmConn f = new frmConn();
            f.Show();
        }
    }
}