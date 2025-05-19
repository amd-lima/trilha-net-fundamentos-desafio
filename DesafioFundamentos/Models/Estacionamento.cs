namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        Colors colors = new Colors();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string placa;

            do
            {
                colors.SetColor("Cyan");
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placa = Console.ReadLine().ToUpper();

                if (veiculos.Any(x => x.ToUpper() == placa))
                {
                    colors.SetColor("Red");
                    Console.WriteLine("Esse veículo já está estacionado. Digite outra placa.\n");
                    colors.SetColor("White");
                }
                // Verifica se a string não esta vazia
                else if (string.IsNullOrEmpty(placa))
                {
                    colors.SetColor("Red");
                    Console.WriteLine("Placa inválida. Digite uma placa válida.\n");
                    colors.SetColor("White");
                }

            } while (string.IsNullOrWhiteSpace(placa) || veiculos.Any(x => x.ToUpper() == placa));

            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            colors.SetColor("Cyan");
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = "";
            placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x == placa))
            {
                colors.SetColor("Cyan");
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                colors.SetColor("White");

                int horas = 0;
                while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
                {
                    colors.SetColor("Red");
                    Console.WriteLine("Valor inválido. Digite um número válido:");
                    colors.SetColor("White");
                }

                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;


                veiculos.Remove(placa);
                colors.SetColor("Green");
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                colors.SetColor("Red");
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine("🔹 " + veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
            colors.SetColor("lightGray");
            Console.WriteLine("Total de veículos estacionados: " + veiculos.Count);
        }
    }
}
