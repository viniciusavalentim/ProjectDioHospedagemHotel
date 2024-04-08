namespace ProjectDioHospedagemHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> hospedes = new List<Pessoa>();
            Console.WriteLine("Bem vindos ao HOTEL - Valentine's");
            Console.Write("Para começarmos a sua reserva me informe o número de Hóspedes: ");
            int quantidadeHospedes = int.Parse(Console.ReadLine());

            Console.WriteLine($"Perefeito!, então vamos cadastrar {quantidadeHospedes} pessoas!");
            for (int i = 0; i < quantidadeHospedes; i++)
            {
                Console.Write($"Digite o nome da {1 + i}° pessoa: ");
                string nomePessoa = Console.ReadLine();
                Console.Write($"Digite o sobrenome da {1 + i}° pessoa: ");
                string sobrenomePessoa = Console.ReadLine();
                Console.WriteLine("<---------------->");
                hospedes.Add(new Pessoa(nomePessoa, sobrenomePessoa));
            }

            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 30);


            Reserva reserva = new Reserva(diasReservados: 10);
            reserva.CadastrarHospedes(hospedes);
            reserva.CadastrarSuite(suite);

            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

        }
    }
}