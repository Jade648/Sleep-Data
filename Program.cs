using System;

using System.IO;

namespace SleepData
{
    class program
   {
        private static int i;

        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1 to create data file.");
            Console.WriteLine("Enter 2 to parse data.");
            Console.WriteLine("Enter anything else to quit.");
            
            string resp = Console.ReadLine();

            if (resp == "1")
            {

                Console.WriteLine("How many weeks of data is needed?");
                
                int weeks = int.Parse(Console.ReadLine());

                DateTime today = DateTime.Now;
               
                DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);
                
                DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));

                Console.WriteLine(dataDate);
                    
                    Console.WriteLine($"{dataDate:M/d/yy},{string.Join("|", hours)}");
                   
                    dataDate = dataDate.AddDays(7);  

                StreamWriter sw = new StreamWriter("data.txt");

                  Random rnd = new Random();
 
                while (dataDate < dataEndDate){

                int[] hours = new int[7];
                    for (int i = 0; i < hours.Length; i++)
                    {
                        hours[i] = rnd.Next(4, 13);
                    }
                    
                    Console.WriteLine($"{dataDate:M/d/yy},{string.Join("|", hours)}");
                    
                    sw.WriteLine($"{dataDate:M/d/yyyy},{string.Join("|", hours)}");
                
                    dataDate = dataDate.AddDays(7);
                }

                sw.Close();
            }

            else if (resp == "2")
            
            {
                // TODO: parse data file

                int weeks = int.Parse(Console.ReadLine());

                DateTime today = DateTime.Now;

                DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);

                DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));

                    Random rnd = new Random();

                    int[] hours = new int[7];
                    for (int i = 0; i < hours.Length; i++)
                    {
                        // generate random number of hours slept between 4-12 (inclusive)
                        hours[i] = rnd.Next(4, 13);
                    }

                    StreamReader sr = new StreamReader(@"data.txt");

                string v = ($"{dataDate:M/d/yyyy},{string.Join("|", hours)}");

                while (!sr.EndOfStream){

                    string line = sr.ReadLine();

                }

                sr.Close();
            }
        }       
    }
}

