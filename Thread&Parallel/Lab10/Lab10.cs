using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab10
{
    class Lab10
    {
        static void Main(string[] args)
        {
            Baby b1 = new Baby("Noah");
            Baby b2 = new Baby("Olivia");
            Baby b3 = new Baby("Liam");
            Baby b4 = new Baby("Emma");
            Baby b5 = new Baby("Amelia");

            Thread t1 = new Thread(b1.run);
            Thread t2 = new Thread(b2.run);
            Thread t3 = new Thread(b3.run);
            Thread t4 = new Thread(b4.run);
            Thread t5 = new Thread(b5.run);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();


        }


    }
}
