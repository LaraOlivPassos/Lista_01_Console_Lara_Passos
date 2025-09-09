// Váriaveis
int totalEleitores, votosBranco, votosNulo, votosValidos;
decimal percentualBranco, percentualNulo, percentualValidos;
//Perguntas + entrada de dados
Console.WriteLine("Qual é a quantidade de eleitores?");
totalEleitores = int.Parse(Console.ReadLine()!);
Console.WriteLine("Qual é a quantidade de votos em branco?");  
votosBranco = int.Parse(Console.ReadLine()!);   
Console.WriteLine("Qual é a quantidade de votos nulos?");
votosNulo = int.Parse(Console.ReadLine()!);
//Cálculo dos percentuais
percentualBranco = (votosBranco * 100) / totalEleitores;
percentualNulo = (votosNulo * 100) / totalEleitores; 
votosValidos = totalEleitores - (votosBranco + votosNulo);
percentualValidos = (votosValidos * 100) / totalEleitores;
Console.WriteLine("\n");
//Mostrar o total de cada tipo de voto e o percentual que ele representa
Console.WriteLine($"Considerando que o total de eleitores é = {totalEleitores}, temos:\n");
Console.WriteLine($"Votos em branco = {votosBranco}, sendo {percentualBranco}% da votação total\n");
Console.WriteLine($"Votos nulos = {votosNulo}, sendo {percentualNulo}% da votação total\n");
Console.WriteLine($"Votos válidos = {votosValidos}, sendo {percentualValidos}% da votação total\n");
//Fim :)