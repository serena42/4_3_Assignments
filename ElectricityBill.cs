using System;
using System.Collections.Generic;
using System.Text;

namespace _4_3_Assignments
{
    internal class ElectricityBill
    {
        public ElectricityBill() { }
        public static float Calculate(int id, string name, int kwh) {
            float billAmount = 0.0f;
            if (kwh <= 199)
            {
                billAmount = kwh * upto199;
            }
            else if (kwh <= 399)
            {
                billAmount = (199 * upto199) + ((kwh - 199) * upto399);
            }
            else if (kwh <= 599)
            {
                billAmount = (199 * upto199) + (200 * upto399) + ((kwh - 399) * upto599);
            }
            else
            {
                billAmount = (199 * upto199) + (200 * upto399) + (200 * upto599) + ((kwh - 599) * above600);
            }
            if (billAmount > 400)
            {
                billAmount += billAmount * surcharge;
            }
            Console.WriteLine($"Electricity bill for {name}: {billAmount:C2}\n\n\n");
            return billAmount;
        }

        // the requirements have people paying fixed rates for each range of units
        // I want to do this as a progressive system, where the first 199 units
        // are charged at 1.20, the next 200 units are charged at 1.50, the next 200
        // units are charged at 1.80, and any units above 600 are charged at 2.0
        public static float upto199 = 1.20f;
        public static float upto399 = 1.50f;
        public static float upto599 = 1.80f;
        public static float above600 = 2.0f;
        public static float surcharge = 0.15f;


    }
}
