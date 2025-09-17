int num, resultado; 
Console.WriteLine("Digite um número para a tabuada");
num = int.Parse (Console.ReadLine ());
resultado = 0;


int contador = 1;
while (contador <= 10; )
{
    resultado = contador * num;
    Console.WriteLine($"{num} X {contador} = {resultado}");
    contador++
}





#region ESTRUTURA FOR
for (int contador = 1; contador<= 10; contador ++)
{
    resultado = contador * num;
    Console.WriteLine($"{num} X {contador} = {resultado}");
}
#endregion

