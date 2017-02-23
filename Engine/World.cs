using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        //ITEMS
            //WEAPONS
        public const int WEAPON_ID_SHITTY_KNIFE = 1;
        public const int WEAPON_ID_DRAGONBANE = 2;
        public const int WEAPON_ID_KEYBLADE = 3;
            //POTIONS
        public const int POTION_ID_HEALING_POTION = 4;
        public const int POTION_ID_GODDESS_TEARS = 5;
            //MISCELANEOUS
        public const int ITEM_ID_BANDIT_RING = 6;
        public const int ITEM_ID_PIECE_OF_FUR = 7;
        public const int ITEM_ID_SNAKE_FANG = 8;
        public const int ITEM_ID_SNAKESKIN = 9;
        public const int ITEM_ID_BEAR_FANG = 10;
        public const int ITEM_ID_SPIDER_SILK = 11;
        public const int ITEM_ID_ADVENTURER_PASS = 12;
            //SCROLLS
        public const int SCROLL_ID_BLAZE = 13;
        //ENEMIES
            //MONSTERS
        public const int MONSTER_ID_BANDIT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_WEABOO = 6;
            //BOSSES
        public const int BOSS_ID_MASTER_CHIEF = 4;
        public const int BOSS_ID_XIDAS = 5;
        //QUESTS
            //BASIC
        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
            //BOSS 
        public const int BOSS_QUEST_BEAT_MASTER_CHIEF = 3;
        //LOCATIONS
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_RAPTURE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(WEAPON_ID_SHITTY_KNIFE, "Shitty Knife", "Shitty Knives", 0, 5));
            Items.Add(new Item(ITEM_ID_BANDIT_RING, "Bandit Ring", "Bandit Rings"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs"));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins"));
            Items.Add(new Weapon(WEAPON_ID_DRAGONBANE, "Dragonbane", "Dragonbanes", 3, 10));
            Items.Add(new HealingPotion(POTION_ID_HEALING_POTION, "Healing potion", "Healing potions", 5));
            Items.Add(new Item(ITEM_ID_BEAR_FANG, "Bear fang", "Bear fangs"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes"));
            Items.Add(new Weapon(WEAPON_ID_KEYBLADE, "Keyblade", "Keyblades", 6, 13));
            Items.Add(new HealingPotion(POTION_ID_GODDESS_TEARS, "Goddess Tears", "Goddess Tears", 50));
            Items.Add(new Scroll(SCROLL_ID_BLAZE, "BLAZE", "BLAZE", 15, 50, 1));
        }

        private static void PopulateMonsters()
        {
            Monster bandit = new Monster(MONSTER_ID_BANDIT, "Bandit", 10, 4, 10, 6, 6);
            bandit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BANDIT_RING), 75, false));
            bandit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));
            bandit.LootTable.Add(new LootItem(ItemByID(SCROLL_ID_BLAZE), 50, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEAR_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monster masterChief = new Monster(BOSS_ID_MASTER_CHIEF, "Master Chief", 150, 300, 100, 100, 100);
            masterChief.LootTable.Add(new LootItem(ItemByID(WEAPON_ID_DRAGONBANE), 5, true));

            Monster xidas = new Monster(BOSS_ID_XIDAS, "Las Xidas", 26, 150, 100, 50, 50);
            xidas.LootTable.Add(new LootItem(ItemByID(WEAPON_ID_KEYBLADE), 100, true));

            Monsters.Add(bandit);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
            Monsters.Add(masterChief);
            Monsters.Add(xidas);
        }
        private static void PopulateQuests()

        {
            Quest clearAlchemistGarden =
                new Quest(
                    QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Clear the alchemist's garden",
                    "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.", 20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BANDIT_RING), 3));

            clearAlchemistGarden.RewardItem = ItemByID(POTION_ID_HEALING_POTION);

            Quest clearFarmersField =
                new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Clear the farmer's field",
                    "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an adventurer's pass and 20 gold pieces.", 20, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. Because every hero has a place to come back. Except Aerith... She just can't.");
            home.MonsterLivingHere = MonsterByID(BOSS_ID_MASTER_CHIEF);
            // home.MonsterLivingHere = null;

            Location rapture = new Location(LOCATION_ID_RAPTURE, "Rapture", "The biggest city");

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_BANDIT);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", ItemByID(ITEM_ID_ADVENTURER_PASS));

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");
            bridge.MonsterLivingHere = MonsterByID(BOSS_ID_XIDAS);

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            // Link the locations together
            home.LocationToNorth = rapture;

            rapture.LocationToNorth = alchemistHut;
            rapture.LocationToSouth = home;
            rapture.LocationToEast = guardPost;
            rapture.LocationToWest = farmhouse;

            farmhouse.LocationToEast = rapture;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = rapture;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = rapture;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(rapture);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}