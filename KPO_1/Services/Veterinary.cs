using KPO_1.Models.Abstractions;
using KPO_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KPO_1.Services.Veterinary;

namespace KPO_1.Services
{
    public class Veterinary : IVeterinary
    {
        public bool HealthCheck(Animal animal)
        {
            return true;
        }
    }
}
