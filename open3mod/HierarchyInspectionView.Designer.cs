﻿namespace open3mod
{
    partial class HierarchyInspectionView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HierarchyInspectionView));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this._tree = new System.Windows.Forms.TreeView();
            this.imageListIconsHierarchy = new System.Windows.Forms.ImageList(this.components);
            this.labelNodeStats = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHitCount = new System.Windows.Forms.Label();
            this.meshInfoPopup = new open3mod.MeshInfoPopup();
            this.nodeInfoPopup = new open3mod.NodeInfoPopup();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(188, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to hidden nodes";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxFilter.Location = new System.Drawing.Point(12, 7);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(287, 20);
            this.textBoxFilter.TabIndex = 7;
            this.textBoxFilter.Text = "Type to search";
            this.textBoxFilter.Click += new System.EventHandler(this.OnClickSearchBox);
            this.textBoxFilter.TextChanged += new System.EventHandler(this.OnChangeFilterText);
            this.textBoxFilter.Leave += new System.EventHandler(this.OnStopFocusingOnSearch);
            // 
            // _tree
            // 
            this._tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tree.BackColor = System.Drawing.Color.White;
            this._tree.FullRowSelect = true;
            this._tree.HotTracking = true;
            this._tree.ImageIndex = 0;
            this._tree.ImageList = this.imageListIconsHierarchy;
            this._tree.Location = new System.Drawing.Point(0, 33);
            this._tree.Name = "_tree";
            this._tree.SelectedImageIndex = 0;
            this._tree.ShowNodeToolTips = true;
            this._tree.Size = new System.Drawing.Size(311, 573);
            this._tree.TabIndex = 5;
            this._tree.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.OnNodeHover);
            this._tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AfterSelect);
            this._tree.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this._tree.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // imageListIconsHierarchy
            // 
            this.imageListIconsHierarchy.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconsHierarchy.ImageStream")));
            this.imageListIconsHierarchy.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconsHierarchy.Images.SetKeyName(0, "HierarchyIconGenerated.png");
            this.imageListIconsHierarchy.Images.SetKeyName(1, "HierarchyIconGenericNode.png");
            this.imageListIconsHierarchy.Images.SetKeyName(2, "HierarchyIconJoint.png");
            this.imageListIconsHierarchy.Images.SetKeyName(3, "HierarchyIconMesh.png");
            // 
            // labelNodeStats
            // 
            this.labelNodeStats.AutoSize = true;
            this.labelNodeStats.Location = new System.Drawing.Point(9, 5);
            this.labelNodeStats.Name = "labelNodeStats";
            this.labelNodeStats.Size = new System.Drawing.Size(118, 13);
            this.labelNodeStats.TabIndex = 0;
            this.labelNodeStats.Text = "Showing m of n nodes. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "p nodes are permanently hidden";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 21);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.labelNodeStats);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 633);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 21);
            this.panel1.TabIndex = 8;
            // 
            // labelHitCount
            // 
            this.labelHitCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHitCount.AutoSize = true;
            this.labelHitCount.BackColor = System.Drawing.Color.GreenYellow;
            this.labelHitCount.Location = new System.Drawing.Point(247, 10);
            this.labelHitCount.Name = "labelHitCount";
            this.labelHitCount.Size = new System.Drawing.Size(0, 13);
            this.labelHitCount.TabIndex = 10;
            // 
            // meshInfoPopup
            // 
            this.meshInfoPopup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.meshInfoPopup.Location = new System.Drawing.Point(191, 335);
            this.meshInfoPopup.Name = "meshInfoPopup";
            this.meshInfoPopup.Size = new System.Drawing.Size(115, 271);
            this.meshInfoPopup.TabIndex = 12;
            // 
            // nodeInfoPopup
            // 
            this.nodeInfoPopup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nodeInfoPopup.Location = new System.Drawing.Point(191, 43);
            this.nodeInfoPopup.Name = "nodeInfoPopup";
            this.nodeInfoPopup.Size = new System.Drawing.Size(115, 282);
            this.nodeInfoPopup.TabIndex = 11;
            // 
            // HierarchyInspectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.meshInfoPopup);
            this.Controls.Add(this.nodeInfoPopup);
            this.Controls.Add(this.labelHitCount);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this._tree);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HierarchyInspectionView";
            this.Size = new System.Drawing.Size(311, 654);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.TreeView _tree;
        private System.Windows.Forms.Label labelNodeStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHitCount;
        private System.Windows.Forms.ImageList imageListIconsHierarchy;
        private NodeInfoPopup nodeInfoPopup;
        private MeshInfoPopup meshInfoPopup;
    }
}
