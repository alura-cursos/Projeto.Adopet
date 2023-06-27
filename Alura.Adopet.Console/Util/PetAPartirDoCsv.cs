using Alura.Adopet.Console.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Util
{
    public class PetAPartirDoCsv
    {
        public Pet ConverteDoTexto(string linha)
        {
            string[]? propriedades = linha.Split(';');
            // cria objeto Pet a partir da separação
            return new Pet(Guid.Parse(propriedades[0]),
            propriedades[1],
            int.Parse(propriedades[2]) == 0 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }
    }
}
