using System;
using System.Data;
using AppDesignPattern;
using Google.Protobuf;
using MySql.Data.MySqlClient;

class Program
{
    public static void Main(string[] args)
    {
        Conexao con = new Conexao();

        string opcao = "";
        do
        {
            opcao = Singleton.GetInstance().ShowMenu("MENU_PRINCIPAL");
            if (opcao == "0")
                break;
            Console.Clear();
            switch (opcao)
            {
                case "1":
                    {
                        opcao = Singleton.GetInstance().ShowMenu("MENU_SECRETARIA");
                       
                        break;
                    }
                case "2":
                    {
                        opcao = Singleton.GetInstance().ShowMenu("MENU_BIBIOTECA");

                        Biblioteca b = new Biblioteca();

                        break;
                    }
                

        } while (opcao != "0");

        



    
}