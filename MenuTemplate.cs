using System;

public abstract class MenuTemplate
{
    public void run(string key)
    {
        this.LimparTela();
        this.ExecutarAcoes(key);
            

    }
    protected abstract void ExecutarAcoes(string key);




    protected void LimparTela()
    {
        Console.Clear();
    }
    



    

}