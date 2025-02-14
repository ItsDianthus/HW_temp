using KPO_1.Models.Abstractions;
using KPO_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_1.Services
{
    public class Zoo(IVeterinary veterinary)
    {
        private readonly IVeterinary _veterinary = veterinary;
        private readonly List<Animal> _animals = new();

        public bool AddAnimal(Animal animal)
        {
            if (!_veterinary.HealthCheck(animal)) return false;
            _animals.Add(animal);
            return true;

        }

        public int TotalFoodEaten() => _animals.Sum(animal => animal.Food);

        public IEnumerable<Animal> GetAllAnimals()
        {
            return _animals;
        }

        public IEnumerable<Animal> GetContactZooAnimals()
        {
            return _animals.Where(animal => animal is Herbo { KindnessLevel: > 5 });
        }

        public IEnumerable<(string Name, int Number)> GetInventoryInfo()
        {
            return _animals.Select(animal => (animal.Name, animal.Number));
        }
    }
}
