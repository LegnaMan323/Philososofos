using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philososlocos
{
    class Table
    {
        internal static Chops Platinum = new Chops() { chopID = 1, ChState = ChopState.OnTheTable };
        internal static Chops Gold = new Chops() { chopID = 2, ChState = ChopState.OnTheTable };
        internal static Chops Silver = new Chops() { chopID = 3, ChState = ChopState.OnTheTable };
        internal static Chops Wood = new Chops() { chopID = 4, ChState = ChopState.OnTheTable };
        internal static Chops Plastic = new Chops() { chopID = 5, ChState = ChopState.OnTheTable };
    }
}
