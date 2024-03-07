// 1 - Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün
// sipariş edildiğini belirleyen algoritma yazınız.Input için Scanner kullanınız


Product product1 = new Product { Id = 1, Name = "Elma", Price = 10 };
Product product2 = new Product { Id = 2, Name = "Kavun", Price = 20 };
Product product3 = new Product { Id = 3, Name = "Karpuz", Price = 30 };
Product product4 = new Product { Id = 4, Name = "Su", Price = 40 };

Console.WriteLine("------ Ürünler ------");
Console.WriteLine("1." + product1.Name + " " + product1.Price + " USD");
Console.WriteLine("2." + product2.Name + " " + product2.Price + " USD");
Console.WriteLine("3." + product3.Name + " " + product3.Price + " USD");
Console.WriteLine("4." + product4.Name + " " + product4.Price + " USD");

Console.WriteLine("_________________________");
Console.WriteLine("Sipariş numarasını giriniz: ");
string orderNumber = Console.ReadLine()!;


switch (orderNumber)
{
    case "1":
        Console.WriteLine("Sipariş başarıyla bulundu! ÜRÜN: " + product1.Name + " FİYAT: " + product1.Price + " USD");
        break;
    case "2":
        Console.WriteLine("Sipariş başarıyla bulundu! ÜRÜN: " + product2.Name + " FİYAT: " + product2.Price + " USD");
        break;
    case "3":
        Console.WriteLine("Sipariş başarıyla bulundu! ÜRÜN: " + product3.Name + " FİYAT: " + product3.Price + " USD");
        break;
    case "4":
        Console.WriteLine("Sipariş başarıyla bulundu! ÜRÜN: " + product4.Name + " FİYAT: " + product4.Price + " USD");
        break;
    default:
        Console.WriteLine("Sipariş bulunamadı.");
        break;

}


class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Price { get; set; }
}