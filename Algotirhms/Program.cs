
static void LinearSearch()
{
    int[] numbers = { -5, 222, 33, 44, 5, -40 };
    int searchNumber = -401; // axtardigimiz reqem
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] ==  searchNumber) // massivin her bir elementi yoxlanilir , ve if true verdiyi halda reqem tapilir, ve dovr stoplanir
        {
            Console.WriteLine("finded");
            break;
        }
    }
}


static void BinarySearch()
{
    int[] numbers = { 10, 20, 34, 35, 44, 67, -5, -4, 100 };
    
    int lowIndex = numbers[0]; // minimal index
    int highIndex = numbers[numbers.Length - 1]; // maximal index
    int midIndex = (lowIndex + highIndex) / 2; // arrayin orta indeksi

    int num = 10; // axtardigimiz reqem

    
    while (numbers[midIndex] != num)
    {
        if (numbers[midIndex] > num) // numbers arrayinin ortadaki elementi axtardigimiz reqemnnen boyukdurse, demeli reqem sol terefdedi
        {
            highIndex = midIndex - 1; //  arrayi sol terefe cekib axtaririg, low ele 0 qalir, high ise midden bir eded balaca( -1 mid indeksin yoxlandigin bildirir, ve bir daha bunu yoxlamaga ehtiyyac yoxdur)
        }
        else // if isdemese demeli axtardigimiz reqem sag terefdedir
        {
            lowIndex = midIndex + 1; // arrayi saga cekirik
        }
        midIndex = (highIndex + lowIndex) / 2; // saga cekdiyimiz arrayin orta indeksin tapib, dovru tekrarlayirig , reqem tapilana kimi
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
        // meselen birinci sefer 10 ile 20 ni muqaise edir, sonra 20 ile 4, gorur ki 4 balacadir 20 den, yerlerin deyisdirir, ve kecir 20 ile 35 - e,
        // bununla deye bilerik ki ikinci for dongusu birinci defe isleyende, max numberi en saga cekecek.
        for (int j = 0; j < numbers.Length -1 -i; j++) // burda ki -i gosterir ki massivin axirdan yoxlamaga ehtiyyac yoxdur, cunki dediyim kimi max numberleri saga cekir for
        {
            if (numbers[j] > numbers[j+1])
            {   
                // ededleri yerin deyisen kod
                int temp = numbers[j]; // vaxt deyiseni
                numbers[j] = numbers[j+1];
                numbers[j+1] = temp;
            }
            
        }
            
    }
    // sort elediyimiz arrayi konsola yazmag
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
        // bu for iki reqemi muqaise edir meselen (1-ci defe: j=0, eyer ikinci reqem birinciden kicikdirse onu saga cekir ve yene muqaise edir
        // deye bilerik ki birinci sefer en minimal reqem en birinci olacag. 
        for (int j = i; j >= 0 && numbers[j+1] < numbers[j]; j--)
        {
   
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }

    // sorted arrayi consola yazir
    foreach (int i in numbers)
    {
        Console.WriteLine(i);
    }

}


static void JumpSearching()
{
    

    int[] numbers = { 10, 20, 34, 35, 44, 67, 85, 93, 100,2,6,4,5 };
    int num = 10; // axtardigimiz reqem
    int search; // axtardigimiz reqemin (tapilsa eyer) indeksi
    int m = (int)(Math.Sqrt(numbers.Length)); // step sayi
    int low = 0; // low indeks
    int high = m - 1; // high indeks
    // birinci while reqemimizin hansi diapazon oldugunu tapir ( low < n < high)
    while (num < numbers[low] || num > numbers[high]) {
        low += m;
        high += m;
        if (numbers.Length -1 < high) high = numbers.Length - 1; // eyer highIndeks arrayin uzunlugun kecerse bu kod error gormemeyimiz ucun onu maxIndeks eder
    }
    // eyer axtardigimiz reqem arrayin axrinci reqemine beraberdise
    if (num == numbers[high])
    {
        search = high;
    }
    // eyer lowa beraberdirse
    else if (num == numbers[low])
    {
        search = low;
    }
    // eyer hec birine beraber deyilse, low-u bir bir artira artira gedirik 
    else
    {
        while (low != num) low++;
        // reqem tapildi
        search = low;
    }




    Console.WriteLine(search);

}



static void FibonacciSearching()
{
    int[] numbers = { 1, 4,5, 10,100 };
    int find = 10; // axtardigimiz reqem
    int f0 = 0; // fibonaccinin birinci reqemi
    int f1 = 1; // ikinci reqemi
    int f2 = 1; // toplusu (3 reqemi)
    int pos = -1; // axtardigimiz reqemin indeksi ( evvelce -1, sonra deyisecek)

    // birinci biz arrayin uzunluquna beraber ve ya onnan yeke bir fibonacci ededi tapmaliyig
    // bu while o ededi tapir
    
    while (f2 < numbers.Length)
    {
        f0 = f1;
        f1 = f2;
        f2 = f1 + f0;
    }
    // start deyiseni indeks tapmag ucun lazimdir
    int start = -1;
    // tapdigimiz fibonacci ededi bir bir azalacag
    while (f2 > 1)

    {   
        // indeksin tapilmasi
        int index = Math.Min(start + f0, numbers.Length - 1);
        
        if (numbers[index] < find) // eyer axtardigimiz reqem arrayin index-deki reqemnen boyukdurse, fibonacci ededin azaldirig
        {
            f2 = f1;
            f1 = f0;
            f0 = f2 - f1;
            start = index; 
        }

        else if (numbers[index] > find) // eyer axtardigimiz reqem arrayin index-deki reqemnen balacadirsa, fibonacci ededin iki defe azaldirig ve starti deyismirik
        {
            // 0 1 1 2 3 5
            f2 = f0;
            f1 = f1 - f0;
            f0 = f2 - f1;

        }
        // eyer beraberdise , demeli reqemi tapmisig
        else
        {
            // hemin o pos deyisenine indexi qoyurug ve break edib cixirig
            pos = index;
            break;
        }
    }

    if (f1 == 1 && numbers[numbers.Length - 1] == find) // bu if axrinci reqemi tapmag lazim olduqda isleyir, cunki while-nin icinde else bloku islemir
    {
        Console.WriteLine(176);
        pos = numbers.Length - 1;
    }

    if (pos > -1)
        Console.Write("Element found at position : " + pos);
    else
        Console.Write("Element not found");

}
