Console.WriteLine("Olá!");
decimal alt, larg, area;
Console.WriteLine("Qual é a altura do retangulo?");
alt = decimal.Parse(Console.ReadLine()!);
Console.WriteLine("Qual é a largura do retangulo?");
larg = decimal.Parse(Console.ReadLine()!);
area = alt * larg;
Console.WriteLine($"A área é = {area}");