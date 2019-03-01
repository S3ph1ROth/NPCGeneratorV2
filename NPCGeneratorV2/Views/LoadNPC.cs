using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPCGeneratorV2.Views
{
    public partial class LoadNPC : Form
    {
        public LoadNPC(string info)
        {
            InitializeComponent();
            firstName.Text = Regex.Match(info, @"First name: (.*)").Groups[1].Value.Trim();
            lastName.Text = Regex.Match(info, @"Last name: (.*)").Groups[1].Value.Trim();
            nickname.Text = Regex.Match(info, @"Nickname: (.*)").Groups[1].Value.Trim();

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
            weapon3Mod1.Text = Regex.Match(info, @"Weapon Mod 1: (.*)").Groups[1].Value.Trim();
            weapon3Mod2.Text = Regex.Match(info, @"Weapon Mod 2: (.*)").Groups[1].Value.Trim();
            weapon3Mod3.Text = Regex.Match(info, @"Weapon Mod 3:  (.*)").Groups[1].Value.Trim();
            weapon3Mod4.Text = Regex.Match(info, @"Weapon Mod 4: (.*)").Groups[1].Value.Trim();

            Dictionary<string, string> _attributes = new Dictionary<string, string>();
            Dictionary<string, string> _inventory = new Dictionary<string, string>();
            

            string[] parse = info.Split('\r');

            for (int i = 0; i < parse.Length; i++)
            {
                if (parse[i].Contains("Attributes"))
                {
                    for (int j = i + 2; !parse[j].Contains("Armor"); j++)
                    {
                        if (string.Compare(parse[j], "\n") != 0)
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
                        if (string.Compare(parse[j], "\n") != 0)
                        {
                            string inv1 = Regex.Match(parse[j], @"(.+) (\d+)").Groups[1].Value;
                            string inv2 = Regex.Match(parse[j], @"(.+) (\d+)").Groups[2].Value;
                            if(inv1 != "" && inv2 !="")
                                _inventory.Add(inv1, inv2);
                        }
                    }
                }
                else if (parse[i].Contains("Description"))
                {
                    for (int j = i + 1; j<parse.Length; j++)
                    {
                        if (string.Compare(parse[j], "\n") != 0 || string.Compare(parse[j], "\r") != 0)
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
        }
    }
}
