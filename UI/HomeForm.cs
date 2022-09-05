using System;
using System.Windows.Forms;
using Pizzeria;

namespace progbase_cw_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pizzaMenuButton_Click(object sender, EventArgs e)
        {
            MenuForm popup = new MenuForm();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addPizzaButton_Click(object sender, EventArgs e)
        {
            CreateBasePizzaForm popup = new CreateBasePizzaForm();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrderLbl.Text = "";
            for (int i = 0; i < Program.order.Count; i++)
            {
                OrderLbl.Text += Program.order[i].ToString() + "\r\n";
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if(Program.order.Count == 0)
            {
                ErrorPopupForm popup = new ErrorPopupForm();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
            else
            {
                SelectPaymentTypeForm popup = new SelectPaymentTypeForm();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
                Form1_Load(sender, e);
            }
        }
        private void pickChefButton_Click(object sender, EventArgs e)
        {
            PickChefForm popup = new PickChefForm();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }
    }
}
