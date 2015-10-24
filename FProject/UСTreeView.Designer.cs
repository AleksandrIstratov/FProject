namespace FProject
{
    partial class UСTreeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TreeViewUC = new System.Windows.Forms.TreeView();
            this.ucMenu1 = new FProject.UCMenu();
            this.SuspendLayout();
            // 
            // TreeViewUC
            // 
            this.TreeViewUC.Location = new System.Drawing.Point(30, 1);
            this.TreeViewUC.Name = "TreeViewUC";
            this.TreeViewUC.Size = new System.Drawing.Size(218, 297);
            this.TreeViewUC.TabIndex = 0;
            // 
            // ucMenu1
            // 
            this.ucMenu1.AutoSize = true;
            this.ucMenu1.Location = new System.Drawing.Point(3, -1);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(27, 93);
            this.ucMenu1.TabIndex = 1;
            // 
            // UСTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucMenu1);
            this.Controls.Add(this.TreeViewUC);
            this.Name = "UСTreeView";
            this.Size = new System.Drawing.Size(271, 304);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView TreeViewUC;
        public UCMenu ucMenu1;
    }
}
