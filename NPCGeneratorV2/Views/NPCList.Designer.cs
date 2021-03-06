﻿namespace NPCGeneratorV2
{
    partial class NPCList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPCList));
            this.npcTabs = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveAllNPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // npcTabs
            // 
            this.npcTabs.Location = new System.Drawing.Point(0, 24);
            this.npcTabs.Margin = new System.Windows.Forms.Padding(0);
            this.npcTabs.Name = "npcTabs";
            this.npcTabs.SelectedIndex = 0;
            this.npcTabs.Size = new System.Drawing.Size(1114, 968);
            this.npcTabs.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAllNPCsToolStripMenuItem,
            this.addNPCToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveAllNPCsToolStripMenuItem
            // 
            this.saveAllNPCsToolStripMenuItem.Name = "saveAllNPCsToolStripMenuItem";
            this.saveAllNPCsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.saveAllNPCsToolStripMenuItem.Text = "Save All NPCs";
            this.saveAllNPCsToolStripMenuItem.Click += new System.EventHandler(this.saveAllNPCSToolStripMenuItem_Click);
            // 
            // addNPCToolStripMenuItem
            // 
            this.addNPCToolStripMenuItem.Name = "addNPCToolStripMenuItem";
            this.addNPCToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.addNPCToolStripMenuItem.Text = "Add NPC";
            this.addNPCToolStripMenuItem.Click += new System.EventHandler(this.addNPCToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.removeToolStripMenuItem.Text = "Remove Selected NPC";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // NPCList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1115, 992);
            this.Controls.Add(this.npcTabs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NPCList";
            this.Text = "NPC List";
            this.Load += new System.EventHandler(this.NPCList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl npcTabs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveAllNPCsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}