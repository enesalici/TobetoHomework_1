

//  3 - Do - While ve While döngüsü nedir? Bununla ilgili örnek yapınız.


long count = 0;
string text = "Do while içerisindeki kod bloğu istenen durum (count <= 100) yerine getirilene kadar çalıştırılır ";

do
{
    Console.WriteLine(text + " : " + count);
    count++;
}
while (count <= 100);

Console.ReadLine();