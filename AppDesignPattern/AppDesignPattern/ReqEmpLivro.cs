// concrete class
using AppDesignPattern;
using System;

public class ReqEmpLivro : IREQ_LIVRO
{

    public void CriarReq()
    {
        Conexao con = new Conexao();

        Console.WriteLine("+------------------------- LIVRO  --------------+    ");
        Console.WriteLine("¦                                               ¦    ");
        Console.WriteLine("        Forneca os dados do Emprestimo:         ¦    ");
        Console.WriteLine("¦                                               ¦    ");
        Console.WriteLine("+-----------------------------------------------+    ");


        Console.WriteLine("ID do livro: ");
        int idlivro = int.Parse(Console.ReadLine());
        Console.WriteLine("ID do aluno: ");
        int idaluno = int.Parse(Console.ReadLine());

        Console.WriteLine("Data de retirada: ");
        DateTime dataretirada = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Data de devolução: ");
        DateTime datadevoluçao = DateTime.Parse(Console.ReadLine());
        string sql1 = $"INSERT INTO REQ_LIVRO (IDLIVRO, IDALUNO, ID_TIPOREQLIVRO) VALUES ('" + idlivro + "','" + idaluno + "','1');";
        con.executeScript(sql1);
        string sql = $"INSERT INTO EMP_LIVRO (ID_REQ_LIVRO, DataRetirada, DataDevolucao) VALUES ('"+idlivro+"','"+dataretirada+"','"+datadevoluçao+"');";
        con.executeScript(sql);
    }
    public void AtualizarReq()
    {
        //update
        Console.WriteLine("deu certo viado");
    }

}


