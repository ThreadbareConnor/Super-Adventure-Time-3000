using System;


namespace Super_Adventure_Time_3000
{

    public class NewCharacter
    {
        public static void CharacterSelection()
        {
            Console.WriteLine("Please select a character 1-Barbarian 2-Knight 3-Mage");
            int characterselection = int.Parse(Console.ReadLine());
            if(characterselection == 1)
            {
                    Barbarian maincharacter = new Barbarian();
                    maincharacter.health = 10;
                    maincharacter.str = 3;
                    maincharacter.def = 2;
                    maincharacter.will = 1;
                    maincharacter.bullrush = 3;
                    maincharacter.shootarrow = 2;
                    maincharacter.inventory = new Inventory();
                    maincharacter.inventory.weapon.name = "Battleaxe";
                    maincharacter.inventory.weapon.damage = 4 + maincharacter.str;
                    ArmorSelection();
            }
            else if (characterselection == 2)
            {
                    Knight maincharacter = new Knight();
                    maincharacter.health = 10;
                    maincharacter.str = 2;
                    maincharacter.def = 3;
                    maincharacter.will = 2;
                    maincharacter.slash = 2;
                    maincharacter.shieldbash = 2;
                    maincharacter.inventory.weapon.name = "Sword";
                    maincharacter.inventory.weapon.damage = 3 + maincharacter.str;
                    ArmorSelection();
            }
            else if (characterselection ==3)
            {
                    Mage maincharacter = new Mage();
                    maincharacter.health = 10;
                    maincharacter.str = 1;
                    maincharacter.def = 1;
                    maincharacter.will = 4;
                    maincharacter.fireball = 3;
                    maincharacter.icelance = 4;
                    maincharacter.inventory.weapon.name = "Boomstick";
                    maincharacter.inventory.weapon.damage = 1 + maincharacter.will;
                    ArmorSelection();
            }
                    
            else 
            {
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
    public class Enemy : Humanoid
    {
        public string name;
        public int chancetodrop;
    }
     public class Humanoid
    {
        public int maxhealth;
        public int health;
        public int str;
        public int def;
        public int will;
        public int sweetcashmoney;
        public Inventory inventory; 
    }
    public class Battle
    {
        Enemy enemy = new Enemy();
        enemy.health = maincharacter.health - 2;
        enemy.str = maincharacter.str - 3;
        enemy.def = maincharacter.def -4;
        enemy.will = maincharacter.will -2;
        enemy.sweetcashmoney = maincharacter.sweetcashmoney / 10;
        enemy.inventory.weapon.damage = maincharacter.inventory.weapon.damage - 2;



    }
}


            





       

        
    
