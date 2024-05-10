using System;
using System.Threading;

namespace ConsoleApplication1.SistemaLoja 
{
    internal class MainProgram {
        
        public static void Main(string[] args) 
        {
            const string mensagemEntrada = @"
    _   ___                                       
   / | / (_)_______     ____  ____  ____ ___  ___ 
  /  |/ / / ___/ _ \   / __ \/ __ `/ __ `__ \/ _ \
 / /|  / / /__/  __/  / / / / /_/ / / / / / /  __/
/_/ |_/_/\___/\___/  /_/ /_/\__,_/_/ /_/ /_/\___/ ";
            
            Console.WriteLine(mensagemEntrada);
            Console.WriteLine("Bem vindo ao Sistema de loja");
            
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Escolha sua operação:");
            Console.WriteLine(@"1 - Login / Cadastro
2 - Operação 2
3 - Operação 3
4 - Operação 4
5 - Operação 5
");
            ConsoleKeyInfo tecla = Console.ReadKey();
            Console.WriteLine("\n");
            switch (tecla.KeyChar)
            {
                case '1':
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    Console.Beep();
                    Console.Write("Operação 1 foi escolhida");
                    Console.ResetColor();

                    Console.WriteLine("\nVocê já tem uma conta? [S / N]");
                    string operacaoEscolhida = Console.ReadLine();
                    // Login
                    if (operacaoEscolhida == "S" || operacaoEscolhida == "Sim")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Entre suas credenciais");
                        Console.ResetColor();
                        
                        Console.WriteLine("\nEmail:");
                        string emailEntrada = Console.ReadLine();

                        Console.WriteLine("Senha:");
                        string senhaEntrada = Console.ReadLine();

                        Cliente cliente = new Cliente(emailEntrada, senhaEntrada);
                        
                        GerenciadorUsuarios gerenciador = new GerenciadorUsuarios();
                        bool existe = gerenciador.ChecarLogin(emailEntrada, senhaEntrada);
                        if (existe)
                        {
                            Console.WriteLine("Login feito com êxito!");
                        }
                        else
                        {
                            Console.WriteLine("Conta não encontrada");
                        }
                    // Cadastro
                    } else if (operacaoEscolhida == "N" || operacaoEscolhida == "Nao")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Faça o cadastro");
                        Console.ResetColor();
                        
                        Console.WriteLine("\nEmail:");
                        string emailEntrada = Console.ReadLine();

                        Console.WriteLine("Senha:");
                        string senhaEntrada = Console.ReadLine();

                        Cliente cliente = new Cliente(emailEntrada, senhaEntrada);
                        GerenciadorUsuarios gerenciadorUsuarios = new GerenciadorUsuarios();
                        gerenciadorUsuarios.AdicionarUsuario(cliente);
                        
                        Console.WriteLine("Inscrição feita! :D");
                        Console.WriteLine("Aviso: um novo arquivo foi criado no seu usuário atual, caso queria removê-lo, vá para pasta do seu usuário atual");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.WriteLine("Entrada não esperada");
                        Console.WriteLine("Fechando...");
                        Thread.Sleep(500);
                        return;
                    }
                    
                    break;
                case '2':
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    Console.Beep();
                    Console.Write("Operação 2 foi escolhida");
                    Console.ResetColor();
                    break;
                case '3':
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    Console.Beep();
                    Console.Write("Operação 3 foi escolhida");
                    Console.ResetColor();
                    break;
                case '4':
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    Console.Beep();
                    Console.Write("Operação 4 foi escolhida");
                    Console.ResetColor();
                    break;
                case '5':
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    Console.Beep();
                    Console.Write("Operação 5 foi escolhida");
                    Console.ResetColor();
                    break;
            }
            Thread.Sleep(3000);
        }
    }
}