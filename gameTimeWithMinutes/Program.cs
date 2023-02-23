using System;
public class Program
{
    /*public int hourDur, minuteDur;
    private static int validGame (int startHour, int startMinute, int endHour, int endMinute)
    {   
        int i;

        if (startHour < endHour & endMinute <= startMinute){
            Console.WriteLine("Jogo inválido");
            Environment.Exit(0);
        }

        if (startHour >= endHour)

        return i;
        if (startHour == endHour)
        {
            if (startMinute == endMinute)
            {
                hourDur = 24;
                minuteDur = 0;                
            } else if (startMinute > endMinute)
                {
                    hourDur = 23;
                    minuteDur = 60 - Math.Abs(startMinute - endMinute);
                } else 
                {
                    hourDur = 0;
                    minuteDur = endMinute - startMinute;
                }
            //return true;
        } else if (startHour > endHour)
        {
            hourDur = 24 - Math.Abs(startHour - endHour);
            if (startMinute > endMinute) 
            {
                minuteDur = 60 - Math.Abs(endMinute - startMinute);
            } else if (startMinute < endMinute)
                {
                    minuteDur = endMinute - startMinute;
                } else minuteDur = 0;
            //return true;
        } else {
            if (endMinute <= startMinute) {
                //return false;
            } else {
                hourDur = 0;
                minuteDur = endMinute - startMinute;
                //return true;
            }
        }
    }*/

    private static void Main(string[] args)
    {
            Console.Write("Entradas: ");
            string[] texto = Console.ReadLine().Split(' ');

            int startHour = int.Parse(texto[0]), startMinute = int.Parse(texto[1]), endHour = int.Parse(texto[2]), endMinute = int.Parse(texto[3]);

            int hourDur, minuteDur;

            if (startHour == endHour)
            {
                if (startMinute == endMinute)
                {
                    hourDur = 24;
                    minuteDur = 0;
                } else if (startMinute > endMinute)
                    {
                        hourDur = 23;
                        minuteDur = 60 - Math.Abs(startMinute - endMinute);
                    } else 
                    {
                        hourDur = 0;
                        minuteDur = endMinute - startMinute;
                    }
            } else if (startHour > endHour)
            {
                hourDur = 24 - Math.Abs(startHour - endHour);
                if (startMinute > endMinute) 
                {
                    minuteDur = 60 - Math.Abs(endMinute - startMinute);
                } else if (startMinute < endMinute)
                    {
                        minuteDur = endMinute - startMinute;
                    } else minuteDur = 0;
            } else {
                if (endMinute <= startMinute) {
                    Console.WriteLine("Jogo inválido");
                    Environment.Exit(0);
                } else {
                    hourDur = 0;
                    minuteDur = endMinute - startMinute;
                }
            }

        Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hourDur, minuteDur);       
    }
}