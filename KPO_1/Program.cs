using KPO_1.Models.Animals;
using KPO_1.Interfaces;
using KPO_1.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KPO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*** - - - *** - - - *** - - - ***");
                Console.WriteLine("Старт программы.");
                Console.WriteLine("*** - - - *** - - - *** - - - ***");


                // DI контейнер собираем
                var services = new ServiceCollection();
                services.AddSingleton<IVeterinary, Veterinary>();
                services.AddSingleton<Services.Zoo>();

                using var serviceProvider = services.BuildServiceProvider();
                var zoo = serviceProvider.GetRequiredService<Services.Zoo>();

                // Собрали

                Console.WriteLine("Добавляем животных...");


                zoo.AddAnimal(new Monkey("Мартышка Мила", 5, 1, 8));
                zoo.AddAnimal(new Rabbit("Кролик Роджер", 2, 2, 10));
                zoo.AddAnimal(new Rabbit("Кролик Злюка", 2, 3, 2));
                zoo.AddAnimal(new Tiger("Тигр Ру", 10, 10));
                zoo.AddAnimal(new Wolf("Волк Кусака", 15, 11));

                Console.WriteLine("Животные добавлены.");
                Console.WriteLine("*** - - - *** - - - *** - - - ***");
                Console.WriteLine("Список всех животных в зоопарке:");

                foreach (var animal in zoo.GetAllAnimals())
                {
                    Console.WriteLine($"- {animal.Name}, Тип: {animal.GetType().Name}, Потребление: {animal.Food} кг");
                }

                Console.WriteLine("*** - - - *** - - - *** - - - ***");
                Console.WriteLine($"Общий расход еды: {zoo.TotalFoodEaten()} кг в сутки");
                Console.WriteLine("*** - - - *** - - - *** - - - ***");
                Console.WriteLine("Животные для контактного зоопарка:");

                foreach (var animal in zoo.GetContactZooAnimals())
                {
                    Console.WriteLine($"- {animal.Name} (номер {animal.Number})");
                }

                Console.WriteLine("*** - - - *** - - - *** - - - ***");
                Console.WriteLine("Inventary info:");

                var inventory = zoo.GetInventoryInfo();
                foreach (var item in inventory)
                {
                    Console.WriteLine($"- {item.Name}, номер: {item.Number}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
