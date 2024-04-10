using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC;

namespace AppDesignPattern
{
    public class Biblioteca: MenuTemplate
    {

        public Biblioteca() { }

        public void CreateLivro()
        {
            Conexao con = new Conexao();
            Livro l = new Livro();
            Console.WriteLine("+------------------------- LIVRO  --------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("        Forneca os dados do Livro:              ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");


            Console.WriteLine("ISBN: ");
            l.SetISBN(Console.ReadLine().ToString());

            Console.WriteLine("Titulo: ");
            l.SetTitulo(Console.ReadLine().ToString());

            Console.WriteLine("Autor: ");
            l.SetAutor(Console.ReadLine().ToString());

            Console.WriteLine("Ano: ");
            l.SetAno(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Genero: ");
            l.SetGenero(Console.ReadLine().ToString());

            Console.WriteLine("Edicao: ");
            l.SetEdicao(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Quantidade: ");
            l.SetQuantidade(Convert.ToInt32(Console.ReadLine()));

            string sql = $"INSERT INTO Livro (isbn, titulo, autor, ano, genero, edicao, quantidade) VALUES ('{l.GetISBN()}', '{l.GetTitulo()}', '{l.GetAutor()}', {l.GetAno()}, '{l.GetGenero()}', {l.GetEdicao()}, {l.GetQuantidade()});";
            con.executeScript(sql);
        }
        public void AtualizarLivro()
        {
            Conexao con = new Conexao();
            Livro l = new Livro();
            Console.WriteLine("+------------------------- LIVRO  --------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("    Forneca os dados atualizados do Livro:      ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");


            Console.WriteLine("ISBN: ");
            l.SetISBN(Console.ReadLine().ToString());

            Console.WriteLine("Titulo: ");
            l.SetTitulo(Console.ReadLine().ToString());

            Console.WriteLine("Autor: ");
            l.SetAutor(Console.ReadLine().ToString());

            Console.WriteLine("Ano: ");
            l.SetAno(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Genero: ");
            l.SetGenero(Console.ReadLine().ToString());

            Console.WriteLine("Edicao: ");
            l.SetEdicao(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Quantidade: ");
            l.SetQuantidade(Convert.ToInt32(Console.ReadLine()));

            string sql = $"UPDATE Livro SET titulo = '{l.GetTitulo()}', autor = '{l.GetAutor()}', ano = {l.GetAno()}, genero = '{l.GetGenero()}', edicao = {l.GetEdicao()}, quantidade = {l.GetQuantidade()} WHERE isbn =  '{l.GetISBN()}' ";

            con.executeScript(sql);
        }
        public void ShowLivro()
        {

            Conexao con = new Conexao();
            Console.WriteLine("+------------------------- LIVRO  --------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("                   Dados do Livro:              ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");
            string sql = $"SELECT * FROM Livro ";
            using MySqlConnection conn = new MySqlConnection("Persist Security Info=False;server=sql.freedb.tech;database=freedb_umc_dp_aluno;uid=freedb_joseescobar;pwd=7V9qtnn5sRRz$nQ;Convert Zero Datetime=True");
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            using MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("ID: " + reader["ID"]);
                Console.WriteLine("ISBN: " + reader["ISBN"]);
                Console.WriteLine("Nome: " + reader["ISBN"]);
                Console.WriteLine("Titulo: " + reader["Titulo"]);
                Console.WriteLine("Ano: " + reader["Ano"]);
                Console.WriteLine("Gênero: " + reader["Genero"]);
                Console.WriteLine("Edição: " + reader["Edicao"]);
                Console.WriteLine("Quantidade: " + reader["Quantidade"]);



            }
            reader.Close();
        }
        public void DeleteLivro()
        {


            Console.WriteLine("+------------------------- LIVRO  --------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("      Forneca o ID do Livro a ser deletado:     ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");
            int d_id;

            d_id = int.Parse(Console.ReadLine());
            string deleteQuery2 = "DELETE FROM Livro WHERE ID =" + d_id;
            //using MySqlConnection conn = new MySqlConnection("Persist Security Info=False;server=sql.freedb.tech;database=freedb_umc_dp_aluno;uid=freedb_joseescobar;pwd=7V9qtnn5sRRz$nQ;Convert Zero Datetime=True");
            //conn.Open();
            //MySqlCommand deletecommand = new MySqlCommand(deleteQuery2, conn);
            //deletecommand.ExecuteNonQuery();
            Console.WriteLine("Deletado com sucesso!");
            Conexao con = new Conexao();
            con.executeScript(deleteQuery2);

        }

        protected override void ExecutarAcoes(string key)
        {

            {
                switch (key)
                {
                    case "1":
                        {
                            CreateLivro();
                            break;
                        }
                    case "2":
                        {
                            AtualizarLivro();
                            break;
                        }
                    case "3":
                        {
                            ShowLivro();
                            break;
                        }
                    case "4":
                        {
                            DeleteLivro();
                            break;
                        }
                    default: break;
                }


            }
        }
        

        


    }
}
