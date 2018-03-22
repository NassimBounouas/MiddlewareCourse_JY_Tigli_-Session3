using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ClientSOAP.MathsService;

namespace ClientSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client 1");
            MathsOperationsClient client = new MathsOperationsClient("MathsOperations");
            Console.WriteLine(client.Add(100, 101));
            Console.WriteLine(client.Multiply(10, 15));

            Console.WriteLine("Client 2");
            MathsOperationsClient client2 = new MathsOperationsClient("MathsBis");
            Console.WriteLine(client2.Add(100, 101));
            Console.WriteLine(client2.Multiply(10, 15));
            try { 
                Console.WriteLine(client2.Divide(10, 0));
            } catch (FaultException ex)
            {
                Console.WriteLine(ex.Reason);
            }

            Console.WriteLine("Client 3");
            MathsOperationsClient client3 = new MathsOperationsClient("MathsTriWShttp");
            Console.WriteLine(client3.Add(100, 101));
            Console.WriteLine(client3.Multiply(10, 15));
           

            Console.ReadLine();
        }
    }
}
