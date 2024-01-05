using exemplo_fundamentos.Models;

string aprensentacao = "olá";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;
DateTime data = DateTime.Now.AddDays(5);


Console.WriteLine(data.ToString("dd/MM/yyyy")); //quando colocamos o ToString conseguimos editar a saida do console
Console.WriteLine(aprensentacao);
Console.WriteLine("Valor da quantidade " + quantidade);
Console.WriteLine("Valor da altura " + altura.ToString("0.00"));
Console.WriteLine("Valor da preço " + preco);
Console.WriteLine("Valor da condição " + condicao);

// entrada e saida
Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 0)
        {
            Console.WriteLine("Idade inválida.");
        }
        else if (idade < 18)
        {
            Console.WriteLine("Você é menor de idade.");
        }
        else if (idade >= 18 && idade < 60)
        {
            Console.WriteLine("Você é adulto.");
        }
        else
        {
            Console.WriteLine("Você é um idoso.");
        }


        //programa  que escolher a operação que deseja
        Console.WriteLine("Selecione uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int escolha = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        switch (escolha)
        {
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine($"Resultado da soma: {resultado}");
                break;

            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine($"Resultado da subtração: {resultado}");
                break;

            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine($"Resultado da multiplicação: {resultado}");
                break;

            case 4:
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"Resultado da divisão: {resultado}");
                }
                else
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                }
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        //instancia

//Pessoa pessoa = new Pessoa();
//pessoa.Nome = "Lucas";
//pessoa.Idade = 22;
//pessoa.Apresentar();