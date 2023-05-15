using System;


namespace Problem_14_Current_Date_and_Time
{
class CurrentDateAndTime
{
    static void Main()


    {
        // Часът и датата в момента според времевата зона, в която се намираме.

        DateTime Now = DateTime.Now;
        Console.WriteLine("The local time is: " + Now); 

        System.Threading.Thread.Sleep(1000); //--- Изчаква за указаното от нас време в скобите. 
        Console.WriteLine("------------------------------"); 
        System.Media.SystemSounds.Beep.Play(); //--- Пуска системен звук по избор.

        // Часът и датата за настоящият момент, представени като coordinated universal time (UTC).

        DateTime UtcNow = DateTime.UtcNow;
        DateTime myDT;
        Console.WriteLine("Date and time for the current moment expressed as coordinated universal time (UTC) is " + UtcNow);

        System.Threading.Thread.Sleep(1000); 
        Console.WriteLine("------------------------------");
        System.Media.SystemSounds.Beep.Play();

        // Показва както UTC, така и локалното време.

        Console.WriteLine("Now...: " + Now);
        Console.WriteLine("UTC now...: " + UtcNow);

        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("------------------------------");
        System.Media.SystemSounds.Beep.Play();

    }
}
}
