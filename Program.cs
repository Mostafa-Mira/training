using System.Diagnostics;
using System.Text;
namespace training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            /*
            string name = "Mostafa Esamil";
            int age = 19;
            decimal salary = 5000;
            bool IsStudent = true;
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Salary : {salary}");
            Console.WriteLine($"IsStudent : {IsStudent}");
            */
            #endregion

            /*
            int x = 10;
            int y = 20;
            x = 30;
            Console.WriteLine("x = "+x);
            Console.WriteLine("y = "+y);

            int number =100;
            long bigNumber = number;
            console.WriteLine(bigNumber);

            double price = 99.75;
            int intprice = (int)price;
            Console.WriteLine(intprice);

            */
            // Console.WriteLine("Enter a number");
            // int x;
            // x = int.Parse(Console.ReadLine());
            // Console.WriteLine(x);


            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your Age");
            //int age = int.Parse(Console.ReadLine());
            //
            //Console.WriteLine($"Hello {name}, you are {age} years old.");

            //int num1, num2;
            //Console.WriteLine("Enter number 1");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 2");
            //num2 = int.Parse(Console.ReadLine());
            //
            //Console.WriteLine($"sum is : {num1+num2}");
            //Console.WriteLine($"Difference  is : {num1-num2}");
            //Console.WriteLine($"Product is : {num1*num2}");


            //int age;
            //decimal salary;
            //Console.WriteLine("Enter your age");
            //age = Convert.ToInt32(Console.ReadLine());
            //
            //Console.WriteLine("Enter your salary");
            //salary = Convert.ToDecimal(Console.ReadLine());
            //
            //Console.WriteLine(age);
            //Console.WriteLine(salary);

            //int age;
            //Console.WriteLine("Enter your age");
            //if (int.TryParse(Console.ReadLine(), out age))
            //{
            //    Console.WriteLine($"your age is {age}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            //Console.WriteLine("Enter your product price");
            //double price;
            //if (double.TryParse(Console.ReadLine(), out price))
            //{ 
            //Console.WriteLine($"your product price is {price}");
            //}
            //else
            //{
            //    Console.WriteLine("invalid input");
            //}

            //string age = "20";
            //int ageNumber;
            //ageNumber = int.Parse(age);
            //Console.WriteLine(ageNumber);

            //string price = "99.75";
            //double productPrice = double.Parse(price);
            //Console.WriteLine(productPrice);

            //string name = "Ali";
            //int intName = int.Parse(name);
            //Console.WriteLine(intName);

            // string name = "Ali";
            // int intName;
            //bool r = int.TryParse(name, out intName);
            // Console.WriteLine(intName);
            // Console.WriteLine(r);

            //Console.WriteLine("Enter your age");
            //int age;
            //bool r =int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine(age);
            //Console.WriteLine(r);




            //string name;
            //int age;
            //double price;
            //int nProduct;
            //Console.WriteLine("Enter your name");
            // name = Console.ReadLine();

            //Console.WriteLine("Enter your age");

            //if (int.TryParse(Console.ReadLine(), out age))
            //{
            //    if (age > 60 || age < 18)
            //    {
            //        Console.WriteLine("Enter product price");

            //        if (double.TryParse(Console.ReadLine(), out price))
            //        {
            //            Console.WriteLine("Ok");
            //        }
            //        else
            //        {
            //            Console.WriteLine("invalid input");

            //        }


            //        Console.WriteLine("Enter number of products");

            //        if (int.TryParse(Console.ReadLine(), out nProduct))
            //        {
            //            if(nProduct > 0)
            //            {
            //                Console.WriteLine("ok");
            //            }
            //            else
            //            {
            //                Console.WriteLine("invalid input");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("invalid input");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("invalid input");
            //}

            //Console.WriteLine(name);
            //Console.WriteLine(age);
            //Console.WriteLine(nProduct);
            //Console.WriteLine(price);


            #region p 01fffffff
            /*
            int age;
            double price;
            string name;
            int nProduct;
            double total;
            double discount;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age");

            if (int.TryParse(Console.ReadLine(), out age))
            {

                if (age >= 18 && age <= 60)
                {
                    Console.WriteLine("Enter a product price");

                    if (double.TryParse(Console.ReadLine(), out price))
                    {
                        Console.WriteLine("enter number of product");

                        if (int.TryParse(Console.ReadLine(), out nProduct))
                        {
                            if(nProduct>0)
                            {
                                total = price * nProduct;
                                if(total>=1000)
                                {
                                    discount = total * 10 / 100;

                                    Console.WriteLine($"your name is : {name}");
                                    Console.WriteLine($"your age is : {age}");
                                    Console.WriteLine($"Total price before discount is : {total}");
                                    Console.WriteLine($"Discount is : {discount}");
                                    Console.WriteLine($"Total price after discount is : {total-discount}");
                                }
                                else
                                {
                                    Console.WriteLine($"your name is : {name}");
                                    Console.WriteLine($"your age is : {age}");
                                    Console.WriteLine($"Total price is : {total}");

                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid input");
                            }
                        }

                        else
                        {

                            Console.WriteLine("invalid input");
                        }
                    }

                    else
                    {
                        Console.WriteLine("invalid input");
                    }

                }
                else
                {
                    Console.WriteLine("invalid input");
                }

            }

            else
            {
                Console.WriteLine("invalid input");
            }
            */
            #endregion


            #region p 02 ffffffffff
            /*
            Console.WriteLine("Enter month numebr");
            int monthNum;
            if (int.TryParse(Console.ReadLine(), out monthNum))
            {
                if (monthNum > 0 && monthNum < 13)
                {
                    switch (monthNum)
                    {
                        case 1:
                            Console.WriteLine("Month:January");
                            break;
                        case 2:
                            Console.WriteLine("Month: February");
                            break;
                        case 3:
                            Console.WriteLine("Month: March");
                            break;
                        case 4:
                            Console.WriteLine("Month: April");
                            break;
                        case 5:
                            Console.WriteLine("Month: May");
                            break;
                        case 6:
                            Console.WriteLine("Month: June");
                            break;
                        case 7:
                            Console.WriteLine("Month: July");
                            break;
                        case 8:
                            Console.WriteLine("Month: August");
                            break;
                        case 9:
                            Console.WriteLine("Month: September");
                            break;
                        case 10:
                            Console.WriteLine("Month: October");
                            break;
                        case 11:
                            Console.WriteLine("Month:November");
                            break;
                        case 12:
                            Console.WriteLine("Month: December");
                            break;
                    }

                    if (monthNum == 1 || monthNum == 2 || monthNum == 3)
                    {
                        Console.WriteLine("Quarter: First Quarter");
                    }
                    else if (monthNum == 4 || monthNum == 5 || monthNum == 6)
                    {
                        Console.WriteLine("Quarter: Second Quarter");
                    }
                    else if (monthNum == 7 || monthNum == 8 || monthNum == 9)
                    {
                        Console.WriteLine("Quarter: Third Quarter");
                    }
                    else
                    {
                        Console.WriteLine("Quarter: Fourth Quarter");
                    }
                }

                else
                {
                    Console.WriteLine("invalid input");
                }
            }

            else
            {
                Console.WriteLine("invalid input");
            }
            */
            #endregion

            //object name = "mosatfa";
            //object num = 15;
            //object chos = true;
            //object nn = 152.1;

            //Console.WriteLine( name.GetType() );
            //Console.WriteLine(num.GetType());
            //Console.WriteLine(chos.GetType());
            //Console.WriteLine(nn.GetType());

            //int x = (int)num;

            //int age = 20;
            //object obj = age;

            //int newAge = (int) obj;


            //object name = "msotafa";
            //object age = 20;

            //Console.WriteLine(name.ToString());
            //Console.WriteLine(age.ToString());

            //object x = 10;
            //object y = 10;

            //Console.WriteLine(y.Equals(x));

            //string x = "mo";
            //string y = "mostafa";
            //x = "mostafa";

            //Console.WriteLine(object.ReferenceEquals(x,y));

            StringBuilder sb = new StringBuilder("hello");
            sb.Append(" mostafa");
            sb.Append(" !");
            Console.WriteLine(sb);



        }
    }
}
