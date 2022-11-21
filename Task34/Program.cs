// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] RandomArray(int N, int start, int end)
{
    {
        int[] RandomArray = new int[N];
        for (int i = 0; i < N; i++)
        {
            RandomArray[i] = new Random().Next(start, end + 1);
        }
        return RandomArray;
    }
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



Console.Clear();
int[] randomArray = RandomArray(20, 100, 999);
ShowArray(randomArray);
Console.WriteLine();
int evennums = 0;
for (int i = 0; i <randomArray.Length; i++)
{
    if (randomArray[i] % 2 == 0)
    evennums += 1;
}

Console.WriteLine($"Сумма чётных чисел в массиве = {evennums}");