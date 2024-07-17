using System;
using System.Threading.Channels;
namespace WhileExp
{
    class While
    {
        static void Main(string[] args)
        {
            int var1=0; //variable for the loop
            while (var1 < 10) 
            {
                Console.WriteLine("I trust the myself i success the this software business");//question 1
                var1++;//variable is plus
            }
        }

            int var2 = 1;// variable for the loop
            while (var2<=20) //question 2
            {

                Console.WriteLine($" {var2}");
                var2++;//variable is plus
            }
        }

            int var3 = 2; //variable for the loop
            while (var3<=20) //question 3
            {

                Console.WriteLine($" {var3} ");
                var3+=2; //it is to be double check we plus 2
            }
            int sum = 50;//question 4
            int var4 = 51;// variable for the loop

            while (var4<=150)
            {

                sum = sum + var4;
                var4++; //variable is plus
            }
            Console.WriteLine($"number 50 to 150 sum:{sum}");

            int sum_single = 0;//question 5
            int sum_double = 0;
            int var5 = 1;// variable for the while loops
            while (var5 <= 120)
            {
                if (var5 % 2 == 0)//if it is double number
                {
                    sum_double = sum_double + var5;//we sum the current double number and sum
                }
                else//if it is single number
                {
                    sum_single = sum_single + var5;//we sum the current single number and sum
                }
                var5++;// variable is plus

            }
            Console.WriteLine($"number 1 to 120 numbers double sum:{sum_double}");// write sum double total number
            Console.WriteLine($"number 1 to 120 numbers single sum:{sum_single}");// write sum single total number
        }
    }
}