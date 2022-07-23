/*
4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
*/

var dictionary = new Dictionary<string, decimal>();

dictionary.Add("SP",(decimal)67836.43);
dictionary.Add("RJ",(decimal)36678.66);
dictionary.Add("MG",(decimal)29229.88);
dictionary.Add("ES",(decimal)27165.48);
dictionary.Add("Outros",(decimal)19849.53);

decimal total = dictionary.Sum(x => x.Value);
string report = $"Faturamento: {total}\n\n";

foreach(KeyValuePair<string, decimal> x in dictionary)
{
    decimal percentual = decimal.Round(x.Value/total*100, 2, MidpointRounding.AwayFromZero);
    report+=$"{x.Key} representa {percentual}% do faturamento total\n";
}

Console.WriteLine(report);
