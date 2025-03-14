using System;
using Homework2;

class Program
{
    static void Main()
    {
        /*
         * 1.Ödev
         */
        Console.Write("Yaşınızı girin: ");
        if (int.TryParse(Console.ReadLine(), out int yas))
        {
            Console.WriteLine(YasKategorisiBelirle(yas));
        }
        else
        {
            Console.WriteLine("Geçerli bir yaş giriniz.");
        }
        /*
         * 2.Ödev
         */
        Console.WriteLine("Arabanızın Yaşını Giriniz:");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine(carAgeCategorized(age));
        }
        else
        {
            Console.WriteLine("Geçerli Yaş Giriniz.");
        }
        //3. Ödev
        int num = 0;
        while (num < 10)//koşul doğru oldukça döngü devam eder
        {
            num = num + 1;
            Console.WriteLine(num); //her döngüde num değerini yaz.
        }
        Console.WriteLine(num);//burada ise döngüden çıkan en son num'a atanana değer yazılır
        int num2 = 10;
        do
        {
            num2 +=1;
            Console.WriteLine(num2);//11 yazdırır 
        } while (num2 < 10); // false döner devamı gelmez do-while döngüsünde ise do kısmı her türlü bir kere işleme sokulur ve daha sonra while daki koşul kontrol edilir eğer true dönerse döngüye geri döner false ise program devam eder.
        
        /*
         * 4.Ödev
         */
        Calisan GM = new Calisan("Ahmet","Kaya","Yönetici","Genel Müdür",90000);
        Calisan MU = new Calisan("Mehmet","Kaya",";Müdür","Müdür",80000); 
        Calisan PR = new Calisan("Zeki","Kaya","Programcı","Programcı",70000);
        Calisan S = new Calisan("Tekin","Kaya","Stajyer","Stajyer",0);
        GM.displayAttribute();
        MU.displayAttribute();
        PR.displayAttribute();
        S.displayAttribute();
        Calisan[] array = {GM,MU,PR,S};
        int sumSalary = 0;
        int index = 0;
        while (index < array.Length-1)
        {
            sumSalary += array[index].salary;
           index++; 
        }
        Console.WriteLine(sumSalary);
        /*
         *
         *
         *5.Ödev
         * 
         */
        List<Araba> arabalar = new List<Araba>
        {
            new Araba("Toyota", 7.5, 100),  
            new Araba("BMW", 9.2, 150),    
            new Araba("Mercedes", 10.5, 200), 
            new Araba("Honda", 6.8, 120)   
        };

        double toplamTuketim = 0;
        
        foreach (var araba in arabalar)
        {
            double tuketim = araba.BenzinTuketimiHesapla();
            
            toplamTuketim += tuketim;
        }

        
        Console.WriteLine("Tüm arabaların toplam benzin tüketimi: "  + toplamTuketim + "litre.");
        


    }

    static string YasKategorisiBelirle(int yas)
    {
        if (yas <= 18 && yas > 0)
            return "Küçüksünüz";
        else if (yas > 18 && yas <= 35)
            return "Gençsiniz";
        else if (yas > 35 && yas <= 55)
            return "Yetişkinsiniz";
        else if (yas > 55 && yas <= 75)
            return "Yaşlısınız";
        else if (yas > 75 && yas <= 99)
            return "Çok yaşlısınız";
        else
            return "Ya hiç doğmadınız ya da çoktan öldünüz";
    }

    static string carAgeCategorized(int age)
    {
        if (age >= 0 && age <= 10)
        {
            return "Arabanız Yeni";
        }
        else if (age > 10 && age <= 20)
        {
            return "Servise Götürmen Gerekebilir.";
        }
        else if (age > 20 && age <= 30)
        {
            return "Arabanız Hurdaya Çıkabiilir.";
        }
        else
        {
            return "Ya hiç üretilmedi ya da trafikten men.";
        }
    }
}




