using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeitoEmSala_Aula3_2TDSPF
{
    internal class Animal
    {

        public void EmitirSom()
        {
            Console.WriteLine("Um som qualquer de animal!");
        }       
    }

    internal class Gato : Animal
    {
        public void Miar()
        {
            
            Console.WriteLine("MIAUUU");
        }
    }
}
