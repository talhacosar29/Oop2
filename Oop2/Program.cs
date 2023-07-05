
using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Id = 1;
            musteri1.CustomerNumber = "12345";
            musteri1.TcNo = "";
            musteri1.FirstName = "Talha";
            musteri1.LastName = "Coşar";

            TuzelMusteri musteri11 = new TuzelMusteri();
            musteri11.Id = 2;
            musteri11.CustomerNumber = "20012001";
            musteri11.SirketName = "Coşar Turizm";
            musteri11.VergiNo = "24801Ahsct";

            Customer customer3 = new GercekMusteri();
            Customer customer4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri11);

        }
    }
}
