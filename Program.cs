using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Suite: {suite.TipoSuite}");
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

//Aumenta a quantidade de dias para obter desconto no valor total
reserva.DiasReservados = 10;

Console.WriteLine($"Suite com desconto: {suite.TipoSuite}");
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

// Cria a suíte simples
Suite suiteSimples = new Suite(tipoSuite: "Simples", capacidade: 1, valorDiaria: 30);

// Cria uma nova reserva com hospedes acima da capacidade, passando a suíte e os hóspedes
Reserva reservaSimples = new Reserva(diasReservados: 5);
reservaSimples.CadastrarSuite(suiteSimples);

// Vai lançar a exception pois não pode ter mais hospedes que a suite comporta
reservaSimples.CadastrarHospedes(hospedes);

Console.WriteLine($"Suite com desconto: {suiteSimples.TipoSuite}");
Console.WriteLine($"Hóspedes: {reservaSimples.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reservaSimples.CalcularValorDiaria()}");