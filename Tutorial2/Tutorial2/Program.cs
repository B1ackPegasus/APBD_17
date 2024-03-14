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
Console.WriteLine("Avarage number: "+avarage);

static int MaxNumber(int[] arr)
{
    int number = arr[0];

    for (int k = 1; k < arr.Length; k++)
    {
        if (arr[k] > number)
        {
            number = arr[k];
            
        }
    }

    return number;
}
int maxNumber = MaxNumber(numbers);
Console.WriteLine("Max number: "+maxNumber);