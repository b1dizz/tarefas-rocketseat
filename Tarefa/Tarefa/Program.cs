namespace Tarefa;

class Program
{
    static void Main()
    {
        //Atividade 1 
        

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome}! Seja bem vindo.");

        Console.WriteLine();
        Console.WriteLine();

        ///////////////////////////////////////////////////////////////////////////

        //Atividade 2 - 

        Console.Write("Digite seu nome: ");
        string nome1 = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome completo é: {nome1} {sobrenome}.");

        Console.WriteLine();
        Console.WriteLine();

        //////////////////////////////////////////////////////////////////////////

        //Atividade 3

        Console.Write("Digite o primeiro número: ");
        double valor1 = Convert.ToDouble( Console.ReadLine() );

        Console.Write("Digite o segundo número: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine();


        double soma = valor1 + valor2;
        double subtração = valor1 - valor2;
        double multiplicação = valor1 * valor2;
        double divisão = 0;

        if(valor2 !=0)
        {
            divisão = valor2 / valor1;
        }
 
        double media = (valor1 + valor2) / 2;

        Console.WriteLine($"A soma do número {valor1} e do número {valor2} é: {soma} ");
        Console.WriteLine($"A subtração do número {valor1} e do número {valor2} é: {subtração} ");
        Console.WriteLine($"A multiplicação do número {valor1} e do número {valor2} é: {multiplicação} ");

        if (valor2 != 0)
        {
            Console.WriteLine($"A divisão do número {valor1} e do número {valor2} é: {divisão}");
        }
        else
        {
            Console.WriteLine("Não é possivel dividir por zero");
        }

        Console.WriteLine($"A média entre os números {valor1} e do número {valor2} é: {media}");


        Console.WriteLine();
        Console.WriteLine();


        //////////////////////////////////////////////////////////////////////////

        //Atividade 4

        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        
        Console.WriteLine();

        int quantidadedecaracters = palavra.Length;          //Contador de caracter
        string palavrasemespaço = palavra.Replace(" ", ""); //Tirar os espaços da string
        int semespaço = palavrasemespaço.Length;            //Obtem numero de caracter sem espaço

        Console.WriteLine($"Sua palavra: {palavra} tem {quantidadedecaracters} caracteres.");
        Console.WriteLine();
        Console.WriteLine($"Sua palavra: {palavrasemespaço} sem espaços tem {semespaço} tem caracteres.");


        Console.WriteLine();
        Console.WriteLine();


        //////////////////////////////////////////////////////////////////////////

        //Atividade 5

        Console.Write("Digite a placa do seu veiculo: ");
        string placa = Console.ReadLine();

        bool placavalida = ValidarPlaca(placa);  //Verdadeiro ou falso

        Console.WriteLine();

        static bool ValidarPlaca(string placa)
        {
            if (placa.Length != 7) //Verifica se a placa tem realmente 7 caracters (Se tiver mais que 8 ja vai dar falso)
            {
                return false;
            }
            for (int i = 0; i < 3; i++)  //Verifica os três primeiros caracteres que são as letras
            {
                if (!Char.IsLetter(placa[i]))  //Char apenas letra
                    return false;
            }           
            for (int i = 3; i < 7; i++)  // Verifica os quatro últimos caracteres que são os números
            {
                if (!Char.IsDigit(placa[i]))
                    return false;
            }
            return true;  //Se passou por tudo, a placa é valida
        }

        Console.WriteLine($"A placa: {placa} é válida? {placavalida}");

        Console.WriteLine();
        Console.WriteLine();

        //////////////////////////////////////////////////////////////////////////

        //Atividade 5

        Console.Write("Deseja saber a data e hora de hoje? ");
        string resposta = Console.ReadLine();

        if (resposta == "sim" || resposta == "Sim" || resposta == "SIM")
        {
            MostrarDataAtual();
        }
        else if (resposta == "não" || resposta == "Não" || resposta == "NÃO")
        {
            Console.WriteLine("Obrigado, até a próxima");
        }
        else
        {
            Console.WriteLine("Resposta invalida, digite: Sim ou Não.");
        }

        static void MostrarDataAtual()
        {
            DateTime dataatual = DateTime.Now;

            string formatocompleto = dataatual.ToString("dddd, dd 'de' MMMM 'de' yyyy 'às' HH:mm:ss");      // Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
            string apenasdata = dataatual.ToString("dd/MM/yyyy");                                           // Apenas a data no formato "01/03/2024".
            string apenashora = dataatual.ToString("HH:mm:ss");                                             // Apenas a hora no formato de 24 horas.
            string datamesextenso = dataatual.ToString("dd 'de' MMMM 'de' yyyy");                           // A data com o mês por extenso.


            Console.WriteLine();
            Console.WriteLine("Datas de hoje: (Diferentes tipos) ");
            Console.WriteLine();

            Console.WriteLine(formatocompleto);
            Console.WriteLine();

            Console.WriteLine(apenasdata);
            Console.WriteLine();

            Console.WriteLine(apenashora);
            Console.WriteLine();

            Console.WriteLine(datamesextenso);
        }
   
    
    }
    

}


