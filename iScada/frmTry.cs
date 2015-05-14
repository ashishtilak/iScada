using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace iScada
{
    public partial class frmTry : Form
    {
        public frmTry()
        {
            InitializeComponent();
        }

        private void frmTry_Load(object sender, EventArgs e)
        {
            loadTree();

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
                    break;

                case "tag":
                    tabTag.PageVisible = true;
                    tabs.SelectedTabPage = tabTag;

                    TreeNode tdev = tn.Parent;
                    txtT_DeviceID.Text = tdev.Tag.ToString();
                    txtT_DeviceName.Text = tdev.Text.ToString();

                    TreeNode tcn = tdev.Parent;
                    txtT_ConnID.Text = tcn.Tag.ToString();
                    txtT_ConnName.Text = tcn.Text.ToString();

                    TreeNode tpj = tcn.Parent;
                    txtT_ProjID.Text = tpj.Tag.ToString();
                    txtT_ProjName.Text = tpj.Text.ToString();
                    break;
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
                    string q ="";
                    if (btnP_Save.Text == "Create")
                        q = "insert into MastProject (ProjectID, ProjectName) " +
                                "values (" + txtP_ProjID.Text + ", '" + txtP_ProjName.Text.Trim() + "')";
                    else
                        q = "update MastProject set ProjectName = '" + txtP_ProjName.Text.Trim() + "' where ProjectID = " + txtP_ProjID.Text;


                    MySqlCommand cmd = new MySqlCommand(q, cn);
                    int i = cmd.ExecuteNonQuery();

                    btnP_Save.Text = "Save";

                    loadTree();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}