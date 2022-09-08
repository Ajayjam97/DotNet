using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApp.Fundamental{

    public class MyDateTime
    {

        public static void work(){
            DateTime dt=new DateTime();
            Console.WriteLine(dt);
            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.TryParse("09-09-2022 01:55:39", out dt));

            CultureInfo currentculture= Thread.CurrentThread.CurrentCulture;
            Console.WriteLine(currentculture);

            string currentCulture = Thread.CurrentThread.CurrentCulture.DisplayName;  
  
            DateTime currentTime = DateTime.Now;  
            
            //// Getting DateTime based on culture.  
            string dateInUSA = currentTime.ToString("D", new CultureInfo("en-US")); // USA  
            string dateInFrench = currentTime.ToString("D", new CultureInfo("fr-FR")); // French 
            Console.WriteLine(dateInUSA);
            Console.WriteLine(dateInFrench); 
                
        }

    }

}
