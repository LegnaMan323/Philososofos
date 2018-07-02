using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Philososlocos
{
    class Starter 
    {

       void startstuff()
        {
            Philosofos aristotle = new Philosofos(Table.Chopstick1, Table.Chopstick2, 1, 4);
            Philosofos palto = new Philosofos(Table.Chopstick2, Table.Chopstick3, 2, 5);
            Philosofos john = new Philosofos(Table.Chopstick3, Table.Chopstick4, 2, 6);
            Philosofos augustine = new Philosofos(Table.Chopstick4, Table.Chopstick5, 3, 4);
            Philosofos thomas = new Philosofos(Table.Chopstick1, Table.Chopstick5, 4, 7);

            new Thread(aristotle.Think).Start();
            new Thread(palto.Think).Start();
            new Thread(john.Think).Start();
            new Thread(augustine.Think).Start();
            new Thread(thomas.Think).Start();


        }
    }
}
