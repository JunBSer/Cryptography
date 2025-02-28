namespace encriptionAlgorithm.Internal;

public class VigenereDirect:EncriptionAlgorithm
{
    public VigenereDirect(string alphabet):
        base(alphabet) { }
    
    public override string Encript(string text, string key)
    {   
        
        text=text.ToLower();
        key=key.ToLower();
        
        string corrKey=CollectCorrectData(key, _letters);
        string corrText= CollectCorrectData(text, _letters);

        if (corrText == "")
        {
            MessageBox.Show("The correct text is empty.");
            return "";
        }

        if (corrKey == "")
        {
            MessageBox.Show("The key is incorrect.");
            return "";
        }

        int currKeyInd = 0;

        string encrText = "";

        for (int i = 0; i < corrText.Length; i++)
        {
            int ind = FindEncrInd(corrText[i], corrKey[currKeyInd]);
            encrText += _letters[ind];
            currKeyInd= (currKeyInd+1)%corrKey.Length;
        }

        return encrText;
    }

    public override string Decript(string text, string key)
    {
        text=text.ToLower();
        key=key.ToLower();
        
        string corrKey=CollectCorrectData(key, _letters);
        string corrText= CollectCorrectData(text, _letters);

        if (corrText == "")
        {
            MessageBox.Show("The correct text is empty.");
            return "";
        }

        if (corrKey == "")
        {
            MessageBox.Show("The key is incorrect.");
            return "";
        }

        int currKeyInd = 0;

        string decrText = "";
        
        
        for (int i = 0; i < corrText.Length; i++)
        {
            int ind = FindDecrInd(corrText[i], corrKey[currKeyInd]);
            decrText += _letters[ind];
            currKeyInd= (currKeyInd+1)%corrKey.Length;
        }

        return decrText;
    }

    private int FindEncrInd(char c, char key)
    {
        return (FindPos(c,_letters) + FindPos(key,_letters)) % LetInAlph;
    }

    private int FindDecrInd(char c, char key)
    {
        return (FindPos(c, _letters) - FindPos(key, _letters) + LetInAlph) % LetInAlph;
    }
    
    private string CollectCorrectData(string data, string alphabet)
    {
        string corrData = "";
        for (int i = 0; i < data.Length; i++)
        {
            if (IsInAlph(data[i], alphabet))
            {
                corrData += data[i];
            }
        }
        return corrData;
    }
}