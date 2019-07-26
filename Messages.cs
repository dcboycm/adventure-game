using System;
namespace consoleproject
{
    public class Messages
    {
        public Messages()
        {
        }

        Random random = new Random();

        public void openingMessages(Player player)
        {
            Console.WriteLine("Hello there " + player.Name + ". Glad to see a " + player.PlayerClass + " has joined the fight!");
            Console.WriteLine("Attack : {0}", player.Attack);
            Console.WriteLine("Defense : {0}", player.Defense);
            Console.WriteLine("Health : {0}", player.Health);
        }

        public void fightFailure(Player player)
        {
            Console.WriteLine("It appears as though " + player.Name + " has fallen");
        }

        /**
         * When a player wins a fight we reward them with XP
         */
        public int fightSuccess(Player player, Enemy enemy)
        {
            int num = random.Next(10);

            Console.WriteLine(player.Name + " has killed " + enemy.Name);
            return num;
        }
    }
}
