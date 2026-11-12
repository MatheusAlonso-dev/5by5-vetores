int n;
int num1 = 0;
int num2 = 1;
int result = 0;

Console.WriteLine("\tFIBONACCI DINAMICA\n");

Console.Write("\ndigite um tamanho: ");
n = int.Parse(Console.ReadLine());

int[] vetor = new int[n];

for (int i = 0; i < n; i++)
{
    vetor[i] = num1;
    result = num1 + num2;
    num1 = num2;
    num2 = result;
}

Console.Write("\n\t");
for (int i = 0; i < n; i++)
{
    Console.Write(vetor[i] + " ");
}