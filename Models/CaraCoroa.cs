using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraOuCoroa.Models
{
    class CaraCoroa
    {
        public CaraCoroa()
        {

        }

        public CaraCoroa(string escolha)
        {
            Escolha = escolha;
        }

        //atributos
        private string Escolha { get; set; }

        //metodos
        public int escolhaResultado()
        {
            return new Random().Next(0, 2);
        }
    }
}
