using SingletonDesignPattern1.SingletonDesignPattern;
using System;

namespace SingletonDesignPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            DBHelper con1 = DBHelper.CreateDBHelper("Test Connection");
            con1.StateMessage = "İlk Baglanti Saglandi";
            Console.WriteLine(con1.StateMessage);

            DBHelper con2 = DBHelper.CreateDBHelper("Another Test Connection");
            con2.StateMessage = "İkinci bir baglantı saglandı";
            Console.WriteLine(con2.StateMessage);
            Console.ReadKey();
        }
    }
}
