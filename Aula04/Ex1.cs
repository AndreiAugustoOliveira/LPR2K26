using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPR
{
 class Program
  {
   static void Main()
    {
      Console.Clear();

      int num;
      num = 0;
     
      Console.WriteLine("Digite algum número inteiro");
      num = Convert.ToInt32(Console.ReadLine());
            
      if (num % 2 == 0)
      {
      Console.WriteLine($"O número {num} é par");
      }

       else
      {
       Console.WriteLine($"O número {num} é ímpar");  
      }
          
    }
  }
}
