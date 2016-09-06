using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreSAAD
{
    public class drop
    {
        public drop(string nome, string valor)
        {
            Nome = nome;
            Valor = valor;
        }

        string _nome;
        string _valor;

        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
