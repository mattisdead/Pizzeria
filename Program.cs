using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace progbase_cw_2._2
{
    internal static class Program
    {
        public static List<Pizza> order = new List<Pizza>();
        public static Dough dough;
        public static Sause sause;
        public static Pizza currentPizza;
        public static Kitchen kitchen = new Kitchen();
        public static Level chefLevel;
        public static Cashier cashier = new Cashier();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
