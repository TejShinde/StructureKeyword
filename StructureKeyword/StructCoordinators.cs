using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureKeyword
{
    internal class StructCoordinators
    {
        private int x;
        private int y;

        public StructCoordinators(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine(x + "  " + y);
        }
    }

}
