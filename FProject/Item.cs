using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FProject
{
    public class Item : TItem, IBaseElement
    {

        public Guid parent_id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }


        //      public TItem TableItem { get; set; }

        //        public Type curr_type { get { return typeof(Item); } }

        //        public Guid guid { get; private set; }
        //        public string name { get; set; }
        //        public Guid parentGuid { get; private set; }
        //        public DateTime dateTime { get; private set; }

        //public Item(string _name = "new")
        //{
        //    this.name = _name;
        //}

        //public Item(string _name, Guid _parentGuid):this(_name)
        //{
        //    this.parentGuid = _parentGuid;
        //}

        //public Item(string _name, Guid _parentGuid, DateTime _dt):this(_name, _parentGuid)
        //{
        //    this.dateTime = _dt;
        //}

        //public Item(string _name, Guid _parentGuid, DateTime _dt, Guid _id):this(_name, _parentGuid, _dt)
        //{
        //    this.guid = _id;
        //}

        //static public List<Item> ListLoadFromDataBase()
        //{
        //    List<Item> _listItems = new List<Item>();
        //    using (var _db = new DataClasses1DataContext())
        //    {
        //        var _allItems = from items in _db.TItems select items;
        //        foreach (TItem _resItem in _allItems)
        //        {
        //            Item _item = new Item(_resItem.name, _resItem.parent_id, _resItem.dt, _resItem.id);
        //            _listItems.Add(_item);
        //        }
        //    }                
        //    return _listItems;
        //}

        //static public void FillTreeView(TreeNodeCollection Node, List<Item> NodeList, Guid key)
        //{

        //    foreach (Item _items in NodeList)
        //    {
        //        if (_items.parentGuid.CompareTo(key)==0)
        //        {
        //            TreeNodeCollection ChildNode = Node.Add(_items.guid.ToString(), _items.name).Nodes;
        //            FillTreeView(ChildNode, NodeList, _items.guid);
        //        }


        //    }
        //}

        //public void FillTreeView(TreeNodeCollection Node)
        //{
        //    FillTreeView(Node, ListLoadFromDataBase(), this.guid);
        //}

        //static public void FillListView(ListView _listView, List<baseElement> _listItems)
        //{
        //    _listView.Clear();
        //    _listView.BeginUpdate();
        //    foreach (var row in _listItems)
        //    {
        //        var item = new ListViewItem(row.name);
        //        _listView.Items.Add(item);
        //    }
        //    _listView.EndUpdate();
        //}

        static public List<IBaseElement> ListLoadFromDataBase()
        {
            var _listItems = new List<IBaseElement>();
            using (var _db = new DataClasses1DataContext())
            {
                var _allItems = from items in _db.TItems select items;
                foreach (var _resItem in _allItems)
                {
                    IBaseElement _el = new Item()
                    {
                        name = _resItem.name,
                        id = _resItem.id,
                    };
                    _listItems.Add(_el);
                }
            }
            return _listItems;
        }

        static public IBaseElement LoadFromDB(Guid _id)
        {
            using (var _db = new DataClasses1DataContext())
            {
                var _item = from items in _db.TItems where items.id == _id select items;
                if (_item.Count() == 1)
                {
                    return new Item()
                    {
                        id = _item.Single().id,
                        name = _item.Single().name
                    };
                }else
                {
                    return null;
                }
                    
            }
        }

        //static public void DelFromDB(Guid _id)
        //{
        //    using (var _db = new DataClasses1DataContext())
        //    {
        //        TItem _item = _db.TItems.SingleOrDefault(x => x.id == _id);
        //        _db.TItems.DeleteOnSubmit(_item);
        //        _db.SubmitChanges();
        //    }
        //}

        static public void UpdGroups(Guid _item_id, Guid _group_id, bool _action)
        {
            using (var _db = new DataClasses1DataContext())
            {
                if (_action)
                {
                    var _grp = new RItemsGroup();
                    _grp.Item_id = _item_id;
                    _grp.Group_id = _group_id;
                    _db.RItemsGroups.InsertOnSubmit(_grp);
                }else
                {
                    var _item = _db.RItemsGroups.Single(x => ((x.Item_id == _item_id) && (x.Group_id == _group_id)));
                    _db.RItemsGroups.DeleteOnSubmit(_item);
                }
                _db.SubmitChanges();
            }
        }

        public void SaveToDB()
        {            
            using (var _db = new DataClasses1DataContext())
            {
                try
                {
                var _item = _db.TItems.Single(x => x.id == this.id);
                    _item.name = this.name;
                }
                catch
                {
                    var _item = new TItem();
                    _item.name = this.name;
                    _db.TItems.InsertOnSubmit(_item);
                }
                _db.SubmitChanges();
            }
        }

        public void DeleteFromDB()
        {
            using (var _db = new DataClasses1DataContext())
            {
                TItem _item = new TItem() { id = this.id };
                _db.TItems.Attach(_item);
                _db.TItems.DeleteOnSubmit(_item);
                _db.SubmitChanges();
            }
        }

        //static public void FillListViewP(ListView _listView, List<baseElement> _listProps)
        //{
        //    _listView.Clear();
        //    _listView.BeginUpdate();
        //    foreach (var row in _listProps)
        //    {
        //        var item = new ListViewItem(row.name);
        //        _listView.Items.Add(item);
        //    }
        //    _listView.EndUpdate();
        //}
    }
}
