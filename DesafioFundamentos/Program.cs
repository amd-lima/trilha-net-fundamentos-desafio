using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

// Instancia a classe Colors
Colors colors = new Colors();


// Cor do carro
colors.SetColor("Red");

// Carro em ASCII
Console.WriteLine(@"
           ______
          /|_||_\`.__
         (   _    _ _\
         =`-(_)--(_)-'

        ");


// Define cores diferentes
colors.SetColor("Yellow");
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");

colors.SetColor("Cyan");
Console.WriteLine("Digite o preço inicial:");
colors.SetColor("White");

// Lê o preço inicial e o preço por hora se é number ou decimal
// Se não for, exibe mensagem de erro

while (!decimal.TryParse(Console.ReadLine(), out precoInicial))
{
    colors.SetColor("Red");
    Console.WriteLine("Valor inválido. Digite um número válido:");
    colors.SetColor("White");

}

colors.SetColor("Cyan");
Console.WriteLine("Agora digite o preço por hora:");
colors.SetColor("White");

while (!decimal.TryParse(Console.ReadLine(), out precoPorHora))
{
    colors.SetColor("Red");
    Console.WriteLine("Valor inválido. Digite um número válido:");
    colors.SetColor("White");
}

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
// Método auxiliar para pausar com mensagem padrão ou personalizada
void Pausar(string mensagem = "\nPressione Enter para continuar...")
{
    colors.SetColor("DarkGray");
    Console.WriteLine(mensagem);
    colors.SetColor("White");
    Console.ReadLine();
}

while (exibirMenu)
{
    Console.Clear();
    colors.SetColor("Yellow");
    Console.WriteLine("Digite a sua opção:");
    colors.SetColor("Cyan");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    colors.SetColor("White");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            Pausar("\nVeículo cadastrado com sucesso. Pressione Enter para voltar ao menu...");
            break;

        case "2":
            es.RemoverVeiculo();
            Pausar("\nPressione Enter para voltar ao menu...");
            break;

        case "3":
            es.ListarVeiculos();
            Pausar();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            colors.SetColor("Red");
            Console.WriteLine("Opção inválida!");
            colors.SetColor("White");
            Thread.Sleep(1000); // Pequena pausa para o usuário ver o erro
            break;
    }
}

colors.SetColor("DarkGray");
Console.WriteLine("O programa se encerrou");
colors.SetColor("White");