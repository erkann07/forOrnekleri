for (int i = 1; i <11; i++)
{
    Console.WriteLine("Kendime inanıyorum ben bu yazılım işini hallederim");
}
for (int i = 1; i < 21; i++)
{
    Console.WriteLine(i);
}
for (int i =0; i < 20; i += 2)
{
    Console.WriteLine(i);
}
for (int i = 0; i < 20; i += 2)
{
    Console.WriteLine(i);
}
int sayi = 50;
int sayi2 = 150;
int toplam = 0;
for (int i = 51; i < 150; i++)
{
    toplam += i;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı = " +toplam);
int tek = 0;
int cift = 0;
for (int i = 0; i <= 120; i++)
{
    if (i % 2 ==0)
    {
        cift += i;
    }
    else
    {
        tek += i;
    }
   
    
} 
Console.WriteLine("1 ile 120 Arasındaki Tek Sayıların Toplamı: " + tek);
Console.WriteLine("1 ile 120 Arasındaki Çift Sayıların Toplamı: " + cift);
