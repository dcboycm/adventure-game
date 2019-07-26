using System;
namespace consoleproject
{
    public class Fight
    {
        public Fight()
        {
        }

        Random random = new Random();

        // Take in a player and an enemey
        public Boolean fightEnemy(Player player, Enemy enemy)
        {
            int num = random.Next(10);
            if (num > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
