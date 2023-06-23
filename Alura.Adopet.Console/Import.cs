namespace Alura.Adopet.Console
{
    internal class Import
    {
        public async Task ImportacaoArquivoPetAsync(string caminhoDoArquivoDeImportacao)
        {            
            var leitor = new LeitorDeArquivo();
            List<Pet> listaDePet = leitor.RealizaLeitura(caminhoDoArquivoDeImportacao);
            foreach (var pet in listaDePet)
            {
                System.Console.WriteLine(pet);
                try
                {
                    var httpCreatePet = new HttpClientPet();
                    await httpCreatePet.CreatePetAsync(pet);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
            System.Console.WriteLine("Importação concluída!");
        }               
    }
}
