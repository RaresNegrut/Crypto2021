using System;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICircularCipher cipher = new CircularPermutaionCipher("hello there", 5);
            string messageEncryptedCircularly = cipher.Encrypt(cipher.PlainText,5);
            Console.WriteLine(messageEncryptedCircularly);
            Console.WriteLine($"{cipher.Analyze("mjqqt, ymjwj")} {cipher.PermutatedLowerAlphabet} {cipher.Index}");
            Console.WriteLine(cipher.Decrypt("mjqqt", 5));
        }
    }
}
