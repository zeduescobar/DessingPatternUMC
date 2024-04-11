using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesignPattern
{
    public class Aluno
    {
        string nome;
        long rgm;
        DateTime dataNasc;
        int bolsista;
        string rg;
        string genero;


        public Aluno(string _nome, long _rgm, DateTime _dataNasc, int _bolsista, string _rg, string _genero)
        {
            nome = _nome;
            rgm = _rgm;
            dataNasc = _dataNasc;
            bolsista = _bolsista;
            rg = _rg;
            genero = _genero;
        }
        public Aluno()
        {
            nome = "";
            rgm = 0;
            dataNasc = new DateTime();
            bolsista = 0;
            rg = "";
            genero = "";
        }
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string valor)
        {
            nome = valor;
        }
        public long GetRgm()
        {
            return rgm;
        }
        public void SetRgm(long valor)
        {
            rgm = valor;
        }
        public DateTime GetDataNasc()
        {
            return dataNasc;
        }
        public void SetDataNasc(DateTime valor)
        {
            dataNasc = valor;
        }

        public int GetBolsista()
        {
            return bolsista;
        }
        public void SetBolsista(int valor)
        {
            bolsista = valor;
        }
        public string GetRg()
        {
            return rg;
        }
        public void SetRg(string valor)
        {
            rg = valor;
        }
        public string GetGenero()
        {
            return genero;
        }
        public void SetGenero(string valor)
        {
            genero = valor;
        }
    }
}