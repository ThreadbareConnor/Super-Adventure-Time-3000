using System;


namespace Super_Adventure_Time_3000
{
    public class GlobalCommands
    {

    }

    public class Inventory
    {
        public Weapon weapon;
        public Armor armor;
        public Item item;

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
    public class Item
    {
        public string name;
        public int effect;
    }

    public class Humanoid
    {
        public int maxhealth;
        public int health;
        public int str;
        public int def;
        public int will;
        public int sweetcashmoney;
        public Inventory inventory = new Inventory();
    }
    public class Barbarian : Humanoid
    {
        public int abilityone;
        public int abilitytwo;
    }
    public class Mage : Humanoid
    {
        public int abilityone;
        public int abilitytwo;
    }
    public class Knight : Humanoid
    {
        public int abilityone;
        public int abilitytwo;
    }
    public class Enemy : Humanoid
    {
        public string name;
        public int chancetodrop;
    }

    public class Battle
    {
        public static void CallEnemy(Humanoid maincharacter)
        {
            Enemy enemy = new Enemy();
            enemy.health = maincharacter.health - 2;
            enemy.str = maincharacter.str - 3;
            enemy.def = maincharacter.def - 4;
            enemy.will = maincharacter.will - 2;
            enemy.sweetcashmoney = maincharacter.sweetcashmoney / 10;
            enemy.inventory.weapon.damage = maincharacter.inventory.weapon.damage - 2;

        }

    }

    public class BasicInterfaceCommands
    {
        public static void pressonetocontinue()
        {
            Console.WriteLine("Enter any key to continue");
            int didtheyhitakey = int.Parse(Console.ReadLine());
        }
    }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Super Adventure Time 3000");
            NewCharacter.CharacterSelection();
        }

        public static void FirstChoice(Humanoid maincharacter)
        {
            Console.WriteLine("You walk out onto the road. To the left, the trees of the forest call to you. \nTo the right you can smell fresh food and hear the clang of a blacksmiths hammer. \n 1-Head to the woods, who needs supplies when your\n the baddest Fuzzy Bunny on the planet. \n 2-Head to town. Even the best adventurers need food. ");
            int firstchoce = int.Parse(Console.ReadLine());
            switch (firstchoce)
            {
                case 1:
                    Woods.EdgeWoods(maincharacter);
                    break;
                case 2:
                    Town.TownSquare(maincharacter);
                    break;
                default:
                    Console.WriteLine("This is not an option");
                    FirstChoice(maincharacter);
                    break;

            }
        }
    }
    public class NewCharacter
    {
        public static void CharacterSelection()
        {
            Console.WriteLine("Please select a character 1-Barbarian 2-Knight 3-Mage");
            int characterselection = int.Parse(Console.ReadLine());
            if (characterselection == 1)
            {
                Barbarian maincharacter = new Barbarian();
                maincharacter.health = 10;
                maincharacter.str = 3;
                maincharacter.def = 2;
                maincharacter.will = 1;
                maincharacter.abilityone = 3;
                maincharacter.abilitytwo = 2;
                maincharacter.sweetcashmoney = 100;
                Weapon battleaxe = new Weapon();
                maincharacter.inventory.weapon = battleaxe;
                maincharacter.inventory.weapon.name = "Battleaxe";
                maincharacter.inventory.weapon.damage = 4 + maincharacter.str;
                ArmorSelection(maincharacter);
            }
            else if (characterselection == 2)
            {
                Knight maincharacter = new Knight();
                maincharacter.health = 10;
                maincharacter.str = 2;
                maincharacter.def = 3;
                maincharacter.will = 2;
                maincharacter.abilityone = 2;
                maincharacter.abilitytwo = 2;
                maincharacter.sweetcashmoney = 100;
                Weapon sword = new Weapon();
                maincharacter.inventory.weapon = sword;
                maincharacter.inventory.weapon.name = "Sword";
                maincharacter.inventory.weapon.damage = 3 + maincharacter.str;
                ArmorSelection(maincharacter);
            }
            else if (characterselection == 3)
            {
                Mage maincharacter = new Mage();
                maincharacter.health = 10;
                maincharacter.str = 1;
                maincharacter.def = 1;
                maincharacter.will = 4;
                maincharacter.abilityone = 3;
                maincharacter.abilitytwo = 4;
                maincharacter.sweetcashmoney = 100;
                Weapon boomstick = new Weapon();
                maincharacter.inventory.weapon = boomstick;
                maincharacter.inventory.weapon.name = "Boomstick";
                maincharacter.inventory.weapon.damage = 1 + maincharacter.will;
                ArmorSelection(maincharacter);
            }

            else
            {
                Console.WriteLine("This is not an option");
                CharacterSelection();
            }
        }
        public static void ArmorSelection(Humanoid maincharacter)
        {
            Console.WriteLine("You arise one morning with a strong wanderlust. \n 1-Put on armor \n 2-Put on leathers \n 3-Put on robes");
            int armorselection = int.Parse(Console.ReadLine());
            switch (armorselection)
            {
                case 1:

                    Armor knightsarmor = new Armor();
                    knightsarmor.name = "Knights Armor";
                    knightsarmor.def = 4;
                    maincharacter.inventory.armor = knightsarmor;
                    Console.WriteLine("You put on your {0}", maincharacter.inventory.armor.name);
                    Program.FirstChoice(maincharacter);
                    break;
                case 2:
                    Armor barbarianleaters = new Armor();
                    barbarianleaters.name = "Barbarian Leathers";
                    barbarianleaters.def = 3;
                    maincharacter.inventory.armor = barbarianleaters;
                    Console.WriteLine("You put on your {0}", maincharacter.inventory.armor.name);
                    Program.FirstChoice(maincharacter);
                    break;
                case 3:
                    Armor willusersrobes = new Armor();
                    willusersrobes.name = "Will Users Robes";
                    willusersrobes.def = 2;
                    maincharacter.inventory.armor = willusersrobes;
                    Console.WriteLine("You put on your {0}", maincharacter.inventory.armor.name);
                    Program.FirstChoice(maincharacter);
                    break;
                default:
                    Console.WriteLine("This is not an option");
                    ArmorSelection(maincharacter);
                    break;
            }
        }
    }
    public class Woods
    {
        public static void EdgeWoods(Humanoid maincharacter)
        {
            Console.WriteLine("A winding path through the trees unfolds before you. \n 1-Turn back \n 2-Continue onwards \n 3-Continue onwards but do not follow the path");
            int edgewoods = int.Parse(Console.ReadLine());
            switch (edgewoods)
            {
                case 1:
                    Program.FirstChoice(maincharacter);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("This is not an option");
                    EdgeWoods(maincharacter);
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
        public static void TownSquare(Humanoid maincharacter)
        {
            Console.WriteLine("You approach the towns square. To your right there is a smithy selling solid iron swords, armor, and shields. \nTo your left there is a small general store that seems to carry almost everything \none would need to go on a lengthy adventure. \n 1-Blacksmith \n 2-General store \n 3-Go Back");
            int townchoice = int.Parse(Console.ReadLine());
            switch (townchoice)
            {
                case 1:
                    TownSmith.TownBlacksmith(maincharacter);
                    break;
                case 2:
                    TownGerneralStore.Generalstore(maincharacter);
                    break;
                case 3:
                    Program.FirstChoice(maincharacter);
                    break;
                default:
                    Console.WriteLine("This is not an option");
                    TownSquare(maincharacter);
                    break;
            }
        }

    }
    public class TownSmith
    {
        public static void TownBlacksmith(Humanoid maincharacter)
        {
            Console.WriteLine("The smiths shop smells of burnt wood and sweat. The celing is black from \ncountless fires");
            Console.WriteLine("What would you like to buy? \n 1-Armor \n 2-Weapons \n 3-Go back");
            int weaponsorarmor = int.Parse(Console.ReadLine());
            switch (weaponsorarmor)
            {
                case 1:
                    TownArmor(maincharacter);
                    break;
                case 2:
                    TownWeapons(maincharacter);
                    break;
                case 3:
                    Town.TownSquare(maincharacter);
                    break;
                default:
                    TownBlacksmith(maincharacter);
                    break;
            }
        }
        public static void TownWeapons(Humanoid maincharacter)
        {
            Console.WriteLine("Which weapon would you like to buy? \n 1-Bastard Sword\n 2-Bigass Axe\n 3-Flaming Sheep Launcher");
            int armorchoice = int.Parse(Console.ReadLine());
            switch (armorchoice)
            {
                case 1:
                    Weapon bastardsword = new Weapon();
                    bastardsword.name = "Bastard Sword";
                    bastardsword.damage = 4;
                    maincharacter.inventory.weapon = bastardsword;
                    maincharacter.sweetcashmoney = maincharacter.sweetcashmoney - 25;
                    Console.WriteLine("You pay the shopkeeper 25 SCM for the large blade. You must be compensating for something");
                    BasicInterfaceCommands.pressonetocontinue();
                    TownBlacksmith(maincharacter);
                    break;
                case 2:
                    Weapon bigassaxe = new Weapon();
                    bigassaxe.name = "Bigass Axe";
                    bigassaxe.damage = 5;
                    maincharacter.inventory.weapon = bigassaxe;
                    maincharacter.sweetcashmoney = maincharacter.sweetcashmoney - 25;
                    Console.WriteLine("You pay the shopkeeper 25 SCM for your shiney new {0}", maincharacter.inventory.weapon.name);
                    BasicInterfaceCommands.pressonetocontinue();
                    TownBlacksmith(maincharacter);
                    break;
                case 3:
                    Weapon flamingsheeplauncher = new Weapon();
                    flamingsheeplauncher.name = "Flaming Sheep Launcher";
                    flamingsheeplauncher.damage = 2;
                    maincharacter.inventory.weapon = flamingsheeplauncher;
                    maincharacter.sweetcashmoney = maincharacter.sweetcashmoney - 25;
                    Console.WriteLine("You pay the shopkeeper 25 SCM for your shiney new {0}", maincharacter.inventory.weapon.name);
                    BasicInterfaceCommands.pressonetocontinue();
                    TownBlacksmith(maincharacter);
                    break;
                default:
                    TownWeapons(maincharacter);
                    break;
            }

        }
        public static void TownArmor(Humanoid maincharacter)
        {
            Console.WriteLine("Which set of armor would you like to buy\n 1-Lords Mail\n 2-Brutal Leathers\n 3-Silk Robes 4-Go Back");
            int armorchoice = int.Parse(Console.ReadLine());
            switch (armorchoice)
            {
                case 1:
                    Armor lordsmail = new Armor();
                    lordsmail.name = "Lords Mail";
                    lordsmail.def = 6;
                    maincharacter.inventory.armor = lordsmail;
                    maincharacter.sweetcashmoney = maincharacter.sweetcashmoney - 25;
                    Console.WriteLine("You pay the shopkeeper 25 SCM for your shiney new {0}", maincharacter.inventory.armor.name);
                    BasicInterfaceCommands.pressonetocontinue();
                    TownBlacksmith(maincharacter);
                    break;
                case 2:
                    Armor brutalleathers = new Armor();
                    brutalleathers.name = "Brutal Leathers";
                    brutalleathers.def = 5;
                    maincharacter.inventory.armor = brutalleathers;
                    maincharacter.sweetcashmoney = maincharacter.sweetcashmoney - 25;
                    Console.WriteLine("You pay the shopkeeper 25 SCM for your shiney new {0}", maincharacter.inventory.armor.name);
                    BasicInterfaceCommands.pressonetocontinue();
                    TownBlacksmith(maincharacter);
                    break;
                case 3:
                    Armor silkrobes = new Armor();
                    silkrobes.name = "Silk Robes";
                    silkrobes.def = 4;
                    maincharacter.inventory.armor = silkrobes;
                    maincharacter.sweetcashmoney = maincharacter.sweetcashmoney - 25;
                    Console.WriteLine("You pay the shopkeeper 25 SCM for your shiney new {0}", maincharacter.inventory.armor.name);
                    BasicInterfaceCommands.pressonetocontinue();
                    TownBlacksmith(maincharacter);
                    break;
                case 4:
                    TownBlacksmith(maincharacter);
                    break;
                default:
                    TownArmor(maincharacter);
                    break;
            }
        }
    }
    public class TownGerneralStore
    {
        public static void Generalstore(Humanoid maincharacter)
        {
            Console.WriteLine("You walk into the general store. There are groceries but you already have food. \nThe clerk points to a box full of health potions. \n 1-Buy potions 2- Leave");
            int gereralstorechoice = int.Parse(Console.ReadLine());
            switch (gereralstorechoice)
            {
                case 1:
                    Item healthpotion = new Item();
                    healthpotion.name = "Health Potion";
                    healthpotion.effect = 5;
                    maincharacter.inventory.item = healthpotion;
                    maincharacter.sweetcashmoney = maincharacter.sweetcashmoney - 10;
                    Console.WriteLine("You hand over ten SCM and recieve your {0}", maincharacter.inventory.item);
                    BasicInterfaceCommands.pressonetocontinue();
                    Generalstore(maincharacter);
                    break;
                case 2:
                    Town.TownSquare(maincharacter);
                    break;
                default:
                    Generalstore(maincharacter);
                    break;
            }
        }
    }
}