using System;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularPermutaionCipher cipher = new CircularPermutaionCipher("hello there", 5);
            Console.WriteLine(cipher.Encrypt(cipher.PlainText));
            Console.WriteLine(cipher.Decrypt("mjqqt ymjwj"));
        }
    }
}
