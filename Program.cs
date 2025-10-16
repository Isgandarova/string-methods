using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using Microsoft.VisualBasic;

class Program
{

    //task 1
    // static string IstifadeciAdi()
    // {
    //     Console.Write("Adinizi daxil edin: ");
    //     string name = Console.ReadLine();
    //     return name;
    // }


    //task2
    // static void CumledeSozAxtar()
    // {
    //     Console.Write("Cümlə: ");
    //     string cumle = Console.ReadLine();

    //     Console.Write("Axtarilan söz: ");
    //     string soz = Console.ReadLine();

    //     if (cumle.Contains(soz))
    //         Console.WriteLine("Tapldi");
    //     else
    //         Console.WriteLine("Taplmadi");
    // }


    /// task 3
    // static void sozuyoxla()
    // {
    //     Console.Write("soz:");
    //     string soz = Console.ReadLine();
    //     if (soz.StartsWith("Di"))
    //         Console.WriteLine("Söz 'Di' ilə başlayr.");
    //     else
    //         Console.WriteLine("Söz 'Di' ilə başlamr.");

    //     if (soz.EndsWith("eva"))
    //         Console.WriteLine("Söz 'eva' ilə bitir.");
    //     else
    //         Console.WriteLine("Söz 'eva' ilə bitmir.");
    // }


    ///task 4
    // static void herfideyis()
    //         {
    //         Console.Write("soz:");
    //         string soz = Console.ReadLine();
    //         Console.WriteLine("soz".Replace("a", "e"));
    ///}

    ///task5

    // static void herfiyazdir()
    //     {
    //         Console.Write("Soz: ");
    //         Console.WriteLine(Console.ReadLine().Substring(0, 3));
    //     }

    ///Task 6
    // static void BosluqSil()
    //     {
    //         Console.Write("Mətn: ");
    //         Console.WriteLine(Console.ReadLine().Trim());
    //     }



    ///task 7
    //  static void CumleniBol()
    //     {
    //         string cumle = "Proqramlaşdirma, düşünməyi, öyrədir.";

    //         foreach (string hisse in cumle.Split(','))
    //             Console.WriteLine(hisse.Trim());
    //     }



    ///task 8

    // static void AdlariBirlestir()
    //     {
    //         string[] adlar = { "Aylin", "Murad", "Aynur", "Leyla", "Aypara", "Elnar" };
    //         Console.WriteLine(string.Join("-", adlar));
    //     }



///task 10
static void SozleriYoxla()
    {
        Console.Write("Birinci söz: ");
        string soz1 = Console.ReadLine();

        Console.Write("İkinci söz: ");
        string soz2 = Console.ReadLine();

        if (soz1 == soz2)
            Console.WriteLine("Eynidir");
        else
            Console.WriteLine("Fərqlidir");
    }



    static void Main(string[] args)
    {

SozleriYoxla();







        ///task 8
        // AdlariBirlestir();







        ///task7
        // CumleniBol();



        // task 6
        // BosluqSil();





        /// task 5
        // herfiyazdir();



        /// task 4

        // herfideyis();





        ///task 3
        // sozuyoxla();



        ///task2
        // CumledeSozAxtar();


        //task 1
        // string ad = IstifadeciAdi();
        // Console.WriteLine(ad.ToUpper());
        // Console.WriteLine(ad.ToLower());
    }
}