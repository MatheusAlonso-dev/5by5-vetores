int n = 10;
char[] vetor1 = new char[n];
object[] vetor2 = new object[n*2];
int opcao = 0;
char auxiliar;
int contadorVetor2 = 0;

Console.WriteLine("\tASCII\n");

void popularVetores()
{
    contadorVetor2 = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"digite o {i + 1}º item(CHAR): ");
        auxiliar = char.Parse(Console.ReadLine());
        vetor1[i] = auxiliar;

        vetor2[contadorVetor2] = vetor1[i];
        contadorVetor2++;
        vetor2[contadorVetor2] = (int)auxiliar;
        contadorVetor2++;
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
    for (int i = 0; i < n*2; i++)
    {
        Console.Write(vetor2[i] + " ");
    }
}

do
{
    Console.WriteLine("\n\n******** MENU DE OPÇÕES********\n\t[1] popular vetores\n\t[2] imprimir vetores\n\t[3] sair");
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
        default: break;
    }

} while (opcao != 3);

Console.WriteLine("saindo do programa...");