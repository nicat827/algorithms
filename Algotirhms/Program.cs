
static void LinearSearch()
{
    int[] numbers = { -5, 222, 33, 44, 5, -40 };
    int searchNumber = -401;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] ==  searchNumber)
        {
            Console.WriteLine("finded");
            break;
        }
    }
}


static void BinarySearch()
{
    int[] numbers = { 10, 20, 34, 35, 44, 67, -5, -4, 100 };
    int lowIndex = numbers[0];
    int highIndex = numbers[numbers.Length - 1];
    int midIndex = (lowIndex + highIndex) / 2;
    int num = 10;
    while (numbers[midIndex] != num)
    {
        if (numbers[midIndex] > num)
        {
            highIndex = midIndex - 1;
        }
        else
        {
            lowIndex = midIndex + 1;
        }
        midIndex = (highIndex + lowIndex) / 2;
    }

    Console.WriteLine(midIndex);
}


static void BubleSorting()
{
    int[] numbers = { 10, 20, 4, 35, 44, 67, -5, -4, 100 };
    // for doing it massive length times (massivin uzunlugu qeder ikinci foru tekrarlamag tekrarlamag)
    for (int i = 0; i < numbers.Length; i++)
    {
        // for compare the numbers in massive (iki qonsu reqemleri compare eleyir)
        for (int j = 0; j < numbers.Length -1 -i; j++)
        {
            if (numbers[j] > numbers[j+1])
            {
                int temp = numbers[j];
                numbers[j] = numbers[j+1];
                numbers[j+1] = temp;
            }
            
        }
            
    }

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}


static void InsertionSorting()
{
    int[] numbers = { 10, 20, 4, 35, 44, 67, -5, -4, 100 };
    for (int i = 0; i < numbers.Length - 1; i ++)
    {
        
        for (int j = i; j >= 0 && numbers[j+1] < numbers[j]; j--)
        {
   
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }

    foreach (int i in numbers)
    {
        Console.WriteLine(i);
    }

}


static void JumpSearching()
{
    

    int[] numbers = { 10, 20, 34, 35, 44, 67, 85, 93, 100,2,6,4,5 };
    int num = 10;
    int search;
    int m = (int)(Math.Sqrt(numbers.Length));
    int low = 0;
    int high = m - 1;

    while (num < numbers[low] || num > numbers[high]) {
        low += m;
        high += m;
        if (numbers.Length -1 < high) high = numbers.Length - 1;
    }

    if (num == numbers[high])
    {
        search = high;
    }
    else if (num == numbers[low])
    {
        search = low;
    }
    else
    {
        while (low != num) low++;
        search = low;
    }




    Console.WriteLine(search);

}

static void FibonacciSearching()
{
    int[] numbers = { 1, 4,5 };
    int find = 5;
    int f0 = 0;
    int f1 = 1;
    int f2 = 1;
    int pos = -1;

    while (f2 < numbers.Length)
    {
        f0 = f1;
        f1 = f2;
        f2 = f1 + f0;
    }

    int start = -1;
    while (f2 > 1)
    {
        int index = Math.Min(start + f0, numbers.Length - 1);

        if (numbers[index] < find)
        {
            f2 = f1;
            f1 = f0;
            f0 = f2 - f1;
            start = index;
        }

        else if (numbers[index] > find)
        {
            // 0 1 1 2 3 5
            f2 = f0;
            f1 = f1 - f0;
            f0 = f2 - f1;

        }

        else
        {
            pos = index;
            break;
        }
    }

    if (f1 == 1 && numbers[numbers.Length - 1] == find)
    {
        Console.WriteLine(176);
        pos = numbers.Length - 1;
    }

    if (pos > -1)
        Console.Write("Element found at position : " + pos);
    else
        Console.Write("Element not found");

}
 