using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSistemaMensal_UniaoEnc
{
    public class Frete
    {
        public string dia;
        public string mes;
        public string ncte;
        public string ano;
        public string remetente;
        public string destinatario;
        public string cidade;
        public int pagamento;
        public double valor = 0;


        public double somaCif = 0;
        public double somaFob = 0;




        public void somaValor(int pg, double valor)
        {
            if (pg == 1)
            {
                somaCif += valor;
            }
            else
            {
                somaFob += valor;
            }

        }

    }
}
