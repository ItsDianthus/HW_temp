using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_1.Models.Abstractions
{
    public abstract class Herbo : Animal
    {
        public int KindnessLevel { get; set; }

        protected Herbo(string name, int food, int number, int kindnessLevel)
            : base(name, food, number)
        {
            KindnessLevel = kindnessLevel;
        }
    }
}
