using System;

namespace kmh_to_ms_converter {
    class MainClass {
        static void Main(string[] args) {
            while (true) { 
                try {
                    Console.WriteLine("Enter Q to quit the program.\nEnter km/h number:");
                    string b_num = (Console.ReadLine()).Replace(".", ",");
                    if (b_num == "Q" || b_num == "q")
                        break;
                    double num = Convert.ToDouble(b_num);
                    double f_num = (num/3.6f); //solution)))
                    double result = Math.Round(f_num, 2,MidpointRounding.ToEven);
                    Console.WriteLine($"\n{b_num} Km/H = {result} M/s\n"); 
                } catch (Exception) {
                    Console.WriteLine("Wrong input, try again.\n");
                }
                finally {}
                continue;
            }
        }
    }
}
