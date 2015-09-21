using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //var l=Item.LoadFromDataBase();
            //l[0].name = "Motor";
            //l[0].SaveToDataBase();
            Item.FillListView(listView1);
            var db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.TItems;
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = new Item("Test");
            item.SaveToDataBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guid _id;
            if (Guid.TryParse(textBox1.Text, out _id))
            {
                var _item = Item.LoadFromDataBase(_id);
            }
            return;
        }
    }
}
