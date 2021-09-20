using System;

namespace primeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
                // Console.WriteLine("enter number you want to check:");
               int num = 47;
            
             int divisors = 0;
               //loops
             for (int i = 1;i <= 47; i++)
              {
                  if (num % i == 0)
               {
               divisors++;
              }
          }
          if (divisors == 2)
           {
              Console.WriteLine("The entered number is a prime number");
          }
          else
          {
               Console.WriteLine("The entered number is not a prime number");
          }

        
         //         }2.    Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.
         // lessThan100(22, 15) ➞ true // 22 + 15 = 37
         // lessThan100(83, 34) ➞ false // 83 + 34 = 117
         // lessThan100(3, 77) ➞ true
         // :white_tick:
         // 1
    
         int num1 = 52 + 29;
         
          {
              Console.WriteLine(num1);
          }
          if (num1 <= 100)
          {
             //what should happen if true
             Console.WriteLine("it's true");
          }
          else
          {
          //what should happen if false//
          Console.WriteLine("it's false");
          }

          int num2 = 18 + 98;
          {
              Console.WriteLine(num2);
          }
           if (num2 <= 100)
           {
               Console.WriteLine("it's true");
           }
           else
           {
               Console.WriteLine("it's false");
           }
           
               

         
         // 3. There is an operator in c#, capable of providing the remainder of a division operation. Two numbers are passed as parameters. The first parameter divided by the second parameter will have a remainder, possibly zero. Return that value.
         // Example:
         // remainder(1, 3) ➞ 1
         // answer is modulus
          int num3 = 15 % 4;
          {
              Console.WriteLine(num3);
          }

        }
    }
}
