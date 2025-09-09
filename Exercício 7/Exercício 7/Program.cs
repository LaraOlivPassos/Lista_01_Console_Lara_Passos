Console.WriteLine("Escreva um valor para que descubramos se é maior ou menor que 10");
decimal valor = decimal.Parse(Console.ReadLine()!); // 
if (valor > 10)
{
    Console.WriteLine("O valor é maior que 10");
}
else if (valor < 10)
{
    Console.WriteLine("O valor é menor que 10");
}
else
{
    Console.WriteLine("O valor é igual a 10");
}