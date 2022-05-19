using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitThreding
{
    class ThreadClass
    {
        int a, b, c;
        //-----------------------

        object locker = new object(); // the locker for the lock operator
        //-------------------------------

        public ThreadClass() { }

        public ThreadClass(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        //--------------------------------------------

        public void CountA()
        {
            if(this.a != 0)
            {
                lock (locker)
                {
                    this.a++;
                    Console.WriteLine($"A:\t{a}");
                    string str = Console.ReadLine();
                    Console.WriteLine(str);
                }
            }
        }
        //---------------------------

        public async Task CountAAsync()
        {
            await Task.Run(() => CountA());
        }
        //---------------------------------

        public bool CountB()
        {
            if(this.b != 0)
            {
                this.b++;
                Console.WriteLine($"B:\t{b}");
                return true;
            }
            else { return false; }
        }
        //---------------------------

        public bool CountC()
        {
            if(this.c != 0)
            {
                this.c++;
                Console.WriteLine($"C:\t{c}");
                return true;
            }
            else { return false; }
        }
        //---------------------------

        public void Callthread()
        {
            ThreadStart star = new ThreadStart(CountA);
            Thread th = new Thread(star);
            th.Start();
        }
    }
}
