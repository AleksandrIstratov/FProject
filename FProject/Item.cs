using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FProject
{
    class Item
    {

        public Guid guid { get; private set; }
        public string name { get; set; }
        public DateTime dateTime { get; private set; }
        
        public Item(string _name)
        {
            this.name = _name;
        }

        public Item(string _name, DateTime _dt):this(_name)
        {
            this.dateTime = _dt;
        }

        public Item(string _name, DateTime _dt, Guid _id):this(_name, _dt)
        {
            this.guid = _id;
        }

        static public List<Item> ListLoadFromDataBase()
        {
            List<Item> _listItems = new List<Item>();

            var _db = new DataClasses1DataContext();
            var _allItems = from items in _db.TItems select items;
            foreach (TItem _resItem in _allItems)
            {
                Item _item = new Item(_resItem.name, _resItem.dt, _resItem.id);
                _listItems.Add(_item);
            }
            return _listItems;
        }

        static public void FillListView(ListView _listView)
        {
            _listView.Clear();
            var _listItems = ListLoadFromDataBase();
            _listView.BeginUpdate();
            foreach (var row in _listItems)
            {
                var item = new ListViewItem(row.name);
                _listView.Items.Add(item);
            }
            _listView.EndUpdate();
        }

        static public Item LoadFromDataBase(Guid _id)
        {
            Item _item = null;
            using (var _db = new DataClasses1DataContext())
            {
                var _Items = from items in _db.TItems where items.id == _id select items;   
                if (_Items.Count<TItem>() > 0)
                {
                    _item = new Item(_Items.First<TItem>().name, _Items.First<TItem>().dt, _Items.First<TItem>().id);
                }            
            }
                return _item;
        }

        public void CreateInDataBase()
        {
            using (var _db = new DataClasses1DataContext())
            {
                TItem _item = new TItem();
                _item.name = this.name;
                _db.TItems.InsertOnSubmit(_item);
                _db.SubmitChanges();
            }
        }

        public void SaveToDataBase()
        {
            if (this.guid.CompareTo(new Guid()) != 0)
            {
                using (var _db = new DataClasses1DataContext())
                {
                    TItem _item = _db.TItems.SingleOrDefault(x => x.id == this.guid);
                    _item.name = this.name;
                    _db.SubmitChanges();
                    return;
                }
            }
            CreateInDataBase();
        }

        public void DeleteFromDataBase()
        {
            using (var _db = new DataClasses1DataContext())
            {
                TItem _item = _db.TItems.SingleOrDefault(x => x.id == this.guid);
                _db.TItems.DeleteOnSubmit(_item);
            }
        }
    }
}
