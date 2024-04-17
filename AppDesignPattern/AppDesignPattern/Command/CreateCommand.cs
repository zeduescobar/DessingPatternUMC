using AppDesignPattern;

public class CreateCommand: ICommand
{
    public void Execute()
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

            string sql = $"INSERT INTO ALUNO (Nome, Rgm, Datanasc, Bolsista, Rg, Genero, ) VALUES ('{c.GetNome()}', '{c.GetRgm()}', '{c.GetDataNasc()}', {c.GetBolsista()}, '{c.GetRg}',' {c.GetGenero()}');";
            con.executeScript(sql);
        }
}