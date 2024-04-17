using AppDesignPattern;
using MySql.Data.MySqlClient;
using System;
public class DeleteCommand: ICommand
{
    public void Execute()
    {
        Conexao con = new Conexao();
        Console.WriteLine("+-------------------------  ALUNO --------------+    ");
        Console.WriteLine("¦                                               ¦    ");
        Console.WriteLine("      Forneca o ID do Aluno a ser deletado:     ¦    ");
        Console.WriteLine("¦                                               ¦    ");
        Console.WriteLine("+-----------------------------------------------+    ");
        int d_id;

        d_id = int.Parse(Console.ReadLine());
        string deleteQuery2 = "DELETE FROM ALUNO WHERE ID =" + d_id;
        using MySqlConnection conn = new MySqlConnection("Persist Security Info=False;server=sql.freedb.tech;database=freedb_umc_dp_aluno;uid=freedb_joseescobar;pwd=7V9qtnn5sRRz$nQ;Convert Zero Datetime=True");
        conn.Open();
        MySqlCommand deletecommand = new MySqlCommand(deleteQuery2, conn);
        deletecommand.ExecuteNonQuery();
        Console.WriteLine("Deletado com sucesso!");
    }
}