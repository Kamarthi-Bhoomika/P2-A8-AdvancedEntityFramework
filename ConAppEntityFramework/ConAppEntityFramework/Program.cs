using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1.Employee Table \n2.Product Table \n3.Order Table");
                Console.WriteLine("Select an Option");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("\n*****Create Employee*****");
                            EmployeeClass.CreateEmployee();
                            Console.WriteLine("\n*****Read Employee*****");
                            EmployeeClass.ReadEmployee();
                            Console.WriteLine("\n*****Update Employee*****");
                            EmployeeClass.UpdateEmployee();
                            Console.WriteLine("\n*****Delete Employee*****");
                            EmployeeClass.DeleteEmployee();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n*****Create Product*****");
                            ProductClass.CreateProduct();
                            Console.WriteLine("\n*****Read Product*****");
                            ProductClass.ReadProduct();
                            Console.WriteLine("\n*****Update Product*****");
                            ProductClass.UpdateProduct();
                            Console.WriteLine("\n*****Delete Product*****");
                            ProductClass.DeleteProduct();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n*****Create Orders*****");
                            OrderClass.CreateOrders();
                            Console.WriteLine("\n*****Read Orders*****");
                            OrderClass.ReadOrders();
                            Console.WriteLine("\n*****Update Orders*****");
                            OrderClass.UpdateOrders();
                            Console.WriteLine("\n*****Delete Orders*****");
                            OrderClass.DeleteOrders();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
