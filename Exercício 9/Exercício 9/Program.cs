Console.WriteLine("Olá! Seja bem vindo a mercearia!");
Console.WriteLine("As maçãs custam: \nR$1,30 cada se forem compradas menos de uma dúzia\nR$1,0 se forem compradas pelo menos 12");
Console.WriteLine("Para iniciar, me diga: Quantas maças foram compradas?");
int quant = int.Parse(Console.ReadLine()!); 
if (quant < 12)
{
    double total = quant * 1.30;
    Console.WriteLine($"O total a pagar é de R${total}");
}
else
{
    double total = quant * 1.0;
    Console.WriteLine($"O total a pagar é de R${total}");
}