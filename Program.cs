// See https://aka.ms/new-console-template for more information

int[] numeri = { 2, 6, 7, 5, 3, 9 };

StampaArray(numeri);








//FUNZIONI

//Funzione lettura Array

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(numeri[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}