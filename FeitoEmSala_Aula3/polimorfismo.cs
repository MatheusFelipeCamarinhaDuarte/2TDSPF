using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeitoEmSala_Aula3_2TDSPF
{
    internal class AnimalPolimorfiso
    {

        public virtual void EmitirSom()
        {
            Console.WriteLine("Um som qualquer de animal!");
        }
    }

    internal class GatoPolimorfiso : AnimalPolimorfiso
    {
         public override void EmitirSom()
        {
            Console.WriteLine("MEAW CARALHO!!!");
        }
    }
}
