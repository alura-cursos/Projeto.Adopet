using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Testes
{
    public class PetAPartirDoCSVTest
    {
       [Fact]
       public void QuandoStringForValidaDeveRetornarUmPet()
        {
            //Arrange            
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";
            var conversor = new PetAPartirDoCsv();
            //Act
            Pet pet = conversor.ConverteDoTexto(linha);
            //Assert
            Assert.NotNull(pet);
            Assert.Equal("Lima Limão", pet.Nome);
            Assert.Equal(TipoPet.Cachorro, pet.Tipo);
        }

    }
}
