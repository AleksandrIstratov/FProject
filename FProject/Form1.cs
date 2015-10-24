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

        private IBaseElement _item;

        public Form1()
        {
            InitializeComponent();

        }

        protected void btnEditClic(object sender, EventArgs e)
        {
            Guid _id;
            if (Guid.TryParse(tVItems.SelectedNode.Name, out _id))
            {
                //Program.LoadFAddItem(Item.LoadFromDB(_id));
            }
        }

        protected bool setCurrentItem()
        {
            Guid _id;
            if (Guid.TryParse(tVItems.SelectedNode.Name, out _id))
            {
                this._item = baseElement.LoadFromDB(_id);
                tBName.Text = this._item.name;
                return true;
            } else
            {
                return false;
            }
        }

        protected void btnDblClic(object sender, EventArgs e)
        {
            setCurrentItem();
            baseElement.FillListView(lVGroups, Group.ListOfGroups(this._item.id));
            baseElement.FillListView(lVProperties, Group.ListOfRestGroups(this._item.id));
            dGVGroups.DataSource = Group.ListOfGroups(this._item.id);
            //baseElement.FillListView(lVProperties, Property.LoadProperties(this._item.id));
        }

        protected void btnPlusClic(object sender, EventArgs e)
        {
            Guid _id;

            if (Guid.TryParse(tVItems.SelectedNode.Name, out _id))
            {
                var _item = new Item() { name = "new_test"};
                _item.SaveToDB();
                //Program.LoadFAddItem(new Item() { name = "new", id = _id });
            }
            tTreeViewRenew();
        }

        protected void btnRenewClic(object sender, EventArgs e)
        {
            tTreeViewRenew();
        }

        protected void btnMinusClic(object sender, EventArgs e)
        {
            Guid _id;
            if (Guid.TryParse(tVItems.SelectedNode.Name, out _id))
            {
                baseElement.LoadFromDB(_id).DeleteFromDB();
            }
            tTreeViewRenew();
        }


        public void tTreeViewRenew()
        {
            tVItems.Nodes.Clear();
            baseElement.FillTreeView(tVItems.Nodes, Group.ListLoadFromDataBase(), new Guid());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._item.name = tBName.Text;
            this._item.SaveToDB();
            tTreeViewRenew();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this._item = new Item();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._item.DeleteFromDB();
            tTreeViewRenew();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //btnSave.Click -= this.btnSave_Click;
        }

        private void tabChanged(int _tabIndex)
        {
            switch (_tabIndex)
            {
                case 0:
                    MessageBox.Show("tab 0");
                    break;
                case 1:
                    MessageBox.Show("tab 1");
                    break;
                default:
                    break;
            }
        }

        private void tabCntrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabChanged(tabCntrl.SelectedIndex);
            //MessageBox.Show();
        }

        private void tVItems_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnDblClic(this, e);
        }

        private void lVGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cMSAdd_Click(object sender, EventArgs e)
        {
            setCurrentItem();
            var fAdd = new AddForm();
            fAdd.Visible = true;
            //baseElement.FillListView(fAdd.lWAdd, Group.ListOfRestGroups(this._item.id));

            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (setCurrentItem())
            {
             //   MessageBox.Show(String.Format("{0} {1} {3}", this._item.id, this._item.name, lVGroups.SelectedItems.));
            }
            
        }
    }
}
