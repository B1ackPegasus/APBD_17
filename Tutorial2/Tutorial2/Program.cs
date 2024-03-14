static double CalculateAverage(int[] arr)
{
    
    double sum = 0;
    for (int i =0 ;i<arr.Length;i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}

int[] numbers = { 1, 2, 3, 4 };
double avarage = CalculateAverage(numbers);
Console.WriteLine(avarage);
