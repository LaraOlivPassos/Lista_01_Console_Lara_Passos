decimal salarioAtual, percentualAumento, salarioAjust;
//iniciação
Console.WriteLine("Seja bem vindo a Calculadora de salário!\nPara começar, insira o valor do salário atual");
salarioAtual = decimal.Parse(Console.ReadLine()!);
Console.WriteLine("Agora, insira o percentual de aumento (sem o símbolo de %)");
percentualAumento = decimal.Parse(Console.ReadLine()!);

// Cálculo do salário ajustado
salarioAjust = salarioAtual + (salarioAtual * (percentualAumento / 100));

//Finalização
Console.WriteLine($"O salário ajustado é = R${salarioAjust}. \n " +
    $"Aumento de R$:{salarioAjust - salarioAtual} em relação ao salário anterior");
