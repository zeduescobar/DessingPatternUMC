using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CrudDP
{
    public class conection
    {
        public MySqlConnection con;

        public conection()
        {
        }

        public void conectar()
        {
           
            con = new MySqlConnection("Persist Security Info=False;server=sql.freedb.tech;database=freedb_umc_dp_aluno;uid=freedb_joseescobar;pwd=7V9qtnn5sRRz$nQ;Convert Zero Datetime=True");
            try
            {
                con.Open();
                Console.WriteLine($"MySQL version : {con.ServerVersion}");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                //MessageBox.Show(e.Message.ToString());
            }

            //verificva se a conexão esta aberta
            if (con.State == ConnectionState.Open)
            { }

           
        }
    }
}

