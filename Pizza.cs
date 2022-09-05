using System;
using System.Collections.Generic;
using System.Text;

namespace progbase_cw_2._2
{
    abstract public class Pizza
    {
        public List<Ingredient> ingredients = new List<Ingredient>();
        protected double price;
        public Sause sause;
        public Dough dough;
        public string quality;
        public static string name;
        public string actualName;
        public Pizza(Dough dough, Sause sause)
        {
            this.dough = dough;
            this.sause = sause;
        }
        public double Price
        {
            get
            {
                this.price = 0;
                for (int i = 0; i < ingredients.Count; i++)
                {
                    this.price += ingredients[i].price;
                }
                return this.price;
            }
        }
        protected abstract void AddIngredients();
        // template method
        public virtual void AddDough()
        {
            ingredients.Add(this.dough);
        }
        public virtual void AddSause()
        {
            ingredients.Add(this.sause);
        }
        public virtual void AddCheese()
        {
            ingredients.Add(new Cheese());
        }
        public virtual void AddMeat() { }
        public virtual void AddVegetables() { }
        public void TemplateMethod()
        {
            this.AddDough();
            this.AddSause();
            this.AddCheese();
            this.AddMeat();
            this.AddVegetables();
            this.actualName = name;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(quality + " " + this.actualName +  " pizza was made with: ");
            for (int i = 0; i < ingredients.Count; i++)
            {
                sb.Append(ingredients[i].ToString() + ", ");
            }
            return sb.ToString();
        }
    }
    public class SalamiPizza : Pizza
    {
        public SalamiPizza(Dough dough, Sause sause) : base(dough, sause) 
        {
            name = "Salami";
            this.AddIngredients();
        }
        public override void AddMeat()
        {
            ingredients.Add(new Salami());
        }
        protected override void AddIngredients()
        {
            this.TemplateMethod();
        }
    }
    public class MeatPizza : Pizza
    {
        public MeatPizza(Dough dough, Sause sause) : base(dough, sause)
        {
            name = "Meat";
            this.AddIngredients();
        }
        public override void AddMeat()
        {
            ingredients.Add(new Ham());
            ingredients.Add(new Bacon());
            ingredients.Add(new Sausage());
            ingredients.Add(new Salami());
        }
        protected override void AddIngredients()
        {
            this.TemplateMethod();
        }
    }
    public class MarinaraPizza : Pizza
    {
        public MarinaraPizza(Dough dough, Sause sause) : base(dough, sause)
        {
            name = "Marianara";
            this.AddIngredients();
        }
        public override void AddCheese() { }
        public override void AddVegetables()
        {
            ingredients.Add(new Tomato());
            ingredients.Add(new Garlic());
            ingredients.Add(new Oregano());
        }
        protected override void AddIngredients()
        {
            this.TemplateMethod();
            this.ingredients.Add(new ExtraVirginOliveOil());
        }
    }
    public class MargheritaPizza : Pizza
    {
        public MargheritaPizza(Dough dough, Sause sause) : base(dough, sause)
        {
            name = "Mergherita";
            this.AddIngredients();
        }
        public override void AddCheese()
        {
            ingredients.Add(new Mozzarella());
        }
        public override void AddVegetables()
        {
            ingredients.Add(new Tomato());
            ingredients.Add(new Basil());
        }
        protected override void AddIngredients()
        {
            this.TemplateMethod();
        }
    }
    public class NewYorkStylePizza : Pizza
    {
        public NewYorkStylePizza(Dough dough, Sause sause) : base(dough, sause)
        {
            name = "New York-style";
            this.AddIngredients();
        }
        public override void AddCheese()
        {
            ingredients.Add(new Mozzarella());
        }
        protected override void AddIngredients()
        {
            this.TemplateMethod();
        }
    }
    public class SicilianPizza : Pizza
    {
        public SicilianPizza(Dough dough, Sause sause) : base(dough, sause)
        {
            name = "Sicilian";
            this.AddIngredients();
        }
        public override void AddCheese()
        {
            ingredients.Add(new Cheese());
        }
        public override void AddVegetables()
        {
            ingredients.Add(new Tomato());
            ingredients.Add(new Onion());
            ingredients.Add(new Anchovies());
        }
        protected override void AddIngredients()
        {
            this.TemplateMethod();
            this.ingredients.Add(new OliveOil());
        }
    }
    public class GreekPizza : Pizza
    {
        public GreekPizza(Dough dough, Sause sause) : base(dough, sause)
        {
            name = "Greek";
            this.AddIngredients();
        }
        public override void AddCheese()
        {
            ingredients.Add(new Mozzarella());
            ingredients.Add(new Cheddar());
            ingredients.Add(new Feta());
        }
        public override void AddVegetables()
        {
            ingredients.Add(new BlackOlive());
            ingredients.Add(new Onion());
            ingredients.Add(new Tomato());
        }
        protected override void AddIngredients()
        {
            this.TemplateMethod();
        }
    }
    public class VegetarianPizza : Pizza
    {
        public VegetarianPizza(Dough dough, Sause sause) : base(dough, sause)
        {
            name = "Vegeterian";
            this.AddIngredients();
        }
        public override void AddCheese()
        {
            ingredients.Add(new Mozzarella());
        }
        public override void AddVegetables()
        {
            ingredients.Add(new BlackOlive());
            ingredients.Add(new Onion());
            ingredients.Add(new Tomato());
            ingredients.Add(new Basil());
            ingredients.Add(new BellPepper());
            ingredients.Add(new Mushroom());
        }
        protected override void AddIngredients()
        {
            this.TemplateMethod();
        }
    }
    public class CheesePizza : Pizza
    {
        public CheesePizza(Dough dough, Sause sause) : base(dough, sause)
        {
            name = "Five-cheese";
            this.AddIngredients();
        }
        public override void AddCheese()
        {
            ingredients.Add(new Mozzarella());
            ingredients.Add(new Cheddar());
            ingredients.Add(new Cheese());
            ingredients.Add(new Feta());
            ingredients.Add(new Parmesan());
        }
        protected override void AddIngredients()
        {
            this.TemplateMethod();
        }
    }
    public class BasePizza : Pizza
    {
        public BasePizza(Dough dough, Sause sause) : base(dough, sause)
        {
            name = "Custom";
            this.AddIngredients();
        }
        public override void AddCheese(){}
        protected override void AddIngredients()
        {
            this.TemplateMethod();
        }
    }
}
