Console.WriteLine("Nota da primeira prova:");
decimal nota1 = decimal.Parse(Console.ReadLine()!);
Console.WriteLine("Nota da segunda prova:");
decimal nota2 = decimal.Parse(Console.ReadLine()!);
decimal media = (nota1 + nota2) / 2;
Console.WriteLine($"A média entre as suas notas é = {media}");
if (media >= 6)
{
    Console.WriteLine("Dessa forma, parabéns, você foi APROVADO");
}
else
{
    Console.WriteLine("Dessa forma, infelizmente você foi REPROVADO");
}