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
        public LoadNPC load;

        public AddNPCForm()
        {
            InitializeComponent();
            path = Environment.CurrentDirectory + "\\Presets\\Default\\";
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
            var n = int.TryParse(npcNum.Text, out int result) ? result : 1;
            for (int i = 0; i < n; i++)
            {
                var tab = new NPCTab(path);
                tabs.Add(tab);
            }
            DialogResult = DialogResult.OK;
        }

        private void loadNPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
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
                    load = new LoadNPC(fileContent);
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}
