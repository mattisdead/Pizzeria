using System;
using static System.Console;

namespace progbase_cw_2._2
{
    abstract public class Stuffing : Ingredient
    {
    }
    // cheese
    public class Mozzarella : Stuffing
    {
        public Mozzarella()
        {
            this.price = 5.9;
        }
    }
    public class Cheese : Stuffing
    {
        public Cheese()
        {
            this.price = 3;
        }
    }
    public class CheeseWithoutLactose : Stuffing
    {
        public CheeseWithoutLactose()
        {
            this.price = 4.6;
        }
    }
    public class Parmesan : Stuffing
    {
        public Parmesan()
        {
            this.price = 7;
        }
    }
    public class Cheddar : Stuffing
    {
        public Cheddar()
        {
            this.price = 6.26;
        }
    }
    public class Feta : Stuffing
    {
        public Feta()
        {
            this.price = 3.82;
        }
    }
    // meat
    public class Ham : Stuffing
    {
        public Ham()
        {
            this.price = 4.9;
        }
    }
    public class Sausage : Stuffing
    {
        public Sausage()
        {
            this.price = 4.3;
        }
    }
    public class Bacon : Stuffing
    {
        public Bacon()
        {
            this.price = 3.4;
        }
    }
    public class Anchovies : Stuffing
    {
        public Anchovies()
        {
            this.price = 5.9;
        }
    }
    public class Salami : Stuffing
    {
        public Salami()
        {
            this.price = 5.4;
        }
    }
    // vegetables
    public class Mushroom : Stuffing
    {
        public Mushroom()
        {
            this.price = 2;
        }
    }
    public class Olive : Stuffing
    {
        public Olive()
        {
            this.price = 3.6;
        }
    }
    public class BellPepper : Stuffing
    {
        public BellPepper()
        {
            this.price = 1.2;
        }
    }
    public class Onion : Stuffing
    {
        public Onion()
        {
            this.price = 0.8;
        }
    }
    public class BlackOlive : Stuffing
    {
        public BlackOlive()
        {
            this.price = 2.65;
        }
    }
    public class Jalapeno : Stuffing
    {
        public Jalapeno()
        {
            this.price = 3.27;
        }
    }
    public class ChiliPepper : Stuffing
    {
        public ChiliPepper()
        {
            this.price = 1.9;
        }
    }
    public class Basil : Stuffing
    {
        public Basil()
        {
            this.price = 1.25;
        }
    }
    public class Spinach : Stuffing
    {
        public Spinach()
        {
            this.price = 1.8;
        }
    }
    public class Tomato : Stuffing
    {
        public Tomato()
        {
            this.price = 1;
        }
    }
    public class Garlic : Stuffing
    {
        public Garlic()
        {
            this.price = 0.7;
        }
    }
    public class Oregano : Stuffing
    {
        public Oregano()
        {
            this.price = 1.2;
        }
    }
    // others
    public class OliveOil : Stuffing
    {
        public OliveOil()
        {
            this.price = 0.3;
        }
    }
    public class ExtraVirginOliveOil : Stuffing
    {
        public ExtraVirginOliveOil()
        {
            this.price = 0.5;
        }
    }
}
