using exemplosC_.fixacao;

Console.WriteLine("informe o valor em metros:");
int metros = int.Parse( Console.ReadLine() );

int milimetros = metodosmilimetros.Converter(metros);

Console.WriteLine($"A medida {metros} metros é igual a {milimetros} milímetros.");

int salario = 1000;
double aumento = 10;
double novoSalario = CalculaAumento.Aumento(salario, aumento);
Console.WriteLine("Salário atual: " + salario);
Console.WriteLine("O novo salário é: " + novoSalario);