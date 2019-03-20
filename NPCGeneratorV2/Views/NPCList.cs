using NPCGeneratorV2.Views;
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
    public partial class NPCList : Form
    {
        private int n;
        private string path;
        private string fileContent;
        public bool bulkLoad = false;
        public List<LoadNPC> bulkLoadList = new List<LoadNPC>();
        public List<NPCTab> saveNPCGen = new List<NPCTab>();
        public List<LoadNPC> saveNPCLoad = new List<LoadNPC>();

        public NPCList()
        {
            InitializeComponent();
        }

        public void bulkLoadNPC(string content)
        {
            bulkLoadList.Add(new LoadNPC(content));
        }

        public string Path { get => path; set => path = value; }
        public int N { get => n; set => n = value; }
        public string FileContent { get => fileContent; set => fileContent = value; }

        private void NPCList_Load(object sender, EventArgs e)
        {

            if (FileContent == null && bulkLoad == false)
            {
                for (int i = 0; i < N; i++)
                {
                    NPCTab tab = new NPCTab(Path);
                    
                    npcTabs.TabPages.Insert(i, tab);
                    tab.i = npcTabs.TabIndex;
                    saveNPCGen.Add(tab);
                }
                npcTabs.SelectedIndex = 0;
            }
            else if (bulkLoad == false && FileContent != null)
            {
                var tab = new LoadNPC(FileContent);
                npcTabs.TabPages.Insert(npcTabs.TabCount, tab);
                npcTabs.SelectedIndex = 0;
                saveNPCLoad.Add(tab);
            }
            else
            {
                foreach(var npc in bulkLoadList)
                {
                    npcTabs.TabPages.Insert(npcTabs.TabCount, npc);
                    saveNPCLoad.Add(npc);
                }
                npcTabs.SelectedIndex = 0;
            }
        }

        private void saveAllNPCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.SelectedPath = Environment.CurrentDirectory + "\\SavedNPCs\\";
            if (fld.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = fld.SelectedPath;
                foreach (NPCTab tab in saveNPCGen)
                {
                    tab.saveAll(selectedPath);
                }
                foreach (LoadNPC tab in saveNPCLoad)
                {
                    tab.saveAll(selectedPath);
                }
            }
        }

        private void addNPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddNPCForm add = new AddNPCForm())
            {
                if (add.ShowDialog() == DialogResult.OK)
                {
                    var tabs = add.tabs;
                    var load = add.load;
                    if (load == null)
                    {
                        foreach (var npc in tabs)
                        {
                            npcTabs.TabPages.Insert(npcTabs.TabCount, npc);
                            saveNPCGen.Add(npc);
                        }
                    }
                    else
                    {
                        foreach (var npc in load)
                        {
                            npcTabs.TabPages.Insert(npcTabs.TabCount, npc);
                            saveNPCLoad.Add(npc);
                        }
                    }
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (npcTabs.TabCount == 1)
            {
                Close();
            }
            else
            {
                npcTabs.TabPages.Remove(npcTabs.SelectedTab);
            }
        }
    }
}
