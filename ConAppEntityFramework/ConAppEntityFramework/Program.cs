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
                            Console.WriteLine("1.Create 2.Read 3.Update 4.Delete");
                            Console.WriteLine("Choose option:");
                            int op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("\n*****Create Employee*****");
                                        EmployeeClass.CreateEmployee();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("\n*****Read Employee*****");
                                        EmployeeClass.ReadEmployee();
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("\n*****Update Employee*****");
                                        EmployeeClass.UpdateEmployee();
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("\n*****Delete Employee*****");
                                        EmployeeClass.DeleteEmployee();
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("invalid choice");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("1.Create 2.Read 3.Update 4.Delete");
                            Console.WriteLine("Choose option:");
                            int op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("\n*****Create Product*****");
                                        ProductClass.CreateProduct();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("\n*****Read Product*****");
                                        ProductClass.ReadProduct();
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("\n*****Update Product*****");
                                        ProductClass.UpdateProduct();
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("\n*****Delete Product*****");
                                        ProductClass.DeleteProduct();
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Invalid choice");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("1.Create 2.Read 3.Update 4.Delete");
                            Console.WriteLine("Choose option:");
                            int op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("\n*****Create Orders*****");
                                        OrderClass.CreateOrders();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("\n*****Read Orders*****");
                                        OrderClass.ReadOrders();
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("\n*****Update Orders*****");
                                        OrderClass.UpdateOrders();
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("\n*****Delete Orders*****");
                                        OrderClass.DeleteOrders();
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("invalid choice");
                                        break;
                                    }
                            }
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
