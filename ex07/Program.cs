// Exercício 7:

int inicial = 0;
int final = 0;
double soma = 0.00;
double mediana = 0.00;

Console.WriteLine("Digite o número inicial da contagem: ");
inicial = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número final da contagem: ");
final = int.Parse(Console.ReadLine());

if (inicial < final)
{
    for (int i = inicial; i <= final; i++)
    {
        Console.WriteLine(i);
        soma = inicial + final;
        mediana = soma / 2;

    }

}
else
{
    for (int i = inicial; i >= final; i--)
    {
        Console.WriteLine(i);
        soma = inicial + final;
        mediana = soma / 2;

    }
}
Console.WriteLine("A mediana é: "+mediana);
