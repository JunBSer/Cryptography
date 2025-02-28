namespace encriptionAlgorithm.Internal;

public class Decimation : EncriptionAlgorithm
{


    public Decimation(string alphabet) :
        base(alphabet) { }
    
    public override string Encript(string text, string key)
    {
        text = text.ToLower();

        string corrKey=CollectCorrectData(key, "0123456789");
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

        int intKey= int.Parse(corrKey);

        if (FindGCD(intKey, LetInAlph) != 1)
        {
            MessageBox.Show("The key is incorrect.");
            return "";
        }
        
        string encrText = "";
        
        for (int i = 0; i < corrText.Length; i++)
        {
            if (EncriptionAlgorithm.IsInAlph(corrText[i],_letters))
            {
                int ind = FindEncrInd(corrText[i], intKey);
                encrText+=ConvertIndToChar(ind);
            }
           
        }
        return encrText;
    }

    public override string Decript(string text, string key)
    {
        text = text.ToLower();
        
        string corrKey=CollectCorrectData(key, "0123456789");
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

        int intKey= int.Parse(corrKey);

        if (FindGCD(intKey, LetInAlph) != 1)
        {
            MessageBox.Show("The key is incorrect.");
            return "";
        }


        string decrText = "";

        for (int i = 0; i < text.Length; i++)
        {
            int ind = FindDecInd(text[i], intKey);

            decrText+=ConvertIndToChar(ind);
        }
        
        
        return decrText;
    }

    private int FindEncrInd(char c, int key)
    {
        int res;
        
        try
        {
             res = (FindPos(c,_letters) * key) % LetInAlph;   
        }
        catch (OverflowException e)
        {
           MessageBox.Show("Key is too large to encrypt: " + e);
           res = 0;
        }
        
        return res;
    }

    private int FindDecInd(char c, int key)
    {
        int currIndx = FindPos(c,_letters);
        
        if (currIndx == 0)
            return 0;
        
        while (currIndx%key!=0)
        {
            currIndx+=LetInAlph;   
        }

        return ((currIndx / key)%LetInAlph);
    }

    private int FindGCD(int a, int b)
    {
        while (a != 0 && b!=0)
        {
            if (a > b)
                a %= b;
            else b %= a;
        }
        return a+b;
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