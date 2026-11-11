int[] numbers = new int[4];
int contador = 0;

void popularVetor()
{
    contador = 0;
    do
    {
        //Console.WriteLine("Informe o numero desejado na posição " + contador);
        Console.WriteLine($"Informe o numero desejado da posição {contador}");
        numbers[contador] = int.Parse(Console.ReadLine());
        contador++;

    } while (contador < numbers.Length);
}

void mostrarVetor()
{
    contador = 0;
    while (contador < numbers.Length)
    {
        Console.WriteLine($"[{numbers[contador]}]");
        contador++;
    }
}

popularVetor();
mostrarVetor();