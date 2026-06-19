public class Reflection : Activity
{
    //attirbutes
    private List<string> _followUpQuestions;

    //Constructor
    public Reflection(string intro, string outro, int time, List<string> prompts, List<string> followUpQuestions) :base(intro, outro, time, prompts)
    {
        _intro=intro;
        _outro=outro;
        _time=time;
        _prompts=prompts;
        _followUpQuestions=followUpQuestions;
    }
    public void DisplayFollowUpQuesiton()
    {
        foreach(string question in  _followUpQuestions)
        {
            Animation1();
            Console.WriteLine($"{question}");
            int half=_time/2;
            CountDown(half);
        }
    }

}