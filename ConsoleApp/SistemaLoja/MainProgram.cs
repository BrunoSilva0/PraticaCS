using System;
using System.Threading;

namespace ConsoleApplication1.SistemaLoja 
{
    internal class MainProgram {
        
        public static void Main(string[] args) 
        {
            const string mensagemEntrada = @"
    _   ___                                       
   / | / (_)_______     ____  ____ _____ ___  ___ 
  /  |/ / / ___/ _ \   / __ \/ __ `/ __ `__ \/ _ \
 / /|  / / /__/  __/  / / / / /_/ / / / / / /  __/
/_/ |_/_/\___/\___/  /_/ /_/\__,_/_/ /_/ /_/\___/ ";
            
            Console.WriteLine(mensagemEntrada);
            Console.WriteLine("Bem vindo ao Sistema de loja");
            
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Escolha sua operação:");
            const string operacao = @"1 - Operação 1
2 - Operação 2
3 - Operação 3
4 - Operação 4
5 - Operação 5
";
            
            Console.WriteLine(operacao);
            ConsoleKeyInfo tecla = Console.ReadKey();
            Console.WriteLine("\n");
            switch (tecla.KeyChar)
            {
                case '1':
                    Console.BackgroundColor = ConsoleColor.Gray;
                    
                    //beep beep
                    Console.Beep(); 
                    Thread.Sleep(100);
                    Console.Beep();
                    
                    Console.Write("Operação 1 foi escolhida");
                    Console.ResetColor();
                    break;
                case '2':
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("Operação 2 foi escolhida");
                    Console.ResetColor();
                    break;
                case '3':
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("Operação 3 foi escolhida");
                    Console.ResetColor();
                    break;
                case '4':
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("Operação 4 foi escolhida");
                    Console.ResetColor();
                    break;
                case '5':
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("Operação 5 foi escolhida");
                    Console.ResetColor();
                    break;
            }
        }
    }
}