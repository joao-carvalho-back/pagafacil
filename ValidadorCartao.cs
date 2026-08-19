// =====================================================================
// MODULO 4 - VALIDADOR DE CARTAO                       Dificuldade: MEDIA
// Branch: feature/04-validador-cartao
// =====================================================================
//
// O QUE ESTE MODULO DEVE FAZER
//   Perguntar o numero do cartao e verificar duas coisas:
//     1. Se tem exatamente 16 digitos
//     2. Qual a bandeira, olhando o PRIMEIRO digito:
//
//          4  -> Visa
//          5  -> Mastercard
//          3  -> American Express
//          6  -> Elo
//          outro -> Bandeira desconhecida
//
// EXEMPLO DE EXECUCAO
//   Numero do cartao: 4532111122223333
//
//   Quantidade de digitos: 16  (ok)
//   Bandeira: Visa
//   Cartao valido para processamento.
//
//   ---
//
//   Numero do cartao: 12345
//
//   Quantidade de digitos: 5  (esperado: 16)
//   Cartao invalido.
//
// O QUE VOCE VAI PRECISAR
//   - Console.ReadLine devolve string: use .Length para contar os digitos
//   - numero[0] devolve o primeiro caractere (um char, entao compare com '4')
//   - if / else if para descobrir a bandeira, ou um switch
//
// DESAFIO EXTRA (opcional)
//   Percorra o numero com um laco e confirme que TODO caractere e digito.
//   Dica: char.IsDigit(c) devolve true ou false.
//
// =====================================================================

static class ValidadorCartao
{
    public static void Executar()
    {
        // TODO: apague a linha abaixo e escreva o seu codigo aqui
        Console.WriteLine("[ Modulo 4 - Validador de cartao ] em construcao.");
    }
}
