using System.ComponentModel;
using encriptionAlgorithm.Internal;

namespace encriptionAlgorithm;

public partial class Form1 : Form
{
    private Decimation dec;
    private VigenereDirect vig;
    private static int ChosedMethod=0;
    public Form1()
    {
        InitializeComponent(); 
        dec=new Decimation("abcdefghijklmnopqrstuvwxyz");
        vig=new VigenereDirect("абвгдеёжзийклмнопрстуфхцчшщъыьэюя"); 
    }
    
    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        ChosedMethod = 0;
    }

    private void rbVigenere_CheckedChanged(object sender, EventArgs e)
    {
        ChosedMethod = 1;
    }

    private void btnEncript_Click(object sender, EventArgs e)
    {
        if (tbxText.Text == "")
        {
            MessageBox.Show("Input text is empty");
            return;
        }

        if (tbxKey.Text == "")
        {
            MessageBox.Show("Input key is empty");
            return;
        }

        string result = "";
        
        switch (ChosedMethod)
        {
            case 0:
                result=dec.Encript(tbxText.Text, tbxKey.Text);
                tbxResult.Text=result;
                break;
            case 1:
                result = vig.Encript(tbxText.Text, tbxKey.Text);
                tbxResult.Text=result;
                break;
        }
    }

    private void btnDecipher_Click(object sender, EventArgs e)
    {
        if (tbxText.Text == "")
        {
            MessageBox.Show("Input text is empty");
            return;
        }

        if (tbxKey.Text == "")
        {
            MessageBox.Show("Input key is empty");
            return;
        }
        
        
        string result = "";
        
        switch (ChosedMethod)
        {
            case 0:
                result=dec.Decript(tbxText.Text, tbxKey.Text);
                tbxResult.Text=result;
                break;
            case 1:
                result = vig.Decript(tbxText.Text, tbxKey.Text);
                tbxResult.Text=result;
                break;
        }
    }


    private void button1_Click(object sender, EventArgs e)
    {
       
        if (sdMain.ShowDialog()==DialogResult.OK)
        {
            string filePath = sdMain.FileName;
            StreamWriter writer = null;
            try
            {
                using (writer = new StreamWriter(filePath))
                {
                    writer.Write(tbxResult.Text);
                    MessageBox.Show("Файл успешно сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        if (odMain.ShowDialog() == DialogResult.OK)
        {
            string filePath = odMain.FileName;
            
            StreamReader reader = null;
           
            string result = "";
            
            try
            {
                using (reader = new StreamReader(filePath))
                {
                    result=reader.ReadToEnd();
                    MessageBox.Show("Файл успешно прочитан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxText.Text=result;
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            
        }
       
    }
}