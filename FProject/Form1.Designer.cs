namespace FProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Items");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Groups");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabCntrl = new System.Windows.Forms.TabControl();
            this.tPItems = new System.Windows.Forms.TabPage();
            this.tVItems = new System.Windows.Forms.TreeView();
            this.cMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMSAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lVProperties = new System.Windows.Forms.ListView();
            this.lVGroups = new System.Windows.Forms.ListView();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tPGroups = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dGVGroups = new System.Windows.Forms.DataGridView();
            this.tabCntrl.SuspendLayout();
            this.tPItems.SuspendLayout();
            this.cMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(154, 293);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // tabCntrl
            // 
            this.tabCntrl.Controls.Add(this.tPItems);
            this.tabCntrl.Controls.Add(this.tPGroups);
            this.tabCntrl.Location = new System.Drawing.Point(177, 12);
            this.tabCntrl.Name = "tabCntrl";
            this.tabCntrl.SelectedIndex = 0;
            this.tabCntrl.Size = new System.Drawing.Size(799, 361);
            this.tabCntrl.TabIndex = 17;
            this.tabCntrl.SelectedIndexChanged += new System.EventHandler(this.tabCntrl_SelectedIndexChanged);
            // 
            // tPItems
            // 
            this.tPItems.Controls.Add(this.dGVGroups);
            this.tPItems.Controls.Add(this.tVItems);
            this.tPItems.Controls.Add(this.lVProperties);
            this.tPItems.Controls.Add(this.lVGroups);
            this.tPItems.Controls.Add(this.tBName);
            this.tPItems.Location = new System.Drawing.Point(4, 22);
            this.tPItems.Name = "tPItems";
            this.tPItems.Padding = new System.Windows.Forms.Padding(3);
            this.tPItems.Size = new System.Drawing.Size(791, 335);
            this.tPItems.TabIndex = 0;
            this.tPItems.Text = "Items";
            this.tPItems.UseVisualStyleBackColor = true;
            // 
            // tVItems
            // 
            this.tVItems.ContextMenuStrip = this.cMS;
            this.tVItems.ImageIndex = 0;
            this.tVItems.ImageList = this.imageList1;
            this.tVItems.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tVItems.Location = new System.Drawing.Point(7, 7);
            this.tVItems.Name = "tVItems";
            this.tVItems.SelectedImageIndex = 0;
            this.tVItems.Size = new System.Drawing.Size(253, 293);
            this.tVItems.TabIndex = 21;
            this.tVItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tVItems_AfterSelect);
            // 
            // cMS
            // 
            this.cMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMSAdd,
            this.deleteToolStripMenuItem});
            this.cMS.Name = "contextMenuStrip1";
            this.cMS.Size = new System.Drawing.Size(108, 48);
            // 
            // cMSAdd
            // 
            this.cMSAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.groupToolStripMenuItem});
            this.cMSAdd.Name = "cMSAdd";
            this.cMSAdd.Size = new System.Drawing.Size(107, 22);
            this.cMSAdd.Text = "Add";
            this.cMSAdd.Click += new System.EventHandler(this.cMSAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "black_point.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            this.imageList1.Images.SetKeyName(2, "red_point.png");
            // 
            // lVProperties
            // 
            this.lVProperties.Location = new System.Drawing.Point(470, 7);
            this.lVProperties.Name = "lVProperties";
            this.lVProperties.Size = new System.Drawing.Size(172, 293);
            this.lVProperties.TabIndex = 20;
            this.lVProperties.UseCompatibleStateImageBehavior = false;
            this.lVProperties.View = System.Windows.Forms.View.List;
            // 
            // lVGroups
            // 
            this.lVGroups.CheckBoxes = true;
            this.lVGroups.ContextMenuStrip = this.cMS;
            this.lVGroups.FullRowSelect = true;
            this.lVGroups.Location = new System.Drawing.Point(648, 7);
            this.lVGroups.Name = "lVGroups";
            this.lVGroups.Size = new System.Drawing.Size(137, 266);
            this.lVGroups.TabIndex = 19;
            this.lVGroups.UseCompatibleStateImageBehavior = false;
            this.lVGroups.View = System.Windows.Forms.View.List;
            this.lVGroups.SelectedIndexChanged += new System.EventHandler(this.lVGroups_SelectedIndexChanged);
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(266, 8);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(137, 20);
            this.tBName.TabIndex = 18;
            // 
            // tPGroups
            // 
            this.tPGroups.Location = new System.Drawing.Point(4, 22);
            this.tPGroups.Name = "tPGroups";
            this.tPGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tPGroups.Size = new System.Drawing.Size(791, 335);
            this.tPGroups.TabIndex = 1;
            this.tPGroups.Text = "Groups";
            this.tPGroups.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1013, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1013, 257);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1013, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1013, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dGVGroups
            // 
            this.dGVGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGroups.Location = new System.Drawing.Point(266, 34);
            this.dGVGroups.Name = "dGVGroups";
            this.dGVGroups.Size = new System.Drawing.Size(198, 200);
            this.dGVGroups.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 403);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabCntrl);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnRenewClic);
            this.tabCntrl.ResumeLayout(false);
            this.tPItems.ResumeLayout(false);
            this.tPItems.PerformLayout();
            this.cMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tabCntrl;
        private System.Windows.Forms.TabPage tPItems;
        private System.Windows.Forms.ListView lVProperties;
        private System.Windows.Forms.ListView lVGroups;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TabPage tPGroups;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TreeView tVItems;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cMS;
        private System.Windows.Forms.ToolStripMenuItem cMSAdd;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dGVGroups;
    }
}

