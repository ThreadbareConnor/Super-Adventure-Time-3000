using System;


namespace Super_Adventure_Time_3000
{

    public class NewCharacter
    {
        public static void CharacterSelection()
        {
            Console.WriteLine("Please select a character 1-Barbarian 2-Knight 3-Mage");
            int characterselection = int.Parse(Console.ReadLine());
            switch (characterselection)
            {
                case 1:
                    Barbarian barbarian = new Barbarian();
                    barbarian.health = 10;
                    barbarian.str = 3;
                    barbarian.def = 2;
                    barbarian.will = 1;
                    barbarian.bullrush = 3;
                    barbarian.shootarrow = 2;
                    barbarian.inventory = new Inventory();
                    barbarian.inventory.weapon.name = "Battleaxe";
                    barbarian.inventory.weapon.damage = 4;
                    ArmorSelection();
                    break;
                case 2:
                    Knight knight = new Knight();
                    knight.health = 10;
                    knight.str = 2;
                    knight.def = 3;
                    knight.will = 2;
                    knight.slash = 2;
                    knight.shieldbash = 2;
                    knight.inventory.weapon.name = "Sword";
                    knight.inventory.weapon.damage = 3 + knight.str;
                    ArmorSelection();
                    break;
                case 3:
                    Mage mage = new Mage();
                    mage.health = 10;
                    mage.str = 1;
                    mage.def = 1;
                    mage.will = 4;
                    mage.fireball = 3;
                    mage.icelance = 4;
                    mage.inventory.weapon.name = "Boomstick";
                    mage.inventory.weapon.damage = 1;
                    ArmorSelection();
                    break;
                default:
                    Console.WriteLine("This is not an option");
                    CharacterSelection();
                    break;
            }
        }
        public static void ArmorSelection()
        {
            Console.WriteLine("You arise one morning with a strong wanderlust. \n 1-Put on armor \n 2-Put on leathers \n 3-Put on robes");
            int armorselection = int.Parse(Console.ReadLine());
            switch (armorselection)
            {
                case 1:
                    Console.WriteLine("You put on your Knights armor");
                    Program.FirstChoice();
                    break;
                case 2:
                    Console.WriteLine("You put on your Barbarian Leathers");
                    Program.FirstChoice();
                    break;
                case 3:
                    Console.WriteLine("You put on your Will Users Robes");
                    Program.FirstChoice();
                    break;
                default:
                    Console.WriteLine("This is not an option");
                    ArmorSelection();
                    break;
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Super Adventure Time 3000");
            NewCharacter.CharacterSelection();
        }

        public static void FirstChoice()
        {
            Console.WriteLine("You walk out onto the road. To the left, the trees of the forest call to you. To the right you can smell fresh food and hear the clang of a blacksmiths hammer. \n 1-Head to the woods, who needs supplies when your\n the baddest Fuzzy Bunny on the planet. \n 2-Head to town. Even the best adventurers need food. ");
            int firstchoce = int.Parse(Console.ReadLine());
            switch (firstchoce)
            {
                case 1:
                    Woods.EdgeWoods();
                    break;
                case 2:
                    Town.TownSquare();
                    break;
                default:
                    Console.WriteLine("This is not an option");
                    FirstChoice();
                    break;

            }
        }


    }
    public class Woods
    {
        public static void EdgeWoods()
        {
            Console.WriteLine("A winding path through the trees unfolds before you. \n 1-Turn back \n 2-Continue onwards \n 3-Continue onwards but do not follow the path");
            int edgewoods = int.Parse(Console.ReadLine());
            switch (edgewoods)
            {
                case 1:
                    Program.FirstChoice();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("This is not an option");
                    EdgeWoods();
                    break;
            }
        }
        public static void WoodlandPath()
        {
            Console.WriteLine("The path ahead is dappeled with sunlight. Birds sing in the trees and you \n feel the sudden urge to skip down the path. Skipping is for nancies though\n so you refrain. \n 1-Keep walking");
            int moveon = int.Parse(Console.ReadLine());
            if (moveon == 1)
            {
                Console.WriteLine("A side path appears before you");

            }
            else if (moveon != 1)
            {
                Console.WriteLine("This is not an option");
                WoodlandPath();
            }
        }
    }
    public class Town
    {
        public static void TownSquare()
        {
            Console.WriteLine("You approach the towns square. To your right there is a smithy selling solid iron swords, armor, and shields. To your left there is a small general store that seems to carry almost everything one would need to go on a lengthy adventure. \n 1-Go right \n 2-Go left");
            int townchoice = int.Parse(Console.ReadLine());
            switch (townchoice)
            {
                case 1:
                    TownBlacksmith();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("This is not an option");
                    TownSquare();
                    break;
            }
        }
        public static void TownBlacksmith()
        {
            Console.WriteLine("The smiths shop smells of burnt wood and sweat. The celing is black from \ncountless fires");
            TownSquare();
        }
    }
    public class Humanoid
    {
        public int health;
        public int str;
        public int def;
        public int will;
        public int sweetcashmoney;
        public Inventory inventory; 
    }
    public class Barbarian : Humanoid
    {
        public int bullrush = 2;
        public int shootarrow = 1;
    }
    public class Mage : Humanoid
    {
        public int fireball = 3;
        public int icelance = 2;
    }
    public class Knight : Humanoid
    {
        public int slash = 2;
        public int shieldbash = 1;
    }
    public class Weapon
    {
       public string name;
       public int damage;
    }
    public class Armor
    {
        public string name;
        public int def;
    }
    public class Inventory
    {
        public Weapon weapon;
        public Armor armor;

    }
}


            





       

        
    
