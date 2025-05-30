namespace assignment1
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
            // ... create shop
            ComputerShop highBudgetShop = new HighBudgetShop();
            // ... assemble (one) computer
            Computer highBudgetComputer = highBudgetShop.AssembleComputer();
            // ... test the new computer
            highBudgetComputer.Test();

            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            // ... create shop
            ComputerShop lowBudgetShop = new LowBudgetShop();
            // ... assemble (one) computer
            Computer lowBudgetComputer = lowBudgetShop.AssembleComputer();
            // ... test the new computer
            lowBudgetComputer.Test();
        }
    }
}
