using System.Dynamic;

class Secrets
{
    private string _word;
    private bool _under;
    
// constructor stuff
    public Secrets(string entry)
    {
        _word=entry;
        _under=false;
    }
    public string GetSecret()
    {
        return _word;
    }
    public void SetSecret(string entry)
    {
        _word=entry;
    }
    public bool GetBool()
    {
        return _under;
    }
    public void HideSet(bool hidden)
    {
        _under=hidden;
    }
    
    public void Display()
    {
        if (_under)
        {
            foreach (char charcter in _word)
            {
                Console.Write("_");
            }
            
        }
        else
        {
            Console.Write($"{_word}");
        }
        Console.Write(" ");
    }

    
}