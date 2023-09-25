decimal salarioBruto = 0, FGTS = 0.11m, horaTrabalhada, ValorHora, impostoSindical = 0.03m, salarioliquido = 0,
    impostoRenda = 0, valorFgts = 0, valorSidical = 0;
Console.WriteLine("Digite Valor da hora trabalhada  :");
ValorHora = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite quantidade de horas trabalhadas");
horaTrabalhada = Convert.ToDecimal(Console.ReadLine());
salarioBruto = horaTrabalhada * ValorHora;



valorFgts = FGTS * salarioBruto;

valorSidical = salarioBruto * impostoSindical;
if (salarioBruto <= 900)
{
    salarioliquido = salarioBruto - impostoSindical;

}
else
{
    if (salarioBruto > 900 && salarioBruto <= 1500)
    {
        impostoRenda = salarioBruto * 0.05m;
        salarioliquido = salarioBruto - impostoRenda - valorSidical;

    }
    if (salarioBruto > 1500 && salarioBruto <= 2500)
    {
        impostoRenda = salarioBruto * 0.1m;
        salarioliquido = salarioBruto - valorSidical - impostoRenda;
    }
    if (salarioBruto > 2500)
    {
        impostoRenda = salarioBruto * 0.2m;
        salarioliquido = salarioBruto - valorSidical - impostoRenda;
    }


}
Console.WriteLine("O salario liquido " + salarioliquido);
Console.WriteLine("o salario bruto é:" + salarioBruto);
Console.WriteLine("O valor do FGTS " + valorFgts);
Console.WriteLine("O valor do Imposto Sidical " + valorSidical);
Console.WriteLine("O valor do Imposto de Renda " + impostoRenda);



