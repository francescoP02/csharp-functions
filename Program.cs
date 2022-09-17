// See https://aka.ms/new-console-template for more information

int[] numbers = { 2, 6, 7, 5, 3, 9 };

Console.WriteLine("Ecco la lista di numeri");

StampaArray(numbers);

int[] numbers2 = ElevaArrayAlQuadrato(numbers);

Console.WriteLine();

Console.WriteLine("Ecco la lista di numeri elevato al quadrato");

StampaArray(numbers2);

Console.WriteLine();

Console.WriteLine("Ecco la lista di controllo dei numeri non elevati al quadrato");

StampaArray(numbers);




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