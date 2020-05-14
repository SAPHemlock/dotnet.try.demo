using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region say_hello
            Console.WriteLine("Hello Sandip!");
            #endregion

            #region what_the_cat_says
            Console.WriteLine(new Cat().Say());
            #endregion
        }
    }
}
