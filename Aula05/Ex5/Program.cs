using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LPR
{
 class Program
  {
   static void Main()
    {

    Console.Clear();

     int horas = 0;
     int HorasTotais = 1000;
     int meses = 0;
     int semanas = 0;
     int dias = 0;


     Console.WriteLine("Jovem discípulo, você está prestes a trilhar o maior desafio da sua vida");
     Console.WriteLine("Para se tornar um verdadeiro Jedi você deve treinar arduamente e ter um total de 1000 horas de treinamento");
     Console.WriteLine("Quantas horas você treinará por dia? (você deve descansar aos finais de semana)");

     horas = Convert.ToInt32(Console.ReadLine());
     int HorasSemana = horas*5;
     double HorasMes = HorasSemana*4.5;


     while (HorasTotais != 0)
      {
        if (HorasTotais > HorasMes)
        {
          meses++;
          HorasTotais = HorasTotais - Convert.ToInt32(HorasMes);
        }

        else if (HorasTotais > HorasSemana)
        {
          semanas++;
          HorasTotais = HorasTotais - Convert.ToInt32(HorasSemana);
        }

        else
        {
          dias++;
          HorasTotais = HorasTotais - horas;
        }
      }

      Console.WriteLine($"Você precisará de {meses} meses, {semanas} semanas e {dias} dias para se tornar um verdadeiro Jedi");
    }
  }
}
