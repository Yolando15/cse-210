using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        //Main Menu!!!
        Console.WriteLine("Welcome to the destresser program!");
        //other varibles
        int choice=0;
        int timechose = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Please select an option below");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Quit the  program");
            choice = int.Parse(Console.ReadLine());
            while (choice>4 || choice<1)
            {
                choice=int.Parse(Console.ReadLine());
            }
            if (choice!=4)
            {
            Console.WriteLine("How long would you like to do this for?");
            timechose=int.Parse(Console.ReadLine());
            }
            Console.Clear();
            
            switch(choice)
            {
                case 1:
                //Breathing activity
                Breathing BreathingActivity= 
                new Breathing("Welcome to the breathing activity! You will hold you when prompted", "Thank you for participating in this activity!", timechose);
                BreathingActivity.DisplayIntro();
                BreathingActivity.JustBreathe();
                BreathingActivity.DisplayOutro();
                BreathingActivity.Animation1();
                break;
                case 2:
                //Reflection Activity
                List<string> prompts=new List<string>
                {
                  "What is something you did that was difficult?", "Why haven't you defeated a dragon yet?", "What is a fond memory you  have of your mother?"  
                };
                List<string> followUp=new List<string>
                {
                    "How did you feel after that?", "What made that so memorable" 
                };
                Reflection reflection=new Reflection("Welcome to the Reflection activty we will give you a prompt and you will reflect on that for the desired time.\nPress enter when you are ready to coninue",
                "Thank you for participating in this activity! I hope that you feel more accomplised",
                timechose, prompts, followUp);
                reflection.DisplayIntro();
                reflection.DisplayPromt();
                Console.ReadLine();
                reflection.DisplayFollowUpQuesiton();
                reflection.DisplayOutro();
                reflection.Animation1();
                break;
                case 3:
                //Listing Activity
                List<string> ListPrompts = new List<string>
                {
                    "When have you felt the Holy Ghost in your life", "When did you serve another person?", "What dates have you been on recently",
                    "What makes you feel happy"
                };
                List<string> EmptyList=new List<string>
                {
                    
                };
                Listing Listing=new Listing("Welcome to the Listing Activity. \nWe will give you a prompt and in the time that you put in you will try to write as many instances of that as you can!",
                "",timechose, ListPrompts, EmptyList);
                Listing.DisplayIntro();
                Listing.ListingActivity();
                Listing.Animation1();
                break;
                case 4:
                //
                break;
                default:
                break;
            }

        }
    }
}