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
        //private string path;



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
        public string Armor1RDmg { get => armor1RDmg; }
        public string Armor1Armor2 { get => armor1Armor2; }
        public string Armor2RDmg { get => armor2RDmg; }
        public string Armor2Armor2 { get => armor2Armor2; }
        public string Weapon1Dmg { get => weapon1Dmg; }
        public string Weapon2Dmg { get => weapon2Dmg; }
        public string Weapon3Mod1 { get => weapon3Mod1; }
        //public string Path { get => path; set => path = value; }

        public NPC(string path)
        {

            Random rnd = new Random(DateTime.Now.Millisecond);

            try
            {
                string[] firstnames = File.ReadAllLines(path + "Name.txt");
                firstName = firstnames[rnd.Next(0, firstnames.Length)];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] lastnames = File.ReadAllLines(path + "Last Name.txt");
                lastName = lastnames[rnd.Next(0, lastnames.Length)];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _nickname = File.ReadAllLines(path + "Nickname.txt");
                nickname = _nickname[rnd.Next(0, _nickname.Length)];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _occupation = File.ReadAllLines(path + "Occupation.txt");
                occupation = _occupation[rnd.Next(0, _occupation.Length)];
            }
            catch(Exception e)
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _armors1 = File.ReadAllLines(path + "Armor 1.txt");
                armor1 = _armors1[rnd.Next(0, _armors1.Length)];
                armor1RDmg = Regex.Match(Armor1, @"([\-+] ?[0-9]* ?(?i)Shift)").Groups[1].Value;
                armor1Armor2 = Regex.Match(Armor1, @"([0-9]+/[0-9]+)").Groups[1].Value;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _armors2 = File.ReadAllLines(path + "Armor 2.txt");
                armor2 = _armors2[rnd.Next(0, _armors2.Length)];
                armor2RDmg = Regex.Match(Armor2, @"([\-+] ?[0-9]* ?(?i)Shift)").Groups[1].Value;
                armor2Armor2 = Regex.Match(Armor2, @"([0-9]+/[0-9]+)").Groups[1].Value;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _weapons1 = File.ReadAllLines(path + "Weapon 1.txt");
                weapon1 = _weapons1[rnd.Next(0, _weapons1.Length)];
                weapon1Dmg = Regex.Match(Weapon1, @"([\-+] ?[0-9]* ?(?i)Shift)").Groups[1].Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _weapons2 = File.ReadAllLines(path + "Weapon 2.txt");
                weapon2 = _weapons2[rnd.Next(0, _weapons2.Length)];
                weapon2Dmg = Regex.Match(Weapon2, @"([\-+] ?[0-9]* ?(?i)Shift|[\-+] ?[0-9]* ?(?i)Shoot)").Groups[1].Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _weapons3 = File.ReadAllLines(path + "Weapon Addons.txt");
                weaponMod = _weapons3[rnd.Next(0, _weapons3.Length)];
                weapon3Mod1 = Regex.Match(WeaponMod, @"([\-+] ?[0-9]* ?(?i)Shift|[\-+] ?[0-9 ]* ?(?i)Shoot)").Groups[1].Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                string[] _inventory = File.ReadAllLines(path + "Inventory.txt");
                int row_max = rnd.Next(2, _inventory.Length);
                int row_min = rnd.Next(1, row_max);

                for (int j = row_min; j < row_max; j++)
                {
                    string inv1 = Regex.Match(_inventory[rnd.Next(0, _inventory.Length)], @"(.+)\t? ?(\d+)\t? ?(\d+)").Groups[1].Value;
                    string inv2 = Regex.Match(_inventory[rnd.Next(0, _inventory.Length)], @"(.+)\t? ?(\d+)\t? ?(\d+)").Groups[2].Value;
                    string inv3 = Regex.Match(_inventory[rnd.Next(0, _inventory.Length)], @"(.+)\t? ?(\d+)\t? ?(\d+)").Groups[3].Value;

                    if (j == row_min)
                    {
                        Inventory.Add(inv1, rnd.Next(int.Parse(inv2), int.Parse(inv3)));
                    }
                    else
                    {
                        if (!inventory.ContainsKey(inv1))
                        {
                            Inventory.Add(inv1, rnd.Next(int.Parse(inv2), int.Parse(inv3)));
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
                string[] eyes = File.ReadAllLines(path + "Eyes.txt");
                string[] hair = File.ReadAllLines(path + "Hair.txt");
                string[] voice = File.ReadAllLines(path + "Voice.txt");
                string[] weight = File.ReadAllLines(path + "Weight.txt");
                string[] height = File.ReadAllLines(path + "Height.txt");
                string[] positive_trait = File.ReadAllLines(path + "Positive traits.txt");
                string[] neutral_trait = File.ReadAllLines(path + "Neutral traits.txt");
                string[] negative_trait = File.ReadAllLines(path + "Negative traits.txt");
                description = String.Format("Eye color: {0}\r" +
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
