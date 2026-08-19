// =====================================================================
// MODULO 2 - JUROS                                     Dificuldade: MEDIA
// Branch: feature/02-juros
// =====================================================================
//
// O QUE ESTE MODULO DEVE FAZER
//   Perguntar um valor inicial, uma taxa de juros mensal e um numero de
//   meses. Imprimir, mes a mes, quanto daria em juros SIMPLES e quanto
//   daria em juros COMPOSTOS.
//
// AS FORMULAS (ja prontas, so aplicar)
//   Juros simples:   valor + (valor * taxa * meses)
//   Juros composto:  valor * (1 + taxa) elevado a meses
//
//   Para a potencia use:  (decimal)Math.Pow((double)(1 + taxa), mes)
//
// EXEMPLO DE EXECUCAO
//   Valor inicial: 1000
//   Taxa mensal (ex: 0,02 para 2%): 0,02
//   Numero de meses: 3
//
//   Mes | Simples  | Composto
//     1 |  1020,00 |  1020,00
//     2 |  1040,00 |  1040,40
//     3 |  1060,00 |  1061,21
//
// O QUE VOCE VAI PRECISAR
//   - um laco for de 1 ate o numero de meses
//   - as duas formulas dentro do laco
//   - {valor:F2} para formatar
//
// DESAFIO EXTRA (opcional)
//   Ao final, informe quantos reais o composto rendeu a mais.
//
// =====================================================================

static class Juros
{
    public static void Executar()
    {
        // TODO: apague a linha abaixo e escreva o seu codigo aqui
        Console.WriteLine("[ Modulo 2 - Juros ] em construcao.");
    }
}
