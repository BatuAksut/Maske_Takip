using Business.Concrete;
using Entities.Concrete;
using System;
namespace Workspace;
class Program
{
    static void Main(string[] args)
    {
        
        SelamVer();

      

        //Diziler

        string ogrenci1 = "Engin";
        string ogrenci2 = "Kerem";
        string ogrenci3 = "Berkay";

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";

        for(int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }


        Person person1 = new Person();
        person1.FirstName = "Engin";
        person1.LastName = "Demiroğ";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 1234;
        Person person2 = new Person();
        person2.FirstName = "Murat";

        List<string> yeniSehirler = new List<string> {"istanbul","ankara","izmir"};
        yeniSehirler.Add("antalya");
        foreach(string sehir in yeniSehirler)
        {
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);


    }
    static void SelamVer(string isim="isimsiz")
    {
        Console.WriteLine("Merhaba "+ isim);
    }


    static int Topla(int sayi1=5,int sayi2=10)
    {
        return  sayi1+sayi2;
    }
}
  