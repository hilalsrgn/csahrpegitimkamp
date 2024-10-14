using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_mainsubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.Write("*****yemek kategorileri*****");
            //Console.WriteLine("");
            //Console.WriteLine("Çorbalar");
            //Console.WriteLine("Ana Yemekler");
            //Console.WriteLine("Soğuk Başlangıçlar");
            //Console.WriteLine("Salatalar");
            //Console.WriteLine("Tatlılar");
            //Console.WriteLine("");
            #endregion
            #region Değişkenler
            //string name;
            //name = "Hilal";
            //Console.WriteLine(name);
            //Camel Case:ilk harfin küçük diğer kelimelerin ilk harflerinin büyükbaşlaması kuralıdır.

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,city,district;

            //customerName = "Hilal";
            //customerSurname = "Sargın";
            //customerPhone = "+90500 500 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "erenköy";
            //city = "kayseri";

            //Console.WriteLine("**REZERVASYON KARTI**");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------");

            //customerName = "özlem";
            //customerSurname = "altın";
            //customerPhone = "+09 400 700 60 90";
            //customerEmail = "test@gmail.com";
            //district = "melikgazi";
            //city = "kayseri";

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------");


            #endregion
            #region Int Degiskenler
            //int: tamsayı türündeki değikenler
            //int
            //int number =24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**Restoran ürün Fiyatı**");
            Console.WriteLine();
            Console.WriteLine("-----hamburger:" + hamburgerPrice +"TL");
            Console.WriteLine("-----kola: "+cokePrice +"TL");
            Console.WriteLine("-----su: "+waterPrice +"TL"); 
            Console.WriteLine("-----kızartma:" +friesPrice +"TL");
            Console.WriteLine("-----pizza:"+pizzaPrice +"TL");
            Console.WriteLine("-----lemonade:" + lemonadePrice+"TL");
            Console.WriteLine();

          
            int hamburgerCount;
            int cokeCount;
            int waterCount; 
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            
            
            hamburgerCount = 3;
            cokeCount = 2;
            waterCount = 1;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice=hamburgerCount*hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("**********************");
            Console.WriteLine("Hamburger Tutarı:"+totalHamburgerPrice);
            Console.WriteLine("Kola Tutarı:" + totalCokePrice);
            Console.WriteLine("su tutarı:" + totalWaterPrice);
            Console.WriteLine("Kızartma tutarı:" + totalFriesPrice);
            Console.WriteLine("pizza tutarı: " + totalPizzaPrice);
            Console.WriteLine("limonata tutarı: " + totalLemonadePrice);

            int totalPrice=totalCokePrice+totalWaterPrice+totalFriesPrice+totalHamburgerPrice+totalLemonadePrice+totalPizzaPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);

            #endregion

            Console.Read();
        }

    }
}
