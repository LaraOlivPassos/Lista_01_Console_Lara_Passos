Console.WriteLine("Valor 1 é");
int valor1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Valor 2 é"); 
int valor2 = int.Parse(Console.ReadLine()!);
if (valor1 > valor2)
{
    Console.WriteLine($"O maior valor é {valor1}");
}
else if (valor2 > valor1)
{
    Console.WriteLine($"O maior valor é {valor2}");
}
else
{
    Console.WriteLine("Os valores são iguais");
}

