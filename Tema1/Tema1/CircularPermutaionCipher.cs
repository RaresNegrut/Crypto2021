using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tema1
{
    public class CircularPermutaionCipher : MonoalphabeticCipher
    {
        public int Index { get; set; }

        //constructor ce imi ia mesajul criptat doar, folosit in cazul in care se doreste decriptarea unui mesaj
        public CircularPermutaionCipher(string cipherText) : base(cipherText) { }

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
            _permutatedLowerAlphabet = _lowerAlphabet.ShiftAlphabetByGivenIndex(index);
            return base.Decrypt(cipherText);
        }

        public override string Analyze(string inputText)
        {
            int index = 1;
            string result = "";
            bool keyFound = false;
            string[] words = File.ReadAllLines("words.txt");
            Regex myRegex = new Regex(@"[^\p{L}]*\p{Z}[^\p{L}]*");

            while (index < 26 && keyFound == false)
            {
                _permutatedLowerAlphabet = _lowerAlphabet.ShiftAlphabetByGivenIndex(index);
                result = Encrypt(inputText);
                
                
                string[] resultedWords = myRegex.Split(result);

                int matchingWords = resultedWords
                    .Where(
                    resultedWord => words.Any(word => string.Compare(word, resultedWord) == 0)).Count();

                keyFound = (matchingWords == resultedWords.Length ? true : false);

                index++;
            }

            return result;
        }
    }
}
