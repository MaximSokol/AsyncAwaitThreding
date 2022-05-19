using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitThreding
{
    class Program
    {
        static int i;
        static void Main(string[] args)
        {

            // The functionality for the Goods!


            //Goods goods = new Goods();
            //var lst = new List<Goods>();

            //lst.Add(new Goods { apples = "Golden", buckwheat = "Brown", 
            //    milk = "2.5 of fat", nuts = "forrest's", rice = "Long"});

            //goods.PrintGoods(lst);
            //var bo = goods.SaveFileAsync(@"D:\\ text.txt", lst); // method of saving asynchronous
            //Console.WriteLine(bo.Result); // return the result of calling
            //goods.SaveFile(@"D:\\ text.txt", lst); // method of saving synchronous


            // The functionality for the ThreadStart


            ThreadClass th = new ThreadClass(1, 2, 3);
            //th.Callthread();

            //while (i <= 10)
            //{
            //    i++;
            //    Thread.Sleep(500);
            //    Console.WriteLine(new string(' ', 10) + "First");
            //}

            th.CountAAsync();

            int index = 0;
            while(index <= 10)
            {
                index++;
                Thread.Sleep(500);
                Console.WriteLine(new string(' ', 10) + index);
            }
        }
    }
}
