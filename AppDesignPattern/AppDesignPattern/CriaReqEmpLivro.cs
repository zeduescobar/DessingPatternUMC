using System;
// concrete creator class 1
public class CriaReqEmpLivro : CriaReqLivro
{
    protected override IREQ_LIVRO CreateReqLivro()
    {
        return new ReqEmpLivro();
    }
    //crud req
}