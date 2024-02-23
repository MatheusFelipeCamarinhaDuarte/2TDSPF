using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeitoEmSala_Aula3_2TDSPF
{
    internal class Carro
    {
        private String modelo; // Carinha encapsulado

        public void DefinirModelo(String novoModelo)
        {
            modelo = novoModelo;
        }

        public String RetornarModelo()
        {
            return modelo;
        }


    }
}
