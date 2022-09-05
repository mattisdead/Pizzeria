using System;
using System.Windows.Forms;
using System.Collections.Generic;
using progbase_cw_2._2;

namespace Pizzeria
{
    public partial class PickToppings : Form
    {
        public PickToppings()
        {
            InitializeComponent();
        }
        private void lactoseFreeCheeseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Decorator decorator = new NoLactoseDecorator(Program.currentPizza);
            decorator.DecorateIngredients();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            Program.order.Add(Program.currentPizza);
        }
        private void PickToppings_Load(object sender, EventArgs e)
        {
            List<Ingredient> ingredients = Program.currentPizza.ingredients;

            mozzarellaNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Mozzarella());
            regularCheeseNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Cheese());
            parmesanNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Parmesan());
            cheddarNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Cheddar());
            fetaNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Feta());
            hamNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Ham());
            sausageNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Sausage());
            baconNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Bacon());
            anchoviesNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Anchovies());
            salamiNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Salami());
            mushroomsNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Mushroom());
            olivesNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Olive());
            bellPepperNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new BellPepper());
            onionsNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Onion());
            blackOlivesNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new BlackOlive());
            jalapenoNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Jalapeno());
            chiliPepperNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new ChiliPepper());
            basilNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Basil());
            spinachNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Spinach());
            tomatoNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Tomato());
            garlicNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Garlic());
            oreganoNumericUpDown.Value = this.GetNumberOfIngredientInList(ingredients, new Oregano());

        }
        public int GetNumberOfIngredientInList(List<Ingredient> list, Ingredient ingr)
        {
            int res = 0;
            if (list.Contains(ingr))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Equals(ingr))
                    {
                        res++;
                    }
                }
            }
            return res;
        }
        public void RemoveIngredientInProgramCurrentPizzaList(Ingredient ingredient)
        {
            while (true)
            {
                if (Program.currentPizza.ingredients.Contains(ingredient))
                {
                    Program.currentPizza.ingredients.Remove(ingredient);
                }
                else
                    break;
            }
        }
        /*public Decorator AddIngredientsAndGetDecorator(Decorator decorator, )
        {
            for (int i = 0; i < regularCheeseNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            return
        }*/

        private void regularCheeseNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Cheese());
            CheeseDecorator decorator = new CheeseDecorator(Program.currentPizza);
            for (int i = 0; i < regularCheeseNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }
        private void parmesanNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Parmesan());
            ParmesanDecorator decorator = new ParmesanDecorator(Program.currentPizza);
            for (int i = 0; i < parmesanNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }
        private void fetaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Feta());
            FetaDecorator decorator = new FetaDecorator(Program.currentPizza);
            for (int i = 0; i < fetaNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }
        private void mozzarellaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Mozzarella());
            MozzarellaDecorator decorator = new MozzarellaDecorator(Program.currentPizza);
            for (int i = 0; i < mozzarellaNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }
        private void cheddarNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Cheddar());
            CheddarDecorator decorator = new CheddarDecorator(Program.currentPizza);
            for (int i = 0; i < cheddarNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void hamNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Ham());
            HamDecorator decorator = new HamDecorator(Program.currentPizza);
            for (int i = 0; i < hamNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void sausageNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Sausage());
            SausageDecorator decorator = new SausageDecorator(Program.currentPizza);
            for (int i = 0; i < sausageNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void baconNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Bacon());
            BaconDecorator decorator = new BaconDecorator(Program.currentPizza);
            for (int i = 0; i < baconNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }
        private void anchoviesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Anchovies());
            AnchoviesDecorator decorator = new AnchoviesDecorator(Program.currentPizza);
            for (int i = 0; i < anchoviesNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void salamiNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Salami());
            SalamiDecorator decorator = new SalamiDecorator(Program.currentPizza);
            for (int i = 0; i < salamiNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void mushroomsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Mushroom());
            MushroomDecorator decorator = new MushroomDecorator(Program.currentPizza);
            for (int i = 0; i < mushroomsNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void olivesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Olive());
            OliveDecorator decorator = new OliveDecorator(Program.currentPizza);
            for (int i = 0; i < olivesNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void bellPepperNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new BellPepper());
            BellPepperDecorator decorator = new BellPepperDecorator(Program.currentPizza);
            for (int i = 0; i < bellPepperNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void onionsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Onion());
            OnionDecorator decorator = new OnionDecorator(Program.currentPizza);
            for (int i = 0; i < onionsNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void blackOlivesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new BlackOlive());
            BlackOliveDecorator decorator = new BlackOliveDecorator(Program.currentPizza);
            for (int i = 0; i < blackOlivesNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void jalapenoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Jalapeno());
            JalapenoDecorator decorator = new JalapenoDecorator(Program.currentPizza);
            for (int i = 0; i < jalapenoNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void chiliPepperNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new ChiliPepper());
            ChiliPepperDecorator decorator = new ChiliPepperDecorator(Program.currentPizza);
            for (int i = 0; i < chiliPepperNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void basilNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Basil());
            BasilDecorator decorator = new BasilDecorator(Program.currentPizza);
            for (int i = 0; i < basilNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void spinachNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Spinach());
            SpinachDecorator decorator = new SpinachDecorator(Program.currentPizza);
            for (int i = 0; i < spinachNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void tomatoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Tomato());
            TomatoDecorator decorator = new TomatoDecorator(Program.currentPizza);
            for (int i = 0; i < tomatoNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void garlicNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Garlic());
            GarlicDecorator decorator = new GarlicDecorator(Program.currentPizza);
            for (int i = 0; i < garlicNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void oreganoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RemoveIngredientInProgramCurrentPizzaList(new Oregano());
            OreganoDecorator decorator = new OreganoDecorator(Program.currentPizza);
            for (int i = 0; i < oreganoNumericUpDown.Value; i++)
            {
                decorator.DecorateIngredients();
                decorator.SetPizza(decorator);
            }
            Program.currentPizza = decorator;
        }

        private void regularCheeseLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
