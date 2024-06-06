// Exercício 4:

int ex = 0;
int inicial = 0;
int final = 0;
int quantidadea = 0;
int quantidadeb = 0;
int quantidadec = 0;
int quantidaded = 0;
double mediaa = 0.00;
double mediab = 0.00;
double mediac = 0.00;
double mediad = 0.00;
double somaa = 0.00;
double somab = 0.00;
double somac = 0.00;
double somad = 0.00;

Console.WriteLine("Digite o número inicial: ");
inicial = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número final: ");
final = int.Parse(Console.ReadLine());

do
{
        Console.WriteLine("Qual exercício deseja exercutar?");
        Console.WriteLine("1. letra a");
        Console.WriteLine("2. letra b");
        Console.WriteLine("3. letra c");
        Console.WriteLine("4. letra d");
        Console.WriteLine("5. letra e");
        Console.WriteLine("0. sair");
        ex = int.Parse(Console.ReadLine());
            
        switch (ex)
        {
            case 1:
            Console.WriteLine("Números inteiros positivos:");
            for (int i = inicial; i <= final; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                    quantidadea++;
                    somaa = somaa + i;
                    mediaa = somaa / quantidadea;
                }

            }
            Console.WriteLine("A quantidade de números inteiros positivos é: " + quantidadea);

            break;

            case 2:
            Console.WriteLine("Números pares:");
            for (int i = inicial; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    quantidadeb++;
                    somab = somab + i;
                    mediab = somab / quantidadeb;
                }
            }
            Console.WriteLine("A quantidade de números pares é: " + quantidadeb);


            break;

            case 3:
            Console.WriteLine("Números ímpares:");
            for (int i = inicial; i <= final; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    quantidadec++;
                    somac = somac + i;
                    mediac = somac / quantidadec;
                }
            }
            Console.WriteLine("A quantidade de números ímpares é: " + quantidadec);

            break;

            case 4:
            Console.WriteLine("Números impares e divisíveis por 3 e 7:");
            for (int i = inicial; i <= final; i++)
            {
                if (i%2!=0 && i%3==0 && i%7==0)
                {
                    Console.WriteLine(i);
                    quantidaded++;
                    somad = somad + i;
                    mediad = somad / quantidaded;
                }
            }
            Console.WriteLine("A quantidade de números impares e divisíveis por 3 e 7 é: " + quantidaded);

            break;

            case 5:

            Console.WriteLine("Média letra a: " + mediaa);
            Console.WriteLine("Média letra b: " + mediab);
            Console.WriteLine("Média letra c: " + mediac);
            Console.WriteLine("Média letra d: " + mediad);

            break;

            default:
                break;

        }

} while (ex != 0);