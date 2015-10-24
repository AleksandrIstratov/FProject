using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FProject
{

    public interface IBaseElement
    {
//        Type curr_type { get; }
        string name { get; set; }
        Guid id { get; set; }
        Guid parent_id { get; set; }

        void SaveToDB();
        void DeleteFromDB();
    }
}
