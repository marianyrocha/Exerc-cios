// Exercício 6:

int n = 0;

Console.WriteLine("Digite um valor para n: ");
Console.WriteLine("Se n for par, será executada a seguinte equação: n=n/2 ");
Console.WriteLine("Caso n seja impar, será executada a equação: n=n*3+1 ");
Console.WriteLine("Isso se repetirá até n ser igual a 1.");
n = int.Parse(Console.ReadLine());

while (n != 1)
{
    if (n % 2 == 0)
    {
        Console.WriteLine(n + " é par");
        n = n / 2;
        Console.WriteLine("ao executar a equãção, obtemos: " + n);

    }
    else
    {
        Console.WriteLine(n + " é impar");
        n = n * 3 + 1;
        Console.WriteLine("ao executar a equãção, obtemos: " + n);
    }
}