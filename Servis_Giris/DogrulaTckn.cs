using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servis_Giris.KpsServiceReference;




namespace Servis_Giris
{
    public partial class DogrulaTckn : Form
    {
        public DogrulaTckn()
        {
            InitializeComponent();
        }

        private void DogrulaTckn_Load(object sender, EventArgs e)
        {


        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            long tckn = Convert.ToInt64(mskdTcknTxt.Text);
            string isim = txtisim.Text.ToUpper();
            string soyisim = txtSoyisim.Text.ToUpper();
            int dogumyili = Convert.ToInt32(mskdDgmYili.Text);

            KPSPublicSoapClient client = new KPSPublicSoapClient();

           bool sonuc = client.TCKimlikNoDogrula(tckn, isim, soyisim, dogumyili);

            if(sonuc)
            {

                MessageBox.Show("Tc No Dogru");
            }

            else
            {

                MessageBox.Show("Tc No Yanlıs");

            }


        }
    }
}
