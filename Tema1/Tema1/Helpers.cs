using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1
{
    public static class Helpers
    {
        public static string ShiftAlphabetByGivenIndex(this string inputText, int index)
        {
            return inputText.Remove(0, index % inputText.Length) + inputText.Substring(0, index % inputText.Length);
        }
    }
}
