using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProject
{
    public class Property:TProperty, IBaseElement
    {
        public string value { get; set; }
        public Guid parent_id { get; set; }

        //        public Type curr_type { get { return typeof(Property); } }

        static public List<IBaseElement> LoadProperties(Guid _item_id)
        {
            var _listProp = new List<IBaseElement>();
            using (var _db = new DataClasses1DataContext())
            {
                var _allProps = from items in _db.TItems
                                from rprops in _db.RParentProperties
                                from props in _db.TProperties
                                where items.id == _item_id
                                select new { id = props.id, name = items.name + " = " + props.name, val = rprops.val };
                foreach (var _resProps in _allProps)
                {
                    Property _prop = new Property()
                    {
                        id = _resProps.id,
                        name = _resProps.name,
                        value = _resProps.val
                    };
                    _listProp.Add(_prop);
                }
            }

            return _listProp;
        }

        public void DeleteFromDB()
        {
            using (var _db = new DataClasses1DataContext())
            {
                _db.TProperties.DeleteOnSubmit(this);
                _db.SubmitChanges();
            }
        }

        public void SaveToDB()
        {
            using (var _db = new DataClasses1DataContext())
            {
                var _prop = _db.TProperties.Single(x => x.id == this.id);
                _prop.name = this.name;
                _db.SubmitChanges();
            }
        }
    }
}
