// Cria o programa de jokenpô
// Exiba a segunte informação ---Jo-keeeeen pô

Console.WriteLine("jó keeeen PÔ");
Console.WriteLine("""
                  escolha sua jogada!
                  opção 1: pedra
                  opção 2: papel
                  opção 3: tesoura
                  """);
// Ler a opção da pessoa, converter para inteiro e salvar em algum lugar
int opcaoUsuario = Convert.ToInt32(Console.ReadLine());

while (opcaoUsuario < 1 || opcaoUsuario > 3)
    
{
    Console.WriteLine("informe um número entre um e três");
   opcaoUsuario = Convert.ToInt32(Console.ReadLine());
    
}


// Computador escolhe um numero aleatorio de 1 a 3
var aleatorio = new Random();
int opcaoComputador = aleatorio.Next(1, 4);

// Estrutura Switch-Case
string escolhaUsuarioTexto;
string escolhaComputadorTexto;

switch (opcaoUsuario)
{
    case 1: // comandos do caso um
        escolhaUsuarioTexto = "pedra";
        break;
    case 2:
       escolhaUsuarioTexto  = "papel";
        break;
    case 3:
       escolhaUsuarioTexto = "tesoura";
        break;
    default:
          escolhaUsuarioTexto = "nenhum";
        break;
}

switch (opcaoComputador)
{
    case 1: // comandos do caso um
       escolhaComputadorTexto  = "pedra";
        break;
    case 2:
        escolhaComputadorTexto = "papel";
        break;
    case 3:
        escolhaComputadorTexto = "tesoura";
        break;
    default:
        escolhaComputadorTexto = "nenhum";
        break;
}

Console.WriteLine($"O usuário esclheu {escolhaUsuarioTexto} e o computador escolheu {escolhaComputadorTexto}");