using System.Runtime.InteropServices;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            // ... create factory
            IComputerFactory highBudgetFactory = new HighBudgetComputerFactory();
            // ... create shop
            ComputerShop highBudgetShop = new ComputerShop();
            // ... assemble (one) computer
            Computer highBudgetComputer = highBudgetShop.AssembleComputer(highBudgetFactory);
            // ... test the new computer
            highBudgetComputer.Test();

            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            // ... create factory
            IComputerFactory lowBudgetFactory = new LowBudgetComputerFactory();
            // ... create shop
            ComputerShop lowBudgetShop = new ComputerShop();
            // ... assemble (one) computer
            Computer lowBudgetComputer = lowBudgetShop.AssembleComputer(lowBudgetFactory);
            // ... test the new computer
            lowBudgetComputer.Test();
        }
    }
}
