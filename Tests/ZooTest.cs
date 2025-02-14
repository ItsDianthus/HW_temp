using KPO_1.Interfaces;
using KPO_1.Models.Animals;
using KPO_1.Models.Inventory;
using KPO_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ZooTests
    {
        private readonly IVeterinary _veterinary;
        private readonly Zoo _zoo;

        public ZooTests()
        {
            _veterinary = new Veterinary();
            _zoo = new Zoo(_veterinary);
        }

        [Fact]
        public void AddAnimal_ShouldAddAnimal_WhenHealthCheckPasses()
        {
            var animal = new Tiger("Шерхан", 10, 103);

            if (_veterinary.HealthCheck(animal))
            {
                var result = _zoo.AddAnimal(animal);
                Assert.True(result);
                Assert.Contains(animal, _zoo.GetAllAnimals());
            }
        }

        [Fact]
        public void AddAnimal_ShouldNotAddAnimal_WhenHealthCheckFails()
        {
            var animal = new Tiger("Шерхан", 10, 103);

            if (!_veterinary.HealthCheck(animal))
            {
                var result = _zoo.AddAnimal(animal);
                Assert.False(result);
                Assert.DoesNotContain(animal, _zoo.GetAllAnimals());
            }
        }

        [Fact]
        public void TotalFoodEaten_ShouldReturnCorrectSum()
        {
            var monkey = new Monkey("Мартышка", 5, 101, 8);
            var tiger = new Tiger("Шерхан", 10, 103);

            if (_veterinary.HealthCheck(monkey))
                _zoo.AddAnimal(monkey);
            if (_veterinary.HealthCheck(tiger))
                _zoo.AddAnimal(tiger);

            Assert.Equal(15, _zoo.TotalFoodEaten());
        }
    }
}
