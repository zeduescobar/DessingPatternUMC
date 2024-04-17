using AppDesignPattern;
using MySql.Data.MySqlClient;

public class ReadCommand: ICommand
{
    public void Execute()
    {

        Conexao con = new Conexao();
        Console.WriteLine("+------------------------- ALUNO  --------------+    ");
        Console.WriteLine("¦                                               ¦    ");
        Console.WriteLine("                   Dados do Aluno:              ¦    ");
        Console.WriteLine("¦                                               ¦    ");
        Console.WriteLine("+-----------------------------------------------+    ");
        string sql = $"SELECT * FROM ALUNO ";
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
}