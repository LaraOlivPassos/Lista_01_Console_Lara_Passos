Console.WriteLine("Escreva um valor e vamos descobrir se é positivo ou negativo");
decimal valor = decimal.Parse(Console.ReadLine()); // não permitir entrada de valor 0
if (valor > 0)
{
    Console.WriteLine("O valor é positivo");
}
else if (valor == 0)
{
    Console.WriteLine("O valor é zero, para alguns, pode ser positivo, para outros, negativo. \nvamos considera-lo nulo");
}
else
{
    Console.WriteLine("O valor é negativo");
}