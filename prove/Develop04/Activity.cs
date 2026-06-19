public class Activity
{
    //Get in some classic attributes
    protected string _intro;
    protected string _outro;
    protected int _time;
    protected List<string> _prompts;

    //methods!
     public Activity(string intro, string outro, int time, List<string> prompts)
    {
        _intro=intro;
        _outro=outro;
        _time=time;
        _prompts=prompts;
        
    }
    public void CountDown(int timeleft)
    {
        while (timeleft>0)
        {
            Console.Write($"{timeleft}");
            timeleft--;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void SecretCountDown(int timeleft)
    {
        while (timeleft>0)
        {
            
            timeleft--;
            Thread.Sleep(1000);
            
        }
    }
    public void Animation1()
    {
        Random r=new Random();
        int i=0;
        while (i<4)
        {
            if (i>0)
            {
                Console.Write("\b \b");
            }
            //see if the iteration is even or not
            if (i%2==0)
            {
                
                Console.Write("+");
            
                Thread.Sleep(r.Next(400,800));
            }
            else if (i%2!=0)
            {
                Console.Write("#");
                Thread.Sleep(r.Next(400,800));
            }
            i++;
        }
    }
    public void DisplayPromt()
    {
      int length=_prompts.Count();
      Random r =new Random();
      int thisone=r.Next(0,length);
      string prompt=_prompts[thisone];
      Console.WriteLine($"{prompt}");

    }
    public void DisplayIntro()
    {
        Console.WriteLine($"{_intro}");
    }
    public void DisplayOutro()
    {
        Console.WriteLine($"{_outro}");
    }
    public void SetTime(int time)
    {
        if (time>0)
        {
            _time=time;
        }
        else
        {
            Console.WriteLine("You silly goose, you should  put in a reasonable time");
        }
    }
    public int GetTime()
    {
        return _time;
    }
        
        


}