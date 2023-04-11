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
                Console.WriteLine("Enter to Choose Option \n1.Read and Write CSV File\n2.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Opearations.ImplementCSVHandling();
                        break;
                    case 2:
                        flag = false;
                        break;  
                }
            }
        }
    }
}