using KPO_1.Models.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.ModelsTests
{
    public class AnimalTest
    {
        [Fact]
        public void Monkey_Creation_ShouldInitializePropertiesCorrectly()
        {
            var monkey = new Monkey("Бублик", 5, 101, 7);

            Assert.Equal("Бублик", monkey.Name);
            Assert.Equal(5, monkey.Food);
            Assert.Equal(101, monkey.Number);
            Assert.Equal(7, monkey.KindnessLevel);
        }

        [Fact]
        public void Rabbit_Creation_ShouldInitializePropertiesCorrectly()
        {
            var rabbit = new Rabbit("Ау", 3, 102, 6);

            Assert.Equal("Ау", rabbit.Name);
            Assert.Equal(3, rabbit.Food);
            Assert.Equal(102, rabbit.Number);
            Assert.Equal(6, rabbit.KindnessLevel);
        }
    }
}
