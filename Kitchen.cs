namespace progbase_cw_2._2
{
    public class Kitchen
    {
        public Level chefLevel;
        public string MakePizza()
        {
            if (chefLevel != null)
                return chefLevel.MakePizza();
            else
                return "Bad";
        }
    }
}
