using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace iScada
{
    public partial class frmTry : Form
    {
        public frmTry()
        {
            InitializeComponent();
        }

        private void mnuCreateProj_Click(object sender, EventArgs e)
        {

        }

        private void frmTry_Load(object sender, EventArgs e)
        {
            loadTree();

            foreach (DevExpress.XtraTab.XtraTabPage t in tabs.TabPages)
            {
                t.PageVisible = false;
            }
        }

        private void loadTree()
        {
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
                                        " and DeviceID = " + dev.Tag.ToString() ;
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
            TreeNode tmp = e.Node;

            //MessageBox.Show("name: " + tmp.Name.ToString() + "text:" + tmp.Text.ToString() + " Tag:" + tmp.Tag.ToString());

            switch (tmp.Name.ToString())
            {
                case "proj":
                    tabProj.PageVisible = true;
                    tabs.SelectedTabPage = tabProj;
                    break;

                case "conn":
                    tabConn.PageVisible = true;
                    tabs.SelectedTabPage = tabConn;
                    break;

                case "dev":
                    tabDev.PageVisible = true;
                    tabs.SelectedTabPage = tabDev;
                    break;

                case "tag":
                    tabTag.PageVisible=true;
                    tabs.SelectedTabPage = tabTag;
                    break;
            }
        }

        private void tabs_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl xt = (DevExpress.XtraTab.XtraTabControl)sender;
            
        }
    }
}