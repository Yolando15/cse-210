public class Breathing : Activity
{
     public Breathing(string intro, string outro, int time) : base(intro, outro, time, new List<string>())
    {
        _intro=intro;
        _outro=outro;
        _time=time;
        
    }
   
    public void BreatheIn(int time)
    {
        Console.WriteLine("Breathe In through your nose");
        CountDown(time);
    }
    public void BreatheOut(int time)
    {
        Console.WriteLine("Breathe Out through your mouth");
        CountDown(time);
    }
    public void JustBreathe()
    {
        Console.Clear();
        Animation1();
        Console.Write("\b \b");
        Console.WriteLine("Lets get started");
        while (_time>0)
        {
            
        
            if (_time<4)
             {
                BreatheIn(_time);

                _time=0;
                
            }
            else if (_time<10 && _time>4)
            {
                int half=_time/2;
                //see how I can change half to a float or make it a whole number
                //I don't know how to do that
                //I learned that if I don't specify the foat it will just  round  down
                BreatheIn(half);
                BreatheOut(half);
                _time=0;
            }
            else
            {
                BreatheIn(4);
                BreatheOut(6);
                _time-=10;
            }


        }
    }
}