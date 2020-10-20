using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Mime;

namespace email_enkripcija
{
    public partial class ShowMail : Form
    {
        public int Index { get; set; }
        public Person Korisnik { get; set; }

        public ShowMail(int broj, Person korisnik)
        {
            InitializeComponent();
            Index = broj;
            Korisnik = korisnik;

            ReadMail poruka = new ReadMail();
            string user = Korisnik.Adress;
            int index = user.IndexOf("@");
            if (index > 0)
                user = user.Substring(0, index);
            Index = poruka.GetNumberOFMessages(Korisnik.Host, Korisnik.PortRead, true, user, Korisnik.Password)-Index;
            OpenPop.Mime.Message procitano = poruka.FetchMailByIndex(Index, Korisnik.Host, Korisnik.PortRead, true, user, Korisnik.Password);
            labelFrom.Text = procitano.Headers.From.ToString();
            labelSubject.Text = procitano.Headers.Subject.ToString();
            //StringBuilder prikazi = new StringBuilder();
            OpenPop.Mime.MessagePart sadrzaj = procitano.FindFirstPlainTextVersion();
            if (sadrzaj != null)
            {
                //prikazi.Append();
                string Poruka = sadrzaj.GetBodyAsText();
                if (Poruka.Contains("#CRYPTO#"))
                {
                    Crypto crypto = new Crypto(Poruka);
                    Poruka = crypto.Decrypt(korisnik);
                }
                labelContent.Text = Poruka;
            }
            




        }
    }
}
