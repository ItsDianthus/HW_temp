using KPO_1.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_1.Models.Animals
{
    public class Rabbit : Herbo
    {
        public Rabbit(string name, int food, int number, int kindnessLevel)
            : base(name, food, number, kindnessLevel)
        { }
    }
}

