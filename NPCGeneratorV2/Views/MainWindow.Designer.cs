namespace NPCGeneratorV2
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.generate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadNPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBulkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dungeonsAndDragonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gurpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathfinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starfinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warhammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callOfCthuluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starWarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldOfDarknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(15, 97);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(87, 23);
            this.generate.TabIndex = 0;
            this.generate.Text = "Generate NPC";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter the number of NPCs to be\r\ngenerated (default is 1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(130, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "By Ivan Cvetkovic and Milos Andric";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPresetToolStripMenuItem,
            this.loadNPCToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadPresetToolStripMenuItem
            // 
            this.loadPresetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customToolStripMenuItem,
            this.toolStripSeparator1,
            this.callOfCthuluToolStripMenuItem,
            this.d20ToolStripMenuItem,
            this.dungeonsAndDragonsToolStripMenuItem,
            this.fateToolStripMenuItem,
            this.gurpsToolStripMenuItem,
            this.pathfinderToolStripMenuItem,
            this.starWarsToolStripMenuItem,
            this.starfinderToolStripMenuItem,
            this.warhammerToolStripMenuItem,
            this.worldOfDarknessToolStripMenuItem});
            this.loadPresetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadPresetToolStripMenuItem.Name = "loadPresetToolStripMenuItem";
            this.loadPresetToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.loadPresetToolStripMenuItem.Text = "Load preset";
            this.loadPresetToolStripMenuItem.DropDownClosed += new System.EventHandler(this.loadPresetToolStripMenuItem_DropDownClosed);
            this.loadPresetToolStripMenuItem.DropDownOpened += new System.EventHandler(this.loadPresetToolStripMenuItem_DropDownOpened);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customToolStripMenuItem.Image")));
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // loadNPCToolStripMenuItem
            // 
            this.loadNPCToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadNPCToolStripMenuItem.BackgroundImage")));
            this.loadNPCToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadNPCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadOneToolStripMenuItem,
            this.loadBulkToolStripMenuItem});
            this.loadNPCToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadNPCToolStripMenuItem.Name = "loadNPCToolStripMenuItem";
            this.loadNPCToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.loadNPCToolStripMenuItem.Text = "Load NPC";
            this.loadNPCToolStripMenuItem.DropDownClosed += new System.EventHandler(this.loadNPCToolStripMenuItem_DropDownClosed);
            this.loadNPCToolStripMenuItem.DropDownOpened += new System.EventHandler(this.loadNPCToolStripMenuItem_DropDownOpened);
            // 
            // loadOneToolStripMenuItem
            // 
            this.loadOneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadOneToolStripMenuItem.Image")));
            this.loadOneToolStripMenuItem.Name = "loadOneToolStripMenuItem";
            this.loadOneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadOneToolStripMenuItem.Text = "Load One NPC";
            this.loadOneToolStripMenuItem.Click += new System.EventHandler(this.loadOneToolStripMenuItem_Click);
            // 
            // loadBulkToolStripMenuItem
            // 
            this.loadBulkToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadBulkToolStripMenuItem.Image")));
            this.loadBulkToolStripMenuItem.Name = "loadBulkToolStripMenuItem";
            this.loadBulkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadBulkToolStripMenuItem.Text = "Load Group";
            this.loadBulkToolStripMenuItem.Click += new System.EventHandler(this.loadBulkToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // d20ToolStripMenuItem
            // 
            this.d20ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("d20ToolStripMenuItem.Image")));
            this.d20ToolStripMenuItem.Name = "d20ToolStripMenuItem";
            this.d20ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.d20ToolStripMenuItem.Text = "D20";
            // 
            // dungeonsAndDragonsToolStripMenuItem
            // 
            this.dungeonsAndDragonsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dungeonsAndDragonsToolStripMenuItem.Image")));
            this.dungeonsAndDragonsToolStripMenuItem.Name = "dungeonsAndDragonsToolStripMenuItem";
            this.dungeonsAndDragonsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dungeonsAndDragonsToolStripMenuItem.Text = "Dungeons and dragons";
            // 
            // fateToolStripMenuItem
            // 
            this.fateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fateToolStripMenuItem.Image")));
            this.fateToolStripMenuItem.Name = "fateToolStripMenuItem";
            this.fateToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.fateToolStripMenuItem.Text = "Fate";
            // 
            // gurpsToolStripMenuItem
            // 
            this.gurpsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gurpsToolStripMenuItem.Image")));
            this.gurpsToolStripMenuItem.Name = "gurpsToolStripMenuItem";
            this.gurpsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.gurpsToolStripMenuItem.Text = "Gurps";
            // 
            // pathfinderToolStripMenuItem
            // 
            this.pathfinderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pathfinderToolStripMenuItem.Image")));
            this.pathfinderToolStripMenuItem.Name = "pathfinderToolStripMenuItem";
            this.pathfinderToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pathfinderToolStripMenuItem.Text = "Pathfinder";
            // 
            // starfinderToolStripMenuItem
            // 
            this.starfinderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("starfinderToolStripMenuItem.Image")));
            this.starfinderToolStripMenuItem.Name = "starfinderToolStripMenuItem";
            this.starfinderToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.starfinderToolStripMenuItem.Text = "Starfinder";
            // 
            // warhammerToolStripMenuItem
            // 
            this.warhammerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("warhammerToolStripMenuItem.Image")));
            this.warhammerToolStripMenuItem.Name = "warhammerToolStripMenuItem";
            this.warhammerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.warhammerToolStripMenuItem.Text = "Warhammer";
            // 
            // callOfCthuluToolStripMenuItem
            // 
            this.callOfCthuluToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("callOfCthuluToolStripMenuItem.Image")));
            this.callOfCthuluToolStripMenuItem.Name = "callOfCthuluToolStripMenuItem";
            this.callOfCthuluToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.callOfCthuluToolStripMenuItem.Text = "Call of Cthulu";
            // 
            // starWarsToolStripMenuItem
            // 
            this.starWarsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("starWarsToolStripMenuItem.Image")));
            this.starWarsToolStripMenuItem.Name = "starWarsToolStripMenuItem";
            this.starWarsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.starWarsToolStripMenuItem.Text = "Star Wars";
            // 
            // worldOfDarknessToolStripMenuItem
            // 
            this.worldOfDarknessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("worldOfDarknessToolStripMenuItem.Image")));
            this.worldOfDarknessToolStripMenuItem.Name = "worldOfDarknessToolStripMenuItem";
            this.worldOfDarknessToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.worldOfDarknessToolStripMenuItem.Text = "World of Darkness";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(317, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "NPC Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBulkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem d20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dungeonsAndDragonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gurpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathfinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starfinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warhammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callOfCthuluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starWarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldOfDarknessToolStripMenuItem;
    }
}

