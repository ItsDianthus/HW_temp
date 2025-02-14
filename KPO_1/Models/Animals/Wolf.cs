using KPO_1.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_1.Models.Animals
{
    public class Wolf : Predator
    {
        public Wolf(string name, int food, int number)
            : base(name, food, number)
        { }
    }
}
