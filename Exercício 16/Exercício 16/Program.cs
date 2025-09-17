/* 
O que é fatorial?
operação matemática representada por um número seguido de um ponto de exclamação (n!)
em outras palavras: 
fatorial de um número n é o produto de todos os inteiros positivos de 1 até n.
0! = 1 (isso é uma definição matemática)
1! = 1
2! = 1 * 2 = 2
3! = 1 * 2 * 3 = 6
4! = 1 * 2 * 3 * 4 = 24
5! = 1 * 2 * 3 * 4 * 5 = 120
 */
Console.Write("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("Não existe fatorial para números negativos");
}
else if (n == 0)
{
    Console.WriteLine("0! = 1");
}
else
{
    long fatorial = 1;
    int valor = 1;

    while (valor <= n)
    {
        fatorial *= valor;
        valor++;
    }

    Console.WriteLine($"{n}! = {fatorial}");
}