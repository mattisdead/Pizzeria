using System;
using System.Windows.Forms;
using progbase_cw_2._2;

namespace Pizzeria
{
    public partial class CreateBasePizzaForm : Form
    {
        public CreateBasePizzaForm()
        {
            InitializeComponent();
        }
        // dough check boxes
        private void WheatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wholeWheatCheckBox.Checked)
                wholeWheatCheckBox.Checked = false;
            if (riceCheckBox.Checked)
                riceCheckBox.Checked = false;
            if (cornCheckBox.Checked)
                cornCheckBox.Checked = false;
            Program.dough = new RegularWheatDough();
        }
        private void WholeWheetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wheatCheckBox.Checked)
                wheatCheckBox.Checked = false;
            if (riceCheckBox.Checked)
                riceCheckBox.Checked = false;
            if (cornCheckBox.Checked)
                cornCheckBox.Checked = false;
            Program.dough = new WholeWheatDough();
        }
        private void riceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wholeWheatCheckBox.Checked)
                wholeWheatCheckBox.Checked = false;
            if (wheatCheckBox.Checked)
                wheatCheckBox.Checked = false;
            if (cornCheckBox.Checked)
                cornCheckBox.Checked = false;
            Program.dough = new RiceDough();
        }
        private void cornCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wholeWheatCheckBox.Checked)
                wholeWheatCheckBox.Checked = false;
            if (wheatCheckBox.Checked)
                wheatCheckBox.Checked = false;
            if (wheatCheckBox.Checked)
                cornCheckBox.Checked = false;
            Program.dough = new CornDough();
        }
        
        private void OkButton_Clicked(object sender, EventArgs e)
        {
            if (!wheatCheckBox.Checked && !wholeWheatCheckBox.Checked && !riceCheckBox.Checked && !cornCheckBox.Checked)
            {
                Program.dough = null;
                Program.sause = null;
                ErrorPopupForm popup = new ErrorPopupForm();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
            else if (!tomatoCheckBox.Checked && !PestoCheckBox.Checked && !garlicCheckBox.Checked)
            {
                Program.dough = null;
                Program.sause = null;
                ErrorPopupForm popup = new ErrorPopupForm();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
            else
            {
                PickPizzaForm popup = new PickPizzaForm();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
        }
        private void CreatePizzaForm_Load(object sender, EventArgs e){ }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        // sause check boxes
        private void TomatoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(garlicCheckBox.Checked) 
                garlicCheckBox.Checked = false;
            if (PestoCheckBox.Checked)
                PestoCheckBox.Checked = false;
            Program.sause = new TomatoSause();
        }
        private void GarlicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tomatoCheckBox.Checked)
                tomatoCheckBox.Checked = false;
            if (PestoCheckBox.Checked)
                PestoCheckBox.Checked = false;
            Program.sause = new GarlicSause();
        }
        private void PestoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (garlicCheckBox.Checked)
                garlicCheckBox.Checked = false;
            if (tomatoCheckBox.Checked)
                tomatoCheckBox.Checked = false;
            Program.sause = new PestoSause();
        }
    }
}
