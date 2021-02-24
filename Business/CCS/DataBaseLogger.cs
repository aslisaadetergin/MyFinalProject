using System;

namespace Business.CCS
{
    public class DataBaseLogger : ILoger
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }

   

}
