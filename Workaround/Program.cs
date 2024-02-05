
using Business.Concrete;
using Entities.Concrete;

SelamVer("Doğan");
SelamVer("Ahmet");
SelamVer("Mehmet");
SelamVer();
Console.WriteLine("***********************************");
Topla(6, 58);
Console.WriteLine("***********************************");
//Diziler / Arrays
string[] ogrenciler = { "Engin", "Kerem", "Doğan", "İlker" };

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}
Console.WriteLine("***********************************");
string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "DOĞAN";
person1.LastName = "ALICI";
person1.DateOfBirthYear = 1998;
person1.NationalIdentity = 123456;

Person person2 = new Person();
person2.FirstName = "Engin";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}
Console.WriteLine("***********************************");
List<string> yeniSehirler1 = new List<string>() { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana 1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}
Console.WriteLine("***********************************");

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
Console.WriteLine("***********************************");



static void SelamVer(string isim = "İsimsiz")
{
    Console.WriteLine($"Merhaba {isim}");
}




static int Topla(int sayi1, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine($"{sayi1} + {sayi2} = {sonuc.ToString()}");
    return sonuc;
}