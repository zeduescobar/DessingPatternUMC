using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AppDesignPattern
{
    public class Secretaria
    {



        public string CreateAluno()
        {
            Conexao con = new Conexao();
            Aluno c = new Aluno();
            Console.WriteLine("+------------------------- ALUNO  --------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("        Forneca os dados do Aluno:              ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");


            Console.WriteLine("Nome: ");
            c.SetNome(Console.ReadLine().ToString());

            Console.WriteLine("Rgm: ");
            c.SetRgm(long.Parse(Console.ReadLine().ToString()));

            Console.WriteLine("Data de nascimento: ");
            c.SetDataNasc(Convert.ToDateTime(Console.ReadLine().ToString()));

            Console.WriteLine("Bolsista: ");
            c.SetBolsista(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Rg: ");
            c.SetRg(Console.ReadLine().ToString());

            Console.WriteLine("Genero: ");
            c.SetGenero(Console.ReadLine().ToString());

            string sql = $"INSERT INTO Aluno (Nome, Rgm, Datanasc, Bolsista, Rg, Genero, ) VALUES ('{c.GetNome()}', '{c.GetRgm()}', '{c.GetDataNasc()}', {c.GetBolsista()}, '{c.GetRg}',' {c.GetGenero()}');";
            con.executeScript(sql);
        }
        public string AtualizarAluno()
        {
            Conexao con = new Conexao();
            Aluno u = new Aluno();
            Console.WriteLine("+------------------------- ALUNO  --------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("    Forneca os dados atualizados do Aluno:      ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");


            Console.WriteLine("Nome: ");
            u.SetNome(Console.ReadLine().ToString());

            Console.WriteLine("Rgm: ");
            u.SetRgm(long.Parse(Console.ReadLine().ToString()));

            Console.WriteLine("Data de nascimento: ");
            u.SetDataNasc(Convert.ToDateTime(Console.ReadLine().ToString()));

            Console.WriteLine("Bolsista: ");
            u.SetBolsista(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Rg: ");
            u.SetRg(Console.ReadLine().ToString());

            Console.WriteLine("Genero: ");
            u.SetGenero(Console.ReadLine().ToString());

            string sql = $"UPDATE Aluno SET Nome = '{u.GetNome()}', rgm = '{u.GetRgm()}', Datanasc = {u.GetDataNasc()}, Bolsista = '{u.GetBolsista()}', genero = {u.GetGenero()} WHERE Rg = {u.GetRg()} ";

            con.executeScript(sql);
        }
        public string ShowAluno()
        {

            Conexao con = new Conexao();
            Console.WriteLine("+------------------------- ALUNO  --------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("                   Dados do Aluno:              ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");
            string sql = $"SELECT * FROM Aluno ";
            using MySqlConnection conn = new MySqlConnection("Persist Security Info=False;server=sql.freedb.tech;database=freedb_umc_dp_aluno;uid=freedb_joseescobar;pwd=7V9qtnn5sRRz$nQ;Convert Zero Datetime=True");
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            using MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("ID: " + reader["ID"]);
                Console.WriteLine("Nome: " + reader["Nome"]);
                Console.WriteLine("Rgm: " + reader["Rgm"]);
                Console.WriteLine("Data de nascimento: " + reader["Datanasc"]);
                Console.WriteLine("Bolsista: " + reader["Bolsista"]);
                Console.WriteLine("Rg: " + reader["Rg"]);
                Console.WriteLine("Gênero: " + reader["Genero"]);




            }
            reader.Close();
        }
            public string DeleteAluno()
        {
            Conexao con = new Conexao();
            Console.WriteLine("+-------------------------  ALUNO --------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("      Forneca o ID do Aluno a ser deletado:     ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");
            int d_id;

            d_id = int.Parse(Console.ReadLine());
            string deleteQuery2 = "DELETE FROM Aluno WHERE ID =" + d_id;
            using MySqlConnection conn = new MySqlConnection("Persist Security Info=False;server=sql.freedb.tech;database=freedb_umc_dp_aluno;uid=freedb_joseescobar;pwd=7V9qtnn5sRRz$nQ;Convert Zero Datetime=True");
            conn.Open();
            MySqlCommand deletecommand = new MySqlCommand(deleteQuery2, conn);
            deletecommand.ExecuteNonQuery();
            Console.WriteLine("Deletado com sucesso!");
        }

    }
}

