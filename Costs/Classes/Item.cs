using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Costs.Classes
{
    public class Item
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Item _parent;
        [XmlIgnore]
        public Item Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        private int _parentId = -1;
        public int ParentId
        {
            get
            {
                if (Parent != null)
                    return Parent.Id;
                return _parentId;
            }
            set { _parentId = value; }
        }
        
        public override string ToString()
        {
            return (Parent != null ? Parent.Name + " - " : "") + Name;
        }

        public static int CompareByParent(Item a, Item b)
        {
            if (a.Parent == b.Parent)
                return CompareByName(a, b);
            else if (a.Parent == null)
                return 1;
            else if (b.Parent == null)
                return -1;
            return Item.CompareByName(a.Parent, b.Parent);
        }

        public static int CompareByName(Item a, Item b)
        {
            return string.Compare(a.Name, b.Name);
        }
    }
}