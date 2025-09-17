Console.WriteLine("Vamos verificar os valores que entre 1000 e 2000, quando divididos por 11 produzem resto = 5"); 
int etapa = 1000;
while (etapa <= 2000)
{
    if(etapa % 11 == 5)
    {
        Console.Write($"{etapa}, ");
    }
    etapa++;
}