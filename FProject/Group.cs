using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProject
{
    public class Group : TGroup, IBaseElement //, baseElement
    {

        public void SaveToDB()
        {
            using (var _db = new DataClasses1DataContext())
            {
                var _group = _db.TGroups.Single(x => x.id == this.id);
                _group.name = this.name;
                _group.parent_id = this.parent_id;
                _db.SubmitChanges();
            }
        }

        public void DeleteFromDB()
        {
            using (var _db = new DataClasses1DataContext())
            {
                _db.TGroups.DeleteOnSubmit(this);
                _db.SubmitChanges();
            }
        }
        
        static public List<IBaseElement> ListIBaseElementLoadFromDataBase()
        {
            var _listItems = new List<IBaseElement>();
            using (var _db = new DataClasses1DataContext())
            {
                var _allItems = from items in _db.TGroups select new { name = items.name, id = items.id};
                foreach (var _resItem in _allItems)
                {
                    IBaseElement _el = new Group()
                    {
                        name = _resItem.name,
                        id = _resItem.id,
                    };
                    _listItems.Add(_el);
                }
            }
            return _listItems;
        }

        static private void GetListGroupsById(List<IBaseElement> _list, Guid _key, List<IBaseElement> _result)
        {
            foreach (var _node in _list)
            {
                if (_node.id.CompareTo(_key) == 0)
                {
                    _result.Add(_node);
                    GetListGroupsById(_list, _node.parent_id, _result);
                }
            }
        }

        static public List<IBaseElement> ListOfGroups(Guid ItemId)
        {
            var _excList = new List<IBaseElement>();
            List<IBaseElement> _allItems;
            var _allWithParent_id = Group.ListLoadFromDataBase();
            using (var _db = new DataClasses1DataContext())
            {
                _allItems = (from groups in _db.TGroups
                            from rIG in _db.RItemsGroups
                            where groups.id == rIG.Group_id
                            where rIG.Item_id == ItemId
                            select new baseElement { name = groups.name, id = groups.id })
                            .ToList<IBaseElement>();
            }
            Group.GetListGroupsById(_allWithParent_id, ItemId, _excList);
            foreach (var _el in _allItems)
            {
                Group.GetListGroupsById(_allWithParent_id, _el.id, _excList);
            }            
            return _excList;
        }

        static public List<IBaseElement> ListLoadFromDataBase()
        {
            List<IBaseElement> _listItems;
            using (var _db = new DataClasses1DataContext())
            {
                _listItems = (from items in _db.TGroups
                              select new baseElement { name = items.name, id = items.id, parent_id = items.parent_id })
                              .ToList<IBaseElement>();
            }
            return _listItems;
        }

        static public List<IBaseElement> ListOfRestGroups(Guid ItemId)
        {
            var _all = Group.ListLoadFromDataBase();
            var _exc = Group.ListOfGroups(ItemId);
            var _groupsNotInItem = _all.Except(_exc);
            return _groupsNotInItem.ToList<IBaseElement>();
        }

        static public IBaseElement LoadFromDB(Guid _id)
        {
            using (var _db = new DataClasses1DataContext())
            {
                var _group = from groups in _db.TGroups where groups.id == _id select groups;
                if (_group.Count() == 1)
                {
                    return new Group()
                    {
                        name = _group.Single().name,
                        id = _group.Single().id
                    };
                }
                else
                {
                    return null;
                }

            }
        }

        static public List<IBaseElement> ListOfItems(Guid GroupId)
        {
            using (var _db = new DataClasses1DataContext())
            {
                var _allItemsInGroup = (from items in _db.TItems
                                        join rIG in _db.RItemsGroups on items.id equals rIG.Item_id                                    
                                        where rIG.Group_id == GroupId
                                        select new Item { name = items.name, id = items.id });
                return _allItemsInGroup.ToList<IBaseElement>();
            }
        }

        static public List<IBaseElement> ListOfItems()
        {
            using (var _db = new DataClasses1DataContext())
            {
                var _except = from rIG in _db.RItemsGroups
                              from items in _db.TItems
                              where items.id == rIG.Item_id
                              select new { name = items.name, id = items.id };
                
                var _all = from items in _db.TItems                           
                           select new { name = items.name, id = items.id };
                var _itemsWithoutGroup = _all.Except(_except);
                var _list = new List<IBaseElement>();
                foreach (var _el in _itemsWithoutGroup)
                {
                    _list.Add(new Item() { name = _el.name, id = _el.id });
                }            
                return _list;
            }
        }

    }
}