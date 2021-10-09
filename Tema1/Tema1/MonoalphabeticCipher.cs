using System;
using System.Text;

namespace Tema1
{
    public class MonoalphabeticCipher : ICipher
    {
        protected const string _lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
        //protected const string _upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //protected const string _alphabet = _upperAlphabet + _lowerAlphabet;
        protected string _permutatedLowerAlphabet;

        public string PlainText { get; }
        public string CipherText { get; }

        //constructor folosit pentru cand se doreste decriptarea unui mesaj citit de la tastatura, fara a se sti permutarea alfabetului
        public MonoalphabeticCipher(string cipherText = "")
        {
            CipherText = cipherText;
        }
        //se da mesajul in plaintext si se doreste criptarea lui dupa un anume alfabet permutat
        public MonoalphabeticCipher(string plainText, string permutatedLowerAlphabet)
        {
            PlainText = plainText;
            _permutatedLowerAlphabet = permutatedLowerAlphabet;
        }

        public virtual string Analyze(string inputText)
        {
            throw new NotImplementedException();
        }

        public virtual string Decrypt(string inputText)
        {
            string result = "";
            foreach (char character in inputText)
            {
                if (char.IsLetter(character))
                {
                    result += _lowerAlphabet[_permutatedLowerAlphabet.IndexOf(character)];
                }
                else
                {
                    result += character;
                }
            }
            return result;
        }

        public virtual string Encrypt(string inputText)
        {
            string result = "";
            foreach (char character in inputText)
            {
                if (char.IsLetter(character))
                {
                    result += _permutatedLowerAlphabet[_lowerAlphabet.IndexOf(character)];
                }
                else
                {
                    result += character;
                }
            }
            return result;
        }
    }
}
