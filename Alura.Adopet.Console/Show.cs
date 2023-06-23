namespace Alura.Adopet.Console
{
    internal class Show
    {
        public void ExibeConteudoArquivo(string caminhoDoArquivoASerExibido)        
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo();
            var listaDepets = leitor.RealizaLeitura(caminhoDoArquivoASerExibido);
            foreach (var pet in listaDepets)
            {
                System.Console.WriteLine(pet);
            }
          
           
        }
    }
}
