using Alura.Adopet.Console.Comandos;

Dictionary<string, IComando> comandosDoSistema = new()
{
    {"help",new Help() },
    {"import",new Import() },
    {"list",new List() },
    {"show",new Show() },
};

Console.ForegroundColor = ConsoleColor.Green;
try
{    
    string comando = args[0].Trim();
    if (comandosDoSistema.ContainsKey(comando))
    {
        IComando? cmd = comandosDoSistema[comando];
        await cmd.ExecutarAsync(args);
    }
    else
    {
        Console.WriteLine("Comando inválido!");
    }
   

    //switch (comando)
    //{
    //    case "import":
    //        var import = new Import();
    //        await import.ExecutarAsync(args);
    //        break;
    //    case "help":     
    //        var help = new Help();
    //        await help.ExecutarAsync(args);
    //        break;
    //    case "show":  
    //        var show = new Show();
    //        await show.ExecutarAsync(args);
    //        break;
    //    case "list":
    //        var list = new List();
    //        await list.ExecutarAsync(args);
    //        break;
    //    default:
    //        Console.WriteLine("Comando inválido!");
    //        break;
    //}
}
catch (Exception ex)
{
    // mostra a exceção em vermelho
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.White;
}
