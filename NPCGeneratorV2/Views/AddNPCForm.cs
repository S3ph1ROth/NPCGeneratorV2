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

namespace NPCGeneratorV2.Views
{
    public partial class AddNPCForm : Form
    {
        public string path = Environment.CurrentDirectory + "\\Presets\\Default\\";
        public List<NPCTab> tabs = new List<NPCTab>();
        public List<LoadNPC> load;

        public AddNPCForm()
        {
            InitializeComponent();
            path = "";
            string d20PathCheck = Environment.CurrentDirectory + "\\Presets\\D20";
            string d100PathCheck = Environment.CurrentDirectory + "\\Presets\\D100";
            string dndPathCheck = Environment.CurrentDirectory + "\\Presets\\DnD";
            string fatePathCheck = Environment.CurrentDirectory + "\\Presets\\FATE RPG";
            string gurpsPathCheck = Environment.CurrentDirectory + "\\Presets\\GURPS";
            string pathfinderPathCheck = Environment.CurrentDirectory + "\\Presets\\Pathfinder";
            string starfinderPathCheck = Environment.CurrentDirectory + "\\Presets\\Starfinder";
            string cocPathCheck = Environment.CurrentDirectory + "\\Presets\\Call of Cthulu";
            string warhammerPathCheck = Environment.CurrentDirectory + "\\Presets\\Warhammer";
            string swPathCheck = Environment.CurrentDirectory + "\\Presets\\Star Wars";
            string wodPathCheck = Environment.CurrentDirectory + "\\Presets\\World of Darkness";
            try
            {
                List<string> d20Folders = Directory.GetDirectories(d20PathCheck).ToList<string>();
                foreach (string folderPath in d20Folders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    d20ToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
            try
            {
                List<string> d100Folders = Directory.GetDirectories(d100PathCheck).ToList<string>();
                foreach (string folderPath in d100Folders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    d100ToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
            try
            {
                List<string> dndFolders = Directory.GetDirectories(dndPathCheck).ToList<string>();
                foreach (string folderPath in dndFolders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    dungeonsAndDragonsToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
            try
            {
                List<string> fateFolders = Directory.GetDirectories(fatePathCheck).ToList<string>();
                foreach (string folderPath in fateFolders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    fateToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
            try
            {
                List<string> gurpsFolders = Directory.GetDirectories(gurpsPathCheck).ToList<string>();
                foreach (string folderPath in gurpsFolders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    gurpsToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
            try
            {
                List<string> pathfinderFolders = Directory.GetDirectories(pathfinderPathCheck).ToList<string>();
                foreach (string folderPath in pathfinderFolders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    pathfinderToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
            try
            {
                List<string> starfinderFolders = Directory.GetDirectories(starfinderPathCheck).ToList<string>();
                foreach (string folderPath in starfinderFolders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    starfinderToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
            try
            {
                List<string> warhammerFolders = Directory.GetDirectories(warhammerPathCheck).ToList<string>();
                foreach (string folderPath in warhammerFolders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    warhammerToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
            try
            {
                List<string> cocFolders = Directory.GetDirectories(cocPathCheck).ToList<string>();
                foreach (string folderPath in cocFolders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    callOfCthuluToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
            try
            {
                List<string> swFolders = Directory.GetDirectories(swPathCheck).ToList<string>();
                foreach (string folderPath in swFolders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    starWarsToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
            try
            {
                List<string> wodFolders = Directory.GetDirectories(wodPathCheck).ToList<string>();
                foreach (string folderPath in wodFolders)
                {
                    string[] folder = folderPath.Split('\\');
                    ToolStripItem preset = new ToolStripMenuItem();
                    preset.Text = folder[folder.Length - 1];
                    preset.Click += (s, EventArgs) => { pathChange_click(s, EventArgs, folderPath + "\\"); };
                    worldOfDarknessToolStripMenuItem.DropDownItems.Add(preset);
                }
            }
            catch { }
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

        private void generate_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                var n = int.TryParse(npcNum.Text, out int result) ? result : 1;
                for (int i = 0; i < n; i++)
                {
                    var tab = new NPCTab(path);
                    tabs.Add(tab);
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please select a preset and then try to generate NPCs", "Error, empty preset");
            }
        }

        private void loadOneNPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                load = new List<LoadNPC>();
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
                    load.Add(new LoadNPC(fileContent));
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void loadGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load = new List<LoadNPC>();
            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.SelectedPath = Environment.CurrentDirectory + "\\SavedNPCs\\";
            if (fld.ShowDialog() == DialogResult.OK)
            {
                path = fld.SelectedPath + "\\";
                string[] files = Directory.GetFiles(path, "*.npc", SearchOption.TopDirectoryOnly);
                foreach (string file in files)
                {
                    string[] contentRaw = File.ReadAllLines(file);
                    string content = "";
                    foreach (string line in contentRaw)
                    {
                        content += line + "\r\n";
                    }
                    load.Add(new LoadNPC(content));
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void loadGroupToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            loadNPCToolStripMenuItem.ForeColor = Color.White;
        }

        private void loadGroupToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            loadNPCToolStripMenuItem.ForeColor = Color.Black;
        }

        private void loadPresetToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            loadPresetToolStripMenuItem.ForeColor = Color.White;
        }

        private void loadPresetToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            loadPresetToolStripMenuItem.ForeColor = Color.Black;
        }

        private void pathChange_click(object sender, EventArgs e, string path)
        {
            this.path = path;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
