using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progbase_cw_2._2
{
    abstract class Decorator : Pizza
    {
        protected Pizza pizza;
        public Decorator(Pizza pizza) : base(pizza.dough, pizza.sause)
        {
            this.SetPizza(pizza);
            this.actualName = Pizza.name;
            this.quality = pizza.quality;
        }
        public void SetPizza(Pizza pizza)
        {
            this.ingredients = pizza.ingredients;
            this.pizza = pizza;
        }
        public abstract void DecorateIngredients();
        protected override void AddIngredients(){}
    }
    // meat decorators
    class HamDecorator : Decorator
    {
        public HamDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Ham());
        }
    }
    class SalamiDecorator : Decorator
    {
        public SalamiDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Salami());
        }
    }
    class SausageDecorator : Decorator
    {
        public SausageDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Sausage());
        }
    }
    class BaconDecorator : Decorator
    {
        public BaconDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Bacon());
        }
    }
    class AnchoviesDecorator : Decorator
    {
        public AnchoviesDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Anchovies());
        }
    }

    class RemoveHamDecorator : Decorator
    {
        public RemoveHamDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Ham());
        }
    }
    class RemoveSalamiDecorator : Decorator
    {
        public RemoveSalamiDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Salami());
        }
    }
    class RemoveSausageDecorator : Decorator
    {
        public RemoveSausageDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Sausage());
        }
    }
    class RemoveBaconDecorator : Decorator
    {
        public RemoveBaconDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Bacon());
        }
    }
    class RemoveAnchoviesDecorator : Decorator
    {
        public RemoveAnchoviesDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Anchovies());
        }
    }
    // cheese decorator
    class CheeseDecorator : Decorator
    {
        public CheeseDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Cheese());
        }
    }
    class NoLactoseDecorator : Decorator
    {
        public NoLactoseDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new CheeseWithoutLactose());
            this.pizza.ingredients.Remove(new Cheese());
            this.pizza.ingredients.Remove(new Mozzarella());
            this.pizza.ingredients.Remove(new Feta());
            this.pizza.ingredients.Remove(new Cheddar());
            this.pizza.ingredients.Remove(new Parmesan());
        }
    }
    class MozzarellaDecorator : Decorator
    {
        public MozzarellaDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Mozzarella());
        }
    }
    class ParmesanDecorator : Decorator
    {
        public ParmesanDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Parmesan());
        }
    }
    class CheddarDecorator : Decorator
    {
        public CheddarDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Cheddar());
        }
    }
    class FetaDecorator : Decorator
    {
        public FetaDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Feta());
        }
    }

    class RemoveCheeseDecorator : Decorator
    {
        public RemoveCheeseDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Cheese());
        }
    }
    class RemoveNoLactoseDecorator : Decorator
    {
        public RemoveNoLactoseDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new CheeseWithoutLactose());
        }
    }
    class RemoveMozzarellaDecorator : Decorator
    {
        public RemoveMozzarellaDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Mozzarella());
        }
    }
    class RemoveParmesanDecorator : Decorator
    {
        public RemoveParmesanDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Parmesan());
        }
    }
    class RemoveCheddarDecorator : Decorator
    {
        public RemoveCheddarDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Cheddar());
        }
    }
    class RemoveFetaDecorator : Decorator
    {
        public RemoveFetaDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Feta());
        }
    }
    // vegetables decorator
    class OnionDecorator : Decorator
    {
        public OnionDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Onion());
        }
    }
    class MushroomDecorator : Decorator
    {
        public MushroomDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Mushroom());
        }
    }
    class OliveDecorator : Decorator
    {
        public OliveDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Olive());
        }
    }
    class BellPepperDecorator : Decorator
    {
        public BellPepperDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new BellPepper());
        }
    }
    class BlackOliveDecorator : Decorator
    {
        public BlackOliveDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new BlackOlive());
        }
    }
    class JalapenoDecorator : Decorator
    {
        public JalapenoDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Jalapeno());
        }
    }
    class ChiliPepperDecorator : Decorator
    {
        public ChiliPepperDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new ChiliPepper());
        }
    }
    class BasilDecorator : Decorator
    {
        public BasilDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Basil());
        }
    }
    class SpinachDecorator : Decorator
    {
        public SpinachDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Spinach());
        }
    }
    class TomatoDecorator : Decorator
    {
        public TomatoDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Tomato());
        }
    }
    class GarlicDecorator : Decorator
    {
        public GarlicDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Garlic());
        }
    }
    class OreganoDecorator : Decorator
    {
        public OreganoDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Add(new Oregano());
        }
    }

    class RemoveOnionDecorator : Decorator
    {
        public RemoveOnionDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Onion());
        }
    }
    class RemoveMuchroomDecorator : Decorator
    {
        public RemoveMuchroomDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Mushroom());
        }
    }
    class RemoveOliveDecorator : Decorator
    {
        public RemoveOliveDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Olive());
        }
    }
    class RemoveBellPepperDecorator : Decorator
    {
        public RemoveBellPepperDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new BellPepper());
        }
    }
    class RemoveBlackOliveDecorator : Decorator
    {
        public RemoveBlackOliveDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new BlackOlive());
        }
    }
    class RemoveJalapenoDecorator : Decorator
    {
        public RemoveJalapenoDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Jalapeno());
        }
    }
    class RemoveChiliPepperDecorator : Decorator
    {
        public RemoveChiliPepperDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new ChiliPepper());
        }
    }
    class RemoveBasilDecorator : Decorator
    {
        public RemoveBasilDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Basil());
        }
    }
    class RemoveSpinachDecorator : Decorator
    {
        public RemoveSpinachDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Spinach());
        }
    }
    class RemoveTomatoDecorator : Decorator
    {
        public RemoveTomatoDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Tomato());
        }
    }
    class RemoveGarlicDecorator : Decorator
    {
        public RemoveGarlicDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Garlic());
        }
    }
    class RemoveOreganoDecorator : Decorator
    {
        public RemoveOreganoDecorator(Pizza pizza) : base(pizza) { }
        public override void DecorateIngredients()
        {
            this.pizza.ingredients.Remove(new Oregano());
        }
    }
}
