using System;
using System.Net.NetworkInformation;

public class VENDA_LIVRO
{
    private int ID;
    private int ID_REQ;
    public VENDA_LIVRO (int _ID, int _ID_REQ)
    {
        ID = _ID;
        ID_REQ = _ID_REQ;
    }

    public VENDA_LIVRO()
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

    public void SetID_REQ(int valor)
    {
        ID_REQ = valor;

    }
}
//getters e setter venda