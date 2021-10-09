using System;
using System.Text;

namespace Tema1
{
    public class MonoalphabeticCipher : INonCircularCipher
    {
        protected const string _lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
        protected string _permutatedLowerAlphabet;

        public string PlainText { get; }
        public string CipherText { get; }

        public string PermutatedLowerAlphabet { get { return _permutatedLowerAlphabet; } }

        public int Index { get { return 0; } }

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
            return ActualEncryption(inputText, _lowerAlphabet, _permutatedLowerAlphabet);
        }

        public virtual string Encrypt(string inputText)
        {
            return ActualEncryption(inputText, _permutatedLowerAlphabet, _lowerAlphabet);
        }

        private string ActualEncryption(string inputText, string alphabetToUse, string alphabetUsed)
        {
            string result = "";
            foreach (char character in inputText)
            {
                result += (char.IsLetter(character) ? alphabetToUse[alphabetUsed.IndexOf(character)] : character);
            }
            _permutatedLowerAlphabet = _lowerAlphabet;
            return result;
        }
    }
}
