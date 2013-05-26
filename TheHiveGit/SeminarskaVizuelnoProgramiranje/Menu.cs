using SeminarskaVizuelnoProgramiranje.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskaVizuelnoProgramiranje
{
    public partial class Menu : Form
    {
        public int selectedLevel;

        public Menu()
        {
            InitializeComponent();
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            Hide();
            SelectLevel selectLevel = new SelectLevel();
            selectLevel.ShowDialog();
            Show();
        }
     }
}
