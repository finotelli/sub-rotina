Console.WriteLine("--- Exemplo de sub-rotina ---");

Console.WriteLine("Digite seu nome......:");
Console.ReadKey();
MostrarMensagemDeErro("Nome Inválido, o Nome é obrigatório");

Console.WriteLine("Digite sua idade......:");
Console.ReadKey();
MostrarMensagemDeErro("A idade deve estar entre 0 e 150 anos");

Console.WriteLine("Digite sua profissão......:");
Console.ReadKey();
MostrarMensagemDeErro("A profissão é obrigatória");


//sub-rotina do tipo procedimento com passagem de parâmetro
void MostrarMensagemDeErro(string mensagem)
{
    string mensagemAjustada = $"| {mensagem} |";
    int quantidadeDeTracos = mensagemAjustada.Length;
    string barra = "".PadRight(quantidadeDeTracos, '-');


    Console.WriteLine();
    Console.WriteLine(barra);

    Console.Write("| ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(mensagem);
    Console.ResetColor();
    Console.WriteLine(" |");

    Console.WriteLine(barra);
    Console.WriteLine();

    Console.Beep();
    Console.Beep();
    Console.ReadKey();
}