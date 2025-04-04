using System;
    /* Kütüphaneden alınan bir kitap ile ilgili aşağıdaki işlemler menü yardımı ile yapılmaktadır. Get-Set metotları yazarak soruyu çözünüz.
Kullanıcı “1” e bastığında “Kitabın adı, Yazarı ve Basım Yılı” bilgisi görüntülenecektir ve bu alanlar private olarak tanımlanacaktır.
Kullanıcı “2” ye bastığında kişinin belirttiği gün sayısı 1-7 gün arasında ise gün başına 5 TL,
 7-15 gün arasındaysa 10 TL günlük gecikme bedeli olacak şekilde Punish_Calculate() fonksiyonu ile hesaplayacaktır ve
ceza bedeli ekranda görüntülenecektir */

namespace consoleAp
{
    internal class program
    {
        static int PunishCalculate(int day1)
        {
            if (day1 < 8)
            {
                return day1 * 5;
            }
            else if (day1 < 16)
            {
                return day1 * 10;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 2:
                    break;
            }
        }
    }
}