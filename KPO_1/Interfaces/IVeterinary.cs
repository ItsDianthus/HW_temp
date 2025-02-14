using KPO_1.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_1.Interfaces
{
    public interface IVeterinary
    {
        bool HealthCheck(Animal animal);
    }
}
