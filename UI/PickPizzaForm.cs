using System;
using System.Windows.Forms;
using progbase_cw_2._2;

namespace Pizzeria
{
    public partial class PickPizzaForm : Form
    {
        public Pizza currentPizza;
        public PickPizzaForm()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        // pizzas check boxes
        private void GreekPizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            vegeterianPizzaCheckBox.Checked = false;
            salamiPizzaCheckBox.Checked = false;
            meatPizzaCheckBox.Checked = false;
            marinaraPizzaCheckBox.Checked = false;
            margheritaPizzaCheckBox.Checked = false;
            cheesePizzaCheckBox.Checked = false;
            newYorkStylePizzaCheckBox.Checked = false;
            sicilianPizzaCheckBox.Checked = false;
            customPizzaCheckBox.Checked = false;

            currentPizza = new GreekPizza(Program.dough, Program.sause);
        }
        private void VegeterianPizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            greekPizzaCheckBox.Checked = false;
            salamiPizzaCheckBox.Checked = false;
            meatPizzaCheckBox.Checked = false;
            marinaraPizzaCheckBox.Checked = false;
            margheritaPizzaCheckBox.Checked = false;
            cheesePizzaCheckBox.Checked = false;
            newYorkStylePizzaCheckBox.Checked = false;
            sicilianPizzaCheckBox.Checked = false;
            customPizzaCheckBox.Checked = false;

            currentPizza = new VegetarianPizza(Program.dough, Program.sause);
        }
        private void SalamiPizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            vegeterianPizzaCheckBox.Checked = false;
            greekPizzaCheckBox.Checked = false;
            meatPizzaCheckBox.Checked = false;
            marinaraPizzaCheckBox.Checked = false;
            margheritaPizzaCheckBox.Checked = false;
            cheesePizzaCheckBox.Checked = false;
            newYorkStylePizzaCheckBox.Checked = false;
            sicilianPizzaCheckBox.Checked = false;
            customPizzaCheckBox.Checked = false;

            currentPizza = new SalamiPizza(Program.dough, Program.sause);
        }
        private void MeatPizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            vegeterianPizzaCheckBox.Checked = false;
            salamiPizzaCheckBox.Checked = false;
            greekPizzaCheckBox.Checked = false;
            marinaraPizzaCheckBox.Checked = false;
            margheritaPizzaCheckBox.Checked = false;
            cheesePizzaCheckBox.Checked = false;
            newYorkStylePizzaCheckBox.Checked = false;
            sicilianPizzaCheckBox.Checked = false;
            customPizzaCheckBox.Checked = false;

            currentPizza = new MeatPizza(Program.dough, Program.sause);
        }
        private void MarinaraPizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            vegeterianPizzaCheckBox.Checked = false;
            salamiPizzaCheckBox.Checked = false;
            meatPizzaCheckBox.Checked = false;
            greekPizzaCheckBox.Checked = false;
            margheritaPizzaCheckBox.Checked = false;
            cheesePizzaCheckBox.Checked = false;
            newYorkStylePizzaCheckBox.Checked = false;
            sicilianPizzaCheckBox.Checked = false;
            customPizzaCheckBox.Checked = false;

            currentPizza = new MarinaraPizza(Program.dough, Program.sause);
        }
        private void MargheritaPizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            vegeterianPizzaCheckBox.Checked = false;
            salamiPizzaCheckBox.Checked = false;
            meatPizzaCheckBox.Checked = false;
            marinaraPizzaCheckBox.Checked = false;
            greekPizzaCheckBox.Checked = false;
            cheesePizzaCheckBox.Checked = false;
            newYorkStylePizzaCheckBox.Checked = false;
            sicilianPizzaCheckBox.Checked = false;
            customPizzaCheckBox.Checked = false;

            currentPizza = new MargheritaPizza(Program.dough, Program.sause);
        }
        private void CheesePizzacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            vegeterianPizzaCheckBox.Checked = false;
            salamiPizzaCheckBox.Checked = false;
            meatPizzaCheckBox.Checked = false;
            marinaraPizzaCheckBox.Checked = false;
            margheritaPizzaCheckBox.Checked = false;
            greekPizzaCheckBox.Checked = false;
            newYorkStylePizzaCheckBox.Checked = false;
            sicilianPizzaCheckBox.Checked = false;
            customPizzaCheckBox.Checked = false;

            currentPizza = new CheesePizza(Program.dough, Program.sause);
        }
        private void NewYorkStylePizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            vegeterianPizzaCheckBox.Checked = false;
            salamiPizzaCheckBox.Checked = false;
            meatPizzaCheckBox.Checked = false;
            marinaraPizzaCheckBox.Checked = false;
            margheritaPizzaCheckBox.Checked = false;
            cheesePizzaCheckBox.Checked = false;
            greekPizzaCheckBox.Checked = false;
            sicilianPizzaCheckBox.Checked = false;
            customPizzaCheckBox.Checked = false;

            currentPizza = new NewYorkStylePizza(Program.dough, Program.sause);
        }
        private void SicilianPizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            vegeterianPizzaCheckBox.Checked = false;
            salamiPizzaCheckBox.Checked = false;
            meatPizzaCheckBox.Checked = false;
            marinaraPizzaCheckBox.Checked = false;
            margheritaPizzaCheckBox.Checked = false;
            cheesePizzaCheckBox.Checked = false;
            newYorkStylePizzaCheckBox.Checked = false;
            greekPizzaCheckBox.Checked = false;
            customPizzaCheckBox.Checked = false;

            currentPizza = new SicilianPizza(Program.dough, Program.sause);
        }
        private void CustomPizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            vegeterianPizzaCheckBox.Checked = false;
            salamiPizzaCheckBox.Checked = false;
            meatPizzaCheckBox.Checked = false;
            marinaraPizzaCheckBox.Checked = false;
            margheritaPizzaCheckBox.Checked = false;
            cheesePizzaCheckBox.Checked = false;
            newYorkStylePizzaCheckBox.Checked = false;
            sicilianPizzaCheckBox.Checked = false;
            greekPizzaCheckBox.Checked = false;

            currentPizza = new BasePizza(Program.dough, Program.sause);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!vegeterianPizzaCheckBox.Checked &&
            !salamiPizzaCheckBox.Checked &&
            !meatPizzaCheckBox.Checked &&
            !marinaraPizzaCheckBox.Checked &&
            !margheritaPizzaCheckBox.Checked &&
            !cheesePizzaCheckBox.Checked &&
            !newYorkStylePizzaCheckBox.Checked &&
            !sicilianPizzaCheckBox.Checked &&
            !greekPizzaCheckBox.Checked &&
            !customPizzaCheckBox.Checked)
            {
                ErrorPopupForm popup = new ErrorPopupForm();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
            else
            {
                Program.currentPizza = this.currentPizza;
                Program.cashier.SetChefLevel(Program.kitchen, Program.chefLevel);
                Program.currentPizza.quality = Program.cashier.MakePizza();                
                PickToppings popup = new PickToppings();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
        }
    }
}
