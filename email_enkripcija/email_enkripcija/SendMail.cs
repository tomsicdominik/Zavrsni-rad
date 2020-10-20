using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net;
using System.Net.Mail;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace email_enkripcija
{
    class SendMail
    {
        public Person Sender { get; set; }
        public Person Reciever { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool SSL { get; set; }
        public bool Crypto { get; set; }

        public SendMail(Person sender, Person reciever, string subject, string body, bool ssl, bool crypto)
        {
            Sender = sender;
            Reciever = reciever;
            Subject = subject;
            Body = body;
            SSL = ssl;
            Crypto = crypto;
        }

        public bool Send()
        {
            if (Crypto)
            {

                Crypto crypto = new Crypto(Body);
                Body = crypto.Encrypt( Sender, Reciever);
                if (Body == "")
                {
                    MessageBox.Show("Primatelj nije registriran u Crypto sustav!");
                    return false;
                }
                
            }


            MailAddress from_address = new MailAddress(Sender.Adress, Sender.Name);
            MailAddress to_address = new MailAddress(Reciever.Adress, Reciever.Name);
            MailMessage message = new MailMessage(Sender.Adress, Reciever.Adress);
            message.Subject = Subject;
            message.Body = Body;
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient()
            {
                Host = Sender.Host,
                Port = Sender.PortSend,
                EnableSsl = SSL,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(from_address.Address, Sender.Password),
            };
            client.Send(message);
            if (Reciever.Adress != "root@dodocrypts.com")
            {
                MessageBox.Show("Poruka je poslana");
            }
            return true;
        }
    }


}
