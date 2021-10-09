using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1
{
    public interface ICircularCipher:ICipher
    {
        string Encrypt(string inputText, int index);
        string Decrypt(string cipherText, int index);
        string Analyze(string cipherText);
    }
}
