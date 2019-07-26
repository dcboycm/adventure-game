using System;

namespace consoleproject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate objects
            Messages messages = new Messages();
            Player player_one = new Player();
            Enemy enemy = new Enemy();
            Fight fight = new Fight();

            // Set up player
            player_one.setPlayerName();
            player_one.setPlayerClass(player_one);

            // Welcome player
            messages.openingMessages(player_one);

            // Fight enemy
            Boolean success = fight.fightEnemy(player_one, enemy);
            if (success)
            {
                Console.WriteLine("You did it!");
            }
            else
            {
                Console.WriteLine("You dead...");
            }
        }
    }
}
