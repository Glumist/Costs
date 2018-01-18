using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Costs.Classes
{
    public class Purchase
    {
        private Item _item;
        [XmlIgnore]
        public Item Item
        {
            get { return _item; }
            set { _item = value; }
        }

        private int _itemId;
        public int ItemId
        {
            get
            {
                if (Item != null)
                    return Item.Id;
                return _itemId;
            }
            set { _itemId = value; }
        }

        private Shop _shop;
        [XmlIgnore]
        public Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }

        private int _shopId;
        public int ShopId
        {
            get
            {
                if (Shop != null)
                    return Shop.Id;
                return _shopId;
            }
            set { _shopId = value; }
        }

        private float _price;
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private float _actualCost;
        public float ActualCost
        {
            get { return _actualCost; }
            set { _actualCost = value; }
        }

        private float _volume;
        public float Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public float CalculatedCost
        {
            get { return Price * Volume; }
        }

        public float OverCost
        {
            get { return ActualCost - CalculatedCost; }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public static int CompareByDate(Purchase a, Purchase b)
        {
            if (a.Date == b.Date)
                return Item.CompareByParent(a.Item, b.Item);
            return (int)(b.Date - a.Date).TotalDays;
        }
    }

    public class CostCollection
    {
        private static string fileName = "Costs.xml";
        private static CostCollection _costCollection;

        private List<Shop> _shops;
        public List<Shop> Shops
        {
            get { return _shops; }
            set { _shops = value; }
        }

        private List<Item> _items;
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private List<Purchase> _purchases;
        public List<Purchase> Purchases
        {
            get { return _purchases; }
            set { _purchases = value; }
        }

        private CostCollection()
        {
            Shops = new List<Shop>();
            Items = new List<Item>();
            Purchases = new List<Purchase>();
        }

        public static CostCollection GetInstance()
        {
            if (_costCollection == null)
                _costCollection = Load();
            return _costCollection;
        }

        public static void Save()
        {
            XmlHelper.SerializeAndSave(fileName, GetInstance());
        }

        private static CostCollection Load()
        {
            CostCollection result;
            try
            {
                result = fileName.LoadAndDeserialize<CostCollection>();
            }
            catch
            {
                return new CostCollection();
            }

            SetItemsParents(result.Items);
            SetPurchasesItems(result.Purchases, result.Items);
            SetPurchasesShops(result.Purchases, result.Shops);

            result.Shops.Sort(Shop.CompareByName);
            result.Items.Sort(Item.CompareByParent);
            result.Purchases.Sort(Purchase.CompareByDate);

            return result;
        }
        
        private static void SetItemsParents(List<Item> items)
        {
            foreach (Item item in items)
                if (item.ParentId != -1)
                    item.Parent = items.Find(i => i.Id == item.ParentId);
        }

        private static void SetPurchasesItems(List<Purchase> purchases, List<Item> items)
        {
            foreach (Purchase purchase in purchases)
                foreach (Item item in items)
                    if (item.Id == purchase.ItemId)
                    {
                        purchase.Item = item;
                        break;
                    }
        }

        private static void SetPurchasesShops(List<Purchase> purchases, List<Shop> shops)
        {
            foreach (Purchase purchase in purchases)
                foreach (Shop shop in shops)
                    if (shop.Id == purchase.ShopId)
                    {
                        purchase.Shop = shop;
                        break;
                    }
        }

        public static void Add(Shop shop)
        {
            int lastId = -1;
            foreach (Shop s in GetInstance().Shops)
                if (s.Id > lastId)
                    lastId = s.Id;

            shop.Id = lastId + 1;

            GetInstance().Shops.Add(shop);
            GetInstance().Shops.Sort(Shop.CompareByName);
        }
        
        public static void Add(Item item)
        {
            int lastId = -1;
            foreach (Item i in GetInstance().Items)
                if (i.Id > lastId)
                    lastId = i.Id;

            item.Id = lastId + 1;

            GetInstance().Items.Add(item);
            GetInstance().Items.Sort(Item.CompareByParent);
        }

        public static void Add(Purchase purchase)
        {
            GetInstance().Purchases.Add(purchase);
            GetInstance().Purchases.Sort(Purchase.CompareByDate);
        }

        public static bool IsPurchaseOfItemBranch(Item item, Purchase purchase)
        {
            if (purchase.Item == item)
                return true;
            else
                foreach (Item childItem in GetInstance().Items.FindAll(i => i.Parent == item))
                    if (IsPurchaseOfItemBranch(childItem, purchase))
                        return true;
            return false;
        }
    }
}
