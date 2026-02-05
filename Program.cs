namespace _4_3_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // says you have to take the input from the keyboard
            // i made it progressive billing instead of fixed rates for each range
            Console.WriteLine("Electricity Bill (Progressive Version)\n");
            Console.WriteLine("Input customer id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input customer name");
            string name = Console.ReadLine();
            Console.WriteLine("Input units consumed");
            int kwh = Convert.ToInt32(Console.ReadLine());
            ElectricityBill.Calculate(id, name, kwh);


            Console.WriteLine("Array Frequency Count\n");
            var afc = new ArrayFreqCount();
            


        }
    }
}
