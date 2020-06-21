using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite suas 4 notas abaixo");
            Console.Write("Nota 1: ");
            double nota1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 2: ");
            double nota2=Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 3: ");
            double nota3=Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 4: ");
            double nota4=Convert.ToDouble(Console.ReadLine());
            
            double resultado=(nota1 + nota2 + nota3 + nota4) / 4;
            
            Console.Clear();

            if(nota1>10.0 || nota2>10.0 || nota3>10.0 || nota4>10.0)
            Console.WriteLine("Digite somente notas entre 0 e 10");
            else if(nota1<0.0 || nota2<0.0 || nota3<0.0 || nota4<0.0)
            Console.WriteLine("Digite somente notas entre 0 e 10");
            else if(resultado<5.0)
            Console.WriteLine($"Você ficou com média {resultado} Resultado: reprovado");
            else if(resultado>5.0 && resultado<7.0)
            Console.WriteLine($"Você ficou com média {resultado} Resultado: recuperação");
            else if(resultado>7.0)
            Console.WriteLine($"Você ficou com média {resultado} Resultado: aprovado");
            
            
            
        
            
            


        }
    }
}
