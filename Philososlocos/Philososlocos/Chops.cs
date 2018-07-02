using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philososlocos
{

    
    enum ChopState { Taken, OnTheTable }


    class Chops
    {
       // public bool inUse = false;
        public int chopID { get; set; }

        public ChopState ChState { get; set; }
        public int TakenBy { get; set; }
        public bool Take(int takenBy)
        {
            lock (this)
            {
                if (this.ChState == ChopState.OnTheTable)
                {
                    ChState = ChopState.Taken;
                    TakenBy = takenBy;
                    //   Console.WriteLine("||| {0} is taken by {1}", chopID, TakenBy);
                    return true;
                }

                else
                {
                    ChState = ChopState.Taken;
                    return false;
                }
            }
        }



        public void Put()
        {
            ChState = ChopState.OnTheTable;
            //       Console.WriteLine("||| {0} is place on the table by {1}", chopID, TakenBy);
            TakenBy = 0;
        }




     


    }


}
