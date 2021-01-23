using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager  ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager  tasitKrediMamager = new TasitKrediMamager();
            IKrediManager  konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseloggerService = new dataBaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, fileLogerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediMamager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
