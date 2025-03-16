using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace treinoRender
{
   public class Produto
    {
        string Nome;
        double Preco;
        int Quant;
        string Desc;

        public Produto(string nome, double preco, int quant, string desc)
        {
            nome = this.Nome;
            preco = this.Preco;
            quant = this.Quant;
            desc = this.Desc;
        }
    }
}
