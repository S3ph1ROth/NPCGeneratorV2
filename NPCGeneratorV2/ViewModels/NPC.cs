using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace NPCGeneratorV2
{
    public class NPC
    {

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

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public Dictionary<string, int> Attributes { get => attributes; set => attributes = value; }
        public string Armor1 { get => armor1; set => armor1 = value; }
        public string Armor2 { get => armor2; set => armor2 = value; }
        public string Weapon1 { get => weapon1; set => weapon1 = value; }
        public string Weapon2 { get => weapon2; set => weapon2 = value; }
        public string WeaponMod { get => weaponMod; set => weaponMod = value; }
        public Dictionary<string, int> Inventory { get => inventory; set => inventory = value; }
        public string Description { get => description; set => description = value; }
        public string Armor1RDmg { get => armor1RDmg; set => armor1RDmg = value; }
        public string Armor1Armor2 { get => armor1Armor2; set => armor1Armor2 = value; }
        public string Armor2RDmg { get => armor2RDmg; set => armor2RDmg = value; }
        public string Armor2Armor2 { get => armor2Armor2; set => armor2Armor2 = value; }
        public string Weapon1Dmg { get => weapon1Dmg; set => weapon1Dmg = value; }
        public string Weapon2Dmg { get => weapon2Dmg; set => weapon2Dmg = value; }
        public string Weapon3Mod1 { get => weapon3Mod1; set => weapon3Mod1 = value; }

        public NPC(string path)
        {

            Random rnd = new Random(DateTime.Now.Millisecond);

            try
            {
                string[] firstnames = File.ReadAllLines(path + "Name.txt");
                FirstName = firstnames[rnd.Next(0, firstnames.Length)];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] lastnames = File.ReadAllLines(path + "Last Name.txt");
                LastName = lastnames[rnd.Next(0, lastnames.Length)];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _nickname = File.ReadAllLines(path + "Nickname.txt");
                Nickname = _nickname[rnd.Next(0, _nickname.Length)];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _occupation = File.ReadAllLines(path + "Occupation.txt");
                Occupation = _occupation[rnd.Next(0, _occupation.Length)];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _attributes = File.ReadAllLines(path + "Attributes.txt");
                for (int j = 0; j < _attributes.Length; j++)
                {
                    string[] attribute = _attributes[j].Split(' ');
                    Attributes.Add(attribute[0], rnd.Next(int.Parse(attribute[1]), int.Parse(attribute[2])));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _armors1 = File.ReadAllLines(path + "Armor 1.txt");
                Armor1 = _armors1[rnd.Next(0, _armors1.Length)];
                Armor1RDmg = Regex.Match(Armor1, @"\((.*)\)").Groups[1].Value;
                Armor1Armor2 = Regex.Match(Armor1, @"\[(.*)\]").Groups[1].Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _armors2 = File.ReadAllLines(path + "Armor 2.txt");
                Armor2 = _armors2[rnd.Next(0, _armors2.Length)];
                Armor2RDmg = Regex.Match(Armor2, @"\((.*)\)").Groups[1].Value;
                Armor2Armor2 = Regex.Match(Armor2, @"\[(.*)\]").Groups[1].Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _weapons1 = File.ReadAllLines(path + "Weapon 1.txt");
                Weapon1 = _weapons1[rnd.Next(0, _weapons1.Length)];
                Weapon1Dmg = Regex.Match(Weapon1, @"\((.*)\)").Groups[1].Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _weapons2 = File.ReadAllLines(path + "Weapon 2.txt");
                Weapon2 = _weapons2[rnd.Next(0, _weapons2.Length)];
                Weapon2Dmg = Regex.Match(Weapon2, @"\((.*)\)").Groups[1].Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _weapons3 = File.ReadAllLines(path + "Weapon Addons.txt");
                WeaponMod = _weapons3[rnd.Next(0, _weapons3.Length)];
                Weapon3Mod1 = Regex.Match(WeaponMod, @"\((.*)\)").Groups[1].Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _inventory = File.ReadAllLines(path + "Inventory.txt");
                int row_max = rnd.Next(2, _inventory.Length);
                int row_min = rnd.Next(1, row_max - 1);

                for (int j = row_min; j < row_max; j++)
                {
                    var invLine = _inventory[rnd.Next(0, _inventory.Length)];
                    string inv1 = Regex.Match(invLine, @"([a-zA-Z0-9\(\)\.,;:\[\]{}\+\-\\\/|º ]+)\s\((\d+) ?(\d+)\)").Groups[1].Value;
                    string inv2 = Regex.Match(invLine, @"([a-zA-Z0-9\(\)\.,;:\[\]{}\+\-\\\/|º ]+)\s\((\d+) ?(\d+)\)").Groups[2].Value;
                    string inv3 = Regex.Match(invLine, @"([a-zA-Z0-9\(\)\.,;:\[\]{}\+\-\\\/|º ]+)\s\((\d+) ?(\d+)\)").Groups[3].Value;

                    if (j == row_min)
                    {
                        Inventory.Add(inv1, rnd.Next(int.Parse(inv2), int.Parse(inv3)));
                    }
                    else
                    {
                        if (!Inventory.ContainsKey(inv1))
                        {
                            Inventory.Add(inv1, rnd.Next(int.Parse(inv2), int.Parse(inv3)));
                        }
                        else
                        {
                            j--;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                string[] age = File.ReadAllLines(path + "Age.txt");
                Description += "Age: " + age[rnd.Next(0, age.Length)] + '\r';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] eyes = File.ReadAllLines(path + "Eyes.txt");
                Description += "Eye color: " + eyes[rnd.Next(0, eyes.Length)] + '\r';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] hair = File.ReadAllLines(path + "Hair.txt");
                Description += "Hair: " + hair[rnd.Next(0, hair.Length)] + '\r';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] voice = File.ReadAllLines(path + "Voice.txt");
                Description += "Voice: " + voice[rnd.Next(0, voice.Length)] + '\r';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] weight = File.ReadAllLines(path + "Weight.txt");
                Description += "Weight: " + weight[rnd.Next(0, weight.Length)] + '\r';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] height = File.ReadAllLines(path + "Height.txt");
                Description += "Height: " + height[rnd.Next(0, height.Length)] + '\r';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] positive_trait = File.ReadAllLines(path + "Positive traits.txt");
                Description += "Positive trait: " + positive_trait[rnd.Next(0, positive_trait.Length)] + '\r';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] neutral_trait = File.ReadAllLines(path + "Neutral traits.txt");
                Description += "Neutral trait: " + neutral_trait[rnd.Next(0, neutral_trait.Length)] + '\r';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] negative_trait = File.ReadAllLines(path + "Negative traits.txt");
                Description += "Negative trait: " + negative_trait[rnd.Next(0, negative_trait.Length)] + '\r';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] medical_issues = File.ReadAllLines(path + "Medical Issues.txt");
                Description += "Medical issues: " + medical_issues[rnd.Next(0, medical_issues.Length)];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

