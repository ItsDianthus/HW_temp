using KPO_1.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_1.Models.Inventory
{
    public class Computer(string name, int number) : Thing(name, number)
    {
    };
}
