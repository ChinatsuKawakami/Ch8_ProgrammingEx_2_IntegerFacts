using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * This is IntegerFacts of the programming exercise in ch8
 * Date:12th June 2016
 * Version 0.0.2 Added another answer 
 * 
 */
namespace IntegerFacts3
{
    class IntegerFacts
    {
        static void Main(string[] args)
        {
            int[] num = new int[20];

           int number;
           
           FirstMethod(num, out number);

           double sum, average;
           int highest, lowest;
           SecondMethod(num, number, out highest, out lowest, out sum, out average);

           Console.WriteLine("Sum : {0},Average : {1} , Highest : {2}, Lowest : {3}", sum, average, highest, lowest);
        

        }

        private static void FirstMethod(int [] array,out int number)
        {
            int i=0;//i should initialize here not inside do loop
            do
            {
             
                int input = 0;
                Console.WriteLine("Enter Integer");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input == -1)
                    {
                        break;
                    }
                    else
                    {
                        array[i] = input;
                       
                    }
                    i++;
                }else{
                    Console.WriteLine("Enter Valid integer");
                }
                
            } while (i < 20);

            number = i;
        }

        
        private static void SecondMethod(int [] array, int number, out int highest,out int lowest,out double sum, out double average)
        {
            highest = array[0];
            lowest = array[0];
            sum = 0;

            for (int count = 0; count < number; count++)
            {

                if (highest < array[count])
                
                    highest = array[count];

               
                if (lowest > array[count])

                    lowest = array[count];



                sum += (double)array[count];

            }

            average = (double)sum / number;
      
        }
    }
}
/*
*
*    static void Main(string[] args)
        {
            int first, second ,sum,number;
            double average;

            int[] array = new int[20];
            FillArrayMethod(array,out number);
            SecondMethod( array ,number,out first, out second ,out sum, out average);
            
            Console.Write("The lowest Numebr is:{0}", second);
            Console.Write("The highest Number is:{0}", first);
            Console.WriteLine("The sum is {0}",sum);
            Console.WriteLine("The Average is {0}",average);
        }//close Main()
      private static void FillArrayMethod(int[] array,out int number)
    {
        
        int i=0;

            //try
            //{
          do{
            int input;
                Console.Write("Enter Integer:");
              
               if( int.TryParse(Console.ReadLine(),out input))
               {
                 
                if (input == -1)
                {
                    break;
                }
                else
                {
                    array[i] = input;
                }
                   i++;
               }else{
                   Console.WriteLine("Enter Valid Integer");
               }
          }while(i<20);
          number= i;
          }


        static void SecondMethod(int []array,int number,out int highest,out int lowest,out int sum, out double average)
        {
     
        
        sum = 0;
        highest = array[0];
        lowest = array[0];

        for(int i = 0; i<number;i++){
            if (array[i] > highest)
                highest = array[i];
            if (array[i] < lowest)
                lowest = array[i];
            sum += array[i];
        }
        average = (double)(sum / number);
    }

        
    }
}
*
*
*/
