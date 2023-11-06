using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStatıcNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static : Nesne örneği alınmadan ulaşabildiğimiz metot , field, sınıf..

            //Stack bölge içerisinde pointer ımız oluştu..
            ogrenci O1;
            //Stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı
            //ve yine class içerisinde tanımlı olan static field ,
            //metot static dediğmiz bölgede oluşturuldu.
            ogrenci.Test2();

            O1 = new ogrenci();
            //Stack bölgede oluşan pointer => kendisini heap bölgede tamamladı... Static olmayan tanınlarını tamamladı..
            O1.Test1(); //nesne örneği alındıktan sonra test1 adındaki metotuma ulaşabildim.
        }
    }
}
