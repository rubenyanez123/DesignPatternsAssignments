using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    internal class HighLife : ConwayGameOfLife
    {

        public override bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // B3/S23

            // cell is born if it has 3 neighbors or 6
            if (!livingCell && (neighbourCount == 3 || neighbourCount == 6))
                return true;

            // cell survives if it has 2 or 3 neighbors
            if (livingCell && (neighbourCount == 2 || neighbourCount == 3))
                return true;

            // dead cell
            return false;
        }

    }
}
