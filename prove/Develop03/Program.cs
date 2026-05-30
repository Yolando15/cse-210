using System;

class Program
{
    static void Main(string[] args)
    {
        Random random1=new Random();
        Console.WriteLine("Hello Develop03 World!");
        
        Scripture favorite;
        Console.WriteLine("Choose what scriputre you want to memeorize");
        Console.WriteLine("1. Jacob 4:7");
        Console.WriteLine("2. D&C 93:36");
        Console.WriteLine("3. 3 Nephi 11:11");
        //Scripture favorite =new Scripture("Jacob", "4", "7", "Nevertheless, the Lord God showeth us our weakness that we may know that it is by his grace, and his great condesnensions unto the children of men, that we have power to do these things.");
        int choice=int.Parse(Console.ReadLine());
        if (choice==1)
        {
            favorite=new Scripture("Jacob", "4", "7", "Nevertheless, the Lord God showeth us our weakness that we may know that it is by his grace, and his great condesnensions unto the children of men, that we have power to do these things.");
        }
        else if (choice==2)
        {
            favorite=new Scripture("D&C", "93", "36", "The glor of God is intelligence, or, in ohhter owrds, light and truth.");

        }
        else if (choice==3)
        {
            favorite=new Scripture("3 Nephi", "11", "11", "And behold, I am the light and the life of the world; and I have drunk out of that  bitter cup wich the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginnning.");
        }
        else
        {
            favorite=new Scripture("Jacob", "4", "7", "Nevertheless, the Lord God showeth us our weakness that we may know that it is by his grace, and his great condesnensions unto the children of men, that we have power to do these things.");
        }
        favorite.Display();
        int length=favorite.GetLengthOfList();
        string entry="";
        int howManytoHide=3;
        do
        {
            Console.WriteLine("Type 'QUIT' if you want to quit the program, otherwise press ENTER to go a level deeper in the memorization");
            entry=Console.ReadLine();
            int done=0;
            Console.Clear();
            if (entry=="quit")
            {
                break;
            }
            if (favorite.SeeAll()>=3)
            {
                while (done!=howManytoHide)
                {
                    int assassin=random1.Next(length);
                    if (favorite.Check(assassin)==false)
                    {
                        favorite.Switch(assassin);
                        done++;
                    }
                }
            }
            else if (favorite.SeeAll()==2)
            {
                 while (done!=2)
                {
                    int assassin=random1.Next(length);
                    if (favorite.Check(assassin)==false)
                    {
                        favorite.Switch(assassin);
                        done++;
                    }
                }
            }
            else if (favorite.SeeAll()==1)
            {
                 while (done!=1)
                {
                    int assassin=random1.Next(length);
                    if (favorite.Check(assassin)==false)
                    {
                        favorite.Switch(assassin);
                        done++;
                    }
                }
            }
            if (favorite.SeeAll()==0)
            {
               entry="quit";
            }
            favorite.Display();
        }
        while(entry!="quit");
        
    }
}