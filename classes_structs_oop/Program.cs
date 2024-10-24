namespace classes_structs_oop
{
    public class Character
    {
        public string name;
        public int exp;

        public Character()
        {
            name = "Not assigned";
        }

        public Character(string name)
        {
            this.name = name;
        }

        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
        }

        private void Reset()
        {
            this.name = "Not assigned";
            this.exp = 0;
        }
    }

    public struct Weapon
    {
        public string name;
        public int damage;

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public void PrintWeaponStats()
        {
            Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
        } 
    }
    public class Paladin: Character
    {
        public Weapon weapon;
        public Paladin(string name, Weapon weapon): base(name)
        {
            this.weapon = weapon;
        }
        public override void PrintStatsInfo()
        {
            Console.WriteLine("Hail " + this.name + " - take up your " + this.weapon.name + "!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            Console.WriteLine("Hero: " + hero.name + " - " + hero.exp + " EXP");

            Character heroine = new Character("Agatha");
            Console.WriteLine("Hero: " + heroine.name + " - " + heroine.exp + " EXP");

            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.PrintWeaponStats();

            Character villain = hero;

            hero.PrintStatsInfo();
            villain.PrintStatsInfo();

            villain.name = "Kor the Almighty";

            hero.PrintStatsInfo();
            villain.PrintStatsInfo();

            Weapon warBow = huntingBow;

            warBow.PrintWeaponStats();
            huntingBow.PrintWeaponStats();

            warBow.name = "War Bow";
            warBow.damage = 155;

            warBow.PrintWeaponStats();
            huntingBow.PrintWeaponStats();

            Paladin knight = new Paladin("Sir Arthur", huntingBow);
            knight.PrintStatsInfo();

            Adventurer mike = new Adventurer("Mike");
            mike.PrintStatsInfo();

            Dude dave = new Dude("Dave");
            dave.PrintStatsInfo();
        }
    }
}
