using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace email_enkripcija
{
    public class Person
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int PortSend { get; set; }
        public int PortRead { get; set; }

        public Person (string name, string adress, string password, string host, int portSend, int portRead)
        {
            Name = name;
            Adress = adress;
            Password = password;
            Host = host;
            PortSend = portSend;
            PortRead = portRead;
        }
        public Person (string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
    }
}
