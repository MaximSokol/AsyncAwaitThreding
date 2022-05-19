using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace AsyncAwaitThreding
{
    class Goods
    {
        public string apples;
        public string rice;
        public string buckwheat;
        public string milk;
        public string nuts;
        //---------------------

        public Goods() { }

        public Goods(string apples, string rice, 
            string buckwheat, string milk, string nuts)
        {
            this.apples = apples;
            this.rice = rice;
            this.buckwheat = buckwheat;
            this.milk = milk;
            this.nuts = nuts;
        }
        //---------------------------------------------------

        public void PrintGoods(List<Goods> goods)
        {
            foreach(var elem in goods)
            {
               Console.WriteLine(elem);
            }
        }
        //-----------------------------------

        public bool SaveFile(string path, List<Goods> goods)
        {
            if (path != " ")
            {
                using (var sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    foreach (var elem in goods)
                    {
                        sw.WriteLine(elem);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        //-----------------------------------

        public async Task<bool> SaveFileAsync(string path, List<Goods> goods)
        {
            await Task.Run(() => SaveFile(path, goods));
            return true;
        }
        //----------------------------------------------------

        public override string ToString()
        {
           return 
               $"Apples:\t\t{apples}\n " +
               $"Rice:\t\t{rice}\n" +
               $"Buckwheat:\t{buckwheat}\n " +
               $"Milk:\t\t{milk}\n " +
               $"Nuts:\t\t{nuts}\n";
        }
        //-------------------------------------
    }
}

