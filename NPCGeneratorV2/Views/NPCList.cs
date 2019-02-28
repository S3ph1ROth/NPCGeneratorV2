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
        public int v;

        public NPCList()
        {
            InitializeComponent();
        }

        private void NPCList_Load(object sender, EventArgs e)
        {
            var tabList = new List<NPCTab>();
            for (int i = 0; i < v; i++)
            {
                tabList.Add(new NPCTab());
            }

            npcTabs.TabPages.AddRange(tabList.ToArray());
        }
    }
}
