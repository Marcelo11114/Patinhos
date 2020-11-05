using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sair;
            do
            {
                Console.Clear();
                int NP;
                Console.WriteLine("     +------------+");
                Console.WriteLine("     |  Patinhos  |");
                Console.WriteLine("     +------------+\n");
                Console.Write("Quantos patinhos foram passear ?");             
                NP=Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("");   
                if (NP==0) {Console.WriteLine("Como nenhum patinho foi passear");
                           Console.WriteLine("     a mamae aproveitou "); 
                          Console.WriteLine("        pra descançar"); }     
                else{  
                for (int i = NP; i > 0; i--)
                 {
                   if (i>1)
                      {Console.WriteLine($"{i} patinhos foram passear");}
                   else  
                      {Console.WriteLine($"Um patinho foi passear");}

                   Console.WriteLine($"Além das montanhas");
                   Console.WriteLine($"Para brincar");
                   Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
                   if (i==2) 
                      {Console.WriteLine($"Mas só {i-1} patinho voltou de lá.\n");}
                   else if (i==1 )
                      { Console.WriteLine("Mas nenhum patinho voltou de la.\n");}
                   else if (i > 2) 
                      {Console.WriteLine($"Mas só {i-1} patinhos voltaram de lá.\n");}
                 }

                 Console.WriteLine("A mamãe patinha foi procurar");
                 Console.WriteLine("Além das montanhas");
                 Console.WriteLine("Na beira do mar");
                 Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
                 if (NP==1) 
                    {Console.WriteLine("E o patinho voltou de lá.");}
                 else 
                    {Console.WriteLine($"E os {NP} patinhos voltaram de la.");}
                }
                Console.Write("\nOutra?(s)");
               sair=Console.ReadLine().ToUpper();
            }while (sair=="S");
            Console.Clear();
        }
    }
}
