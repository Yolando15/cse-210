using System.ComponentModel.DataAnnotations;

class Entry
{
    //attributes
    //Time stuff
    public string _date;
    public string _response;
    public string _prompt;

    //behaviors (methods)(or funstions that your class does)
    public void Display()
    {
        //Time stuff
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        Console.WriteLine($"{_date}--{_prompt}\n{_response}");
        Console.WriteLine(">");
        _response=Console.ReadLine();
    }

    public string RandomPrompt()
    {
        string [] prompts =
        {
        "What was the wierdest thing that happend today?  ",
        "Who made you the happiest today?",
        "Who was the most interesting person",
        "What was the hardest thing that happened today",
        "What would you want to do over"
        };
        Random random=new Random();
        int aletorio=random.Next(5);

        
        _prompt=prompts[aletorio];
        return _prompt;
    }

public void AddEmUp(string date, string prompt, string response)
    {
        _date=date;
        _prompt=prompt;
        _response=response;
    }
}