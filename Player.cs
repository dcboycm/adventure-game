using System;
namespace consoleproject
{
    public class Player : PlayerClasses
    {
        public Player()
        {
            Name = null;
            PlayerClass = null;
            Level = 1;
            Experience = 0;
        }

        public string Name { get; set; }
        public string PlayerClass { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public void setPlayerName()
        {
            Console.WriteLine("What is your name?");

            Name = Console.ReadLine();
        }

        public void setPlayerClass(Player player)
        {
            Console.WriteLine("What is your class? \n 1. Knight \n 2. Wizard \n 3. Theif");
            int classSelection;
            int.TryParse(Console.ReadLine(), out classSelection);

            switch (classSelection)
            {
                case 1:
                    PlayerClass = "Knight";
                    Level = 1;
                    setAttributes(PlayerClass);
                    break;
                case 2:
                    PlayerClass = "Wizard";
                    Level = 1;
                    setAttributes(PlayerClass);
                    break;
                case 3:
                    PlayerClass = "Theif";
                    Level = 1;
                    setAttributes(PlayerClass);
                    break;
                default:
                    Console.WriteLine("You did not make a correct selection: ");
                    Level = 1;
                    setPlayerClass(player);
                    break;
            }
        }

    }

}
