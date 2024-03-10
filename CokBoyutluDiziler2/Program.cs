
// ÇOK BOYUTLU DİZİLER - 2 

// Düzensiz Diziler 

// Tanımlaması düzenli dizilere göre farklıdır.

//int[][] dizi1 = new int[3][];        // 5 satırlık bir çoklu dizi oluştu. Ancak her satırda kaç sutün olduğu bilinmediğinden boş bıraktım.

//dizi1[0] = new int[5];
//dizi1[1]= new int[4];
//dizi1[2]= new int[3];

// Soru 1 : Düzensiz bir dizi oluşturunuz 10 satırı olsun her bir satırda 1-5 arasında rastgele sutünu olsun.
//Random rndm = new Random();

//Random rnd = new Random();

//int[][] dizi1 = new int[10][];
//for (int i = 0;i<1 ; i++)
//{
//    dizi1[i] = new int[rnd.Next(1,5)];
//}

// Soru 2 : Yukarıdaki diziyi oluşturduktan sonra dizi elemeanları içinde rastgele 1-50 arası sayı ekleyiniz.

//Random rnd = new Random();

//int[][] dizi = new int[10][];
//for (int i = 0; i < 10; i++)
//{
//    dizi[i] = new int[rnd.Next(1, 5)];

//    for (int j = 0; j < dizi[i].Length; j++)
//    {
//        dizi[i][j] = rnd.Next(1, 50);
//        Console.Write(dizi[i][j] + " ");
//    }
//    Console.WriteLine( );
//}

// Soru 3 : Yukarıdaki diziyi her bir satırını aralarına - koyarak ekrana yazdırınız.
// 1-2-3
// 2-8-10-15 

//Random rnd = new Random();

//int[][] dizi = new int[10][];
//for (int i = 0; i < 10; i++)
//{
//    int rastgl = rnd.Next(1, 5);
//    dizi[i] = new int[rastgl];
//    for (int j = 0; j < dizi[i].Length; j++)
//    {
//        dizi[i][j] = rnd.Next(1, 50);
//        Console.Write(dizi[i][j] + "-");
//    }
//    Console.WriteLine();
//}

// Soru 4 : Yukarıdaki dizideki elemanların ortalamasını alınız.

//Random rnd = new Random();
//int toplam = 0;
//int elemanSayisi = 0;

//int[][] dizi = new int[10][];
//for (int i = 0; i < 10; i++)
//{
//    int rastgl = rnd.Next(1, 5);
//    dizi[i] = new int[rastgl];
//    for (int j = 0; j < dizi[i].Length; j++)
//    {
//        dizi[i][j] = rnd.Next(1, 50);
//        toplam += dizi[i][j];
//        elemanSayisi++;
//        Console.Write(dizi[i][j] + "-");
//    }
//    Console.WriteLine();
//}
//double ortalama = toplam / elemanSayisi;
//Console.WriteLine("Toplam : " + toplam);
//Console.WriteLine("eleman sayısı : " + elemanSayisi);
//Console.WriteLine("Ortalama : " + ortalama);

// Soru 5 : Yukarıdaki dizide her bir satır kontrolünde en fazla sütün bulunan satırı ve sütunu yazınız.

Random rnd = new Random();
int[][] dizi = new int[10][];
int enBuyuk = 0;
for (int i = 0; i < 10; i++)
{
    int rastgl = rnd.Next(1, 5);
    int sutunSayisi = rnd.Next(1, 5);
    if (sutunSayisi > enBuyuk)
    {
        enBuyuk = sutunSayisi;
    }
    dizi[i] = new int[sutunSayisi];
    for (int j = 0; j < dizi[i].Length; j++)
    {
        dizi[i][j] = rnd.Next(1, 50);
        Console.WriteLine(dizi[i][j] + "-");
    }
    Console.WriteLine();
}