using System;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularPermutaionCipher cipher = new CircularPermutaionCipher("hello there", 5);
            string messageEncryptedCircularly = cipher.Encrypt(cipher.PlainText);
            Console.WriteLine(messageEncryptedCircularly);
            Console.WriteLine($"{cipher.Decrypt("mjqqt, ymjwj")} {cipher.PermutatedLowerAlphabet} {cipher.Index}");
            Console.WriteLine(cipher.Decrypt("mjqqt", 5));
        }
    }
}
