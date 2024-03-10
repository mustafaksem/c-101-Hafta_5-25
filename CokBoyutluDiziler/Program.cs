
// ÇOK BOYUTLU DİZİLER ( Multi Dimensial Array)

// Çook boyutlu dizide bizler genellikle 2 boyutlu diziyi kullnaırız.
// Anahtar işaretimiz burada virgül ,
// Tek boyutlu diziler liste kavramı ile çok boyutlu diziler tablo mnatığı ile yapılır.

// Düzenli diziler = Her satırda aynı sayıda sütun bulunduran dizilerdir.
// Düzensiz diziler = Her satırda aynı sayıda sütun olmayan dizilerdir.

// iki boyutlu dizi

using System;
using System.Collections;
using System.Diagnostics;

//int[] dizi1 = new int[5];       // 5 elemanlı tek boyutlu dizi
//int[,] dizi2 = new int[5,5];    // 5*5 elemanlı 2 boyutlu dizi - soldaki virgül kadar sağdaki virgül ****DİKKAT****
//int[,,] dizi3 = new int[5,2,3]; // 5*2*3 şeklinde 3 boyutlu dizi

// Elemanları elle atama 

int[,] dizi4 = new int[,] { { 1, 2 }, { 3, 4}, { 5, 6 }, { 7, 8 }, { 9, 10}, {11, 12}, {13, 14},{15, 16} };

//Console.WriteLine(dizi4[0,1]);

// Soru 1 : Yukarıdaki dizideki tüm elemanları sıra ile ekrana yazdırınız . Not sadece döngü kullanarak

//for (int i = 0; i < 8; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.Write(dizi4[i, j] + " ");
//    }
//    Console.WriteLine();
//}

// İlgili elemanı güncellemek
//dizi4[7, 1] = 9999;

// Soru 2 : Yukarıdaki dizide tüm elemanları 0-50 arasında rastgele sayı ile güncelleyiniz.

//Random rnd = new Random();
//for (int i = 0; i < 8; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        dizi4[i, j] = rnd.Next(0, 50);
//        Console.Write(dizi4[i, j] + " ");
//    }
//    Console.WriteLine();
//}

// Soru 3 : Yukarıdaki dizideki sayıların toplamını bulunuz.

//int toplam = 0;
//for (int i = 0; i < 8; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        toplam += dizi4[i, j];
//    }
//}
//Console.WriteLine("Toplamı : " + toplam);

// Soru  4 :  Yukardaki dizideki sayıları büyükten küçüğe sıralanmış şekilde ekrana yazdırınız.
//ArrayList liste = new ArrayList();
//for (int i = 0; i < 8; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        liste.Add(dizi4[i, j]);
//    }
//}
//liste.Sort();
//liste.Reverse();
//for (int i = 0; i < liste.Capacity; i++)
//{
//    Console.WriteLine(liste[i]);
//}

// Soru 5 : Yukarıdaki diziyi aşağıdaki formatta ekrana yazdırınnız.
//1-2
//3-4

//for (int i = 0; i < 8; i++)
//{
//    Console.WriteLine(dizi4[i, 0] + "-"+ dizi4[i, 1]);
//}

// Soru 6 : 5 satır 4 sütunlu bir çok boyutlu dizi oluşturunuz ve dizi elemanlarını 1-20 arası rastgele sayılarla güncelleyiniz.

int[,] dizi = new int[5, 4];
Random rndm = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        dizi[i, j] = rndm.Next(1, 20);
        Console.Write(dizi[i, j] + " ");
    }
    Console.WriteLine();
}


// Soru 7 : Yukarıdaki dizideki elemanların ortalamasını alınız.
int toplam = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        toplam += dizi[i, j];
    }
}
double ortalama = toplam / (5 * 4);
Console.WriteLine(" Dizinin Ortalaması :" + ortalama);