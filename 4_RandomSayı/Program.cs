// 4-Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve
// doğru tahmin edene kadar devam eden bir program yazınız
// .(While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)



Console.Write("1 ile 10 arasında sayı giriniz: ");
int guess = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int randomNum = random.Next(1, 10);

while(true)
{
    if (guess == randomNum)
    {
        Console.WriteLine("doğru tahmin");
        break;
    }
    else
    {
        Console.WriteLine("yanlış, yeni sayı gir");
        guess = Convert.ToInt32(Console.ReadLine());
    }
}
