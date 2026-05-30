class Scripture
{
    private Reference _reference;
    private List<Secrets> _words=new List<Secrets>();

//constructor fun stuff
    public Scripture (string book, string chapter, string verse, string theWholeThing)
    {
        _reference=new Reference(book, chapter,verse);
        SeperateScripture(theWholeThing);
    }
    public void SeperateScripture(string phrase)
    {
           string[] cluster=phrase.Split(' ');
            foreach (string word in cluster)
            {
                Secrets assassin=new Secrets(word);
                _words.Add(assassin);
            } 
    }    

    //Display my scirputre stuff
    public void Display()
    {
        _reference.Display();
        foreach (Secrets palavras in _words)
        {
            palavras.Display();
        }
    }
    public int GetLengthOfList()
    {

        return _words.Count();
    }
    public bool Check(int  index)
    {
        return _words[index].GetBool();
    }
    public void Switch(int index)
    {
        if (_words[index].GetBool()==false)
        {
            _words[index].HideSet(true);
        }
    }
    public int SeeAll()
    {
        int finalcountdown=0;
        foreach (Secrets chair in _words)
        {
            if (chair.GetBool()==false)
            {
              finalcountdown++; 
            }
        }
        return finalcountdown;
    }
}