using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using InfiniteRemotingServer2;

namespace RemoteClient2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            TcpChannel t1 = new TcpChannel(8003);
            ChannelServices.RegisterChannel(t1);

            //create a service class object
            InfiniteServer2 services = (InfiniteServer2)Activator.GetObject(typeof
                        (InfiniteServer2), "http://localhost:101/OurRemoteService1");
            //start making calls to the remote object
            //int res=services.WriteData(x, y);
            string z = services.WriteData(x, y).ToString();
            label3.Text = z;



        }
    }
}
