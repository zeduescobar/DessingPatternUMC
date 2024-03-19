using System;
using System.Data;
using CrudDP;
using MySql.Data.MySqlClient;

class Program
{
    public static void Main(string[] args)
    {
       conection conexao = new conection();
        conexao.conectar();
        

            
            string opcao = "";
            do
            {

                opcao = Singleton.GetInstance().ExxibirMenu();

                if (opcao == "0")
                    break;

                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        { //CREATE
                            Console.WriteLine("+------------------------- LIVRO  --------------+    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("        Forneca os dados do Livro:              ¦    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("+-----------------------------------------------+    "); 

                            
                            Console.WriteLine("Insira o ISBN");
                            string isbn = Console.ReadLine();
                            Console.WriteLine("Insira o titulo");
                            string titulo = Console.ReadLine();
                            Console.WriteLine("Insira o autor");
                            string autor = Console.ReadLine();
                            Console.WriteLine("Insira o ano de lançamento");
                            int ano = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira o genero");
                            string genero = Console.ReadLine();
                            Console.WriteLine("Insira a edição ");
                            int edicao = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira a quantidade");
                            int quantidade = int.Parse(Console.ReadLine());
                            string insertQuery2 = "INSERT INTO Livro(ISBN, Titulo, Autor, Ano, Genero, Edicao, Quantidade) " +
                                "VALUES('" + isbn + "', '" + titulo + "', '" + autor + "', '" + ano + "', '" + genero + "', '" + edicao + "', '" + quantidade + "' )";
                            MySqlCommand insertCommand = new MySqlCommand(insertQuery2, conexao.con );
                            insertCommand.ExecuteNonQuery();
                            Console.WriteLine("Dados inseridos com sucesso!");

                            break;
                        }
                    case "2":
                        {  //READ
                            Console.WriteLine("+------------------------- LIVRO  --------------+    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("                   Dados do Livro:              ¦    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("+-----------------------------------------------+    ");
                            string selectQuery2 = "SELECT * FROM Livro";
                            MySqlCommand Selectcommand = new MySqlCommand(selectQuery2, conexao.con);
                            MySqlDataReader dataReader2 = Selectcommand.ExecuteReader();
                            while (dataReader2.Read())
                            {
                                Console.WriteLine("ID: " + dataReader2.GetValue(0).ToString());
                                Console.WriteLine("ISBN: " + dataReader2.GetValue(1).ToString());
                                Console.WriteLine("Titulo: " + dataReader2.GetValue(2).ToString());
                                Console.WriteLine("Autor: " + dataReader2.GetValue(3).ToString());
                                Console.WriteLine("Ano: " + dataReader2.GetValue(4).ToString());
                                Console.WriteLine("Genero: " + dataReader2.GetValue(5).ToString());
                                Console.WriteLine("Edição: " + dataReader2.GetValue(6).ToString());
                                Console.WriteLine("Quantidade: " + dataReader2.GetValue(7).ToString());
                            }
                            dataReader2.Close();
                            break;
                        }
                    case "3":
                        {  //UPDATE >> U 
                            Console.WriteLine("+------------------------- LIVRO  --------------+    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("    Forneca os dados atualizados do Livro:      ¦    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("+-----------------------------------------------+    ");
                            int u_id;
                            string u_isbn;
                            string u_titulo;
                            string u_autor;
                            int u_ano;
                            string u_genero;
                            int u_edicao;
                            int u_quantidade;
                            Console.WriteLine("Insira as novas informações do livro");
                            Console.WriteLine("Insira o ID");
                            u_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira o ISBN");
                            u_isbn = Console.ReadLine();
                            Console.WriteLine("Insira o titulo");
                            u_titulo = Console.ReadLine();
                            Console.WriteLine("Insira o autor");
                            u_autor = Console.ReadLine();
                            Console.WriteLine("Insira o ano");
                            u_ano = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira o genero");
                            u_genero = Console.ReadLine();
                            Console.WriteLine("Insira a edição");
                            u_edicao = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira a quantidade");
                            u_quantidade = int.Parse(Console.ReadLine());
                            string updateQuery2 = "UPDATE Livro SET ISBN = '" + u_isbn + "', Titulo = '" + u_titulo + "', Autor= '" + u_autor + "', Ano= '" + u_ano + "', Genero ='" + u_genero + "', Edicao= '" + u_edicao + "', Quantidade= '" + u_quantidade + "' WHERE ID = " + u_id + " ";
                            MySqlCommand updatecommand2 = new MySqlCommand(updateQuery2, conexao.con);
                            updatecommand2.ExecuteNonQuery();
                            Console.WriteLine("Os dados foram atualizados com sucesso!");
                            break;
                        }


                    case "4":
                        {  //DELETE >> D
                            Console.WriteLine("+------------------------- LIVRO  --------------+    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("      Forneca o ID do Livro a ser deletado:     ¦    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("+-----------------------------------------------+    ");
                            int d_id;
                            
                            d_id = int.Parse(Console.ReadLine());
                            string deleteQuery2 = "DELETE FROM Livro WHERE ID =" + d_id;
                            MySqlCommand deletecommand2 = new MySqlCommand(deleteQuery2, conexao.con);
                            deletecommand2.ExecuteNonQuery();
                            Console.WriteLine("Deletado com sucesso!");
                            break;
                        }


                    case "5":
                        {
                            //Create
                            Console.WriteLine("+------------------------- ALUNO  --------------+    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("        Forneca os dados do Aluno:              ¦    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("+-----------------------------------------------+    ");

                            Console.WriteLine("CRUD Aluno");
                            Console.WriteLine("Insira seu nome");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Insira seu RGM");
                            long rgm = long.Parse(Console.ReadLine());
                            Console.WriteLine("Insira sua data de nascimento");
                            DateTime datanasc = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Insira 1 se for bolsista se não insira 0");
                            int bolsista = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira seu RG");
                            string rg = Console.ReadLine();
                            Console.WriteLine("Insira seu Gênero");
                            string generol = Console.ReadLine();
                            string insertQuery = "INSERT INTO Aluno(Nome, Rgm, Datanasc, Bolsista, Rg, Genero) " +
                                        "VALUES('" + nome + "','" + rgm + "','" + datanasc + "','" + bolsista + "','" + rg + "','" + generol + "')";
                            MySqlCommand insertComand = new MySqlCommand(insertQuery, conexao.con);
                            insertComand.ExecuteNonQuery();
                            Console.WriteLine("Dados inseridos com sucesso!");
                            break;
                        }

                    case "6":
                        {  //Read
                            Console.WriteLine("+------------------------- ALUNO  --------------+    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("                   Dados do Aluno:              ¦    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("+-----------------------------------------------+    ");
                            string selectQuery = "SELECT * FROM Aluno";
                            MySqlCommand SelectCommand = new MySqlCommand(selectQuery, conexao.con);
                            MySqlDataReader dataReader = SelectCommand.ExecuteReader();
                            while (dataReader.Read())
                            {
                                Console.WriteLine("Id: " + dataReader.GetValue(0).ToString());
                                Console.WriteLine("Nome: " + dataReader.GetValue(1).ToString());
                                Console.WriteLine("Rgm: " + dataReader.GetValue(2).ToString());
                                Console.WriteLine("Data de nascimento: " + dataReader.GetValue(3).ToString());
                                Console.WriteLine("Bolsista: " + dataReader.GetValue(4).ToString());
                                Console.WriteLine("Rg: " + dataReader.GetValue(5).ToString());
                                Console.WriteLine("Gênero: " + dataReader.GetValue(6).ToString());


                            }

                            dataReader.Close();
                            break;
                        }


                    case "7":
                        {
                            //Update >> UP
                            Console.WriteLine("+------------------------- ALUNO  --------------+    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("     Forneca os dados atualizados do Livro:     ¦    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("+-----------------------------------------------+    ");
                            int up_id;
                            string up_nome;
                            long up_rgm;
                            DateTime up_date;
                            int up_bolsista;
                            string up_rg;
                            string up_genero;
                            Console.WriteLine("Insira as novas informações do usuario");
                            Console.WriteLine("Insira o id do aluno que será alterado");
                            up_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira o nome do aluno que será alterado");
                            up_nome = Console.ReadLine();
                            Console.WriteLine("Insira o RGM do aluno que será alterado");
                            up_rgm = long.Parse(Console.ReadLine());
                            Console.WriteLine("Insira a Data de nascimento do aluno que será alterado");
                            up_date = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Insira 1 se for bolsista e 0 se não");
                            up_bolsista = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira o RG do aluno que será alterado");
                            up_rg = Console.ReadLine();
                            Console.WriteLine("Insira o genero do aluno que será alterado");
                            up_genero = Console.ReadLine();
                            string updateQuery = "UPDATE Aluno SET Nome = '" + up_nome + "', Rgm = '" + up_rgm + "',  Datanasc = '" + up_date + "',  Bolsista = '" + up_bolsista + "',  Rg = '" + up_rg + "', Genero ='" + up_genero + "' WHERE ID = " + up_id + "";
                            MySqlCommand updatecommand = new MySqlCommand(updateQuery, conexao.con);
                            updatecommand.ExecuteNonQuery();
                            Console.WriteLine("Os dados foram atualizados com sucesso!");
                            break;
                        }

                    case "8":
                        {
                            //Delete >> De
                            Console.WriteLine("+------------------------- ALUNO  --------------+    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("       Insira o ID do aluno a ser deletado      ¦    ");
                            Console.WriteLine("¦                                               ¦    ");
                            Console.WriteLine("+-----------------------------------------------+    ");
                            int de_id;
                          
                            de_id = int.Parse(Console.ReadLine());
                            string deleteQuery = "DELETE FROM Aluno WHERE ID =" + de_id;
                            MySqlCommand deletecommand = new MySqlCommand(deleteQuery, conexao.con);
                            deletecommand.ExecuteNonQuery();
                            Console.WriteLine("Deletado com sucesso!");
                            break;
                        }
                      
                    default:
                        {
                            Console.WriteLine("Opção invalida");
                            break;
                        }
                }
               
            
            } while (opcao != "0"); 




     
    }
}