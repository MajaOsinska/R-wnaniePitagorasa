using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Równanie_Pitagorasa;

namespace Równanie_Pitagorasa
{
    class Program
    {
        static void Main(string[] args)
        {

            int chosedOption;


            Console.WriteLine("Które z obliczeń z równania Pitagorasa chcesz wykonać:\n"+ 
                "1. Chcesz sprawdzić czy liczby podane przez Ciebie tworzą równanie?\n"+ 
                "2. Chcesz obliczyć wynik dla podanych wartości?\n"+ 
                "3. Chcesz wyliczyć niewiadomą a?\n");
            //Console.WriteLine();
            int.TryParse(Console.ReadLine(), out chosedOption);
            
            switch (chosedOption)
            {
                case 1:
                  
                Calculations.compareArguments();
                break;                                           
                    
                case 2:

                Calculations.calculateC();
                break;

                case 3:

                Calculations.calculateA();
                break;

            }

            

              
               

            

        }

    }
}