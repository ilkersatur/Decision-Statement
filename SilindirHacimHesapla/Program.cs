// silindirin hacmi
using System.IO;

    Console.Write("yarıcap= ");
    int yarıcap = Convert.ToInt16(Console.ReadLine());
    Console.Write("yükseklik= ");
    int yükseklik = Convert.ToInt16(Console.ReadLine());

    double hacim = (Math.PI) * (yarıcap) * (yarıcap) * (yükseklik);

    Console.WriteLine($"yarıçapı {yarıcap} olan yüksekliği {yükseklik} olan silindirin hacmi = {hacim}");