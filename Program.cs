using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Atama ve İşlemli Atama *****");

            // Atama ve İşlemli Atama

            int x = 5;
            int y = 3;

            y = y + 2;               // 'y' sayısına 2 ekle anlamına gelir.
            Console.WriteLine(y);    // çıktı: 5 olur.

            y += 2;                  // 'y' sayısına 2 ekle anlamına gelir. 
            Console.WriteLine(y);    // çıktı: 7 olur.

            y /= 1;                  // 'y' sayısını 1'e böl anlamına gelir.
            Console.WriteLine(y);    // çıktı: 7/1 = 7 

            x *= 2;                  // 'x' sayısının 2 ile çarp anlamına gelir.
            Console.WriteLine(x);    // çıktı: x = x*2 -> 5*2=10



            Console.WriteLine("***** Mantıksal İfadeler *****");

            // (&& - ve) , (|| - veya) şeklinde gösterilirler.

            // (&&) "VE" Operatörü, Belirtilen şartların tümü doğru olduğunda koşul sağlanmış olur ve çıktı True değeri verir. 
            // Şartlardan bir tanesi bile yanlış (false) olursa koşul sağlanmamış olur ve çıktı False değeri verir.

            // ÖRNEK

            // Koşullarımızın ikisinin de değerinin "true" olduğunu varsayarsak;
            // koşul1 = true, 
            // koşul2 = true,
            // ("koşul1" && "koşul2) => (true && true) => çıktı: true


            // Koşullarımızın yalnızca bir tanesinin değerinin "true" olduğunu varsayarsak;
            // koşul1 = true,
            // koşul2 = false,
            // ("koşul1" && "koşul2") => (true && false) => çıktı: false


            // Koşullarımızın ikisisin de değerinin "false" olduğunu varsayarsak;
            // koşul1 = false,
            // koşul2 = false, 
            // ("koşul1" && "koşul2") => (false && false) => çıktı: false



            // (||) "VEYA" Operatörü, Belirtilen şartlardan sadece bir tanesi bile doğru (true) olursa koşul sağlanmış olur ve çıktı True değeri verir.
            // Şartlardan ikisi de yanlışsa (false) koşul sağlanmaz ve çıktı False değerini verir.

            // ÖRNEK

            // Koşullarımızın ikisinin de değerinin "true" olduğunu varsayarsak;
            // koşul1 = true,
            // koşul2 = true,
            // ("koşul1" || "koşul2") => (true || true) => çıktı: true


            // Koşullarımızın yalnızca bir tanesinin değerinin "true" olduğunu varsayarsak;
            // koşul1 = true,
            // koşul2 = false,
            // ("koşul1" || "koşul2") => (true || false) => çıktı: true


            // Koşullarımızın ikisinin de değerinin "false" olduğunu varsayarsak;
            // koşul1 = false,
            // koşul2 = false,
            // ("koşul1" || "koşul2") => (false || false) => çıktı: false 



            Console.WriteLine("***** IF Operatörü *****");

            bool isSucces = true;
            bool isCompleted = true;

            if(isSucces && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSucces || isCompleted)
                Console.WriteLine("Great!");

            if (isSucces && !isCompleted)
                Console.WriteLine("Fine!");



            Console.WriteLine("***** İlişkisel Operatörler *****");

            // İlişkisel operatörler, (<, >, <=, >=, ==, !=)  

            int a = 9;
            int b= 7;
            bool sonuc = a > b;

            Console.WriteLine(sonuc);
            sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc= a>=b; 
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);
           



            Console.WriteLine("***** Aritmetik Operatörler *****");

            // Aritmetik Operatörler, (+, -, *, /, %)

            int sayi1 = 8;
            int sayi2 = 4;
            int cevap;

            cevap = sayi1 + sayi2;                 
            Console.WriteLine("Cevap: " + cevap);

            cevap= sayi1 - sayi2;
            Console.WriteLine("Cevap: " + cevap);

            cevap = sayi1 * sayi2;
            Console.WriteLine("Cevap: " + cevap);

            cevap = sayi1 / sayi2;
            Console.WriteLine("Cevap: " + cevap);

            cevap= sayi1 % sayi2;
            Console.WriteLine("Cevap: " + cevap);

            Console.Read();










            
            






      







           
           

           
        }
    }
}
