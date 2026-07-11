using System.Diagnostics;
public class Listing : Activity
{
    private List<string> _responses;
    

    public Listing(string intro, string outro, int time, List<string> prompts, List<string> responses) :base(intro, outro, time, prompts)
    {
        _intro=intro;
        _outro=outro;
        _time=time;
        _prompts=prompts;
        _responses=responses;
        
    }
    public void WriteAsFastAsYouCan( int timeleft)
    {
        Stopwatch timer = Stopwatch.StartNew();

        while (timer.Elapsed.TotalSeconds < _time)
        {
            
            string entry = Console.ReadLine();
                
             if (timer.Elapsed.TotalSeconds>_time)
            {
                entry = null;
            }
            _responses.Add(entry);
        }
    }
    public void ListingActivity()
    {
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPromt();
        Console.WriteLine("You may begin in:");
        CountDown(3);
        WriteAsFastAsYouCan(_time);
        Console.WriteLine($"Nice Job! You wrote {_responses.Count} entries!");

    }
}