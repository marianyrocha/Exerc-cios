// Exercício 9

int candidatos = 0;

int sexo = 0;
int feminino = 0;
int masculino = 0;

int idade  = 0;
int idadem  = 0;
int idadeh  = 0;

int experiencia = 0;
int experienciam = 0;
int experienciah = 0;

int ensino = 0;
int ensinof = 0;
int ensinom = 0;
int ensinos = 0;
int ensinopg = 0;

double mediah = 0.00;
double mediam = 0.00;
int porcentagem = 0;
int menor = 0;

do
{
    Console.WriteLine("Qual o sexo do candidato?");
    Console.WriteLine("1. feminino");
    Console.WriteLine("2. masculino");
    sexo = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual o idade do candidato?");
    idade = int.Parse(Console.ReadLine());

    Console.WriteLine("O candidato possui experiência profissional?");
    Console.WriteLine("1. sim");
    Console.WriteLine("2. não");
    experiencia = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual a escolaridade do candidato?");
    Console.WriteLine("1. Ensino Fundamental");
    Console.WriteLine("2. Ensino Médio");
    Console.WriteLine("3. Ensino Superior");
    Console.WriteLine("4. Pós-Graduação");
    ensino = int.Parse(Console.ReadLine());

    Console.WriteLine("Deseja cadastrar outro candidato?");
    Console.WriteLine("1. sim");
    Console.WriteLine("2. não");
    candidatos = int.Parse(Console.ReadLine());

    if (sexo == 1)
    {
        feminino++;
    }

    if (sexo == 2)
    {
        masculino++;
    }

    if (sexo == 2 && experiencia == 1)
    {
        experienciah++;
        idadeh = idadeh + idade;
        mediah = idadeh / experienciah;
    }

    if (sexo == 1 && experiencia == 1)
    {
        experienciam++;

        idadem = idadem + idade;
        mediam = (idadem / experienciam);
    }

    if (sexo == 2 && idade >= 35 && idade <= 45)
    {
        porcentagem++;
        porcentagem = (porcentagem * 100)/masculino;
    }

    if (sexo == 1 && experiencia == 1)
    {
        
        if (menor == 0)
        {
            menor = idade;
        }
        if (idade < menor)
        {
            menor = idade;
        }
           
    }

    if (ensino == 1)
    {
        ensinof++;
    }
    else
    {
        if (ensino == 2)
        {
            ensinom++;
        }
        else
        {
            if (ensino == 3)
            {
                ensinos++;
            }
            else
            {
                ensinopg++;
            }
        }

    }


} while (candidatos != 2);


Console.WriteLine("- O número de candidatos do sexo femnino." + feminino);
Console.WriteLine("- O número de candidatos do sexo masculino: " + masculino);
Console.WriteLine("- A idade média dos homens com experiência." + mediah);
Console.WriteLine("- A idade média das mulheres com experiência." + mediam);
Console.WriteLine("- A porcentagem dos homens entre 35 e 45 anos, entre o total dos homens: " + porcentagem + "%");
Console.WriteLine("- A menor idade entre as mulheres que já tem experiência no serviço: " + menor);
Console.WriteLine("- O nivel de escolaridade dos candidatos: ");
Console.WriteLine("  - Ensino Fundamental: "+ensinof);
Console.WriteLine("  - Ensino Médio: "+ensinom);
Console.WriteLine("  - Ensino Superior: "+ensinos);
Console.WriteLine("  - Pós-Graduação: "+ensinopg);

