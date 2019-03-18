using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace StrongPasswordGenerator
{
    public class PasswordGenerator
    {
        string numbers, symbols;
        string lchars,uchars;
        public string password = "";
        int passwordLength;
        List<string> optionsList;

        public PasswordGenerator(int LEN,bool NR,bool SY,bool LCH,bool UCH)
        {
            passwordLength = LEN;
            numbers = "0123456789";
            symbols = "!@$#%^&*{}[]()~;:.<>+-_";
            lchars = "abcdefghijklmnopqrstuvwxyz";
            uchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            optionsList = new List<string>();
            if (NR == true) optionsList.Add(numbers);
            if (SY == true) optionsList.Add(symbols);
            if (LCH == true) optionsList.Add(lchars);
            if (UCH == true) optionsList.Add(uchars);
            
        }

        public void Generate()
        {
            Random randChooseTheSet = new Random();
            Random randChooseTheSymbol = new Random();
            if (optionsList.Count == 0)
                throw new Exception("You have to thick at least one chechbox!");
            
            for (int i=0;i<passwordLength;i++)
            {
                int optionListIndex=randChooseTheSet.Next(0, optionsList.Count);
                string set = optionsList[optionListIndex];
                int setIndex = randChooseTheSymbol.Next(0, set.Length);
                password = password + set[setIndex];  
            }
            if (password == "")
                throw new Exception("Password not generated.");
        }
        
        public void SaveToFileEncrypted()
        {
            string encryptedPassword,decryptedPassword;
            byte[] encryptedBytes,decryptedBytes;
            byte[] plainBytes = Encoding.ASCII.GetBytes(password);
            Aes aes = Aes.Create();
            ICryptoTransform encryptor= aes.CreateEncryptor(aes.Key, aes.IV);
            //encrypt1
            encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
            encryptedPassword = Convert.ToBase64String(encryptedBytes);

            //decrypt
            //ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            //decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            //decryptedPassword = Encoding.ASCII.GetString(decryptedBytes);
           
            StreamWriter sw = new StreamWriter(@"##passwords##.txt",true);//bool append=true;
            //sw.WriteLine(password + "  " + encryptedPassword+"  "+decryptedPassword);
            sw.WriteLine(encryptedPassword+"  Key:"+Convert.ToBase64String(aes.Key)
                +"  IV:"+Convert.ToBase64String(aes.IV));
            sw.Close();
        }
    }
}