// See https://aka.ms/new-console-template for more information

Console.WriteLine("Quanti numeri vuoi inserire?");

int answer = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[answer];

for (int i = 0; i < answer; i++)
{
    Console.WriteLine($"Inserisci un numero: ({(answer - i)} rimanenti)");

    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Ecco la lista di numeri");

StampaArray(numbers);

int[] numbers2 = ElevaArrayAlQuadrato(numbers);

Console.WriteLine();

Console.WriteLine("Ecco la lista di numeri elevato al quadrato");

StampaArray(numbers2);

Console.WriteLine();

Console.WriteLine("Ecco la lista di controllo dei numeri non elevati al quadrato");

StampaArray(numbers);

Console.WriteLine();

int somma = sommaElementiArray(numbers);

Console.WriteLine($"Somma lista di numeri: {somma}");

int somma2 = sommaElementiArray(numbers2);

Console.WriteLine($"Somma lista di numeri: {somma2}");




//FUNZIONI

//Funzione lettura Array

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

//Funzione elevazione a potenza

int Quadrato(int numero)
{

    return numero * numero;
}

//Funzione creazione array con numeri elevati al quadrato

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] squared = new int[array.Length];

    array.CopyTo(squared, 0);

    for (int i = 0; i < squared.Length; i++)
    {
        squared[i] = Quadrato(array[i]);
    }

    return squared;
}

//Funzione creazione array con somma numeri

int sommaElementiArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum;
}