//Iniciação do programa
Console.WriteLine("Olá, seja muito bem vindo a calculadora de médias de tempo da STEM Racing!");
Console.WriteLine("Quatro corridas serão contabilizadas");
// Menu de opções
Console.WriteLine("Menu: \na - Média com tempo de reação(tempo do piloto) \nb - Média sem tempo de reação(tempo do piloto)");
string escolha = Console.ReadLine()!.ToLower();
if (escolha == "a")
{

    Console.WriteLine("Tempo do carro:");
    double tempoCarro = double.Parse(Console.ReadLine()!);

}
