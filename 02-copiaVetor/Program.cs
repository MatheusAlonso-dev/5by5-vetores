int n = 5;
int[] vetor1 = new int[n];
int[] vetor2 = new int[n];
int[] vetor3 = new int[n];
int[] vetor4 = new int[n];
int opcao = 0;

Console.WriteLine("\tCOPIA VETOR\n");

void popularVetores()
{
    int contVet3 = 0;
    int contVet4 = 0;

    for (int i = 0; i < n; i++)
    {
        vetor3[i] = 0;
        vetor4[i] = 0;
    }

    for (int i = 0; i < n; i++)
    {
        Console.Write($"digite o {i + 1}º item(INTEIRO): ");
        vetor1[i] = int.Parse(Console.ReadLine());

        if (vetor1[i] % 2 == 0)
        {
            vetor3[contVet3] = vetor1[i];
            contVet3++;
        }
        else
        {
            vetor4[contVet4] = vetor1[i];
            contVet4++;
        }
    }

    int j = 0;
    for (int i = n-1; i >= 0; i--)
    {        
        vetor2[j] = vetor1[i];
        j++;
    }
}

void imprimirVetores()
{
    Console.Write("\n\nvetor 1 --->\t");
    for (int i = 0; i < n; i++)
    {
        Console.Write(vetor1[i] + " ");
    }

    Console.Write("\n\nvetor 2 --->\t");
    for (int i = 0; i < n; i++)
    {
        Console.Write(vetor2[i] + " ");
    }

    Console.Write("\n\nvetor 3 --->\t");
    for (int i = 0; i < n; i++)
    {
        Console.Write(vetor3[i] + " ");
    }

    Console.Write("\n\nvetor 4 --->\t");
    for (int i = 0; i < n; i++)
    {
        Console.Write(vetor4[i] + " ");
    }
}

do
{
    Console.WriteLine("\n\n******** MENU DE OPÇÕES********\n\t[1] popular vetor\n\t[2] imprimir vetor\n\t[3] imprimir vetor inverso\n\t[4] sair");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");

    switch (opcao)
    {
        case 1:
            popularVetores();
            break;
        case 2:
            imprimirVetores();
            break;
        case 3:
            break;
        case 4:
            break;
        default: break;

    }

} while (opcao != 4);

Console.WriteLine("saindo do programa...");