// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");


int[] array = new int[6];

int length = 0;

for(int x =0; x < 3; x++)
{
    array[length] = x;
    length++;
    Console.WriteLine(length);
}

Console.ReadKey();


