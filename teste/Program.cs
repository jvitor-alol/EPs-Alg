internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Anos: ");
        int anos = int.Parse(Console.ReadLine());
        Console.Write("Meses: ");
        int meses = int.Parse(Console.ReadLine());
        Console.Write("Dias: ");
        int dias  = int.Parse(Console.ReadLine());
        int idadeDias = anos*365 + meses*30 + dias;
        Console.WriteLine("Sua idade em dias é: {0}", idadeDias);
    
        if (idadeDias >= 365*10){
            Console.WriteLine("Mais de 10 anos");
        }
        else Console.WriteLine("Fucking kid");
    }
}