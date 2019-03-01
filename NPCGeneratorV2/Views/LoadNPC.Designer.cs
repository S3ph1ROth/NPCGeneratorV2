namespace NPCGeneratorV2.Views
{
    partial class LoadNPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadNPC));
            this.label33 = new System.Windows.Forms.Label();
            this.Attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributes = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.weapon3Mod4 = new System.Windows.Forms.TextBox();
            this.weapon3Mod3 = new System.Windows.Forms.TextBox();
            this.weapon3Mod2 = new System.Windows.Forms.TextBox();
            this.weapon3Mod1 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.weaponMod = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.weapon2Ammo2 = new System.Windows.Forms.TextBox();
            this.weapon2Ammo1 = new System.Windows.Forms.TextBox();
            this.weapon2Mod = new System.Windows.Forms.TextBox();
            this.weapon2Dmg = new System.Windows.Forms.TextBox();
            this.weapon1Ammo2 = new System.Windows.Forms.TextBox();
            this.weapon1Ammo1 = new System.Windows.Forms.TextBox();
            this.weapon1Mod = new System.Windows.Forms.TextBox();
            this.weapon1Dmg = new System.Windows.Forms.TextBox();
            this.armor2Armor2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.armor1Mod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.armor2Armor1 = new System.Windows.Forms.TextBox();
            this.armor2Mod = new System.Windows.Forms.TextBox();
            this.armor2RDmg = new System.Windows.Forms.TextBox();
            this.armor1Armor2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.armor1Armor1 = new System.Windows.Forms.TextBox();
            this.armor1RDmg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.weapon2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.weapon1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.armor2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.armor1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.occupation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributes)).BeginInit();
            this.SuspendLayout();
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(383, 653);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(175, 13);
            this.label33.TabIndex = 221;
            this.label33.Text = "By Ivan Cvetkovic and Milos Andric";
            // 
            // Attribute
            // 
            this.Attribute.HeaderText = "Attribute";
            this.Attribute.Name = "Attribute";
            this.Attribute.Width = 71;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 59;
            // 
            // inventory
            // 
            this.inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.dataGridViewTextBoxColumn2});
            this.inventory.Location = new System.Drawing.Point(12, 436);
            this.inventory.Name = "inventory";
            this.inventory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.inventory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.inventory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.inventory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inventory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.inventory.Size = new System.Drawing.Size(285, 93);
            this.inventory.TabIndex = 220;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 52;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 71;
            // 
            // attributes
            // 
            this.attributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.attributes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.attributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attribute,
            this.Value});
            this.attributes.Location = new System.Drawing.Point(12, 68);
            this.attributes.Name = "attributes";
            this.attributes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.attributes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.attributes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.attributes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.attributes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.attributes.Size = new System.Drawing.Size(228, 141);
            this.attributes.TabIndex = 219;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(11, 548);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(547, 96);
            this.description.TabIndex = 218;
            this.description.Text = "";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(521, 375);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 13);
            this.label29.TabIndex = 217;
            this.label29.Text = "Mod 4";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(474, 375);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 13);
            this.label30.TabIndex = 216;
            this.label30.Text = "Mod 3";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(427, 375);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 13);
            this.label31.TabIndex = 215;
            this.label31.Text = "Mod 2";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(380, 375);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 214;
            this.label32.Text = "Mod 1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(521, 336);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 13);
            this.label22.TabIndex = 213;
            this.label22.Text = "Ammo 2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(474, 336);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 212;
            this.label23.Text = "Ammo 1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(427, 336);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 13);
            this.label24.TabIndex = 211;
            this.label24.Text = "Mods";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(380, 336);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 13);
            this.label25.TabIndex = 210;
            this.label25.Text = "Dmg";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(521, 295);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 209;
            this.label18.Text = "Ammo 2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(474, 295);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 208;
            this.label19.Text = "Ammo 1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(427, 295);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 207;
            this.label20.Text = "Mods";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(380, 295);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 206;
            this.label21.Text = "Dmg";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(521, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 205;
            this.label14.Text = "Armor 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(474, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 204;
            this.label15.Text = "Armor 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(427, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 203;
            this.label16.Text = "Mods";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(380, 255);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 202;
            this.label17.Text = "R.Dmg";
            // 
            // weapon3Mod4
            // 
            this.weapon3Mod4.Location = new System.Drawing.Point(521, 393);
            this.weapon3Mod4.Name = "weapon3Mod4";
            this.weapon3Mod4.Size = new System.Drawing.Size(41, 20);
            this.weapon3Mod4.TabIndex = 201;
            // 
            // weapon3Mod3
            // 
            this.weapon3Mod3.Location = new System.Drawing.Point(474, 393);
            this.weapon3Mod3.Name = "weapon3Mod3";
            this.weapon3Mod3.Size = new System.Drawing.Size(41, 20);
            this.weapon3Mod3.TabIndex = 200;
            // 
            // weapon3Mod2
            // 
            this.weapon3Mod2.Location = new System.Drawing.Point(427, 393);
            this.weapon3Mod2.Name = "weapon3Mod2";
            this.weapon3Mod2.Size = new System.Drawing.Size(41, 20);
            this.weapon3Mod2.TabIndex = 199;
            // 
            // weapon3Mod1
            // 
            this.weapon3Mod1.Location = new System.Drawing.Point(380, 393);
            this.weapon3Mod1.Name = "weapon3Mod1";
            this.weapon3Mod1.Size = new System.Drawing.Size(41, 20);
            this.weapon3Mod1.TabIndex = 198;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(10, 648);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 197;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // weaponMod
            // 
            this.weaponMod.Location = new System.Drawing.Point(10, 393);
            this.weaponMod.Name = "weaponMod";
            this.weaponMod.Size = new System.Drawing.Size(364, 20);
            this.weaponMod.TabIndex = 196;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(8, 377);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 13);
            this.label28.TabIndex = 195;
            this.label28.Text = "Weapon Mod";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(8, 532);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 13);
            this.label27.TabIndex = 194;
            this.label27.Text = "Description";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(10, 418);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 13);
            this.label26.TabIndex = 193;
            this.label26.Text = "Inventory";
            // 
            // weapon2Ammo2
            // 
            this.weapon2Ammo2.Location = new System.Drawing.Point(521, 352);
            this.weapon2Ammo2.Name = "weapon2Ammo2";
            this.weapon2Ammo2.Size = new System.Drawing.Size(41, 20);
            this.weapon2Ammo2.TabIndex = 192;
            // 
            // weapon2Ammo1
            // 
            this.weapon2Ammo1.Location = new System.Drawing.Point(474, 352);
            this.weapon2Ammo1.Name = "weapon2Ammo1";
            this.weapon2Ammo1.Size = new System.Drawing.Size(41, 20);
            this.weapon2Ammo1.TabIndex = 191;
            // 
            // weapon2Mod
            // 
            this.weapon2Mod.Location = new System.Drawing.Point(427, 352);
            this.weapon2Mod.Name = "weapon2Mod";
            this.weapon2Mod.Size = new System.Drawing.Size(41, 20);
            this.weapon2Mod.TabIndex = 190;
            // 
            // weapon2Dmg
            // 
            this.weapon2Dmg.Location = new System.Drawing.Point(380, 352);
            this.weapon2Dmg.Name = "weapon2Dmg";
            this.weapon2Dmg.Size = new System.Drawing.Size(41, 20);
            this.weapon2Dmg.TabIndex = 189;
            // 
            // weapon1Ammo2
            // 
            this.weapon1Ammo2.Location = new System.Drawing.Point(521, 311);
            this.weapon1Ammo2.Name = "weapon1Ammo2";
            this.weapon1Ammo2.Size = new System.Drawing.Size(41, 20);
            this.weapon1Ammo2.TabIndex = 188;
            // 
            // weapon1Ammo1
            // 
            this.weapon1Ammo1.Location = new System.Drawing.Point(474, 311);
            this.weapon1Ammo1.Name = "weapon1Ammo1";
            this.weapon1Ammo1.Size = new System.Drawing.Size(41, 20);
            this.weapon1Ammo1.TabIndex = 187;
            // 
            // weapon1Mod
            // 
            this.weapon1Mod.Location = new System.Drawing.Point(427, 311);
            this.weapon1Mod.Name = "weapon1Mod";
            this.weapon1Mod.Size = new System.Drawing.Size(41, 20);
            this.weapon1Mod.TabIndex = 186;
            // 
            // weapon1Dmg
            // 
            this.weapon1Dmg.Location = new System.Drawing.Point(380, 311);
            this.weapon1Dmg.Name = "weapon1Dmg";
            this.weapon1Dmg.Size = new System.Drawing.Size(41, 20);
            this.weapon1Dmg.TabIndex = 185;
            // 
            // armor2Armor2
            // 
            this.armor2Armor2.Location = new System.Drawing.Point(521, 271);
            this.armor2Armor2.Name = "armor2Armor2";
            this.armor2Armor2.Size = new System.Drawing.Size(41, 20);
            this.armor2Armor2.TabIndex = 184;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(474, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 177;
            this.label11.Text = "Armor 1";
            // 
            // armor1Mod
            // 
            this.armor1Mod.Location = new System.Drawing.Point(427, 228);
            this.armor1Mod.Name = "armor1Mod";
            this.armor1Mod.Size = new System.Drawing.Size(41, 20);
            this.armor1Mod.TabIndex = 176;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(427, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 175;
            this.label12.Text = "Mods";
            // 
            // armor2Armor1
            // 
            this.armor2Armor1.Location = new System.Drawing.Point(474, 271);
            this.armor2Armor1.Name = "armor2Armor1";
            this.armor2Armor1.Size = new System.Drawing.Size(41, 20);
            this.armor2Armor1.TabIndex = 183;
            // 
            // armor2Mod
            // 
            this.armor2Mod.Location = new System.Drawing.Point(427, 271);
            this.armor2Mod.Name = "armor2Mod";
            this.armor2Mod.Size = new System.Drawing.Size(41, 20);
            this.armor2Mod.TabIndex = 182;
            // 
            // armor2RDmg
            // 
            this.armor2RDmg.Location = new System.Drawing.Point(380, 271);
            this.armor2RDmg.Name = "armor2RDmg";
            this.armor2RDmg.Size = new System.Drawing.Size(41, 20);
            this.armor2RDmg.TabIndex = 181;
            // 
            // armor1Armor2
            // 
            this.armor1Armor2.Location = new System.Drawing.Point(521, 228);
            this.armor1Armor2.Name = "armor1Armor2";
            this.armor1Armor2.Size = new System.Drawing.Size(41, 20);
            this.armor1Armor2.TabIndex = 180;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(521, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 179;
            this.label10.Text = "Armor 2";
            // 
            // armor1Armor1
            // 
            this.armor1Armor1.Location = new System.Drawing.Point(474, 228);
            this.armor1Armor1.Name = "armor1Armor1";
            this.armor1Armor1.Size = new System.Drawing.Size(41, 20);
            this.armor1Armor1.TabIndex = 178;
            // 
            // armor1RDmg
            // 
            this.armor1RDmg.Location = new System.Drawing.Point(380, 228);
            this.armor1RDmg.Name = "armor1RDmg";
            this.armor1RDmg.Size = new System.Drawing.Size(41, 20);
            this.armor1RDmg.TabIndex = 174;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(380, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 173;
            this.label13.Text = "R.Dmg";
            // 
            // weapon2
            // 
            this.weapon2.Location = new System.Drawing.Point(11, 352);
            this.weapon2.Name = "weapon2";
            this.weapon2.Size = new System.Drawing.Size(364, 20);
            this.weapon2.TabIndex = 172;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 171;
            this.label9.Text = "Weapon 2";
            // 
            // weapon1
            // 
            this.weapon1.Location = new System.Drawing.Point(10, 311);
            this.weapon1.Name = "weapon1";
            this.weapon1.Size = new System.Drawing.Size(364, 20);
            this.weapon1.TabIndex = 170;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 169;
            this.label8.Text = "Weapon 1";
            // 
            // armor2
            // 
            this.armor2.Location = new System.Drawing.Point(11, 271);
            this.armor2.Name = "armor2";
            this.armor2.Size = new System.Drawing.Size(364, 20);
            this.armor2.TabIndex = 168;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 167;
            this.label7.Text = "Armor 2";
            // 
            // armor1
            // 
            this.armor1.Location = new System.Drawing.Point(10, 228);
            this.armor1.Name = "armor1";
            this.armor1.Size = new System.Drawing.Size(364, 20);
            this.armor1.TabIndex = 166;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 165;
            this.label6.Text = "Armor 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 164;
            this.label5.Text = "Attributes";
            // 
            // occupation
            // 
            this.occupation.Location = new System.Drawing.Point(330, 29);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(100, 20);
            this.occupation.TabIndex = 163;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(330, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 162;
            this.label4.Text = "Occupation";
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(224, 29);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(100, 20);
            this.nickname.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(224, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 160;
            this.label3.Text = "Nickname";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(118, 29);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 159;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 158;
            this.label2.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(12, 29);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 156;
            this.label1.Text = "First Name";
            // 
            // LoadNPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 677);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.attributes);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.weapon3Mod4);
            this.Controls.Add(this.weapon3Mod3);
            this.Controls.Add(this.weapon3Mod2);
            this.Controls.Add(this.weapon3Mod1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.weaponMod);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.weapon2Ammo2);
            this.Controls.Add(this.weapon2Ammo1);
            this.Controls.Add(this.weapon2Mod);
            this.Controls.Add(this.weapon2Dmg);
            this.Controls.Add(this.weapon1Ammo2);
            this.Controls.Add(this.weapon1Ammo1);
            this.Controls.Add(this.weapon1Mod);
            this.Controls.Add(this.weapon1Dmg);
            this.Controls.Add(this.armor2Armor2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.armor1Mod);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.armor2Armor1);
            this.Controls.Add(this.armor2Mod);
            this.Controls.Add(this.armor2RDmg);
            this.Controls.Add(this.armor1Armor2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.armor1Armor1);
            this.Controls.Add(this.armor1RDmg);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.weapon2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.weapon1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.armor2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.armor1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.occupation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadNPC";
            this.Text = "NPC";
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridView inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView attributes;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox weapon3Mod4;
        private System.Windows.Forms.TextBox weapon3Mod3;
        private System.Windows.Forms.TextBox weapon3Mod2;
        private System.Windows.Forms.TextBox weapon3Mod1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox weaponMod;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox weapon2Ammo2;
        private System.Windows.Forms.TextBox weapon2Ammo1;
        private System.Windows.Forms.TextBox weapon2Mod;
        private System.Windows.Forms.TextBox weapon2Dmg;
        private System.Windows.Forms.TextBox weapon1Ammo2;
        private System.Windows.Forms.TextBox weapon1Ammo1;
        private System.Windows.Forms.TextBox weapon1Mod;
        private System.Windows.Forms.TextBox weapon1Dmg;
        private System.Windows.Forms.TextBox armor2Armor2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox armor1Mod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox armor2Armor1;
        private System.Windows.Forms.TextBox armor2Mod;
        private System.Windows.Forms.TextBox armor2RDmg;
        private System.Windows.Forms.TextBox armor1Armor2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox armor1Armor1;
        private System.Windows.Forms.TextBox armor1RDmg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox weapon2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox weapon1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox armor2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox armor1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox occupation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label1;
    }
}