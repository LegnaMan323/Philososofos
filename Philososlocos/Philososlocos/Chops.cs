using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philososlocos
{

    
    enum ChopState { InUse, OnTheTable }


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
                    ChState = ChopState.InUse;
                    TakenBy = takenBy;
                    //   chop used by phID
                    return true;
                }

                else
                {
                    ChState = ChopState.InUse;
                    return false;
                }
            }
        }



        public void Put()
        {
            ChState = ChopState.OnTheTable;
            //     Chop placed by phID
            TakenBy = 0;
        }




     


    }


}
