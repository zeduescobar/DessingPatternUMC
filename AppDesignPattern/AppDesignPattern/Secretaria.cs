using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AppDesignPattern
{
    public class Secretaria: MenuTemplate

    { 

        protected override void ExecutarAcoes(string key)
        {
            
            switch (key) {
                case "1":
                    {
                        ICommand create = new CreateCommand();
                        create.Execute();
                        break;
                    }
                case "2":
                    {
                        ICommand update = new UpdateCommand();
                        update.Execute();
                        break;
                    }
                case "3":
                    {
                        ICommand read = new ReadCommand();
                        read.Execute();
                        break;
                    }
                case "4":
                    {
                        ICommand delete = new DeleteCommand();
                        delete.Execute();
                        break;
                    }

                default:  break;
            } 


        }

       

    }
}
