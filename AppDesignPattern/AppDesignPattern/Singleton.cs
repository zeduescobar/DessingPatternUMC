using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesignPattern
{
    public sealed class Singleton
    {

        private Singleton()
        {

        }
        private static Singleton _instance;
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        public string ShowMenu(String key)
        {
            string opcao = "";
            switch (key)
            {
                case "MENU_PRINCIPAL":
                    {


                        Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
                        Console.WriteLine("║ 1 MENU SECRETARIA                             ║    ");
                        Console.WriteLine("║                                               ║    ");
                        Console.WriteLine("║ 2 MENU BIBLIOTECA                             ║    ");
                        Console.WriteLine("║                                               ║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║                                               ║    ");
                        Console.WriteLine("║ 0 SAIR                                        ║    ");
                        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                        Console.WriteLine(" ");
                        Console.Write("DIGITE UMA OPÇÃO : ");
                        opcao = Console.ReadLine();

                        break;
                    }
                case "MENU_SECRETARIA":
                    {
                        Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
                        Console.WriteLine("║ 1 INCLUIR - LIVRO                             ║    ");
                        Console.WriteLine("║ 2 ATUALIZAR - LIVRO                           ║    ");
                        Console.WriteLine("║ 3 CONSULTAR - LIVRO                           ║    ");
                        Console.WriteLine("║ 4 REMOVER - LIVRO                             ║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║ 0 SAIR                                        ║    ");
                        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                        Console.WriteLine(" ");
                        Console.Write("DIGITE UMA OPÇÃO : ");
                        opcao = Console.ReadLine();

                        break;
                    }
                case "MENU_BIBLIOTECA":
                    Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
                    Console.WriteLine("║ 1 INCLUIR - ALUNO                             ║    "); 1
                    Console.WriteLine("║ 2 ATUALIZAR - ALUNO                           ║    ");
                    Console.WriteLine("║ 3 CONSULTAR - ALUNO                           ║    ");
                    Console.WriteLine("║ 4 REMOVER - ALUNO                             ║    ");
                    Console.WriteLine("║═══════════════════════════════════════════════║    ");
                    Console.WriteLine("║ 0 SAIR                                        ║    ");
                    Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                    Console.WriteLine(" ");
                    Console.Write("DIGITE UMA OPÇÃO : ");
                    opcao = Console.ReadLine();

                    break;
            }


        }
    } }

