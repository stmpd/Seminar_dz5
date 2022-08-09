// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble (int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * 100; 
        arr[i] = Math.Round(arr[i], 1);
    }
    return arr;
}

double GetMaxNumber (double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double GetMinNumber (double[] array)
{
    double min = 100;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

double[] array = CreateArrayRndDouble(5);
PrintArray(array);
double maxRes = GetMaxNumber(array);
double minRes = GetMinNumber(array);

double result = maxRes - minRes;
result = Math.Round(result, 1);

Console.Write($" >>> {result}");