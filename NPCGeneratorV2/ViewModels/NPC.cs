using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace NPCGeneratorV2
{
    public class NPC
    {

        string[] firstnames = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Name.txt");
        string[] lastnames = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Last Name.txt");
        string[] _nickname = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Nickname.txt");
        string[] _occupation = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Occupation.txt");
        string[] _attributes = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Attributes.txt");
        string[] _armors1 = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Armor 1.txt");
        string[] _armors2 = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Armor 2.txt");
        string[] _weapons1 = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Weapon 1.txt");
        string[] _weapons2 = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Weapon 2.txt");
        string[] _weapons3 = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Weapon Addons.txt");
        string[] _inventory = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Inventory.txt");
        string[] eyes = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Eyes.txt");
        string[] hair = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Hair.txt");
        string[] voice = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Voice.txt");
        string[] weight = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Weight.txt");
        string[] height = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Height.txt");
        string[] positive_trait = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Positive traits.txt");
        string[] neutral_trait = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Neutral traits.txt");
        string[] negative_trait = File.ReadAllLines(Environment.CurrentDirectory + "\\Text files\\Negative traits.txt");

        Random rnd;

        private string firstName;
        private string lastName;
        private string nickname;
        private string occupation;
        private Dictionary<string, int> attributes = new Dictionary<string, int>();
        private string armor1;
        private string armor2;
        private string weapon1;
        private string weapon2;
        private string weaponMod;
        private Dictionary<string, int> inventory = new Dictionary<string, int>();
        private string description;
        private string armor1RDmg;
        private string armor1Armor2;
        private string armor2RDmg;
        private string armor2Armor2;
        private string weapon1Dmg;
        private string weapon2Dmg;
        private string weapon3Mod1;

        public NPC()
        {
            rnd = new Random(DateTime.Now.Millisecond);
            firstName = firstnames[rnd.Next(0, firstnames.Length)];
            lastName = lastnames[rnd.Next(0, lastnames.Length)];
            nickname = _nickname[rnd.Next(0, _nickname.Length)];
            occupation = _occupation[rnd.Next(0, _occupation.Length)];

            for (int j = 0; j < _attributes.Length; j++)
            {
                string[] attribute = _attributes[j].Split(' ');
                Attributes.Add(attribute[0], rnd.Next(int.Parse(attribute[1]), int.Parse(attribute[2])));
            }

            armor1 = _armors1[rnd.Next(0, _armors1.Length)];
            armor2 = _armors2[rnd.Next(0, _armors2.Length)];
            weapon1 = _weapons1[rnd.Next(0, _weapons1.Length)];
            weapon2 = _weapons2[rnd.Next(0, _weapons2.Length)];
            weaponMod = _weapons3[rnd.Next(0, _weapons3.Length)];

            int row_max = rnd.Next(2, _inventory.Length);
            int row_min = rnd.Next(1, row_max);

            for (int j = row_min; j < row_max; j++)
            {
                string[] inv = _inventory[rnd.Next(0, _inventory.Length)].Split('\t');

                if (j == row_min)
                {
                    Inventory.Add(inv[0], rnd.Next(int.Parse(inv[1]), int.Parse(inv[2])));
                }
                else
                {
                    if (!inventory.ContainsKey(inv[0]))
                    {
                        Inventory.Add(inv[0], rnd.Next(int.Parse(inv[1]), int.Parse(inv[2])));
                    }
                }
            }
            description = String.Format("Eye color: {0}\n" +
                                        "Hair color: {1}\r" +
                                        "Voice type: {2}\r" +
                                        "Body type: {3}\r" +
                                        "Height: {4}\r" +
                                        "Positive trait: {5}\r" +
                                        "Neutral trait: {6}\r" +
                                        "Negative trait: {7}\r",
                                        eyes[rnd.Next(0, eyes.Length)],
                                        hair[rnd.Next(0, hair.Length)],
                                        voice[rnd.Next(0, voice.Length)],
                                        weight[rnd.Next(0, weight.Length)],
                                        height[rnd.Next(0, height.Length)],
                                        positive_trait[rnd.Next(0, positive_trait.Length)],
                                        neutral_trait[rnd.Next(0, neutral_trait.Length)],
                                        negative_trait[rnd.Next(0, negative_trait.Length)]);
            armor1RDmg = Regex.Match(Armor1, @"\(([^)]*)\)").Groups[1].Value;
            armor1Armor2 = Regex.Match(Armor1, @"([0-9]+/[0-9]+)").Groups[1].Value;
            armor2RDmg = Regex.Match(Armor2, @"\(([^)]*)\)").Groups[1].Value;
            armor2Armor2 = Regex.Match(Armor2, @"([0-9]+/[0-9]+)").Groups[1].Value;
            weapon1Dmg = Regex.Match(Weapon1, @"(\+[0-9 ]+ Shift)").Groups[1].Value;
            weapon2Dmg = Regex.Match(Weapon2, @"([\-+0-9 ]* Shift|[\-+0-9 ]* Shoot)").Groups[1].Value;
            weapon3Mod1 = Regex.Match(WeaponMod, @"([\-+0-9]* Shift|[\-+0-9]* Shoot)").Groups[1].Value;
        }

        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        public string Nickname { get => nickname; }
        public string Occupation { get => occupation; }
        public Dictionary<string, int> Attributes { get => attributes; }
        public string Armor1 { get => armor1; }
        public string Armor2 { get => armor2; }
        public string Weapon1 { get => weapon1; }
        public string Weapon2 { get => weapon2; }
        public string WeaponMod { get => weaponMod; }
        public Dictionary<string, int> Inventory { get => inventory; }
        public string Description { get => description; }
        public string Armor1RDmg { get => armor1RDmg;}
        public string Armor1Armor2 { get => armor1Armor2;}
        public string Armor2RDmg { get => armor2RDmg; }
        public string Armor2Armor2 { get => armor2Armor2;}
        public string Weapon1Dmg { get => weapon1Dmg; }
        public string Weapon2Dmg { get => weapon2Dmg; }
        public string Weapon3Mod1 { get => weapon3Mod1; }
    }
}
