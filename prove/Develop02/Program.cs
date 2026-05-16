using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        // Lets make the main menu
        int escolha=0;
        Journal caderno=new Journal();
        do
        {
            Console.WriteLine("Please put in an input: ");
            Console.WriteLine("1. Write an entry into the journal");
            Console.WriteLine("2. Display your current entries");
            Console.WriteLine("3. Load previous entries from a file");
            Console. WriteLine("4. Save current entries into a file");
            Console. WriteLine("5. Quit the program");
            Console.WriteLine(">");
            escolha=int.Parse(Console.ReadLine());
            if (escolha== 1)
            {
                
                Entry entryy = new Entry();
                entryy.RandomPrompt();
                entryy.Display();
                caderno.AddEntry(entryy);
            }
            else if (escolha==2)
            {
                caderno.DisplayEntries();
            }
            else if (escolha==3)
            {
                caderno.LoadFiles();
            }
            else if (escolha==4)
            {
                caderno.SaveEntries();
            }
        }while (escolha !=5);
        //Lets see if this works
        Console. WriteLine("Now Your journal is done.");
    }
}