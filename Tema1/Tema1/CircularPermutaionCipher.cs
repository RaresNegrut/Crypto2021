using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Tema1
{
    public class CircularPermutaionCipher : MonoalphabeticCipher
    {
        public int Index { get; set; }

        //constructor ce imi ia mesajul criptat doar, folosit in cazul in care se doreste decriptarea unui mesaj
        public CircularPermutaionCipher(string cipherText) : base(cipherText)
        {

        }

        //constructor ce ia plaintextul si indexul si imi cripteaza mesajul
        public CircularPermutaionCipher(string plainText, int index) : base(plainText, permutatedLowerAlphabet: "")
        {
            Index = index;
            _permutatedLowerAlphabet = _lowerAlphabet.ShiftAlphabetByGivenIndex(index);
        }

        public override string Decrypt(string cipherText)
        {
            return Analyze(cipherText);
        }

        public string Decrypt(string cipherText, int index)
        {
            return base.Decrypt(cipherText);
        }

        public override string Encrypt(string inputText)
        {
            return base.Encrypt(inputText);
        }
        public override string Analyze(string inputText)
        {
            string result = "";
            int index = 1;
            bool keyFound = false;
            string[] words = File.ReadAllLines("words.txt");
            while (index < 26 && keyFound == false)
            {
                //string shiftedLowerAlphabet = _upperAlphabet.ShiftAlphabetByGivenIndex(index);
                _permutatedLowerAlphabet = _lowerAlphabet.ShiftAlphabetByGivenIndex(index);
                result = Encrypt(inputText);
                string[] resultedWords = result.Split(' ', '.', ',');
                int matchingWords = 0;
                foreach (string resultedWord in resultedWords)
                {

                    if (words.Any(word => string.Compare(word,resultedWord)==0))
                    {
                        matchingWords++;
                    }
                }
                if (matchingWords == resultedWords.Length)
                {
                    keyFound = true;
                }
                index++;
                /*
                 * apply alphabet shift to letters
                 * fghijklmnopqrstuvwxyzabcde->ghijklmnopqrstuvwxyzabcdef
                 * mjqqt ymjwj->nkrru znkxk
                 * Encrypt Gets Called
                 */

            }

            return result;
        }
    }
}
