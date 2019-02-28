using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPCGeneratorV2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NPCList npcList = new NPCList();
            npcList.v = int.TryParse(textBox1.Text, out int result) ? result : 1;
            npcList.Show();
        }
    }
}
