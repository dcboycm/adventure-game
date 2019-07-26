using System;
namespace consoleproject
{
    public class Enemy
    {
        public Enemy()
        {
            Name = null;
        }

        public string Name { get; set; }

        public void setEnemyName()
        {
            Name = "Goblin";
        }
    }
}
