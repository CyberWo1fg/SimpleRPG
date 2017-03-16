using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace Engine
{
    public class EditorWorld
    {
        private readonly List<Item> _items = new List<Item>();
        private readonly List<Monster> _monsters = new List<Monster>();
        private readonly List<Quest> _quests = new List<Quest>();
        private readonly List<Location> _locations = new List<Location>();

        private const string LOCATIONS_DATA_FILE_NAME = "LocationsData.xml";
        private const string ITEMS_DATA_FILE_NAME = "ItemsData.xml";

        public const int UNSELLABLE_ITEM_PRICE = -1;

        public string DATA_PATH;

        public EditorWorld(string WorldDataPath)
        {
            DATA_PATH = WorldDataPath;
            string ItemsPath = DATA_PATH + "\\" + ITEMS_DATA_FILE_NAME;
            if (!File.Exists(ItemsPath))
                File.Create(ItemsPath);
        }

        public void SaveWorldData()
        {
            File.WriteAllText(DATA_PATH + "\\" + ITEMS_DATA_FILE_NAME, GetItemsXML());
        }

        public void AddWeaponToList(int id, string name, string namep, int price, int minD, int maxD)
        {
            _items.Add(new Weapon(id, name, namep, minD, maxD, price));
        }

        private string GetItemsXML()
        {
            XmlDocument itemsData = new XmlDocument();

            // Create the top-level XML node
            XmlNode items = itemsData.CreateElement("Items");
            itemsData.AppendChild(items);

            foreach (Item item in _items)
            {
                XmlNode itemNode = itemsData.CreateElement("Item");

                XmlAttribute idAttribute = itemsData.CreateAttribute("ID");
                idAttribute.Value = item.ID.ToString();
                itemNode.Attributes.Append(idAttribute);

                XmlAttribute priceAttribute = itemsData.CreateAttribute("Price");
                priceAttribute.Value = item.Price.ToString();
                itemNode.Attributes.Append(priceAttribute);

                XmlNode name = itemsData.CreateElement("Name");
                name.AppendChild(itemsData.CreateTextNode(item.Name));
                itemNode.AppendChild(name);

                XmlNode nameP = itemsData.CreateElement("NamePlural");
                nameP.AppendChild(itemsData.CreateTextNode(item.NamePlural));
                itemNode.AppendChild(nameP);

                XmlAttribute typeAttribute = itemsData.CreateAttribute("Type");

                if (item is Weapon)
                {
                    typeAttribute.Value = "Weapon";

                    XmlNode minD = itemsData.CreateElement("MinimumDamage");
                    minD.AppendChild(itemsData.CreateTextNode(((Weapon)item).MinimumDamage.ToString()));
                    itemNode.AppendChild(minD);

                    XmlNode maxD = itemsData.CreateElement("MaximumDamage");
                    maxD.AppendChild(itemsData.CreateTextNode(((Weapon)item).MaximumDamage.ToString()));
                    itemNode.AppendChild(maxD);

                } else 
                if (item is HealingPotion)
                {
                    typeAttribute.Value = "HealingPotion";

                    XmlNode Heal = itemsData.CreateElement("AmmountToHeal");
                    Heal.AppendChild(itemsData.CreateTextNode(((HealingPotion)item).AmountToHeal.ToString()));
                    itemNode.AppendChild(Heal);

                }

                itemNode.Attributes.Append(typeAttribute);

                items.AppendChild(itemNode);
            }

            return itemsData.InnerXml; // The XML document, as a string, so we can save the data to disk

        }
    }
}