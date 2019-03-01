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

        public NPCList()
        {
            InitializeComponent();
            
        }

        public string Path { get => path; set => path = value; }
        public int N { get => n; set => n = value; }

        private void NPCList_Load(object sender, EventArgs e)
        {
            var tabList = new List<NPCTab>();
            for (int i = 0; i < N; i++)
            {
                NPCTab tab = new NPCTab(Path);
                tabList.Add(tab);

            }

            npcTabs.TabPages.AddRange(tabList.ToArray());
        }
    }
}
