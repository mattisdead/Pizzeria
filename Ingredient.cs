using System;
using System.Text;

namespace progbase_cw_2._2
{
    public abstract class Ingredient
    {
        public double price;
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string name = this.GetType().ToString().Remove(0, 17);
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsUpper(name[i]))
                {
                    if (i != 0)
                        sb.Append(" ");
                    sb.Append(Char.ToLower(name[i]));
                }
                else
                {
                    sb.Append(name[i].ToString());
                }
            }
            return sb.ToString();
        }
    }
}
