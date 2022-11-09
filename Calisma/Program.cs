// kullanıcının girdiği 2 tam sayı toplama 
Console.Write("1. sayıyı giriniz= ");
int sayi1 = Convert.ToInt16(Console.ReadLine());
Console.Write("2. sayıyı giriniz= ");
int sayi2 = Convert.ToInt16(Console.ReadLine());
int toplam = sayi1 + sayi2;

// Console.WriteLine("Toplam = " + (toplam));
Console.WriteLine("Sonuc={0}", toplam);
//Console.WriteLine($"Sonuc={ toplam}");
Console.WriteLine("{0} ile {1} toplamı = {2}", sayi1, sayi2, toplam);
Console.WriteLine($"{sayi1} ile {sayi2} toplamı = {toplam}");


if (toplam % 2 == 0)
{
    Console.WriteLine("Çift sayı");
}
else { Console.WriteLine("Sayı tek"); }

//console.writeline(4%2) sonuç 1