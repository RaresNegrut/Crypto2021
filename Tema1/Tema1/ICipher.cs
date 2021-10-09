namespace Tema1
{
    public interface ICipher
    {
        string Encrypt(string inputText);

        string Decrypt(string inputText);

        string Analyze(string inputText);
    }
}
