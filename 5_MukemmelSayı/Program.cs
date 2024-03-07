//5- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

Console.WriteLine("Mükemmel sayı controlcüsü, Sayı giriniz:");
double perfectNumber = Convert.ToDouble(Console.ReadLine());
double temp = 0;


    for (int i = 1; i < perfectNumber; i++)
    {
        if (perfectNumber % i == 0)
        {
            temp = temp + i;
        }

    }
    if (temp == perfectNumber)
    {
        Console.WriteLine("bu bir mükemmel sayıdır");

    }
    else
    {
        Console.WriteLine("bu bir mükemmel sayı değildir");
    }


