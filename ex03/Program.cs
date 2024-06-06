// Exercício 3:

int numero = 0;

Console.WriteLine("Digite o número da tabuada:");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i<=numero; i++)
{
    for(int j = 1;j<=10; j++)
    {
        Console.WriteLine(i+" x "+j+" = "+j*i);
    }
}