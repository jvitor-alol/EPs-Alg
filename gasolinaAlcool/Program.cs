using System;
internal class Program
{
    public static int maiorMenor(float razaoReal){
        const float razao = 0.7F;

        if (razaoReal > razao) {
            return 0;
        }else if (razaoReal < razao){
                return 1;
            } else return 2;
    }
    public static void Main(string[] args)
    {
        string simNao = "";
        
        do{
            Console.Write("Insira o preço da gasolina: R$ ");
            float gasolina = float.Parse(Console.ReadLine());
            Console.Write("Insira o preço do álcool: R$ ");
            float alcool = float.Parse(Console.ReadLine());

            float razaoReal = alcool / gasolina;

            switch (maiorMenor(razaoReal)){
                case 0:
                    Console.WriteLine("Vale a pena a gasolina");
                    break;
                case 1:
                    Console.WriteLine("Vale a pena o álcool");
                    break;
                case 2:
                    Console.WriteLine("Tanto faz abastecer com um ou outro");
                    break;
            }

            Console.Write("Deseja iniciar outro cálculo? [S/N]: ");
            simNao = Console.ReadLine();
            while (simNao != "s" & simNao != "S" & simNao != "n" & simNao != "N"){
                Console.WriteLine("Valor inválido, insira novamente");
                simNao = Console.ReadLine();
            }
        } while(simNao == "s" | simNao == "S");
    }
}