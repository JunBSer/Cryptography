using System.Linq.Expressions;

namespace encriptionAlgorithm.Internal;

public abstract class EncriptionAlgorithm
{
    protected int LetInAlph;
    protected  string _letters = null!;

    public EncriptionAlgorithm(string alphabet)
    {
        _letters = alphabet;
        LetInAlph = alphabet.Length;
    }
    protected static bool IsInAlph(char c, string alphabet)
    {
        char letter = c.ToString().ToLower()[0];
        return (FindPos(letter,alphabet)!=-1);
    }

    public abstract string Encript(string text, string key);
    
    public abstract string Decript(string text, string key);

    protected static int FindPos(char c, string alphabet)
    {
        return alphabet.IndexOf(c);
    }
    protected char ConvertIndToChar(int pos)
    {
        return _letters[pos];
    }

    
    
}

