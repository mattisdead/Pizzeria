using System;

namespace progbase_cw_2._2
{
    abstract public class Sause : Ingredient
    {
    }
    public class TomatoSause : Sause
    {
        public TomatoSause()
        {
            this.price = 2;
        }
    }
    public class GarlicSause : Sause
    {
        public GarlicSause()
        {
            this.price = 2.9;
        }
    }
    public class PestoSause : Sause
    {
        public PestoSause()
        {
            this.price = 3.3;
        }
    }
}
