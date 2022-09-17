// See https://aka.ms/new-console-template for more information

int[] numbers = { 2, 6, 7, 5, 3, 9 };
int[] numbers2 = new int[numbers.Length];

Console.WriteLine("Ecco la lista degli array");
StampaArray(numbers);







//FUNZIONI

//Funzione lettura Array

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(numbers[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}


int Quadrato(int numero)
{

    return numero * numero;
}