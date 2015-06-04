using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Sockets;
using Modbus.Device;
using System.Timers;


namespace iScada
{
    public partial class frmConn : Form
    {
        private System.Timers.Timer _t;

        public frmConn()
        {
            InitializeComponent();
        }

        private void frmConn_Load(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
            {
                try
                {
                    cn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("Select TagID, TagName, IP from v_Tag", cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "RESULT");

                    BindingSource bs = new BindingSource();
                    bs.DataSource = ds;
                    bs.DataMember = "RESULT";

                    txtTag.DataBindings.Add("EditValue", bs, "TagID");
                    txtTag.Properties.DataSource = bs;


                    txtTag.Properties.DisplayMember = "TagName";
                    txtTag.Properties.ValueMember = "TagID";
                    txtTag.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtTag_EditValueChanged(object sender, EventArgs e)
        {
            using(MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.cnStr))
            {
                try
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from v_tag where tagid =" + txtTag.EditValue.ToString(), cn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        txtIP.Text = dr["IP"].ToString();
                        txtRegAdd.Text = dr["RegAddress"].ToString();
                        txtSlaveID.Text = dr["SlaveAddress"].ToString();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _t = new System.Timers.Timer();
            _t.Interval = 500;
            _t.AutoReset = true;
            _t.Elapsed += DelReadHoldingRegister;

            _t.Start();
        }

        //Timer Elapsed event handler
        private void DelReadHoldingRegister(Object sender, System.Timers.ElapsedEventArgs args)
        {
            _t.Stop();

            ReadHoldingRegister();

            _t.Interval = 500;
            _t.Start();
        }

        //function for reading holding register
        private void ReadHoldingRegister()
        {
            if(InvokeRequired)
            {
                MethodInvoker invoker = delegate { ReadHoldingRegister() ; };
                Invoke(invoker);
                return;
            }

            using (TcpClient client = new TcpClient(txtIP.Text, 502))
            {
                try
                {
                    ModbusIpMaster master = ModbusIpMaster.CreateIp(client);
                    ushort StartAddress = Convert.ToUInt16(txtRegAdd.Text);
                    ushort RegisterCount = Convert.ToUInt16("2");
                    byte SlaveAddress = Convert.ToByte("1");

                    ushort[] values = master.ReadHoldingRegisters(SlaveAddress, StartAddress, RegisterCount);

                    foreach (ushort i in values)
                    {
                        txtResult.Text += DateTime.Now.ToString() + " " + i.ToString() + ";\r\n";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _t.Stop();
            _t.Dispose();
        }
    }
}
