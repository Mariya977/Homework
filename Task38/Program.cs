// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

int max = randomArray[0];
for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] > max)
    max = randomArray[i];
}
int min = randomArray[0];
for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] < min)
    min = randomArray[i];
}
int diff = max - min;
Console.WriteLine($"Разница между максимальным числом [{max}] и минимальным числом [{min}] = {diff}");