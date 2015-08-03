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
using System.Diagnostics;

namespace MeowEff
{
    public partial class Meow : Form
    {
        SoundPlayer kawaiplayer = new SoundPlayer(Properties.Resources.meow);
        public Meow()
        {
            InitializeComponent();
            btnNapoveda.BackgroundImage = Properties.Resources.btnNapoveda_ico;     //ikona
            label1.BackColor = Color.Transparent;   //pozdai lb (nevim ktereho a k cemu vubec je)
            lbAktualniInt.BackColor = Color.Transparent;
            btnMeowStart.Enabled = false; //nasledujici tri radky vypinaji tlacitka, jelikoz jsem linej je vypnout defaultne v jejich properties
            btnInstaMeow.Enabled = false;
            btnMeowStop.Enabled = false;
            this.KeyDown += new KeyEventHandler(Press); //vytvori udalost pri zmacknuti klavesy
            //this.KeyUp += new KeyEventHandler(Release); //vytvori udalost pri odmacknuti klavesy
            this.KeyPreview = true;

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

                if (tbInterval.Text == String.Empty) // kontrola blbosti uzviatele
                {
                    throw new Exception("Zadej interval");
                }
                if (int.Parse(tbInterval.Text) <= 7) //schvalne, kolik lidi se dokaze nachytat na slova "VÍCE" a "NEŽ"
                {
                    throw new Exception("Interval musí být VÍCE, než 7 sekund");
                }

                int interval = int.Parse(tbInterval.Text) * 1000; // precte a prevede na milisekundy

                timer1.Interval = interval;

                btnInstaMeow.Enabled = true; // povoli tlacitka
                btnMeowStart.Enabled = true;
                btnMeowStop.Enabled = true;

                lbAktualniInt.Text = string.Format("Aktuální interval: {0} sekund", interval / 1000); // vypise info o intervalu   PS. String Format je moc mainstream
            }
            
            catch (Exception exception) //chyba
            {
                MessageBox.Show(exception.Message);
                tbInterval.Text = String.Empty;
            }
        }

        private void btnNapoveda_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.Show();
        }
        private void Press(object sender, KeyEventArgs e) //keydown metoda
        {
            switch (e.KeyCode) //toto snad neni potreba komentovat
            {
                case Keys.F1:
                    Process.Start("http://knowyourmeme.com/memes/i-should-buy-a-boat-cat");
                    break;
                case Keys.F2:
                    Process.Start("http://www.wikihow.com/Take-Care-of-Kittens");
                    break;
                case Keys.F3:
                    Process.Start("https://www.reddit.com/r/cute/");
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
    }
}
