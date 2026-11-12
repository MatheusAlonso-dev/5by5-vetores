int n = 6;
int[] numbers = new int[n];
int opcao = 0;

Console.WriteLine("\tVETOR INVERSO\n");

void popularVetor() {
    for (int i = 0; i < n; i++) {
        Console.Write($"digite o {i+1}º item(INTEIRO): ");
        numbers[i] = int.Parse(Console.ReadLine());
    }
}

void imprimirVetor()
{
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine("\t" +numbers[i]);
    }
}
void imprimirVetorInverso()
{
    for (int i = n-1; i >= 0; i--)
    {
        Console.WriteLine("\t" + numbers[i]);
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
            popularVetor();
            break;
        case 2:
            imprimirVetor();
            break;
        case 3:
            imprimirVetorInverso();
            break;
        case 4:
            break;
        default:break;

    }

} while (opcao != 4);

Console.WriteLine("saindo do programa...");