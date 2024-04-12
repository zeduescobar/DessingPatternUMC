using Org.BouncyCastle.Math.EC.Multiplier;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public string ShowMenu(String key, MenuTemplate obj)
        {
            string opcao = "";

            switch (key)
            {
                case "MENU_PRINCIPAL":
                    {
                        Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
                        Console.WriteLine("║ 1 MENU SECRETARIA                             ║    ");
                        Console.WriteLine("║ 2 MENU BIBLIOTECA                             ║    ");
                        Console.WriteLine("║ 3 MENU EMPRESTIMO                             ║    ");
                        Console.WriteLine("║ 4 MENU VENDA                                  ║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║                                               ║    ");
                        Console.WriteLine("║ 0 SAIR                                        ║    ");
                        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");

                        break;
                    }
                case "MENU_SECRETARIA":
                    {

                        Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
                        Console.WriteLine("║ 1 INCLUIR - ALUNO                             ║    ");
                        Console.WriteLine("║ 2 ATUALIZAR - ALUNO                           ║    ");
                        Console.WriteLine("║ 3 CONSULTAR - ALUNO                           ║    ");
                        Console.WriteLine("║ 4 REMOVER - ALUNO                             ║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║ 0 SAIR                                        ║    ");
                        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                        break;
                    }
                case "MENU_BIBLIOTECA":
                    {
                        Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
                        Console.WriteLine("║ 1 INCLUIR - LIVRO                             ║    ");
                        Console.WriteLine("║ 2 ATUALIZAR - ALUNO                           ║    ");
                        Console.WriteLine("║ 3 CONSULTAR - ALUNO                           ║    ");
                        Console.WriteLine("║ 4 REMOVER - ALUNO                             ║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║ 0 SAIR                                        ║    ");
                        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                        break;
                    }
                case "MENU_EMPRESTIMO":
                    {
                        Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
                        Console.WriteLine("║ 1 INCLUIR - EMPRESTIMO                        ║    ");
                        Console.WriteLine("║ 2 ATUALIZAR - EMPRESTIMO                      ║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║ 0 SAIR                                        ║    ");
                        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                        break;
                    }
                case "MENU_VENDA":
                    {
                        Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
                        Console.WriteLine("║ 1 INCLUIR - VENDA                             ║    ");
                        Console.WriteLine("║ 2 ATUALIZAR - VENDA                           ║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║ 0 SAIR                                        ║    ");
                        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                        break;
                    }



            }
            opcao = Console.ReadLine();
            if (obj != null)
            {
                obj.run(opcao);
            }
            return opcao;
        }
    }
}



/*public string ShowMenu(String key, TemplateMenu templatemenu)
{
    Se key === Menu {
        exibe o menu direto
    }

    Senao {
        classe.showMenu
    }

    Console.WriteLine(" ");
    Console.Write("DIGITE UMA OPÇÃO : ");
    opcao = Console.ReadLine();
}*/