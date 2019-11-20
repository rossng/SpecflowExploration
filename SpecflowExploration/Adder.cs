using System.Collections.Generic;
using System.Linq;

namespace SpecflowExploration
{
    public class Adder
    {
        public List<int> Operands { get; set; } = new List<int>();
        public int Result { get; private set; }

        public void Calculate()
        {
            Result = Operands.Sum();
        }
    }
}
