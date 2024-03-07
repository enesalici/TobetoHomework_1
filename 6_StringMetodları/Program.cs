// 6- String metotlarını araştırınız. Her bir metot için örnek yapınız.



string str = "Merhaba!";
int uzunluk = str.Length;
Console.WriteLine("Uzunluk: " + uzunluk);
//________________________________________________________
string buyukHarf = str.ToUpper();
string kucukHarf = str.ToLower();
Console.WriteLine("Büyük Harf: " + buyukHarf);
Console.WriteLine("Küçük Harf: " + kucukHarf);
//________________________________________________________
string altDize = str.Substring(0, 3);
Console.WriteLine("Alt Dize: " + altDize);
//________________________________________________________
int index = str.IndexOf('a');
int lastIndex = str.LastIndexOf('a');
Console.WriteLine("İlk 'a' İndeks: " + index);
Console.WriteLine("Son 'a' İndeks: " + lastIndex);
//________________________________________________________
string yeniStr = str.Replace('a', 'e');
Console.WriteLine("Değiştirilmiş String: " + yeniStr);
//________________________________________________________
string bosluksuz = "   Merhaba dünya   ".Trim();
Console.WriteLine("Boşluksuz: " + bosluksuz);
//________________________________________________________
string cumle = "Bu bir örnek cümledir.";
string[] kelimeler = cumle.Split(' ');
foreach (var kelime in kelimeler)
{
    Console.WriteLine("Kelime: " + kelime);
}
//________________________________________________________
