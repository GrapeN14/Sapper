using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapper
{
    public class DifficultyLevel
    {
        public string Name { get; set; }
        public int BoardSize { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
