// koşul ifadeleri - karar yapıları - koşul 
// 1- if else  --------> ? : if in kısa gösterimi
// 2- switch-case
// toInt32 = int  ------ toInt16 = short
/*
Console.WriteLine(3<4); //true
Console.WriteLine(4 < 4); //false
*/

int sayi =int.Parse(Console.ReadLine());

if (sayi == 50)                           // tek satır var ise süslü parantez koymak zorunda değiliz
    Console.WriteLine($"sayı {sayi}");
else if (sayi < 50)
    Console.WriteLine($"{sayi} 50'den küçük");
else if (sayi > 50)
    Console.WriteLine($"{sayi} 50'den büyük");
else 
    Console.WriteLine($"{sayi} 50'dan farklı"); 
}
