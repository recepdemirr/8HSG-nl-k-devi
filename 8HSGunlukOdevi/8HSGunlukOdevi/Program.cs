using _8HSGunlukOdevi.Controller;
using _8HSGunlukOdevi.Db;
using _8HSGunlukOdevi.Modal;
using System.Data.SqlClient;

namespace _8HSGunlukOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("1-Yeni Kayıt Ekle\n---------------------\n2-Kayıtları Listele\n---------------------\n3-Kayıtları Sil\n---------------------\n4-Çıkış yap");
            Console.WriteLine("-------------------------");
            Console.Write("Lütfen bir seçenek girin (1-4): ");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    KayitEkle();
                    break;
                    case "2":
                    KayitlariListele();
                    break;
                    case "3":
                    KayitSil();
                    break;
                    case "4":
                    Console.WriteLine("Çıkış Yapılıyor...");
                    break;
                    default: Console.WriteLine("Hatalı Giriş");
                    break;

            }
        }
        static void KayitEkle()
        {
            Console.WriteLine("Günlüğünüze Yazabilirsiniz:");
            //string gunluk=Console.ReadLine();
            //Gunluk gunluk1 = new Gunluk();
            //gunluk1.Name = gunluk;
            bool Ekleme =GunlukController.KayitEkle(new Gunluk()
            {
                Name = Console.ReadLine()
            }) ;
            if (Ekleme)
            {
                Console.WriteLine("Eklendi");
            }
            else 
            {
                Console.WriteLine("Eklenemedi");     
            }
        }
        static void KayitSil()
        {
            Console.WriteLine("Kayıtları Silmek İstedinize Eminmisiniz? ---> (E/H)");
             string sonuc= Console.ReadLine();
            if (sonuc.ToUpper() == "E")
            {
                GunlukController.KayitSil();
            }
            else
            {
                Console.WriteLine("Kayıtlar Silinmemiştir.");
            }
            
        }
        static void KayitlariListele()
        {
            List<Gunluk> list = GunlukController.KayitListele();
            Console.WriteLine("Kayıtlarınız:\n");
            foreach (Gunluk g in list)
            {
                Console.WriteLine($"{g.DateCreated.ToString("dd MMMM yyyy")}\n {g.Name}"
                        + "\n-------------");
            }
        }

    }
}
