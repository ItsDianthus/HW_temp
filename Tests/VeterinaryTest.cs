using KPO_1.Interfaces;
using KPO_1.Models.Animals;
using KPO_1.Services;

namespace Tests
{
    public class VeterinaryTests
    {
        [Fact]
        public void HealthCheck_ShouldReturnTrue()
        {
            var veterinary = new Veterinary();
            var animal = new Monkey("Мартышка", 5, 101, 8);

            Assert.True(veterinary.HealthCheck(animal));
        }
    }

}