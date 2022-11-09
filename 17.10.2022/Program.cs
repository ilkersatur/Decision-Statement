/*
Console.WriteLine("merhaba dünya ");                                                cw tab + tab
Console.Write("\n\nmerhaba dünya\n ");                                             \n satır atlama

Console.ReadLine();

Console.ReadKey();
*/

//                                                                           operatörler     
// değişken tanımlama                                                     = atama,  == eşittir
//                                                       operatörün operantları(iki taraf) aynı tip olmak zorundadır!                                                             
/*string ad=Console.ReadLine();
Console.WriteLine(ad);

int sayi = Convert.ToInt16(Console.Read());                                          // tip dönüşümleri                                                             // .parse, .convert, cast

atama operatörleri
     =,  +=, -=,  *=,  /=
    
    aritmetik ope.
     +,  -*,   /, %,   i++,   i--,   --i,   ++i

    karşılaştırma ope.
     ==,!=,>,<,>=,<=

    matıksal ope.
     &&, ||, !

4+5 çift operant, i++ tek operant*/
//int + - 2 milyar

//int sayi = int.Parse(Console.ReadLine());


int sayi=int.Parse(Console.ReadLine());
if (sayi % 2 == 0)
    Console.WriteLine("Çift sayı");
else 
    Console.WriteLine("Sayı tek"); 
