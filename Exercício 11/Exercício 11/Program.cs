int anoAtual = DateTime.Now.Year;
Console.WriteLine("Em que ano você nasceu?");
int anoNascimento = int.Parse(Console.ReadLine()!);
int idade = anoAtual - anoNascimento;
if (idade >= 18)
{
    Console.WriteLine($"Você tem {idade} anos. É obrigado a votar!");
}
else if (idade > 16 & idade < 18)
{
    Console.WriteLine($"Você tem {idade} anos. Já pode votar, mas não é obrigado (facultativo)");
}
else
{
    Console.WriteLine($"Você tem {idade} anos. Ainda não pode votar!");
}
