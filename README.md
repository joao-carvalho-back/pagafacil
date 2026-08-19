# PagaFácil

Projeto em equipe da **Aula 03 — Lógica de programação e projeto em equipe**.

Um menu de console com cinco utilitários de pagamento. Cada pessoa do grupo
implementa **um** módulo, na **sua própria branch**, e no final tudo é
integrado na `main` via Pull Request.

---

## Como rodar

```bash
dotnet run
```

O menu abre. Módulos ainda não implementados avisam "em construção" — e o
programa continua funcionando normalmente.

> Se der erro de versão do .NET, abra `PagaFacil.csproj` e troque `net9.0`
> pela versão que você tem instalada.

---

## Os cinco módulos

| # | Arquivo | Branch | Dificuldade |
|---|---|---|---|
| 1 | `Parcelamento.cs` | `feature/01-parcelamento` | Fácil |
| 2 | `Juros.cs` | `feature/02-juros` | Média |
| 3 | `Descontos.cs` | `feature/03-descontos` | Fácil |
| 4 | `ValidadorCartao.cs` | `feature/04-validador-cartao` | Média |
| 5 | `Relatorio.cs` | `feature/05-relatorio` | Difícil |

**O enunciado completo de cada módulo está em comentário no topo do próprio
arquivo.** Abra o seu e leia antes de escrever a primeira linha.

---

## As regras do jogo

1. **Uma branch por pessoa.** Use o nome exato da tabela acima.
2. **Você só edita o SEU arquivo.** Mexer no arquivo de outra pessoa é o que
   gera conflito. O `Program.cs` já está pronto e ninguém deve alterá-lo.
3. **Nunca commite direto na `main`.** Todo código entra por Pull Request.
4. **Commits pequenos, com mensagem no padrão Conventional Commits.**
   Exemplo: `feat(parcelamento): calcula valor da parcela`
5. **Assine a lista "Feito por" abaixo.** Vai dar conflito — é de propósito.
6. **Ninguém aprova o próprio PR.** Outra pessoa do grupo revisa e aprova.

---

## Seu passo a passo

```bash
# 1. clone o repositório do seu grupo
git clone <url-do-seu-grupo>
cd pagafacil

# 2. crie a sua branch (use o SEU número)
git switch -c feature/01-parcelamento

# 3. implemente o seu arquivo e assine o README

# 4. rode e teste ANTES de enviar
dotnet run

# 5. commite e envie
git add .
git commit -m "feat(parcelamento): calcula tabela de parcelas"
git push -u origin feature/01-parcelamento

# 6. abra o Pull Request no GitHub e chame alguém para revisar
```

---

## Critério de pronto

- [ ] Clone limpo roda com `dotnet run` sem erro
- [ ] O menu abre e a opção `0` encerra
- [ ] Cada módulo entregue funciona e volta ao menu
- [ ] Módulo não entregue avisa "em construção" sem quebrar
- [ ] Nenhum commit direto na `main`
- [ ] O README tem o nome de **todas** as pessoas do grupo

> Entregar tudo é bom. **A `main` rodando é obrigatório.** Um grupo com três
> módulos funcionando e a `main` de pé entregou melhor que um grupo com cinco
> módulos e a `main` quebrada.

---

## Feito por

<!-- Acrescente o seu nome na linha de baixo, junto com o módulo que você fez.
     Quando der conflito no merge, mantenha TODOS os nomes. -->

- 


29 pessoas → 5 grupos de 5 + 1 grupo de 4.

Grupo 1

Wallisson de matos
Henrique araujo
mateus pevidor
icaro roberto
jyullio Thiago

Grupo 2

icaro Daniel
joao lucas
Breno de lima
Raul Silveira
Raissa dos santos

Grupo 3

victor hugo
lucas Werner
rodrigo luiz
felipe de oliveira
janete mariulu

Grupo 4

Atilia
Gabriel marco
joao Gabriel
wallace Sanches de oliveira
pablo vital

Grupo 5

Diergo Inácio
Anderson Luciano
thomas gonzalez
Paulo Henrique
fabio domingues

Grupo 6

Gutemberg
max de as
Ester urbinati
Matheus amaral