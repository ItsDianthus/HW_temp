using KPO_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_1.Models.Abstractions
{
    public class Thing(string naming, int number) : IInventory
    {
        public string Naming { get; set; } = naming;
        public int Number { get; set; } = number;
    }
}
