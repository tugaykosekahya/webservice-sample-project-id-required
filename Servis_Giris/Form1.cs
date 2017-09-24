using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servis_Giris.UrunServiceReferance;

namespace Servis_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunlerServisSoapClient client = new UrunlerServisSoapClient();
            string message = client.HelloWorld();
            MessageBox.Show(message);            
        }
    }
}
