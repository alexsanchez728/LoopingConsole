using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingConsole
{
    class Child
    {
        public string Name { get; set; }
        public bool Troubled { get; set; }

        public string ForgeASickNote(bool sick)
        {
            return sick
                ? $"Please excuse {Name} from class today. As she is very VERY sick"
                : $"{Name}, I know you tried to forge a sick note, but you're faking it. Go to school. Love, Mom";
        }
    }
}
