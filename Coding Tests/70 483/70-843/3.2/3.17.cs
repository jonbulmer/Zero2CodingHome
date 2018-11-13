using System;
using System.IO;
using System.Security.Cryptography;

namespace Exam.Objective3_1
{

    // https://books.google.co.uk/books?id=b7dCAwAAQBAJ&pg=PT313&lpg=PT313&dq=static+byte%5B%5D+Encrypt(SymmetricAlgorithm+aesAlg,+string+plainText)&source=bl&ots=ZD_SQMqjmQ&sig=Cpv_xFilFz9X7WtVrDW8xLSHrzY&hl=en&sa=X&ved=2ahUKEwiOz6ubvtDeAhUDCCwKHd2uDOMQ6AEwBHoECAYQAQ#v=onepage&q=static%20byte%5B%5D%20Encrypt(SymmetricAlgorithm%20aesAlg%2C%20string%20plainText)&f=false
    public class WorkingWithEncryption
    {
        public static void EncryptSomeText()
        {
            string original = "My secret data!";

            using (SymmetricAlgorithm symmetricAlgorithm = new AesManaged())
            {
                byte[] encrypted = Encript(symmetricAlgorithm, original);

                string roundtrip = Decrypt(symmetricAlgorithm, encrypted);

                // Display: My secret data!
                Console.WriteLine($"Original: {original}");
                Console.WriteLine($"Round Trip: {roundtrip}");
            }

        }

        static byte[] Encript(SymmetricAlgorithm aesAlg, string plainText)
        {
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt =
                    new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return msEncrypt.ToArray();
                }
            }
        }

        static string Decrypt(SymmetricAlgorithm aesAlg, byte[] cipherText)
        {
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt =
                    new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}