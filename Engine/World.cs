using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace Engine
{
    public static class World
    {
        private static readonly List<Item> _items = new List<Item>();
        private static readonly List<Monster> _monsters = new List<Monster>();
        private static readonly List<Quest> _quests = new List<Quest>();
        private static readonly List<Location> _locations = new List<Location>();

        private const string LOCATIONS_DATA_FILE_NAME = "LocationsData.xml";

        public const int UNSELLABLE_ITEM_PRICE = -1;

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_STONE_KNIFE = 11;
        public const int ITEM_ID_STONE_AXE = 12;
        public const int ITEM_ID_SILICON_KNIFE = 13;
        public const int ITEM_ID_SILICON_AXE = 14;
        public const int ITEM_ID_WOLF_SKIN = 15;
        public const int ITEM_ID_WOLF_FANG = 16;
        public const int ITEM_ID_BEAR_SKIN = 17;
        public const int ITEM_ID_HALFHUMAN_HEAD = 18;
        public const int ITEM_ID_FISH = 19;
        public const int ITEM_ID_MUSHROOMS = 20;
        public const int ITEM_ID_BIRD_EGG = 21;
        public const int ITEM_ID_WILD_BERRY = 22;
        public const int ITEM_ID_BAD_STONE = 23;
        public const int ITEM_ID_GOOD_STONE = 24;
        public const int ITEM_ID_BEST_STONE = 25;
        public const int ITEM_ID_PIKE = 26;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_SPIDER = 3;
        public const int MONSTER_ID_GIANT_SPIDER = 4;
        public const int MONSTER_ID_WOLF = 5;
        public const int MONSTER_ID_BEAR = 6;
        public const int MONSTER_ID_HALFHUMAN = 7;

        public const int QUEST_ID_FISHING = 1;
        public const int QUEST_ID_STONE_FOR_AXE = 2;
        public const int QUEST_ID_NEW_AMULET = 3;
        public const int QUEST_ID_NEED_FOR_FOOD = 4;

        public const int LOCATION_ID_VILLAGE = 1;
        public const int LOCATION_ID_VILLAGE_MEADOW = 2;
        public const int LOCATION_ID_RIVERBAND = 3;
        public const int LOCATION_ID_FOREST_RIVER = 4;
        public const int LOCATION_ID_FOREST = 5;
        public const int LOCATION_ID_BLACKWOOD_PATH = 6;
        public const int LOCATION_ID_OAK_GROVE = 7;
        public const int LOCATION_ID_VILLAGE_BACK = 8;
        public const int LOCATION_ID_SOUTHWEST = 9;
        public const int LOCATION_ID_VILLAGE_SOUTH = 10;
        public const int LOCATION_ID_LIGHTWOOD_EDGE = 11;
        public const int LOCATION_ID_LIGHTWOOD_RIVER = 12;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            //PopulateLocations();
            PopulateLocationsNew();
        }

        private static void PopulateLocationsNew()
        {
            Location village = new Location(LOCATION_ID_VILLAGE, "Деревня невров", "Пара крупных деревьев с дуплами используется как жилища. Также есть несколько землянок. Деревья-великаны окружили исполинскую поляну плотной стеной, ветви над ней переплелись. Выход из деревни только на востоке.");
            Location villageMeadow = new Location(LOCATION_ID_VILLAGE_MEADOW, "Поляна", "Деревенская поляна. Тут проводятся различные обряды и посвящения");
            Location riverBand = new Location(LOCATION_ID_RIVERBAND, "Излучина реки", "Излучина реки. Край деревни");
            Location forestRiver = new Location(LOCATION_ID_FOREST_RIVER, "Река в полесье", "Продолжение реки к северу от деревни. Русло реки ширится и уходит на северо-запад. Если уйти на север сейчас, через реку не перейти");
            Location forest = new Location(LOCATION_ID_FOREST, "Полесье", "Отсюда можно уйти по направлению в черный лес, или к большой реке");
            Location blackwoodPath = new Location(LOCATION_ID_BLACKWOOD_PATH, "Тропа в черный лес", "В черном лесу можно сгинуть с первых же шагов. Но тропа туда все равно имеется");
            Location oakGrove = new Location(LOCATION_ID_OAK_GROVE, "Дубовая роща", "Последний рубеж перед черным лесом. Дальше на запад лучше не идти");
            Location villageBack = new Location(LOCATION_ID_VILLAGE_BACK, "Лес за деревней", "\" Задний двор \" деревни. Отсюда можно увидеть Дупло Боромира");
            Location southWest = new Location(LOCATION_ID_SOUTHWEST, "Юго западный угол деревни", "Просто еще одна лесная локация");
            Location villageSouth = new Location(LOCATION_ID_VILLAGE_SOUTH, "Юг от деревни", "Дальше на юге Темный лес. Там Полулюди убивают всех.");
            Location lightwoodEdge = new Location(LOCATION_ID_LIGHTWOOD_EDGE, "Край светлого леса", "Дальше на юге Темный лес. Там Полулюди убивают всех.");
            Location lightwoodRiver = new Location(LOCATION_ID_LIGHTWOOD_RIVER, "Река светлого леса", "Дальше на юге Темный лес. Там Полулюди убивают всех.");

            village.QuestAvailableHere = QuestByID(QUEST_ID_NEED_FOR_FOOD);

            villageBack.AddMonster(MONSTER_ID_SPIDER, 95);
            villageBack.AddMonster(MONSTER_ID_GIANT_SPIDER, 5);

            riverBand.AddLoot(ITEM_ID_WILD_BERRY, 30);
            riverBand.AddLoot(ITEM_ID_BIRD_EGG, 15);

            forestRiver.AddLoot(ITEM_ID_WILD_BERRY, 30);
            forestRiver.AddLoot(ITEM_ID_BIRD_EGG, 30);

            forest.AddLoot(ITEM_ID_WILD_BERRY, 25);
            forest.AddLoot(ITEM_ID_MUSHROOMS, 45);

            village.LocationToEast = villageMeadow;

            villageMeadow.LocationToEast = riverBand;
            villageMeadow.LocationToWest = village;
            villageMeadow.LocationToSouth = lightwoodEdge;

            riverBand.LocationToNorth = forestRiver;
            riverBand.LocationToWest = villageMeadow;
            riverBand.LocationToSouth = lightwoodRiver;

            forestRiver.LocationToSouth = riverBand;
            forestRiver.LocationToWest = forest;

            forest.LocationToEast = forestRiver;
            forest.LocationToWest = blackwoodPath;

            blackwoodPath.LocationToEast = forest;
            blackwoodPath.LocationToWest = oakGrove;

            oakGrove.LocationToEast = blackwoodPath;
            oakGrove.LocationToSouth = villageBack;

            villageBack.LocationToNorth = oakGrove;
            villageBack.LocationToSouth = southWest;

            southWest.LocationToNorth = villageBack;
            southWest.LocationToEast = villageSouth;

            villageSouth.LocationToWest = southWest;
            villageSouth.LocationToEast = lightwoodEdge;

            lightwoodEdge.LocationToWest = villageSouth;
            lightwoodEdge.LocationToNorth = villageMeadow;
            lightwoodEdge.LocationToEast = lightwoodRiver;

            lightwoodRiver.LocationToWest = lightwoodEdge;
            lightwoodRiver.LocationToNorth = riverBand;
            
             // Add the locations to the static list
            _locations.Add(village);
            _locations.Add(villageMeadow);
            _locations.Add(riverBand);
            _locations.Add(forestRiver);
            _locations.Add(forest);
            _locations.Add(blackwoodPath);
            _locations.Add(oakGrove);
            _locations.Add(villageBack);
            _locations.Add(southWest);
            _locations.Add(villageSouth);
            _locations.Add(lightwoodEdge);
            _locations.Add(lightwoodRiver);

        }

        private static void PopulateItems()
        {
            _items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5, 5));
            _items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails", 1));
            _items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur", 1));
            _items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs", 1));
            _items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", 2));
            _items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10, 8));
            _items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5, 3));
            _items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs", 1));
            _items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks", 1));
            _items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes", UNSELLABLE_ITEM_PRICE));
            _items.Add(new Weapon(ITEM_ID_STONE_KNIFE, "Stone knife", "stone knives", 0, 3, 10));
            _items.Add(new Weapon(ITEM_ID_STONE_AXE, "Stone axe", "stone axes", 2, 5, 30));
            _items.Add(new Weapon(ITEM_ID_SILICON_KNIFE, "Silicon knife", "Silicon knives", 1, 4, 20));
            _items.Add(new Weapon(ITEM_ID_SILICON_AXE, "Silicon axe", "Silicon axes", 4, 9, 50));
            _items.Add(new Item(ITEM_ID_WOLF_SKIN, "Wolf skin", "Wolf skins", 2)); 
            _items.Add(new Item(ITEM_ID_WOLF_FANG, "Wolf fang", "Wolf fangs", 3));
            _items.Add(new Item(ITEM_ID_BEAR_SKIN, "Bear skin", "Bear skins", 50));
            _items.Add(new Item(ITEM_ID_HALFHUMAN_HEAD, "Head of halfhuman", "Heads of halfhumans", 1));
            _items.Add(new Item(ITEM_ID_FISH, "Fish", "Fishes", 5));
            _items.Add(new Item(ITEM_ID_MUSHROOMS, "Mashroom", "Mashrooms", 7));
            _items.Add(new Item(ITEM_ID_BIRD_EGG, "Bird's egg", "Bird's eggs", 10));
            _items.Add(new Item(ITEM_ID_WILD_BERRY, "Wild berry", "Wild berries", 6));
            _items.Add(new Item(ITEM_ID_BAD_STONE, "Bad stone", "Bad stones", 1));
            _items.Add(new Item(ITEM_ID_GOOD_STONE, "Good stone", "Good stones", 2));
            _items.Add(new Item(ITEM_ID_BEST_STONE, "Best stone", "Best stones", 5));
            _items.Add(new Weapon(ITEM_ID_PIKE, "Wooden pike", "Wooden pikes", 3, 8, 25));
    }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.AddLoot(ITEM_ID_RAT_TAIL, 75);
            rat.AddLoot(ITEM_ID_PIECE_OF_FUR, 75, true);

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.AddLoot(ITEM_ID_SNAKE_FANG, 75);
            snake.AddLoot(ITEM_ID_SNAKESKIN, 75, true);

            Monster spider = new Monster(MONSTER_ID_SPIDER, "Spider", 5, 3, 10, 3, 3);
            spider.AddLoot(ITEM_ID_SPIDER_FANG, 50, true);
            spider.AddLoot(ITEM_ID_SPIDER_SILK, 10);
 
            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.AddLoot(ITEM_ID_SPIDER_FANG, 75, true);
            giantSpider.AddLoot(ITEM_ID_SPIDER_SILK, 25);

            Monster wolf = new Monster(MONSTER_ID_WOLF, "Wolf", 15, 4, 0, 5, 5);
            wolf.AddLoot(ITEM_ID_WOLF_SKIN, 65, true);
            wolf.AddLoot(ITEM_ID_WOLF_FANG, 35);

            Monster bear = new Monster(MONSTER_ID_BEAR, "Bear", 40, 50, 0, 60, 60);
            bear.AddLoot(ITEM_ID_BEAR_SKIN, 100);

            Monster halfhuman = new Monster(MONSTER_ID_HALFHUMAN, "Wild Half Human", 50, 100, 0, 100, 100);
            halfhuman.AddLoot(ITEM_ID_STONE_KNIFE, 5);
            halfhuman.AddLoot(ITEM_ID_STONE_AXE, 1);

            _monsters.Add(rat);
            _monsters.Add(snake);
            _monsters.Add(spider);
            _monsters.Add(giantSpider);
            _monsters.Add(wolf);
            _monsters.Add(bear);
            _monsters.Add(halfhuman);

        }

        private static void PopulateQuests()
        {
            Quest fishing =
                new Quest(
                    QUEST_ID_FISHING,
                    "Веселая рыбалка",
                    "Годовит попросил вас наловить вместо него рыбы. Думаю, 10 рыбин должно хватить", 20, 0);
            fishing.RewardItem = ItemByID(ITEM_ID_BIRD_EGG);

            Quest stoneForAxe =
                new Quest(
                    QUEST_ID_STONE_FOR_AXE,
                    "Найдите лучший камень",
                    "Громобой сможет сделать вам каменную секиру, но для этого ему нужен хороший кусок камня", 30, 0);

            stoneForAxe.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BEST_STONE), 1));
            stoneForAxe.RewardItem = ItemByID(ITEM_ID_STONE_AXE);

            Quest needForFood =
                new Quest(
                    QUEST_ID_NEED_FOR_FOOD,
                    "Найдите еды и принесите в деревню",
                    "После зимы все жители деревню очень слабы и голодны. Вы должны найти немного еды, подкрепиться самому и помочь другим жителям", 10 , 0);

            needForFood.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_WILD_BERRY), 10));

            Quest newAmulet =
                new Quest(
                    QUEST_ID_NEW_AMULET,
                    "Принеси Боромиру змеиные клыки для нового оберега",
                    "К северу от деревни должны водиться змеи. На новый оберег нужно 20 змеиных клыков", 20, 0);

            newAmulet.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 20));

            newAmulet.RewardItem = ItemByID(ITEM_ID_SILICON_KNIFE);

            _quests.Add(needForFood);
            _quests.Add(newAmulet);
            _quests.Add(fishing);
            _quests.Add(stoneForAxe);
        }

        private static void PopulateLocations()
        {
            //// Create each location
            //Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.");

            //Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.");

            //Vendor bobTheRatCatcher = new Vendor("Bob the Rat-Catcher");
            //bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_PIECE_OF_FUR), 5);
            //bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_RAT_TAIL), 3);
            //bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_CLUB), 1);

            //townSquare.VendorWorkingHere = bobTheRatCatcher;

            //Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.");
            //alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            //Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.");
            //alchemistsGarden.AddMonster(MONSTER_ID_RAT, 100);

            //Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            //farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            //Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.");
            //farmersField.AddMonster(MONSTER_ID_SNAKE, 100);
            //Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", ItemByID(ITEM_ID_ADVENTURER_PASS));

            //Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            //Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.");
            //spiderField.AddMonster(MONSTER_ID_GIANT_SPIDER, 100);

            //// Link the locations together
            //home.LocationToNorth = townSquare;

            //townSquare.LocationToNorth = alchemistHut;
            //townSquare.LocationToSouth = home;
            //townSquare.LocationToEast = guardPost;
            //townSquare.LocationToWest = farmhouse;

            //farmhouse.LocationToEast = townSquare;
            //farmhouse.LocationToWest = farmersField;

            //farmersField.LocationToEast = farmhouse;

            //alchemistHut.LocationToSouth = townSquare;
            //alchemistHut.LocationToNorth = alchemistsGarden;

            //alchemistsGarden.LocationToSouth = alchemistHut;

            //guardPost.LocationToEast = bridge;
            //guardPost.LocationToWest = townSquare;

            //bridge.LocationToWest = guardPost;
            //bridge.LocationToEast = spiderField;

            //spiderField.LocationToWest = bridge;

            //// Add the locations to the static list
            //_locations.Add(home);
            //_locations.Add(townSquare);
            //_locations.Add(guardPost);
            //_locations.Add(alchemistHut);
            //_locations.Add(alchemistsGarden);
            //_locations.Add(farmhouse);
            //_locations.Add(farmersField);
            //_locations.Add(bridge);
            //_locations.Add(spiderField);
        }

        public static Item ItemByID(int id)
        {
            return _items.SingleOrDefault(x => x.ID == id);
        }

        public static Monster MonsterByID(int id)
        {
            return _monsters.SingleOrDefault(x => x.ID == id);
        }

        public static Quest QuestByID(int id)
        {
            return _quests.SingleOrDefault(x => x.ID == id);
        }

        public static Location LocationByID(int id)
        {
            return _locations.SingleOrDefault(x => x.ID == id);
        }
    }
}