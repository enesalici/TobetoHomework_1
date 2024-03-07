//2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak
//toplam alışveriş tutarını hesaplayan bir algoritma yazınız.

Console.WriteLine("Kaç adet ürün istiyorsunuz");
Console.WriteLine();
int val = Convert.ToInt32(Console.ReadLine());
double total = 0;


for(int i = 0; i<val; i++)
{
    Console.WriteLine("fiyat girin");
    
    double price = Convert.ToDouble(Console.ReadLine());
    total = total + price;
}
Console.WriteLine("toplam fiyat" + " : "+ total);