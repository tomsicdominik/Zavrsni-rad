using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace email_enkripcija
{
    public partial class Main : Form
    {
        Person posiljatelj;
        public Main(Person Posiljatelj)
        {
            InitializeComponent();
            posiljatelj = Posiljatelj;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            bool crypto = false;
            if(inputToName.Text != "" &&
            inputToAdress.Text != "" &&
            inputSubject.Text != "" &&
            inputBody.Text != ""){
                string sadrzaj = inputBody.Text;
                if (checkBoxCrypto.Checked)
                {
                    crypto = true;
                }
                Person primatelj = new Person(inputToName.Text, inputToAdress.Text);
                SendMail posalji = new SendMail(posiljatelj, primatelj, inputSubject.Text, sadrzaj, true, crypto);
                posalji.Send();
                
                inputToName.Text = "";
                inputToAdress.Text = "";
                inputSubject.Text = "";
                inputBody.Text = "";

                
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Crypto crypto = new Crypto();
            crypto.Register(posiljatelj);
            string user = posiljatelj.Adress;
            int index = user.IndexOf("@");
            if (index > 0)
                user = user.Substring(0, index);
            DataTable table = new DataTable();
            table.Columns.Add("Pošiljatelj", typeof(string));
            table.Columns.Add("Subject", typeof(string));


            dgvMails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMails.MultiSelect = false;
            dgvMails.AllowUserToAddRows = false;
            dgvMails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;

            
            ReadMail citac = new ReadMail();
            List <OpenPop.Mime.Header.MessageHeader> mailovi = citac.FetchAllHeaders(posiljatelj.Host, posiljatelj.PortRead, true, user, posiljatelj.Password);
            foreach (var m in mailovi)
            {
                table.Rows.Add(m.From.ToString(), m.Subject.ToString());
            }
            dgvMails.DataSource = table;

            dgvMails.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMails.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            

        }

        private void btnShowMail_Click(object sender, EventArgs e)
        {
            ShowMail citaj = new ShowMail(dgvMails.CurrentCell.RowIndex, posiljatelj);
            citaj.ShowDialog();
        }
    }
}
