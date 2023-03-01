using System;
internal class Program
{
    public static void maiorMenor(float razaoReal){
        const float razao = 0.7F;

        if (razaoReal > razao) {
            Console.WriteLine("Vale a pena a gasolina");
        }else if (razaoReal < razao){
                Console.WriteLine("Vale a pena o álcool");
        } else Console.WriteLine("Tanto faz abastecer com um ou outro");
    }
    public static void Main(string[] args)
    {
        string simNao = "";
        
        do{
            Console.Clear();
            Console.Write("Insira o preço da gasolina: R$ ");
            float gasolina = float.Parse(Console.ReadLine());
            Console.Write("Insira o preço do álcool: R$ ");
            float alcool = float.Parse(Console.ReadLine());

            //float razaoReal = alcool / gasolina;

            maiorMenor(alcool / gasolina);

            Console.Write("Deseja iniciar outro cálculo? [S/N]: ");
            simNao = Console.ReadLine();
            while (simNao != "s" & simNao != "S" & simNao != "n" & simNao != "N"){
                Console.WriteLine("Valor inválido, insira novamente");
                simNao = Console.ReadLine();
            }
        } while (simNao == "s" | simNao == "S");
    }
}