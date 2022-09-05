using System;
using System.Windows.Forms;
using System.Globalization;
using progbase_cw_2._2;

namespace Pizzeria
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void pizzaMenuButton_Click(object sender, EventArgs e)
        {
            if (pizzaMenuLbl.Text != " ")
            {
                pizzaMenuLbl.Text = " ";
                return;
            }
            string specifier = "C";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            pizzaMenuLbl.Text = $@"Salami pizza: {new SalamiPizza(new RegularWheatDough(), new TomatoSause()).Price.ToString(specifier, culture)}
Meat Pizza: {new MeatPizza(new RegularWheatDough(), new TomatoSause()).Price.ToString(specifier, culture)}
Marinara Pizza: {new MarinaraPizza(new RegularWheatDough(), new TomatoSause()).Price.ToString(specifier, culture)}
Margherita Pizza: {new MargheritaPizza(new RegularWheatDough(), new TomatoSause()).Price.ToString(specifier, culture)}
Five-Cheese Pizza: {new CheesePizza(new RegularWheatDough(), new TomatoSause()).Price.ToString(specifier, culture)}
New York-Style Pizza: {new NewYorkStylePizza(new RegularWheatDough(), new TomatoSause()).Price.ToString(specifier, culture)}
Sicilian Pizza: {new SicilianPizza(new RegularWheatDough(), new TomatoSause()).Price.ToString(specifier, culture)}
Greek Pizza: {new GreekPizza(new RegularWheatDough(), new TomatoSause()).Price.ToString(specifier, culture)}
Vegetarian Pizza: {new VegetarianPizza(new RegularWheatDough(), new TomatoSause()).Price.ToString(specifier, culture)}";
        }

        private void toppingsMenuButton_Click_1(object sender, EventArgs e)
        {
            if (toppingsMenuLbl.Text != " ")
            {
                toppingsMenuLbl.Text = " ";
                return;
            }
            string specifier = "C";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            toppingsMenuLbl.Text += $@"Mozzarella: {new Mozzarella().price.ToString(specifier, culture)}
Regular cheese: {new Cheese().price.ToString(specifier, culture)}
Lactose-free cheese: {new CheeseWithoutLactose().price.ToString(specifier, culture)}
Parmesan: {new Parmesan().price.ToString(specifier, culture)}
Cheddar: {new Cheddar().price.ToString(specifier, culture)}
Feta: {new Feta().price.ToString(specifier, culture)}

Ham: {new Ham().price.ToString(specifier, culture)}
Sasages: {new Sausage().price.ToString(specifier, culture)}
Bacon: {new Bacon().price.ToString(specifier, culture)}
Anchovies: {new Anchovies().price.ToString(specifier, culture)}
Salami: {new Salami().price.ToString(specifier, culture)}

Mushroom: {new Mushroom().price.ToString(specifier, culture)}
Olive: {new Olive().price.ToString(specifier, culture)}
BellPepper: {new BellPepper().price.ToString(specifier, culture)}
Onion: {new Onion().price.ToString(specifier, culture)}
BlackOlive: {new BlackOlive().price.ToString(specifier, culture)}
Jalapeno: {new Jalapeno().price.ToString(specifier, culture)}
ChiliPepper: {new ChiliPepper().price.ToString(specifier, culture)}
Basil: {new Basil().price.ToString(specifier, culture)}
Spinach: {new Spinach().price.ToString(specifier, culture)}
Tomato: {new Tomato().price.ToString(specifier, culture)}
Garlic: {new Garlic().price.ToString(specifier, culture)}
Oregano: {new Oregano().price.ToString(specifier, culture)}";
        }
    }
}
