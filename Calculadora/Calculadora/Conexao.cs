using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Conexao
    {

        public void executeScript(string sql)
        {
            MySqlConnection con;
            con = new MySqlConnection("Persist Security Info=False;server=sql.freedb.tech;database=freedb_umc_dp_aluno;uid=freedb_joseescobar;pwd=7V9qtnn5sRRz$nQ;Convert Zero Datetime=True");
            try
            {
                con.Open();
                Console.WriteLine($"MySQL version : {con.ServerVersion}");
            }
            catch (Exception e)
            {
                //Console.WriteLine (e.Message.ToString());
                //MessageBox.Show(e.Message.ToString());
            }

            //verificva se a conexão esta aberta
            if (con.State == ConnectionState.Open)
            {
                Console.WriteLine("connection Open!");
                using var cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

    }
}
