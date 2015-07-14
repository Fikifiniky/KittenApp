using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MeowEff
{
    public partial class Meow : Form
    {
        SoundPlayer kawaiplayer = new SoundPlayer(Properties.Resources.meow);
        public Meow()
        {
            InitializeComponent();
            btnNapoveda.BackgroundImage = Properties.Resources.btnNapoveda_ico;
            label1.BackColor = Color.Transparent;
            lbAktualniInt.BackColor = Color.Transparent;
            btnMeowStart.Enabled = false;
            btnInstaMeow.Enabled = false;
            btnMeowStop.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kawaiplayer.Play();
        }

        private void btnMeowStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnInstaMeow_Click(object sender, EventArgs e)
        {
            kawaiplayer.Play();
        }

        private void btnMeowStop_Click(object sender, EventArgs e)
        {
            kawaiplayer.Stop();
            timer1.Stop();
        }

        private void tbInterval_TextChanged(object sender, EventArgs e)
        {
            string fujpismena = tbInterval.Text;
            if (fujpismena.Trim() == "") return;
            for (int i = 0; i < fujpismena.Length; i++)
            {
                if (!char.IsNumber(fujpismena[i]))
                {
                    tbInterval.Text = "";
                    return;
                }

            }
        }

        private void btnPotvrdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbInterval.Text == String.Empty)
                {
                    throw new Exception("Zadej interval");
                }
                if (int.Parse(tbInterval.Text) <= 7)
                {
                    throw new Exception("Interval musí být VÍCE, než 7 sekund");
                }

                int interval = int.Parse(tbInterval.Text) * 1000; // precte a prevede na milisekundy

                timer1.Interval = interval;

                btnInstaMeow.Enabled = true; // povoli tlacitka
                btnMeowStart.Enabled = true;
                btnMeowStop.Enabled = true;

                lbAktualniInt.Text = string.Format("Aktuální interval: {0} sekund", interval / 1000); // vypise info o intervalu
            }
            
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
                tbInterval.Text = String.Empty;
            }
        }

        private void btnNapoveda_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.Show();
        }
    }
}
