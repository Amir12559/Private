using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ArenaFighter
{
    class RollingDie
    {
       
        private Random random;
        private int sidesCount;
        public RollingDie()
        {
            sidesCount = 6;
            random = new Random();
        }

        public RollingDie(int sidesCount)
        {
            this.sidesCount = sidesCount;
            random = new Random();
        }

        public int GetSidesCount()
        {
            return sidesCount;
        }

        public int Roll()
        {
            return random.Next(1, sidesCount + 1);
        }

        public override string ToString()
        {
            return String.Format("Rolling die with {0} sides", sidesCount);
        }

    }
    class Player
    {
        private string name;
        private int health;
        private int maxHealth;      
        private int damage;
        private int defense;
        private RollingDie die;
        private string message;

        public Player(string name,  int health, int damage, int defense, RollingDie die)
        {
            this.name = name;
            this.health = health;
            this.maxHealth = health;           
            this.damage = damage;  
            this.defense = defense;
            this.die = die;
        }

        public override string ToString()
        {
            return name;
        }

        public bool Alive()
        {
            return (health > 0);
        }

        public string HealthBar()
        {
            string s = "[";
            int total = 20;
            double count = Math.Round(((double)health / maxHealth) * total);
            if ((count == 0) && (Alive()))
                count = 1;
            for (int i = 0; i < count; i++)
                s += "#";
            s = s.PadRight(total + 1);
            s += "]";
            return s;
        }

        public void Attack(Player enemy)
        {
            int hit = damage + die.Roll();
            SetMessage(String.Format("{0} attacks with a hit worth {1} hp", name, hit));
            enemy.Defend(hit);
        }

        public void Defend(int hit)
        {
            int injury = hit - (defense + die.Roll());
            if (injury > 0)
            {
                health -= injury;
                message = String.Format("{0} defended against the attack but still lost {1} hp", name, injury);
                if (health <= 0)
                {
                    health = 0;
                    message += " and died";
                }

            }
            else
                message = String.Format("{0} blocked the hit", name);
            SetMessage(message);
        }

        private void SetMessage(string message)
        {
            this.message = message;
        }

        public string GetLastMessage()
        {
            return message;
        }

    }
    class Arena
    {
        private Player Player1; // Instances // These fields will be initialized from the constructor parameters
        private Player Player2;
        private RollingDie die;

        public Arena(Player Player1, Player Player2, RollingDie die)
        {
            this.Player1 = Player1;
            this.Player2 = Player2;
            this.die = die;
        }

        private void Render() // Method used to print 
        {
            Console.Clear();// Clear() method, which clears the console screen// The method is private, it'll be used only within the class.
            Console.WriteLine("-------------- Arena -------------- \n");
            Console.WriteLine("Players health: \n");
            Console.WriteLine("{0} {1}", Player1, Player1.HealthBar());
            Console.WriteLine("{0} {1}", Player2, Player2.HealthBar());
        }

        private void PrintMessage(string message) // private method to print dramtic pause
        {
            Console.WriteLine(message);//We added using System.Threading; 
            Thread.Sleep(500);
        }

        public void Fight()
        {
            // The original order
            Player w1 = Player2;
            Player w2 = Player1;
            Console.WriteLine("Welcome to the Arena!");
            Console.WriteLine("Today {0} will battle against {1}! \n", Player1, Player2);
            // swapping the Players
            bool Player2Starts = (die.Roll() <= die.GetSidesCount() / 2);
            if (Player2Starts)
            {
                w1 = Player2;
                w2 = Player1;
            }
            Console.WriteLine("{0} goes first! \nLet the battle begin...", w1);
            Console.ReadKey();
            // fight loop
            while (w1.Alive() && w2.Alive())
            {
                w1.Attack(w2);
                Render();
                PrintMessage(w1.GetLastMessage()); // attack message
                PrintMessage(w2.GetLastMessage()); // defense message
                if (w2.Alive())
                {
                    w2.Attack(w1);
                    Render();
                    PrintMessage(w2.GetLastMessage()); // attack message
                    PrintMessage(w1.GetLastMessage()); // defense message
                }
                Console.WriteLine();
            }
        }

    }
    

    class Program
    {
        static void Main(string[] args)
        {


            // creating objects
            RollingDie die = new RollingDie(10);
            Player Amir = new Player("Amir", 10, 20, 16, die);
            Player Uzma = CreatePlayer();
            Arena arena = new Arena(Amir, Uzma, die);
            // fight
            arena.Fight();
            Console.ReadKey();
        }

        private static Player CreatePlayer()
        {
            Player player;
            Random random = new Random();
            string[] names = new string[] { "Uzma", "Rocket", "Rocket2", "Rocket3", "Rocket4", "Rocket5", "Rocket6", "Rocket7", "Rocket8" };// It will go for random

            string name = names[random.Next(0, names.Length - 1)];
            player = new Player(name, 5, 5, 5, new RollingDie());
            return player;
        }
    }
}
