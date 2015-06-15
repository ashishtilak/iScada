using System;
using System.Windows.Forms;
using System.Threading;
using NetMQ;
using NetMQ.Sockets;
using Newtonsoft.Json;

namespace iScada
{
    public partial class frmConn : Form
    {
        private int _tagID;

        // TODO: Msg class to be changed as per Tag class sent from iScadaPublisher
        public class msg
        {
            public string data;
            public string dt;
            public int id;
            public string name;
            public int state;
            public msg()
            {
                dt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        Thread _t;

        public frmConn(int tagID)
        {
            _tagID = tagID;
            InitializeComponent();

            _t = new Thread(t_Elapsed);
            _t.Start();
        }

        private void frmConn_Load(object sender, EventArgs e)
        {
            //
        }

        void t_Elapsed()
        {
            NetMQContext ctx = NetMQContext.Create();
            NetMQSocket socket = ctx.CreateSubscriberSocket();

            // TODO: change socket connection ip, port
            socket.Connect("tcp://172.16.12.188:5555");
            socket.Subscribe(_tagID.ToString("000"));

            socket.ReceiveReady += (s, a) =>
                {
                    string topic = socket.ReceiveString();
                    string message = socket.ReceiveString();

                    msg m = JsonConvert.DeserializeObject<msg>(message);
                    
                    WriteText(m);
                    //Application.DoEvents();
                };

            Poller poller = new Poller();
            poller.AddSocket(socket);
            poller.Start();
        }

        public void WriteText(msg value)
        {
            if(InvokeRequired)
            {
                this.Invoke(new Action<msg>(WriteText), new object[] { value });
                return;
            }

            stateIndicatorComponent1.StateIndex = value.state;
            txtVal.Text = value.data.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _t.Abort();
            this.Close();
        }
    }
}