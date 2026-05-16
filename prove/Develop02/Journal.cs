using System.Data;

class Journal
{
    //attributes
    public List<Entry> _entries = new List<Entry>();

    //Methods
    public void AddEntry(Entry notebook)
    {
        _entries.Add(notebook);
    }
    public void DisplayEntries()
    {
        int size=_entries.Count();
        for (int i=0; i<size; i++)
        {
            Console.WriteLine($"Entry {i+1}: {_entries[i]._date} {_entries[i]._prompt}\n{_entries[i]._response}");
        }
    }

    public void SaveEntries()
    {
     Console.WriteLine("What do you want to be the name of your journal entries? ");
     string fileName =Console. ReadLine();
     using (StreamWriter bunda=new StreamWriter(fileName))
        {
            foreach(Entry escrito in _entries)
            {
                bunda.WriteLine($"{escrito._date}###{escrito._prompt}###{escrito._response}");
            }
        }
    }

    public void LoadFiles()
    {
        _entries.Clear();
        Console.WriteLine("What is the name of the file you want to get? (remember the .txt at the end)");
        string fileName=Console.ReadLine();
        string[] readFile=System.IO.File.ReadAllLines(fileName);
        foreach (string passaro in readFile)
        {
            string[] partes = passaro.Split("###");
            string date=partes[0];
            string prompt=partes[1];
            string response=partes[2];
            Entry final=new Entry();
            final.AddEmUp(date,prompt,response);
            AddEntry(final);
        }
    }

}