using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int a, b;
                //a = 2;
                //b = 0;
                //Test test = new Test();
                //test.X=0;
                //Test.Name = "Roman";
                //throw new Exception("Testowy błąd");
                //int x = a / b;
                var name = ConfigurationManager.AppSettings["name"];
                Console.WriteLine(name);
                Names names = Names.Krzysiek;
                switch (names)
                {
                    case Names.Roman:
                        break;
                    case Names.Anna:
                        break;
                    case Names.Krzysiek:
                        Console.WriteLine(Names.Krzysiek.ToString());
                        Console.WriteLine((int)Names.Krzysiek);
                        break;
                    default:
                        break;
                }
            }
            catch(DivideByZeroException dbze)
            {
                Console.WriteLine(dbze.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Koniec programu");
            }
     
            Console.ReadLine();
        }
    }
}
