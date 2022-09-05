using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using progbase_cw_2._2;

namespace Pizzeria
{
    public partial class PickChefForm : Form
    {
        public PickChefForm()
        {
            InitializeComponent();
        }

        private void topChefButton_Click(object sender, EventArgs e)
        {
            Program.chefLevel = new TopLevel();
            this.Dispose();
        }

        private void regularChefButton_Click(object sender, EventArgs e)
        {
            Program.chefLevel = new RegularLevel();
            this.Dispose();
        }

        private void traineeButton_Click(object sender, EventArgs e)
        {
            Program.chefLevel = new TraineeLevel();
            this.Dispose();
        }
    }
}
