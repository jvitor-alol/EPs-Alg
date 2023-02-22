using System;
class Program{

    public static int recursao (){

        string escolha = Console.ReadLine();
        string simNao;
        //int testeA = 0, testeB = 0;
        bool valido;

        if (escolha == "a" | escolha == "A"){
            //testeA = 1;
            //chama função a
            if (funcaoA() == 0 /*& testeB != 1*/){
                
                Console.WriteLine("Calcular salário também? [S/N]");
                do {
                    simNao = Console.ReadLine();                
                    valido = true;

                    switch (simNao)
                    {
                        case "s" :
                            funcaoB();
                            break;

                        case "S" :
                            funcaoB();
                            break;

                        case "n" :
                            Console.Write("OK, ");
                            break;

                        case "N" :
                            Console.Write("OK, ");
                            break;

                        default :
                            valido = false;
                            Console.WriteLine("Entrada inválida\nInsira novamente [S/N]: ");
                            break;
                    } 
                } while (!valido);
            }
        }
        else if (escolha == "b" | escolha == "B"){
                //testeB = 1;
                //chama função b
                if (funcaoB() == 0 /*& testeA != 1*/){

                    Console.WriteLine("Calcular idade também? [S/N]");
                    do {
                        simNao = Console.ReadLine();                
                        valido = true;

                        switch (simNao)
                        {
                            case "s" :
                                funcaoA();
                                break;

                            case "S" :
                                funcaoA();
                                break;

                            case "n" :
                                Console.Write("OK, ");
                                break;

                            case "N" :
                                Console.Write("OK, ");
                                break;

                            default :
                                valido = false;
                                Console.WriteLine("Entrada inválida\nInsira novamente [S/N]: ");
                                break;
                        } 
                    } while (!valido);
                }
            }
            else {
                Console.WriteLine("Escolha uma opção válida.");
                recursao();
            }

        Console.WriteLine("Fim do programa");
        return 0;
    }

    public static int funcaoA(){
        //Programa que lê a idade da pessoa em dias, meses e anos e retorna a idade em dias

        Console.Write("Anos: ");
        int anos = int.Parse(Console.ReadLine());
        Console.Write("Meses: ");
        int meses = int.Parse(Console.ReadLine());
        Console.Write("Dias: ");
        int dias  = int.Parse(Console.ReadLine());
        int idadeDias = anos*365 + meses*30 + dias;
        Console.WriteLine("Sua idade em dias é: {0}", idadeDias);
        
        //Teste sintaxe de condicional

        if (idadeDias >= 365*18){
            Console.WriteLine("Mais de 18 anos");
        }
        else Console.WriteLine("Fucking kid");

        return 0;
    }    

    public static int funcaoB(){
        Console.Write("Salário: ");

        double salario = double.Parse(Console.ReadLine());
        double salarioReajustado;

        if (salario <= 300) {
            //reajusta em 15%
            //salarioReajustado = salario*1.15
            salarioReajustado = salario * 1.15;
        }
        else salarioReajustado = salario * 1.075;

        Console.WriteLine("Novo Salário = R$ {0:N2}", salarioReajustado);
        
        return 0;
    }

    public static void Main(string[] args){

        Console.Write("Selecione a função A (Idade) ou B (Salário) [A/B]: ");
        recursao();  
    }
}