using System;
using System.Data;
using System.Globalization;
using Google.Protobuf;
using MySql.Data.MySqlClient;

namespace AppDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Conexao con = new Conexao();

            string opcao = "";


            do
            {
                opcao = Singleton.GetInstance().ShowMenu("MENU_PRINCIPAL", null);

                if (opcao == "0")
                    break;
                // Console.Clear();
                switch (opcao)
                {
                    case "1":
                        {

                            Secretaria s = new Secretaria();
                            Singleton.GetInstance().ShowMenu("MENU_SECRETARIA", s);


                            break;
                        }
                    case "2":
                        {
                            Biblioteca b = new Biblioteca();
                            Singleton.GetInstance().ShowMenu("MENU_BIBLIOTECA", b);



                            break;
                        }
                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }
            } while (opcao != "0");







        }
    }
}