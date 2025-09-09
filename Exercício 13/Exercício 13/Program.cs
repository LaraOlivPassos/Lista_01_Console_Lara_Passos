//introdução dos dados iniciais
Console.WriteLine("Valor 1 =");
decimal valor1 = decimal.Parse(Console.ReadLine()!);
Console.WriteLine("Valor 2 =");
decimal valor2 = decimal.Parse(Console.ReadLine()!);
if (valor2 == valor1)
{
    Console.WriteLine("Valor 2 não pode ser igual ao Valor 1, verifique os valores e tente novamente");
}
Console.WriteLine("Valor 3 =");
decimal valor3 = decimal.Parse(Console.ReadLine()!);
if (valor3 == valor1 || valor3 == valor2)
{
    Console.WriteLine("Valor 3 não pode ser igual ao Valor 1 ou ao Valor 2, verifique os valores e tente novamente");
}
// Análise dos valores
if (valor1 > valor2 && valor1 > valor3)
{
    if (valor2 > valor3)
    {
        Console.WriteLine($"Ordem decrescente: {valor1}, {valor2}, {valor3}");
    }
    else
    {
        Console.WriteLine($"Ordem decrescente: {valor1}, {valor3}, {valor2}");
    }
}
else if (valor2 > valor1 && valor2 > valor3)
{
    if (valor1 > valor3)
    {
        Console.WriteLine($"Ordem decrescente: {valor2}, {valor1}, {valor3}");
    }
    else
    {
        Console.WriteLine($"Ordem decrescente: {valor2}, {valor3}, {valor1}");
    }
}
else if (valor3 > valor1 && valor3 > valor2)
{
    if (valor1 > valor2)
    {
        Console.WriteLine($"Ordem decrescente: {valor3}, {valor1}, {valor2}");
    }
    else
    {
        Console.WriteLine($"Ordem decrescente: {valor3}, {valor2}, {valor1}");
    }
}
else
{

}