using System;
using static System.Console;

namespace progbase_cw_2._2
{
    abstract public class Dough : Ingredient
    {
    }
    class RegularWheatDough : Dough
    {
        public RegularWheatDough()
        {
            this.price = 3.99;
        }
    }
    class WholeWheatDough : Dough
    {
        public WholeWheatDough()
        {
            this.price = 5;
        }
    }
    class CornDough : Dough
    {
        public CornDough()
        {
            this.price = 2.44;
        }
    }
    class RiceDough : Dough
    {
        public RiceDough()
        {
            this.price = 6.7;
        }
    }
}
