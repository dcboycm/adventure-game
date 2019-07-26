namespace consoleproject
{
    public class PlayerClasses
    {
        public PlayerClasses()
        {

        }

        public int setAttack(string chosenClass) 
        {
            switch (chosenClass)
            {
                case "Knight":
                    Attack = 10;
                    return Attack;
                case "Wizard":
                    Attack = 4;
                    return Attack;
                case "Theif":
                    Attack = 6;
                    return Attack;
                default:
                    return 0;
            }
        }

        public int setDefense(string chosenClass) 
        {
            switch (chosenClass)
            {
                case "Knight":
                    Defense = 6;
                    return Defense;
                case "Wizard":
                    Defense = 2;
                    return Defense;
                case "Theif":
                    Defense = 4;
                    return Defense;
                default:
                    return 0;
            }
        }

        public int setHealth(string chosenClass) 
        {
            switch (chosenClass)
            {
                case "Knight":
                    Health = 8;
                    return Health;
                case "Wizard":
                    Health = 4;
                    return Health;
                case "Theif":
                    Health = 4;
                    return Health;
                default:
                    return 0;
            }
        }

        public void setAttributes(string chosenClass) 
        {
            setAttack(chosenClass);
            setDefense(chosenClass);
            setHealth(chosenClass);
        }

        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }

    }
}