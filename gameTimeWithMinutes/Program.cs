using System;
public class Program
{
    private static void Main(string[] args)
    {
        //Console.Write("Entradas: ");
        string[] texto = Console.ReadLine().Split(' ');

        int startGame = int.Parse(texto[0])*60 + int.Parse(texto[1]), endGame = int.Parse(texto[2])*60 + int.Parse(texto[3]);
        int hourDur, minDur;

        if(endGame>startGame)
        {
            hourDur = (endGame - startGame)/60;
            minDur = (endGame - startGame)%60;
            
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hourDur, minDur);
        } else if(endGame<startGame)
            {
                hourDur = (24*60-startGame+endGame)/60;
                minDur =  (24*60-startGame+endGame)%60;

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hourDur, minDur);
            } else Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
    }
}