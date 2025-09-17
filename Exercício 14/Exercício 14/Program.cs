int num;
Console.WriteLine("Digite o maior número inteiro");
num = int.Parse(Console.ReadLine());

for (int contador = 1; contador <= num; contador++)
{
    Console.Write($"{contador}, ");
}