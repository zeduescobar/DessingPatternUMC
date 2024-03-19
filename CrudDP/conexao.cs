using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDP
{
    internal class conexao
    {
        MySqlConnection con;
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
    }
}
