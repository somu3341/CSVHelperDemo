using System;
namespace CSVHelperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag=true;
            while(flag)
            {
                Console.WriteLine("Enter to Choose Option \n1.Read and Write CSV File\n2.Read and Write CSV to Json File\n3.Read and Write Json to CSV File\n4.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Opearations.ImplementCSVHandling();
                        break;
                        case 2:
                        Opearations.ImplementCSVToJson();
                        break;
                        case 3:
                            Opearations.ImplementJsonToCSV();
                        break;
                    case 4:
                        flag = false;
                        break;  
                }
            }
        }
    }
}