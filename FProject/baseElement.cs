
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FProject
{
    public class baseElement:IBaseElement
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public Guid parent_id { get; set; }

        public override int GetHashCode()
        {
            return this.id.GetHashCode()*19 + this.parent_id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is baseElement))
                throw new ArgumentException("obj is not an baseElement");
            var _beseEl = obj as baseElement;
            if (_beseEl == null)
                return false;
            return this.id.Equals(_beseEl.id) && this.parent_id.Equals(_beseEl.parent_id);
        }

        static public IBaseElement LoadFromDB(Guid _id)
        {
            var _item = Item.LoadFromDB(_id);
            var _group = Group.LoadFromDB(_id);
            return (_item != null) ? _item : _group;
        }

        static public void GetListGroupsById(List<IBaseElement> _list, Guid _key, List<IBaseElement> _result)
        {
            foreach(var _node in _list)
            {
                if (_node.id.CompareTo(_key) == 0)
                {
                    _result.Add(_node);
                    GetListGroupsById(_list, _node.parent_id, _result);
                }
            }
        }

        static private void FillTV(TreeNodeCollection Node, List<IBaseElement> NodeList, Guid _key)
        {
            foreach (var _el in NodeList)
            {
                if (_el.parent_id.CompareTo(_key) == 0)
                {
                    TreeNodeCollection ChildNode = Node.Add(_el.id.ToString(), _el.name, 1).Nodes;
                    var _items = Group.ListOfItems(_el.id);
                    foreach(var _ibs in _items)
                    {
                        ChildNode.Add(_ibs.id.ToString(), _ibs.name, 2);
                    }                    
                    //var lst = new ImageList();
                    //lst.Images.Add(Image.FromFile("1.png"));
                    //lst.Images.Add(Image.FromFile("2.png"));
                    FillTV(ChildNode, NodeList, _el.id);
                }
            }                
        }

        static public void FillTreeView(TreeNodeCollection Node, List<IBaseElement> NodeList, Guid _key)
        {
            FillTV(Node, NodeList, _key);
            var _items = Group.ListOfItems();
            foreach (var _el in _items)
            {
                Node.Add(_el.id.ToString(), _el.name, 2);
            }

        }

        static public void FillListView(ListView _listView, List<IBaseElement> _listEl)
        {
            _listView.Clear();
            _listView.BeginUpdate();
            foreach (IBaseElement row in _listEl)
            {
                var item = new ListViewItem(row.name);
                _listView.Items.Add(item);
            }
            _listView.EndUpdate();
        }

        public void SaveToDB()
        {
            throw new NotImplementedException();
        }

        public void DeleteFromDB()
        {
            throw new NotImplementedException();
        }
    }
}
