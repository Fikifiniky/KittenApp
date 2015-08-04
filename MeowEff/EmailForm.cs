using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace MeowEff
{
    public partial class EmailForm : Form
    {
        MySQL_c c = new MySQL_c();
        bool validemail;
        public EmailForm()
        {
            InitializeComponent();
            label1.Text = "Pokud chcete posílat novinky o koťátkách, tak \n napište svůj email";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpravnyEmail(tbMail.Text);
            if (validemail == true)
            {
            string em = tbMail.Text;
            string us = Environment.UserName;
            c = new MySQL_c();
            c.QUERY(String.Format("insert into subsemdb(email, username) values('{0}', '{1}')", em, us));
            MessageBox.Show("Odesláno");
            }


        }
        public bool SpravnyEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                validemail = true;
                return true;
            }
            catch (FormatException)
            {
                validemail = false;
                MessageBox.Show("Zadaná emailová adresa není ve správném formátu, zadejte platnou adresu a klikněte Potvrdit", "Neplatná emailová adresa");
                return false;
            }
        }
    }
}
