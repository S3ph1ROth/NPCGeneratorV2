using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace NPCGeneratorV2.Views
{
    public partial class LoadNPC : TabPage
    {
        public NPC npc;
        public int i;

        public LoadNPC(string info)
        {
            InitializeComponent();

            markDead.Checked = bool.TryParse(Regex.Match(info, @"DEAD: (.*)").Groups[1].Value, out bool dead) ? dead : false;
            surrender.Checked = bool.TryParse(Regex.Match(info, @"SURRENDERED: (.*)").Groups[1].Value, out bool surr) ? surr : false;

            firstName.Text = Regex.Match(info, @"First name: (.*)").Groups[1].Value.Trim();
            lastName.Text = Regex.Match(info, @"Last name: (.*)").Groups[1].Value.Trim();
            nickname.Text = Regex.Match(info, @"Nickname: (.*)").Groups[1].Value.Trim();
            occupation.Text = Regex.Match(info, @"Occupation: (.*)").Groups[1].Value.Trim();

            armor1.Text = Regex.Match(info, @"Armor 1: (.*)").Groups[1].Value.Trim();
            armor1Armor1.Text = Regex.Match(info, @"Armor 1 armor 1: (.*)").Groups[1].Value.Trim();
            armor1Armor2.Text = Regex.Match(info, @"Armor 1 armor 2: (.*)").Groups[1].Value.Trim();
            armor1RDmg.Text = Regex.Match(info, @"Armor 1 reduce damage: (.*)").Groups[1].Value.Trim();
            armor1Mod.Text = Regex.Match(info, @"Armor 1 mod: (.*)").Groups[1].Value.Trim();

            armor2.Text = Regex.Match(info, @"Armor 2: (.*)").Groups[1].Value.Trim();
            armor2Armor1.Text = Regex.Match(info, @"Armor 2 armor 1: (.*)").Groups[1].Value.Trim();
            armor2Armor2.Text = Regex.Match(info, @"Armor 2 armor 2: (.*)").Groups[1].Value.Trim();
            armor2RDmg.Text = Regex.Match(info, @"Armor 2 reduce damage: (.*)").Groups[1].Value.Trim();
            armor2Mod.Text = Regex.Match(info, @"Armor 2 mod: (.*)").Groups[1].Value.Trim();

            weapon1.Text = Regex.Match(info, @"Weapon 1: (.*)").Groups[1].Value.Trim();
            weapon1Ammo1.Text = Regex.Match(info, @"Weapon 1 ammo 1: (.*)").Groups[1].Value.Trim();
            weapon1Ammo2.Text = Regex.Match(info, @"Weapon 1 ammo 2: (.*)").Groups[1].Value.Trim();
            weapon1Dmg.Text = Regex.Match(info, @"Weapon 1 damage: (.*)").Groups[1].Value.Trim();
            weapon1Mod.Text = Regex.Match(info, @"Weapon 1 mod: (.*)").Groups[1].Value.Trim();

            weapon2.Text = Regex.Match(info, @"Weapon 2: (.*)").Groups[1].Value.Trim();
            weapon2Ammo1.Text = Regex.Match(info, @"Weapon 2 ammo 1: (.*)").Groups[1].Value.Trim();
            weapon2Ammo2.Text = Regex.Match(info, @"Weapon 2 ammo 2: (.*)").Groups[1].Value.Trim();
            weapon2Dmg.Text = Regex.Match(info, @"Weapon 2 damage: (.*)").Groups[1].Value.Trim();
            weapon2Mod.Text = Regex.Match(info, @"Weapon 2 mod: (.*)").Groups[1].Value.Trim();

            weaponMod.Text = Regex.Match(info, @"Weapon mod: (.*)").Groups[1].Value.Trim();
            weapon3Mod1.Text = Regex.Match(info, @"Weapon mod 1: (.*)").Groups[1].Value.Trim();
            weapon3Mod2.Text = Regex.Match(info, @"Weapon mod 2: (.*)").Groups[1].Value.Trim();
            weapon3Mod3.Text = Regex.Match(info, @"Weapon mod 3:  (.*)").Groups[1].Value.Trim();
            weapon3Mod4.Text = Regex.Match(info, @"Weapon mod 4: (.*)").Groups[1].Value.Trim();

            Dictionary<string, string> _attributes = new Dictionary<string, string>();
            Dictionary<string, string> _inventory = new Dictionary<string, string>();


            string[] parse = info.Split('\r');

            for (int i = 0; i < parse.Length; i++)
            {
                if (parse[i].Contains("Attributes"))
                {
                    for (int j = i + 2; !parse[j].Contains("Armor"); j++)
                    {
                        if (string.Compare(parse[j], "\n") != 0 && parse[j] != "")
                        {
                            var attribute = parse[j].Split(' ');
                            _attributes.Add(attribute[0], attribute[1]);
                        }
                    }
                }
                else if (parse[i].Contains("Inventory"))
                {
                    for (int j = i + 1; !parse[j].Contains("Description"); j++)
                    {
                        if (string.Compare(parse[j], "\n") != 0 && parse[j] != "")
                        {
                            string inv1 = Regex.Match(parse[j], @"(.+) (\d+)").Groups[1].Value;
                            string inv2 = Regex.Match(parse[j], @"(.+) (\d+)").Groups[2].Value;
                            if (inv1 != "" && inv2 != "")
                                _inventory.Add(inv1, inv2);
                        }
                    }
                }
                else if (parse[i].Contains("Description"))
                {
                    for (int j = i + 1; j < parse.Length; j++)
                    {
                        if ((string.Compare(parse[j], "\n") != 0 || string.Compare(parse[j], "\r") != 0) && parse[j] != "")
                        {
                            description.Text += parse[j].Trim();
                            if (parse[j].Trim() != "")
                                description.Text += '\r';
                        }
                    }
                }
            }
            foreach (string key in _attributes.Keys)
            {
                attributes.Rows.Add(key, _attributes[key]);
            }
            foreach (string key in _inventory.Keys)
            {
                inventory.Rows.Add(key, _inventory[key]);
            }
            description.Text.TrimStart();
            description.Text.TrimEnd();

            attributes.Sort(attributes.Columns["Attribute"], ListSortDirection.Ascending);
            attributes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            inventory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            inventory.Sort(inventory.Columns["Item"], ListSortDirection.Ascending);

            npc = new NPC("")
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Nickname = nickname.Text,
                Occupation = occupation.Text,
                Description = description.Text,
                Armor1 = armor1.Text,
                Armor1Armor2 = armor1Armor2.Text,
                Armor1RDmg = armor1RDmg.Text,
                Armor2 = armor2.Text,
                Armor2Armor2 = armor2Armor2.Text,
                Armor2RDmg = armor2RDmg.Text,
                Weapon1 = weapon1.Text,
                Weapon1Dmg = weapon1Dmg.Text,
                Weapon2 = weapon2.Text,
                Weapon2Dmg = weapon2Dmg.Text,
                WeaponMod = weaponMod.Text,
                Weapon3Mod1 = weapon3Mod1.Text
            };
            foreach (DataGridViewRow inv in inventory.Rows)
            {
                try
                {
                    npc.Inventory.Add(inv.Cells[0].Value.ToString(), int.TryParse(inv.Cells[1].Value.ToString(), out int result) ? result : 1);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Reached the end of the list " + e.Message);
                }
            }
            foreach (DataGridViewRow attr in attributes.Rows)
            {
                try
                {
                    npc.Attributes.Add(attr.Cells[0].Value.ToString(), int.TryParse(attr.Cells[1].Value.ToString(), out int result) ? result : 1);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Reached the end of the list " + e.Message);
                }
            }

            save.Click += (s, EventArgs) => { save_Click(s, EventArgs, npc); };
            if (dead)
                Text = "*DEAD* " + firstName.Text + " " + lastName.Text;
            else if (surr)
            {
                Text = "*SURRENDERED* " + firstName.Text + " " + lastName.Text;
                pictureBox2.BackgroundImage = Properties.Resources.SURRENDER__3;
                pictureBox3.BackgroundImage = Properties.Resources.CIKICA_SUR__3;
            }
            else
                Text = firstName.Text + " " + lastName.Text;
        }
        private void save_Click(object sender, EventArgs e, NPC npc)
        {
            List<string> info = new List<string>();

            npc.FirstName = firstName.Text;
            npc.LastName = lastName.Text;
            npc.Nickname = nickname.Text;
            npc.Occupation = occupation.Text;
            npc.Description = description.Text;
            npc.Armor1 = armor1.Text;
            npc.Armor1Armor2 = armor1Armor2.Text;
            npc.Armor1RDmg = armor1RDmg.Text;
            npc.Armor2 = armor2.Text;
            npc.Armor2Armor2 = armor2Armor2.Text;
            npc.Armor2RDmg = armor2RDmg.Text;
            npc.Weapon1 = weapon1.Text;
            npc.Weapon1Dmg = weapon1Dmg.Text;
            npc.Weapon2 = weapon2.Text;
            npc.Weapon2Dmg = weapon2.Text;
            npc.WeaponMod = weaponMod.Text;
            npc.Weapon3Mod1 = weapon3Mod1.Text;

            info.Add("DEAD: " + markDead.Checked + "\r\n");
            info.Add("SURRENDERED: " + surrender.Checked + "\r\n");

            info.Add("First name: " + npc.FirstName + "\r\n");
            info.Add("Last name: " + npc.LastName + "\r\n");
            info.Add("Nickname: " + npc.Nickname + "\r\n");
            info.Add("Occupation: " + npc.Occupation + "\r\n");
            info.Add("Attributes:\r");
            foreach (string key in npc.Attributes.Keys)
            {
                info.Add(key + " " + npc.Attributes[key]);
            }
            info.Add("\r\n");
            info.Add("Armor 1: " + npc.Armor1);
            info.Add("Armor 1 reduce damage: " + npc.Armor1RDmg);
            info.Add("Armor 1 mod: " + (armor1Mod.Text == null ? "" : armor1Mod.Text));
            info.Add("Armor 1 armor 1: " + (armor1Armor1.Text == null ? "" : armor1Mod.Text));
            info.Add("Armor 1 armor 2: " + npc.Armor1Armor2 + "\r");

            info.Add("Armor 2: " + npc.Armor2);
            info.Add("Armor 2 reduce damage: " + npc.Armor2RDmg);
            info.Add("Armor 2 mod: " + (armor2Mod.Text == null ? "" : armor2Mod.Text));
            info.Add("Armor 2 armor 1: " + (armor2Armor1.Text == null ? "" : armor2Mod.Text));
            info.Add("Armor 2 armor 2: " + npc.Armor2Armor2 + "\r");

            info.Add("Weapon 1: " + npc.Weapon1);
            info.Add("Weapon 1 damage: " + npc.Weapon1Dmg);
            info.Add("Weapon 1 mod: " + (weapon1Mod.Text == null ? "" : weapon1Mod.Text));
            info.Add("Weapon 1 ammo 1: " + (weapon1Ammo1.Text == null ? "" : weapon1Ammo1.Text));
            info.Add("Weapon 1 ammo 2: " + (weapon1Ammo2.Text == null ? "" : weapon1Ammo2.Text) + '\r');

            info.Add("Weapon 2: " + npc.Weapon2);
            info.Add("Weapon 2 damage: " + npc.Weapon2Dmg);
            info.Add("Weapon 2 mod: " + (weapon2Mod.Text == null ? "" : weapon1Mod.Text));
            info.Add("Weapon 2 ammo 1: " + (weapon2Ammo1.Text == null ? "" : weapon2Ammo1.Text));
            info.Add("Weapon 2 ammo 2: " + (weapon2Ammo2.Text == null ? "" : weapon2Ammo2.Text) + '\r');

            info.Add("Weapon mod: " + npc.WeaponMod);
            info.Add("Weapon mod 1: " + npc.Weapon3Mod1);
            info.Add("Weapon mod 2: " + (weapon3Mod2.Text == null ? "" : weapon3Mod2.Text));
            info.Add("Weapon mod 3: " + (weapon3Mod3.Text == null ? "" : weapon3Mod3.Text));
            info.Add("Weapon mod 4: " + (weapon3Mod4.Text == null ? "" : weapon3Mod4.Text) + "\r");

            info.Add("Inventory:\r");
            foreach (string key in npc.Inventory.Keys)
            {
                info.Add(key + " " + npc.Inventory[key]);
            }
            info.Add("\r\n");

            info.Add("Description:\r");
            foreach (string line in npc.Description.Split('\r'))
            {
                info.Add(line);
            }
            using (SaveFileDialog fd = new SaveFileDialog())
            {
                fd.InitialDirectory = Environment.CurrentDirectory + "\\SavedNPCs\\";
                fd.Filter = "npc files (*.npc)|*.npc";
                fd.Title = "Save NPC";
                fd.RestoreDirectory = true;

                if (markDead.Checked)
                    fd.FileName = "DEAD " + npc.FirstName + " " + npc.LastName + ".npc";
                else if (surrender.Checked)
                    fd.FileName = "SURRENDERED " + npc.FirstName + " " + npc.LastName + ".npc";
                else
                    fd.FileName = npc.FirstName + " " + npc.LastName + ".npc";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(fd.FileName, info);
                }
            }
        }
        public void saveAll(string path)
        {
            List<string> info = new List<string>();

            npc.FirstName = firstName.Text;
            npc.LastName = lastName.Text;
            npc.Nickname = nickname.Text;
            npc.Occupation = occupation.Text;
            npc.Description = description.Text;
            npc.Armor1 = armor1.Text;
            npc.Armor1Armor2 = armor1Armor2.Text;
            npc.Armor1RDmg = armor1RDmg.Text;
            npc.Armor2 = armor2.Text;
            npc.Armor2Armor2 = armor2Armor2.Text;
            npc.Armor2RDmg = armor2RDmg.Text;
            npc.Weapon1 = weapon1.Text;
            npc.Weapon1Dmg = weapon1Dmg.Text;
            npc.Weapon2 = weapon2.Text;
            npc.Weapon2Dmg = weapon2.Text;
            npc.WeaponMod = weaponMod.Text;
            npc.Weapon3Mod1 = weapon3Mod1.Text;

            info.Add("DEAD: " + markDead.Checked + "\r\n");
            info.Add("SURRENDERED: " + surrender.Checked + "\r\n");

            info.Add("First name: " + npc.FirstName + "\r\n");
            info.Add("Last name: " + npc.LastName + "\r\n");
            info.Add("Nickname: " + npc.Nickname + "\r\n");
            info.Add("Occupation: " + npc.Occupation + "\r\n");
            info.Add("Attributes:\r");
            foreach (string key in npc.Attributes.Keys)
            {
                info.Add(key + " " + npc.Attributes[key]);
            }
            info.Add("\r\n");
            info.Add("Armor 1: " + npc.Armor1);
            info.Add("Armor 1 reduce damage: " + npc.Armor1RDmg);
            info.Add("Armor 1 mod: " + (armor1Mod.Text == null ? "" : armor1Mod.Text));
            info.Add("Armor 1 armor 1: " + (armor1Armor1.Text == null ? "" : armor1Mod.Text));
            info.Add("Armor 1 armor 2: " + npc.Armor1Armor2 + "\r");

            info.Add("Armor 2: " + npc.Armor2);
            info.Add("Armor 2 reduce damage: " + npc.Armor2RDmg);
            info.Add("Armor 2 mod: " + (armor2Mod.Text == null ? "" : armor2Mod.Text));
            info.Add("Armor 2 armor 1: " + (armor2Armor1.Text == null ? "" : armor2Mod.Text));
            info.Add("Armor 2 armor 2: " + npc.Armor2Armor2 + "\r");

            info.Add("Weapon 1: " + npc.Weapon1);
            info.Add("Weapon 1 damage: " + npc.Weapon1Dmg);
            info.Add("Weapon 1 mod: " + (weapon1Mod.Text == null ? "" : weapon1Mod.Text));
            info.Add("Weapon 1 ammo 1: " + (weapon1Ammo1.Text == null ? "" : weapon1Ammo1.Text));
            info.Add("Weapon 1 ammo 2: " + (weapon1Ammo2.Text == null ? "" : weapon1Ammo2.Text) + '\r');

            info.Add("Weapon 2: " + npc.Weapon2);
            info.Add("Weapon 2 damage: " + npc.Weapon2Dmg);
            info.Add("Weapon 2 mod: " + (weapon2Mod.Text == null ? "" : weapon1Mod.Text));
            info.Add("Weapon 2 ammo 1: " + (weapon2Ammo1.Text == null ? "" : weapon2Ammo1.Text));
            info.Add("Weapon 2 ammo 2: " + (weapon2Ammo2.Text == null ? "" : weapon2Ammo2.Text) + '\r');

            info.Add("Weapon mod: " + npc.WeaponMod);
            info.Add("Weapon mod 1: " + npc.Weapon3Mod1);
            info.Add("Weapon mod 2: " + (weapon3Mod2.Text == null ? "" : weapon3Mod2.Text));
            info.Add("Weapon mod 3: " + (weapon3Mod3.Text == null ? "" : weapon3Mod3.Text));
            info.Add("Weapon mod 4: " + (weapon3Mod4.Text == null ? "" : weapon3Mod4.Text) + "\r");

            info.Add("Inventory:\r");
            foreach (string key in npc.Inventory.Keys)
            {
                info.Add(key + " " + npc.Inventory[key]);
            }
            info.Add("\r\n");

            info.Add("Description:\r");
            foreach (string line in npc.Description.Split('\r'))
            {
                info.Add(line);
            }

            if (!markDead.Checked)
                File.WriteAllLines(path + "\\" + npc.FirstName + " " + npc.LastName + ".npc", info);
            else
                File.WriteAllLines(path + "\\DEAD " + npc.FirstName + " " + npc.LastName + ".npc", info);
        }

        private void markDead_CheckedChanged(object sender, EventArgs e)
        {
            if (markDead.Checked)
            {
                surrender.Checked = false;
                Text = "*DEAD* " + Text;
                pictureBox2.BackgroundImage = Properties.Resources.DEAD_3;
                pictureBox3.BackgroundImage = Properties.Resources.KRVCA;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                foreach (Control control in Controls)
                    if (control.Name != markDead.Name && control.GetType() != typeof(Label) && control.GetType() != typeof(Button))
                        control.Enabled = false;
            }
            else
            {
                Text = Text.Replace("*DEAD* ", "");
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                foreach (Control control in Controls)
                    if (control.Name != markDead.Name && control.GetType() != typeof(Label) && control.GetType() != typeof(Button))
                        control.Enabled = true;
            }
        }

        private void surrender_CheckedChanged(object sender, EventArgs e)
        {
            if (surrender.Checked)
            {
                Text = "*SURRENDERED* " + Text;
                pictureBox2.BackgroundImage = Properties.Resources.SURRENDER__3;
                pictureBox3.BackgroundImage = Properties.Resources.CIKICA_SUR__3;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
            else
            {
                Text = Text.Replace("*SURRENDERED* ", "");
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
        }
    }
}
