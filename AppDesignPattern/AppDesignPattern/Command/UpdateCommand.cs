using AppDesignPattern;
using Mysqlx.Prepare;
using System;


public class UpdateCommand : ICommand
{

    public void Execute()
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

        string sql = $"UPDATE ALUNO SET Nome = '{u.GetNome()}', rgm = '{u.GetRgm()}', Datanasc = {u.GetDataNasc()}, Bolsista = '{u.GetBolsista()}', genero = {u.GetGenero()} WHERE Rg = {u.GetRg()} ";

        con.executeScript(sql);
    }

}