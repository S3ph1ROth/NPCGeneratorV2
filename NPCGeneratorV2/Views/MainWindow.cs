﻿using NPCGeneratorV2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPCGeneratorV2
{
    public partial class MainWindow : Form
    {

        public string path = Environment.CurrentDirectory + "\\Presets\\Default\\";

        public MainWindow()
        {
            InitializeComponent();
            path = Environment.CurrentDirectory + "\\Presets\\Default\\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NPCList npcList = new NPCList();
            npcList.Path = path;
            npcList.N = int.TryParse(textBox1.Text, out int result) ? result : 1;
            npcList.Show();
        }

        private void loadPresetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.SelectedPath = Environment.CurrentDirectory + "\\Presets\\";
            
            if (fld.ShowDialog() == DialogResult.OK)
            {
                path = fld.SelectedPath + "\\";
            }
        }

        private void loadNPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog()) {
                NPCList npc = new NPCList();
                fd.InitialDirectory = Environment.CurrentDirectory;
                fd.Filter = "npc files (*.npc)|*.npc";
                fd.RestoreDirectory = true;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    var filePath = fd.FileName;
                    var fileStream = fd.OpenFile();
                    string fileContent;
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    npc = new NPCList();
                    npc.FileContent = fileContent;
                    npc.Show();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Random NPC generator\nVersion 2.0\nCreated by Ivan Cvetkovic and Milos Andric", "About");
        }
    }
}
