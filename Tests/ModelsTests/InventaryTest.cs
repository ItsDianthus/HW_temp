using KPO_1.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.ModelsTests
{
    public class InventoryTest
    {
        [Fact]
        public void Thing_Creation_ShouldInitializePropertiesCorrectly()
        {
            var thing = new Thing("Итем", 200);

            Assert.Equal("Итем", thing.Naming);
            Assert.Equal(200, thing.Number);
        }
    }
}
