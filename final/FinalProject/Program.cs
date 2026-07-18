using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");

        //Set up the player and enemy
        Player player = new Player(name: "Hero", strength: 10, atunement: 10, dexterity: 10, hp: 100, sanity: 100);
        Enemy enemy = new Enemy(hitpoints: 70, damage: 32);
        //AI taught me a new way to write my constructors. It does make it a lot easier to read, but it is more typing. Sorry if you didn't want me to write them this way.
        Sword sword = new Sword(inhand: false, basedamage: 5, attackword: "smite", revealword: "unsheathe");
        Wand wand = new Wand(attackword: "12", revealword: "abracadabra"); // wand's "attackword" is unused by BuildChallenge, since wands use math, gott be different

        player.AddWeapon(sword);
        player.AddWeapon(wand);
        
        HealingPotion potion = new HealingPotion(healAmount: 15);
        Berserker berserker=new Berserker(newstrength: 25);


        //Let the player choose their weapon for the fight
        Console.WriteLine("Choose your weapon: (1) Sword  (2) Wand");
        string weaponChoice = Console.ReadLine();
        if (weaponChoice != null && weaponChoice.Trim() == "2")
            player.EquipWeapon(wand);
        else
            player.EquipWeapon(sword);

        //Main game loop
        int round = 1;
        while (player.IsAlive() && enemy.IsAlive())
        {
            Console.WriteLine($"\n--- Round {round} ---");
            Console.WriteLine($"Your HP: {player.GetHP()}   Enemy HP: {enemy.GetHP()}");

            Weapon activeWeapon = player.GetActiveWeapon();
            //I know that this is var, but my expected answer changes between an int and a string depending on my weapon that I select.
            var (prompt, expectedAnswer) = BuildChallenge(activeWeapon);
            Console.WriteLine(prompt);
            Console.WriteLine("(You have 3 seconds! Type 'potion' instead to heal.\nOr type 'berserker' to use your berserker potion)");

            string playerInput = await GetInputWithTimeout(3000);

            if (playerInput != null && playerInput.Trim().Equals("potion", StringComparison.OrdinalIgnoreCase))
            {
                potion.Use(player);
            }
            if (playerInput != null && playerInput.Trim().Equals("berserker", StringComparison.OrdinalIgnoreCase))
            {
                berserker.Use(player);
            }
            else if (playerInput != null && playerInput.Trim() == expectedAnswer)
            {
                int damage = activeWeapon.Attack(
                    player.GetHP(), player.GetSanity(), player.GetAtunement(),
                    player.GetDexterity(), player.GetStrength());
                enemy.ChangeHP(damage);
                Console.WriteLine($"Hit! You dealt {damage} damage.");
            }
            else
            {
                // I found a new war to write an if statement for simple things
                Console.WriteLine(playerInput == null ? "Too slow!" : "Wrong answer!");
            }

            // Enemy attacks back as long as it's still alive after the player's turn
            if (enemy.IsAlive())
            {
                player.ChangeHitPoints(-enemy.GetDamage());
                Console.WriteLine($"The enemy attacks you for {enemy.GetDamage()} damage!");
            }

            round++;
        }

        Console.WriteLine(player.IsAlive() ? "\nYou won!" : "\nYou died...");
    }

    // Builds the prompt text and the correct answer, based on which weapon is equipped
    static (string prompt, string expectedAnswer) BuildChallenge(Weapon weapon)
    {
        if (weapon is Sword sword)
        {
            string word = sword.GetAttackWord();
            return ($"Type your attack word: {word}", word);
        }
        else if (weapon is Wand wand)
        {
            Random rng = new Random();
            int a = rng.Next(1, 10);
            int b = rng.Next(1, 10);
            int answer = a + b;
            return ($"Solve to cast: {a} + {b} = ?", answer.ToString());
        }
        else
        {
            throw new ArgumentException("Unknown weapon type");
        }
    }

    //  Returns null if the timeout wins.
    static async Task<string> GetInputWithTimeout(int timeoutMs)
    {
        Task<string> inputTask = Task.Run(() => Console.ReadLine());
        Task timeoutTask = Task.Delay(timeoutMs);

        Task completed = await Task.WhenAny(inputTask, timeoutTask);

        if (completed == timeoutTask)
            return null;
        return await inputTask;
    }
}
