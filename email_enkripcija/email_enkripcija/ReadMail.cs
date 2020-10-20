using OpenPop.Mime;
using OpenPop.Mime.Header;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace email_enkripcija
{
    class ReadMail
    {

        public Message FetchMailByIndex(int index, string hostname, int port, bool useSsl, string username, string password)
        {
            using (Pop3Client client = new Pop3Client())
            {
                client.Connect(hostname, port, useSsl);
                client.Authenticate(username, password);
                int messageCount = client.GetMessageCount();
                Message Read = client.GetMessage(index);
                return Read;
            }
        }

        public int GetNumberOFMessages(string hostname, int port, bool useSsl, string username, string password)
        {
            int count=0;
            using (Pop3Client client = new Pop3Client())
            {
                client.Connect(hostname, port, useSsl);
                client.Authenticate(username, password);
                count = client.GetMessageCount();
            }

                return count;
        }

        public static void DeleteMessageOnServer(string hostname, int port, bool useSsl, string username, string password, int messageNumber)
        {
            using (Pop3Client client = new Pop3Client())
            {
                client.Connect(hostname, port, useSsl);
                client.Authenticate(username, password);
                client.DeleteMessage(messageNumber);
            }
        }

        public List<MessageHeader>  FetchAllHeaders(string hostname, int port, bool useSsl, string username, string password)
        {
            using (Pop3Client client = new Pop3Client())
            {
                client.Connect(hostname, port, useSsl);
                client.Authenticate(username, password);
                int messageCount = client.GetMessageCount();
                List<MessageHeader> allMessages = new List<MessageHeader>(messageCount);
                for (int i = messageCount; i > messageCount- 50; i--)
                {
                    MessageHeader headers = client.GetMessageHeaders(i);
                    allMessages.Add(headers);
                }
                return allMessages;





            }
        }
    }
}
