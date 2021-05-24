using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;

namespace messageQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdEnviar_Click(object sender, EventArgs e)
        {
            MessageQueue mq = new MessageQueue(@".\private$\testQueue");
            mq.Send(txtMensajeEnvio.Text);
        
        }

        private void cmdRecibir_Click(object sender, EventArgs e)
        {
            MessageQueue mq = new MessageQueue(@".\private$\testQueue");
            mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });
            System.Messaging.Message msj = mq.Receive();
            rtbMensajesRecibidos.Text += msj.Body.ToString()+"\r\n";
        }
    }
}
