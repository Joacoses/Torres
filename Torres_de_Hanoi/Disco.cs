using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        /*TODO: 
        Decidir tipo de Valor
        public int Valor { get; set; }
        public String Valor { get; set; }
        */

        //usamos int
        private int tam;

        public Disco(int tamanyo)
        {
            tam = tamanyo;
        }
        //get
        public int getValor()
        {
            return this.tam;
        }

        //set
        public void setValor(int tamanyo)
        {
            this.tam = tamanyo;
        }

    }
}
