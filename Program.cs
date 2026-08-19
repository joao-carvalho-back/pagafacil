// =====================================================================
// PAGAFACIL - Utilitarios de pagamento
// =====================================================================
// ATENCAO: este arquivo JA ESTA PRONTO. Voce NAO precisa alterar nada aqui.
//
// Se voce mexer neste arquivo, vai gerar conflito com os outros 4 colegas
// do seu grupo. Trabalhe apenas no arquivo do SEU modulo.
// =====================================================================

bool sair = false;

while (!sair)
{
    Console.WriteLine();
    Console.WriteLine("===== PAGAFACIL =====");
    Console.WriteLine();
    Console.WriteLine("1 - Simular parcelamento");
    Console.WriteLine("2 - Comparar juros");
    Console.WriteLine("3 - Calcular desconto");
    Console.WriteLine("4 - Validar cartao");
    Console.WriteLine("5 - Relatorio de transacoes");
    Console.WriteLine("0 - Sair");
    Console.WriteLine();
    Console.Write("Escolha uma opcao: ");

    string opcao = Console.ReadLine();
    Console.WriteLine();

    switch (opcao)
    {
        case "1":
            Parcelamento.Executar();
            break;

        case "2":
            Juros.Executar();
            break;

        case "3":
            Descontos.Executar();
            break;

        case "4":
            ValidadorCartao.Executar();
            break;

        case "5":
            Relatorio.Executar();
            break;

        case "0":
            sair = true;
            Console.WriteLine("Ate mais!");
            break;

        default:
            Console.WriteLine("Opcao invalida. Digite um numero de 0 a 5.");
            break;
    }

    if (!sair)
    {
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}
