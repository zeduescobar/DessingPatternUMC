using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDP
{
    public sealed class Singleton
    {
        
        private Singleton() { 
        
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
        public string ExibirMenu()
        {
            // ...
            Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
            Console.WriteLine("║ 1 INCLUIR - LIVRO                             ║    ");
            Console.WriteLine("║ 2 ATUALIZAR - LIVRO                           ║    ");
            Console.WriteLine("║ 3 CONSULTAR - LIVRO                           ║    ");
            Console.WriteLine("║ 4 REMOVER - LIVRO                             ║    ");
            Console.WriteLine("║═══════════════════════════════════════════════║    ");
            Console.WriteLine("║ 5 INCLUIR - ALUNO                             ║    ");
            Console.WriteLine("║ 6 ATUALIZAR - ALUNO                           ║    ");
            Console.WriteLine("║ 7 CONSULTAR - ALUNO                           ║    ");
            Console.WriteLine("║ 8 REMOVER - ALUNO                             ║    ");
            Console.WriteLine("║═══════════════════════════════════════════════║    ");
            Console.WriteLine("║ 0 SAIR                                        ║    ");
            Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
            Console.WriteLine(" ");
            Console.Write("DIGITE UMA OPÇÃO : ");
            return Console.ReadLine();
           
            
        }
        

    }
}