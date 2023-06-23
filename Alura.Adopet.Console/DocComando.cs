namespace Alura.Adopet.Console
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DocComando: System.Attribute
    {
        public DocComando(string documentacao)
        {
            Documentacao = documentacao;
        }

        public string Documentacao { get; }
    }
}
