using System;

public class CriaReqVendaLivro : CriaReqLivro
{
    protected override IREQ_LIVRO CreateReqLivro()
    {
        return new ReqVendaLivro();
    }

}