// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
int[] randomArray = RandomArray(10, 1, 100);
ShowArray(randomArray);
Console.WriteLine();
int sum = 0;
for (int i = 1; i < randomArray.Length; i+=2)
    {
        sum += randomArray[i];
    }
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");