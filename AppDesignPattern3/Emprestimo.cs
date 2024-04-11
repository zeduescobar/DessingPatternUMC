using System;

public class Emprestimo_Livro
{
    private int ID;
    private int ID_REQ;

    public Emprestimo_Livro(int _ID, int _ID_REQ) {
        ID = _ID;
        ID_REQ = _ID_REQ;
    }

    public Emprestimo_Livro()
    {

        ID = 0;
        ID_REQ = 0;
    }

    public int GetID()
    {
        return ID;
    }

    public void SetID(int valor)
    {
        ID = valor;
    }


    public int GetID_REQ()
    {
        return ID_REQ;
    }

    public void SETID_REQ(int valor)
    {
        ID_REQ = valor;
    }

}
//gettters e setters emprestimo