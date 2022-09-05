namespace progbase_cw_2._2
{
    abstract public class Worker
    {
        //abstract public void Work();
    }
    public class Cashier : Worker
    {
        Kitchen kitchen;
        public void SetChefLevel(Kitchen k, Level chefLevel)
        {
            kitchen = k;
            k.chefLevel = chefLevel;
        }
        public string MakePizza()
        {
            return kitchen.MakePizza();
        }
    }
    public abstract class Level
    {
        abstract public string MakePizza();
    }
    public class TopLevel : Level
    {
        public override string MakePizza()
        {
            return "Excellent";
        }
    }
    public class RegularLevel : Level
    {
        override public string MakePizza()
        {
            return "Good";
        }
    }
    public class TraineeLevel : Level
    {
        override public string MakePizza()
        {
            return "Ok";
        }
    }

    public class Chef : Worker
    {
        public Level chefLevel;

        public Chef(Level level)
        {
            this.chefLevel = level;
        }
        public string MakePizza()
        {
            return chefLevel.MakePizza();
        }
    }

}