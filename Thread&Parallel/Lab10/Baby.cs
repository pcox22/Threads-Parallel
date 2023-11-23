using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab10
{
    class Baby
    {
        private int time;
        private string name;
        private static Random rand = new Random();


        public Baby(string title)
        {
            name = title;
            time = rand.Next(5000);
        }

        public void run()
        {
            try
            {
                Console.WriteLine("My name is " + name + ", and I am going to sleep for " + time + "ms.");
                Thread.Sleep(time);
                Console.WriteLine("My name is " + name + ", I am awake, feed me!!!");
            }
            catch (ThreadInterruptedException)
            {

            }

        }

    }
}
