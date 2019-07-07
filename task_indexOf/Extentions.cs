using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_indexOf_prime
{
    public static class Extentions
    {
        public static int FindIndexOf(this string str,char a)
        {
            int result = 0;
            for(int i = str.Length-1; i > 0; i--)
            {
                if (str[i] == a)
                {
                    result = i+1;
                    break;
                }
                else
                {
                    result= -1;
                }
            }
            return result;
        }


        public static string PrimeNumbers(this int number)
        {
            string result = "";
            
            if ( number==3 || number == 2)
            {
                result= "Bu sade ededdir";
                
            }
            else if(number % 2 == 0 || number % 3 == 0 || number % 5 == 0) 
            {
                result= "Daxil etdiyiniz eded sade deyil";
            }
            else
            {
                result = "Bu sade ededdir";
            }
            return result;
        }

    }
}
