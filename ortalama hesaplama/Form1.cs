using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, not4, durum;

            not1 = Convert.ToDouble(txtNot1.Text);
            not2 = Convert.ToDouble(txtNot2.Text);
            not3 = Convert.ToDouble(txtNot2.Text);
            not4 = Convert.ToDouble(txtNot4.Text);
            durum = (not1 + not2 + not3 + not4) / 4;

            if (durum < 50)
            {
                lblDurum.Text = "Kaldı :";
            }
            
            else if (durum > 50 & durum < 70)
            {
                lblDurum.Text = "Geçti :";
            }

            else if (durum >= 70 & durum < 84)
            {
                lblDurum.Text = "Teşekkür belgesi :";
            }

            else if (durum >= 85 & durum < 100)
            {
                lblDurum.Text = "Takdir belgesi :";
            }
        }
    }
}
