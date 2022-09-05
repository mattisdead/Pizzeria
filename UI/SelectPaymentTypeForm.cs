using System;
using System.Windows.Forms;
using progbase_cw_2._2;

namespace Pizzeria
{
    public partial class SelectPaymentTypeForm : Form
    {
        private decimal balance;
        public SelectPaymentTypeForm()
        {
            InitializeComponent();
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(new CreditCardPayment((double)balance));
            double totalPrice = 0;
            for (int i = 0; i < Program.order.Count; i++)
            {
                totalPrice += Program.order[i].Price;
            }
            Program.order.Clear();
            this.Dispose();
        }
        private void debitCardButton_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(new DebitCardPayment((double)balance));
            double totalPrice = 0;
            for (int i = 0; i < Program.order.Count; i++)
            {
                totalPrice += Program.order[i].Price;
            }
            if (!c.PayForOrder(totalPrice))
            {
                ErrorPopupForm popup = new ErrorPopupForm();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
            else
            {
                Program.order.Clear();
                this.Dispose();
            }
        }
        private void cashButton_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(new CashPayment((double)balance));
            double totalPrice = 0;
            for (int i = 0; i < Program.order.Count; i++)
            {
                totalPrice += Program.order[i].Price;
            }
            if (!c.PayForOrder(totalPrice))
            {
                ErrorPopupForm popup = new ErrorPopupForm();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
            else
            {
                Program.order.Clear();
                changeSumLbl.Text = "Change: " + c.paymentType.Balance.ToString();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            balance = numericUpDown1.Value;
        }
        private void SelectPaymentTypeForm_Load(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < Program.order.Count; i++)
            {
                sum += Program.order[i].Price;
            }
            sumLbl.Text = sum.ToString();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
