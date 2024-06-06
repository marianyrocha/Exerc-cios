// Exercício 2:

int exercicios = 0;
int alturap = 150;
int altural = 110;
int anos = 0;

do
{
    Console.WriteLine("Qual exercício deseja verificar?");
    Console.WriteLine("1. letra a;");
    Console.WriteLine("2. letra b;");
    Console.WriteLine("0. sair.");
    exercicios = int.Parse(Console.ReadLine());

    switch (exercicios)
    {
        case 1:
            do
            {
                alturap += 2;
                altural += 3;
                anos++;

            } while (alturap != altural);
            Console.WriteLine("Serão necessários " + anos + " anos para que Lucas e Pedro tenham o mesmo tamanho. ");

            break;

        case 2:
            do
            {
                alturap += 2;
                altural += 3;
                anos++;

            } while (altural <= alturap);
            Console.WriteLine("Serão necessários " + anos + " anos para Lucas ser maior que Pedro.");

            break;

        default:
            break;
    }

} while (exercicios != 0); 