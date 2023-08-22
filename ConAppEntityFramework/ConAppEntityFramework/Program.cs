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
                            EmployeeClass.CreateEmployee();
                            EmployeeClass.ReadEmployee();
                            EmployeeClass.UpdateEmployee();
                            EmployeeClass.DeleteEmployee();
                            break;
                        }
                    case 2:
                        {
                            ProductClass.CreateProduct();
                            ProductClass.ReadProduct();
                            ProductClass.UpdateProduct();
                            ProductClass.DeleteProduct();
                            break;
                        }
                    case 3:
                        {
                            OrderClass.CreateOrders();
                            OrderClass.ReadOrders();
                            OrderClass.UpdateOrders();
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
