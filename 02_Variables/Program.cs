using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            ////double number;

            ////number = 4.85;

            ////Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;

            //orangePrice = 20.95;

            //strawberryPrice = 45;

            //potatoPrice = 9.74;

            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice + " TL"); 
            //Console.WriteLine("---- Portakal Birim Fiyatı :" + orangePrice + " TL"); 
            //Console.WriteLine("---- Çilek Birim Fiyatı :" + strawberryPrice + " TL"); 
            //Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice + " TL"); 
            //Console.WriteLine("---- Domates Birim Fiyatı :" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotal, orangeTotal, strawberryTotal, potatoTotal, tomatoTotal;

            //double Total;

            //appleTotal = appleGram * applePrice;

            //orangeTotal = orangeGram * orangePrice;

            //strawberryTotal = strawberryGram * strawberryPrice;

            //potatoTotal = potatoGram * potatoPrice;

            //tomatoTotal = tomatoGram * tomatoPrice;

            //Total = appleTotal + potatoTotal + tomatoTotal + orangeTotal + strawberryTotal;


            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " TL" + " - Gramaj: " + appleGram + " - Total Fiyat: " + appleTotal + (" TL"));

            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " TL" + " - Gramaj: " + potatoGram + " - Total Fiyat: " + potatoTotal + (" TL"));

            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " TL" + " - Gramaj: " + tomatoGram + " - Total Fiyat: " + tomatoTotal + (" TL"));

            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " TL" + " - Gramaj: " + orangeGram + " - Total Fiyat: " + orangeTotal + (" TL"));

            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " TL" + " - Gramaj: " + strawberryGram + " - Total Fiyat: " + strawberryTotal + (" TL"));

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("Toplam Tutar: " + Total  + " TL");




            #endregion

            #region Char Değiişkenler

            //char symbol;

            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** Türk Hava Yolları Yolcu Bilgisi *****");

            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");

            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");

            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------------------");

            //Console.WriteLine("Yolcu TC No: " + passengerIdentityNumber + " - " + "Yolcu Ad SOYAD: " + passengerName + " " + passengerSurname + " - " + "İkametgah: " + passengerDistrict + "/" + passengerCity + " - " + "Yaş: " + passengerAge);





            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 900;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen alacağınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen alacağınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen alacağınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen alacağınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice + "TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalamanız: " + result);




            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion




            Console.Read();
        }
    }
}
