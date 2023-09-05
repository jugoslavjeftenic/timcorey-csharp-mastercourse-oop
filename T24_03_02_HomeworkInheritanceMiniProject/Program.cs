using System.Collections;
using T24_03_02_HomeworkInheritanceMiniProject.Interfaces;
using T24_03_02_HomeworkInheritanceMiniProject.Models;

namespace T24_03_02_HomeworkInheritanceMiniProject
{
    // Build a similar project to what we did here but change
    // just a bit so you are sure you understand it.

    internal class Program
    {
        static void Main(string[] args)
        {
            List<ILoanPart> loanParts = new List<ILoanPart>();
            List<ISparePart> spareParts = new List<ISparePart>();

            var monitor = new MonitorModel
            {
                PartName = "Monitor",
                MonitorBrand = "Lenovo",
                MonitorDiagonal = 24,
                QuantityInStock = 2
            };
            var laptop = new LaptopModel
            {
                PartName = "Laptop",
                LaptopBrand = "Lenovo",
                LaptopProcesor = "I5",
                MemoryCapacity = 16,
                QuantityInStock = 2
            };
            var memory = new MemoryModel()
            {
                PartName = "Memory",
                MemoryType = "SODIMM DDR4",
                MemoryCapacity = 8,
                QuantityInStock = 10
            };
            var storage = new StorageDeviceModel()
            {
                PartName = "Storage device",
                StorageType = "SSD",
                StorageCapacity = 1024,
                QuantityInStock = 10
            };

            loanParts.Add(monitor);
            loanParts.Add(laptop);

            spareParts.Add(memory);
            spareParts.Add(storage);

            bool menu = true;
            do
            {
                Console.Write("Do you want to (L)oan part, (R)eplace part or (E)xit:");
                string? menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "l":
                        ChosePart(loanParts);
                        break;
                    case "r":
                        ChosePart(spareParts);
                        break;
                    default:
                        menu = false;
                        break;
                }
            } while (menu);
        }

        private static void ChosePart(IList partsList)
        {
            foreach (var item in partsList)
            {
                if (item is ILoanPart loanPart)
                {
                    Console.Write($"Do you want to loan {loanPart.PartName} (y/n)? ");
                    if (Console.ReadLine()?.ToLower() == "y")
                    {
                        loanPart.LoanPart();
                        Console.WriteLine($"{loanPart.PartName} inventory: {loanPart.QuantityInStock}.");
                    }
                }

                if (item is ISparePart sparePart)
                {
                    Console.Write($"Do you want to replace {sparePart.PartName} (y/n)? ");
                    if (Console.ReadLine()?.ToLower() == "y")
                    {
                        sparePart.ReplacePart();
                        Console.WriteLine($"{sparePart.PartName} inventory: {sparePart.QuantityInStock}.");
                    }
                }
            }
        }
    }
}