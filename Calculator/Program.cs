using System;

namespace ConsoleApp1
{
    class CalcApp
    {
        public double AppDiv(double dFirstNum, double dSecondNum)
        {
            if (dSecondNum == 0)
            {
                return 0;
            }
            else
            {
                return dFirstNum / dSecondNum; 
            }
        }
    public double AppMult(double dFirstNum, double dSecondNum)
        {
            return dFirstNum * dSecondNum; 
        }
    public double AppAdd(double dFirstNum, double dSecondNum)
        {
            return dFirstNum + dSecondNum; 
        }
    public double AppSub(double dFirstNum, double dSecondNum)
        {
            return dFirstNum - dSecondNum;  
        }
    }
    class Program
    {
        static void Main(string[] args) // Main app
        {
            AGAIN:
            Console.WriteLine("Enter the number for square root(s for skip):"); // Query for square root of a number
            string sAnsw; //Buffer for questions
            string sAnsw2;
            double dbAnsw; //Digital buffer
            double dbAnsw2;
            Boolean bAnsw;
            CalcApp Calc1 = new CalcApp(); 
              
            OUT1:
            sAnsw = Console.ReadLine(); // All, that we want, is the root
            if (sAnsw != "s")
            {
                if (ThisIsDig(sAnsw) == false) { // We are checking here
                    Console.WriteLine("Error!");
                    goto OUT1;
                }
                bAnsw = double.TryParse(sAnsw, out dbAnsw);
                Console.WriteLine("Your answer is " + Math.Sqrt(dbAnsw) + ".");
            }
                Console.WriteLine("Please select your operation(+ - for addition, - - for substraction, * - for multiplication, : - for division):"); // Selection of ariphmetic operation
            OUT10:
            sAnsw = Console.ReadLine();
            if (sAnsw == "+")
            {
                Console.WriteLine("Enter the first number:"); // First number of addition
                OUT2:
                sAnsw = Console.ReadLine();
                if (ThisIsDig(sAnsw) == false) // We are checking here
                {
                    Console.WriteLine("Error!");
                    goto OUT2;
                }
                Console.WriteLine("Enter the second number:"); // Second number of addition
                OUT3:
                sAnsw2 = Console.ReadLine();
                if (ThisIsDig(sAnsw2) == false) // We are checking here
                {
                    Console.WriteLine("Error!");
                    goto OUT3;
                }
                bAnsw = double.TryParse(sAnsw, out dbAnsw);
                bAnsw = double.TryParse(sAnsw2, out dbAnsw2);
                Console.WriteLine("Your answer is " + (dbAnsw + dbAnsw2) + "."); // Addition is done
            }
            else if (sAnsw == "-") { 
                Console.WriteLine("Enter the first number:"); // First number of substraction
                OUT4:
                sAnsw = Console.ReadLine();
                if (ThisIsDig(sAnsw) == false) // We are checking here
                {
                    Console.WriteLine("Error!");
                    goto OUT4;
                }
                Console.WriteLine("Enter the second number:"); // Second number of substraction
                OUT5:
                sAnsw2 = Console.ReadLine();
                if (ThisIsDig(sAnsw2) == false) // We are checking here
                {
                    Console.WriteLine("Error!");
                    goto OUT5;
                }
                bAnsw = double.TryParse(sAnsw, out dbAnsw);
                bAnsw = double.TryParse(sAnsw2, out dbAnsw2);
                Console.WriteLine("Your answer is " + (dbAnsw - dbAnsw2) + "."); // Substraction is done 
            }
            else if (sAnsw == "*")
            {
                Console.WriteLine("Enter the first number:"); // First number of multiplication
                OUT6:
                sAnsw = Console.ReadLine();
                if (ThisIsDig(sAnsw) == false) // We are checking here
                {
                    Console.WriteLine("Error!");
                    goto OUT6;
                }
                Console.WriteLine("Enter the second number:"); // Second number of multiplication
                OUT7:
                sAnsw2 = Console.ReadLine();
                if (ThisIsDig(sAnsw2) == false) // We are checking here
                {
                    Console.WriteLine("Error!");
                    goto OUT7;
                }
                bAnsw = double.TryParse(sAnsw, out dbAnsw);
                bAnsw = double.TryParse(sAnsw2, out dbAnsw2);
                Console.WriteLine("Your answer is " + (dbAnsw * dbAnsw2) + "."); // Multiplication is done
            }
            else if (sAnsw == ":")
            {
                Console.WriteLine("Enter the first number:"); // First number of division
                OUT8:
                sAnsw = Console.ReadLine();
                if (ThisIsDig(sAnsw) == false) // We are checking here
                {
                    Console.WriteLine("Error!");
                    goto OUT8;
                }
            OUT:
                Console.WriteLine("Enter the second number:"); // Second number of division
                OUT9:
                sAnsw2 = Console.ReadLine();
                if (ThisIsDig(sAnsw2) == false) // We are checking here
                {
                    Console.WriteLine("Error!");
                    goto OUT9;
                }
                if (sAnsw2 == "0") // We can't accept zero
                {
                    goto OUT;
                }
                bAnsw = double.TryParse(sAnsw, out dbAnsw);
                bAnsw = double.TryParse(sAnsw2, out dbAnsw2);
                Console.WriteLine("Your answer is " + Calc1.AppDiv(dbAnsw,dbAnsw2) + ".");  // Division is done
            }
            else
            {
                Console.WriteLine("Error!"); // We don't want any symbols
                goto OUT10;
            }
            Console.WriteLine("Repeat?(y/n)"); // Try again
            sAnsw = Console.ReadLine(); 
            if (sAnsw == "y")
            {
                goto AGAIN;
            }
            Console.ReadLine();
        }
        static bool ThisIsDig(string strAnsw) //Total count for numbers
        {
            char[] cInput;
            cInput = strAnsw.ToCharArray();
            foreach (char i in cInput) // Only numbers
            {
                if (char.IsDigit(i) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
