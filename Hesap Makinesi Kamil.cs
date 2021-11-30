// See https://aka.ms/new-console-template for more information
using System;


  
  

     Console.Title = "Programs";
     Console.ForegroundColor = ConsoleColor.Green;
     Console.WindowHeight = 20;


     Console.WriteLine("Merhaba ben Kamil");
     Console.WriteLine("Senin adın ne?");

     string userName =  Console.ReadLine();

     Console.WriteLine("Selam " + userName + "");

     Console.WriteLine("İsmini Beğendim :)");
     Console.WriteLine("Hmm Pekiii");

     double num1;
     double num2;
     
     Console.Write("Bi sayı söyler misin?");

     num1 = Convert.ToDouble( Console.ReadLine() );
     
     Console.Write("Bi tane daha lütfen :)");

     num2 = Convert.ToDouble( Console.ReadLine() );

     double result = num1*num2;

     Console.WriteLine("Bekle ikisini çarpıyorum hesaplıyorumm...Bitti! Cevap=" + result);
     Console.WriteLine("Çok zekiyim be (^__~)");

     double num3;
     double num4;

     Console.WriteLine("Şimdi bölme vakti ._.");

     Console.Write("Bi sayı alıyım lütfen :D");

     num3 = Convert.ToDouble( Console.ReadLine() );

     Console.Write("Bu kasaya bi tane daha sayı :D");

     num4 = Convert.ToDouble( Console.ReadLine() );

     double result2 = num3/num4;
     Console.WriteLine("Bekle ikisini bölüyorum hesaplıyorumm...Bitti! Cevap=" + result2);
     Console.Write("Merak ediyorum insanlar bilgisayarsız napardı :P");
     
     Console.WriteLine("Beni de hsap makinesine çevirdin neyse :D");
     Console.WriteLine("Şimdi ortalama vakti");
     Console.WriteLine("Bu sefe üç sayı lazım");

     double no1;
     double no2;
     double no3;
     

     Console.Write("İlkini alayım lütfen " + userName + ":)");

     no1 = Convert.ToDouble( Console.ReadLine() );

     Console.Write("Ne yapacağını biliyorsun artık " + userName +":P");

     no2 = Convert.ToDouble( Console.ReadLine() );

     Console.Write("Ve son sayı");

     no3 = Convert.ToDouble( Console.ReadLine() );

     double average = (no1 + no2 + no3) / 3;
     Console.WriteLine("Hesaplıyorumm..Topluyorum..Bölüyorummm......Bitti! Verdiğin sayıların ortalaması="+ average +"");
     Console.WriteLine("Yoruldum artık ben uyuyorum -_-zZZ");
   



     

     


     

     


     Console.ReadKey();

        