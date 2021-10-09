using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1
{
    public interface ICipher
    {
        string PlainText { get; }
        string PermutatedLowerAlphabet { get; }
        int Index { get; }
    }
}
