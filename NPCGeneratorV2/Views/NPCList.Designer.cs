namespace NPCGeneratorV2
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
            this.SuspendLayout();
            // 
            // npcTabs
            // 
            this.npcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.npcTabs.Location = new System.Drawing.Point(0, 0);
            this.npcTabs.Margin = new System.Windows.Forms.Padding(0);
            this.npcTabs.Name = "npcTabs";
            this.npcTabs.SelectedIndex = 0;
            this.npcTabs.Size = new System.Drawing.Size(564, 701);
            this.npcTabs.TabIndex = 0;
            // 
            // NPCList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(564, 701);
            this.Controls.Add(this.npcTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NPCList";
            this.Text = "NPC List";
            this.Load += new System.EventHandler(this.NPCList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl npcTabs;
    }
}