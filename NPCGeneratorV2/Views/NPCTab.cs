﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace NPCGeneratorV2
{
    public partial class NPCTab : TabPage
    {
        public NPC npc;
        public int i;
        public NPCTab(string Path)
        {
            InitializeComponent();

            npc = new NPC(Path);

            firstName.Text = npc.FirstName;
            lastName.Text = npc.LastName;
            nickname.Text = npc.Nickname;
            occupation.Text = npc.Occupation;
            foreach (string key in npc.Attributes.Keys)
            {
                attributes.Rows.Add(key, npc.Attributes[key]);
            }
            attributes.Sort(attributes.Columns["Attribute"], ListSortDirection.Ascending);
            attributes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            armor1.Text = npc.Armor1;
            armor2.Text = npc.Armor2;
            weapon1.Text = npc.Weapon1;
            weapon2.Text = npc.Weapon2;
            weaponMod.Text = npc.WeaponMod;
            armor1RDmg.Text = npc.Armor1RDmg;
            armor1Armor2.Text = npc.Armor1Armor2;
            armor2RDmg.Text = npc.Armor2RDmg;
            armor2Armor2.Text = npc.Armor2Armor2;
            weapon1Dmg.Text = npc.Weapon1Dmg;
            weapon2Dmg.Text = npc.Weapon2Dmg;
            //weapon3Mod1.Text = npc.Weapon3Mod1;
            foreach (string key in npc.Inventory.Keys)
            {
                inventory.Rows.Add(key, npc.Inventory[key]);
            }
            inventory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            inventory.Sort(inventory.Columns["Item"], ListSortDirection.Ascending);
            description.Text = npc.Description;
            save.Click += (s, EventArgs) => { save_Click(s, EventArgs, npc); };
            Text = npc.FirstName + " " + npc.LastName;

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
            //npc.Weapon3Mod1 = weapon3Mod1.Text;

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
            //info.Add("Armor 1 armor 1: " + (armor1Armor1.Text == null ? "" : armor1Mod.Text));
            info.Add("Armor 1 armor 2: " + npc.Armor1Armor2 + "\r");

            info.Add("Armor 2: " + npc.Armor2);
            info.Add("Armor 2 reduce damage: " + npc.Armor2RDmg);
            info.Add("Armor 2 mod: " + (armor2Mod.Text == null ? "" : armor2Mod.Text));
            //info.Add("Armor 2 armor 1: " + (armor2Armor1.Text == null ? "" : armor2Mod.Text));
            info.Add("Armor 2 armor 2: " + npc.Armor2Armor2 + "\r");

            info.Add("Weapon 1: " + npc.Weapon1);
            info.Add("Weapon 1 damage: " + npc.Weapon1Dmg);
            //info.Add("Weapon 1 mod: " + (weapon1Mod.Text == null ? "" : weapon1Mod.Text));
            //info.Add("Weapon 1 ammo 1: " + (weapon1Ammo1.Text == null ? "" : weapon1Ammo1.Text));
            info.Add("Weapon 1 ammo 2: " + (weapon1Ammo2.Text == null ? "" : weapon1Ammo2.Text) + '\r');

            info.Add("Weapon 2: " + npc.Weapon2);
            info.Add("Weapon 2 damage: " + npc.Weapon2Dmg);
            //info.Add("Weapon 2 mod: " + (weapon2Mod.Text == null ? "" : weapon1Mod.Text));
            //info.Add("Weapon 2 ammo 1: " + (weapon2Ammo1.Text == null ? "" : weapon2Ammo1.Text));
            //info.Add("Weapon 2 ammo 2: " + (weapon2Ammo2.Text == null ? "" : weapon2Ammo2.Text) + '\r');

            info.Add("Weapon mod: " + npc.WeaponMod);
            info.Add("Weapon mod 1: " + npc.Weapon3Mod1);
            //info.Add("Weapon mod 2: " + (weapon3Mod2.Text == null ? "" : weapon3Mod2.Text));
            //info.Add("Weapon mod 3: " + (weapon3Mod3.Text == null ? "" : weapon3Mod3.Text));
            //info.Add("Weapon mod 4: " + (weapon3Mod4.Text == null ? "" : weapon3Mod4.Text) + "\r");

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
            //npc.Weapon3Mod1 = weapon3Mod1.Text;

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
            //info.Add("Armor 1 armor 1: " + (armor1Armor1.Text == null ? "" : armor1Mod.Text));
            info.Add("Armor 1 armor 2: " + npc.Armor1Armor2 + "\r");

            info.Add("Armor 2: " + npc.Armor2);
            info.Add("Armor 2 reduce damage: " + npc.Armor2RDmg);
            info.Add("Armor 2 mod: " + (armor2Mod.Text == null ? "" : armor2Mod.Text));
            //info.Add("Armor 2 armor 1: " + (armor2Armor1.Text == null ? "" : armor2Mod.Text));
            info.Add("Armor 2 armor 2: " + npc.Armor2Armor2 + "\r");

            info.Add("Weapon 1: " + npc.Weapon1);
            info.Add("Weapon 1 damage: " + npc.Weapon1Dmg);
            //info.Add("Weapon 1 mod: " + (weapon1Mod.Text == null ? "" : weapon1Mod.Text));
            //info.Add("Weapon 1 ammo 1: " + (weapon1Ammo1.Text == null ? "" : weapon1Ammo1.Text));
            info.Add("Weapon 1 ammo 2: " + (weapon1Ammo2.Text == null ? "" : weapon1Ammo2.Text) + '\r');

            info.Add("Weapon 2: " + npc.Weapon2);
            info.Add("Weapon 2 damage: " + npc.Weapon2Dmg);
            //info.Add("Weapon 2 mod: " + (weapon2Mod.Text == null ? "" : weapon1Mod.Text));
            //info.Add("Weapon 2 ammo 1: " + (weapon2Ammo1.Text == null ? "" : weapon2Ammo1.Text));
            //info.Add("Weapon 2 ammo 2: " + (weapon2Ammo2.Text == null ? "" : weapon2Ammo2.Text) + '\r');

            info.Add("Weapon mod: " + npc.WeaponMod);
            info.Add("Weapon mod 1: " + npc.Weapon3Mod1);
            //info.Add("Weapon mod 2: " + (weapon3Mod2.Text == null ? "" : weapon3Mod2.Text));
            //info.Add("Weapon mod 3: " + (weapon3Mod3.Text == null ? "" : weapon3Mod3.Text));
            //info.Add("Weapon mod 4: " + (weapon3Mod4.Text == null ? "" : weapon3Mod4.Text) + "\r");

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

            if (markDead.Checked)
                File.WriteAllLines(path + "\\DEAD " + npc.FirstName + " " + npc.LastName + ".npc", info);
            else if (surrender.Checked)
                File.WriteAllLines(path + "\\SURRENDERED " + npc.FirstName + " " + npc.LastName + ".npc", info);
            else
                File.WriteAllLines(path + "\\" + npc.FirstName + " " + npc.LastName + ".npc", info);
        }

        private void markDead_Click(object sender, EventArgs e)
        {
            if (markDead.Checked)
            {
                surrender.Checked = false;
                Text = "*DEAD* " + Text;
                foreach (Control control in Controls)
                    if (control.Name != markDead.Name && control.GetType() != typeof(Label) && control.GetType() != typeof(Button))
                        control.Enabled = false;
            }
            else
            {
                Text = Text.Replace("*DEAD* ", "");
                foreach (Control control in Controls)
                    if (control.Name != markDead.Name && control.GetType() != typeof(Label) && control.GetType() != typeof(Button))
                        control.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (surrender.Checked)
            {
                Text = "*SURRENDERED* " + Text;
            }
            else
            {
                Text = Text.Replace("*SURRENDERED* ", "");
            }
        }
    }
}
