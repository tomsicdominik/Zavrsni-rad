using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.IO;

namespace email_enkripcija
{
    class Crypto
    {
        public string Poruka { get; set; }
        public Crypto()
        {

        }
        
        public Crypto(string poruka)
        {
            Poruka = poruka;
        }

        public string Encrypt(Person Sender, Person Reciever)
        {
            byte[] alicePublicKey;
            byte[] alicePrivateKey;
            byte[] bobPublicKey;
            byte[] aliceKey;
            
            string alicekeystring;
            string IVstring;

            using (ECDiffieHellmanCng cng = new ECDiffieHellmanCng(
                CngKey.Create(
                    CngAlgorithm.ECDiffieHellmanP256,
                    null,
                    new CngKeyCreationParameters
                    { ExportPolicy = CngExportPolicies.AllowPlaintextExport })))
            {
                cng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                cng.HashAlgorithm = CngAlgorithm.Sha512;                
                alicePublicKey = cng.PublicKey.ToByteArray();
                alicePrivateKey = cng.Key.Export(CngKeyBlobFormat.EccPrivateBlob);

            }

            StringBuilder hexPublic = new StringBuilder(alicePublicKey.Length * 2);
            foreach (byte b in alicePublicKey)
                hexPublic.AppendFormat("{0:x2}", b);
            alicekeystring = hexPublic.ToString();

            ReadMail reader = new ReadMail();
            string keystring = "";
            string user = Sender.Adress;
            int index = user.IndexOf("@");
            if (index > 0)
                user = user.Substring(0, index);
            int before = reader.GetNumberOFMessages(Sender.Host, Sender.PortRead, true, user, Sender.Password);
            string body = "#!#" + Reciever.Adress + "#!#";
            Person Dodocrypts = new Person("root", "root@dodocrypts.com");
            SendMail posalji = new SendMail(Sender, Dodocrypts, "request keys", body, true, false);
            posalji.Send();


            int after = before;
            int timer = 0;
            while (after == before && timer < 30)
            {
                System.Threading.Thread.Sleep(1000);
                timer++;
                after = reader.GetNumberOFMessages(Sender.Host, Sender.PortRead, true, user, Sender.Password);
                if (after > before)
                {
                    OpenPop.Mime.Message procitano = reader.FetchMailByIndex(after, Sender.Host, Sender.PortRead, true, user, Sender.Password);
                    if (procitano.Headers.From.ToString().Contains("root@mail.dodocrypts.com"))
                    {
                        OpenPop.Mime.MessagePart sadrzaj = procitano.FindFirstPlainTextVersion();
                        if (sadrzaj != null)
                        {
                            keystring = sadrzaj.GetBodyAsText();
                            if (keystring.Contains("Trazeni korisnik"))
                            {
                                return "";
                            }
                            ReadMail.DeleteMessageOnServer(Sender.Host, Sender.PortRead, true, user, Sender.Password, after);                       
                        }
                    }
                    else
                    {
                        before++;
                    }
                }
            }

            bobPublicKey = Enumerable.Range(0, keystring.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(keystring.Substring(x, 2), 16))
                     .ToArray();

            using (ECDiffieHellmanCng cng = new ECDiffieHellmanCng(CngKey.Import(alicePrivateKey, CngKeyBlobFormat.EccPrivateBlob)))
            {
                cng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                cng.HashAlgorithm = CngAlgorithm.Sha256;
                aliceKey = cng.DeriveKeyMaterial(CngKey.Import(bobPublicKey, CngKeyBlobFormat.EccPublicBlob));
            }

            using (Aes myAes = Aes.Create())
            {
                StringBuilder hexIV = new StringBuilder(myAes.IV.Length * 2);
                foreach (byte b in myAes.IV)
                    hexIV.AppendFormat("{0:x2}", b);
                IVstring = hexIV.ToString();

                byte[] encrypted = EncryptStringToBytes_Aes(Poruka, aliceKey, myAes.IV);

                StringBuilder hexPoruka = new StringBuilder(encrypted.Length * 2);
                foreach (byte b in encrypted)
                    hexPoruka.AppendFormat("{0:x2}", b);
                Poruka = hexPoruka.ToString();

            }
            Poruka = "#CRYPTO#" + keystring + "#!#" + alicekeystring + "#!#" + IVstring + "#!#" + Poruka;
            return Poruka;
        }

        public string Decrypt(Person Reciever)
        {
            Poruka = Poruka.Substring(8);
            string[] separatingStrings = { "#!#","!#!" };
            string[] keysAndContent = Poruka.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            byte[] alicePublicKey;
            byte[] IV;
            byte[] Content;
            byte[] bobPrivateKey = null;
            byte[] bobKey;

            string line = "";
            StreamReader file = new StreamReader("LocalKeys.txt");
            bool found = false;
            while ((line = file.ReadLine()) != null && !found)
            {
                string[] LocalKeys = line.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                
                if(LocalKeys[0] == Reciever.Adress && LocalKeys[1] == keysAndContent[0])
                {        
                    found = true;
                    bobPrivateKey = Enumerable.Range(0, LocalKeys[2].Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(LocalKeys[2].Substring(x, 2), 16))
                     .ToArray();
                }
            }
            file.Close();
            if (found)
            {   
                alicePublicKey = Enumerable.Range(0, keysAndContent[1].Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(keysAndContent[1].Substring(x, 2), 16))
                     .ToArray();

                IV = Enumerable.Range(0, keysAndContent[2].Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(keysAndContent[2].Substring(x, 2), 16))
                     .ToArray();

                Content = Enumerable.Range(0, keysAndContent[3].Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(keysAndContent[3].Substring(x, 2), 16))
                     .ToArray();

                using (ECDiffieHellmanCng cng = new ECDiffieHellmanCng(CngKey.Import(bobPrivateKey, CngKeyBlobFormat.EccPrivateBlob)))
                {
                    cng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                    cng.HashAlgorithm = CngAlgorithm.Sha256;
                    
                    bobKey = cng.DeriveKeyMaterial(CngKey.Import(alicePublicKey, CngKeyBlobFormat.EccPublicBlob));
                }
                Poruka = DecryptStringFromBytes_Aes(Content, bobKey, IV);
            }
            else
            {
                Poruka = "Poruka je enkriptirana koristeći CRYPTO, no ključ koji je korišten nije spremljen na ovom računalu!";
            }
            return Poruka;
        }

        public bool Register(Person Sender)
        {
            byte[] bobPublicKey;
            byte[] bobPrivateKey;

            string keystring;

            using (ECDiffieHellmanCng cng = new ECDiffieHellmanCng(
                CngKey.Create(
                    CngAlgorithm.ECDiffieHellmanP256,
                    null,
                    new CngKeyCreationParameters
            { ExportPolicy = CngExportPolicies.AllowPlaintextExport })))
            {
                cng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                cng.HashAlgorithm = CngAlgorithm.Sha256;
                bobPrivateKey = cng.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
                bobPublicKey = cng.PublicKey.ToByteArray();
                
            }

            StringBuilder hexPublic = new StringBuilder(bobPublicKey.Length * 2);
            foreach (byte b in bobPublicKey)
            hexPublic.AppendFormat("{0:x2}", b);
            keystring = hexPublic.ToString();

            StringBuilder exPrivate = new StringBuilder(bobPrivateKey.Length * 2);
            foreach (byte b in bobPrivateKey)
            exPrivate.AppendFormat("{0:x2}", b);
            string privatekeystring = exPrivate.ToString();
            
            string body = "#reg#" + keystring;
            Person Dodocrypts = new Person("root", "root@dodocrypts.com");

            SendMail posalji = new SendMail(Sender, Dodocrypts, "register", body, true, false);
            posalji.Send();
            
            using (StreamWriter writer = new StreamWriter("LocalKeys.txt", true))
            {
                writer.WriteLine(Sender.Adress+"!#!"+keystring + "!#!" + privatekeystring);
            }    
            return true;
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {

            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            string plaintext = null;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
    }
}
