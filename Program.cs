//Crie um menu de aplicação interativo e englobe os exercicios anteriores
//  para selecionar qual sera executado. 
//Os itens do menu devem ser :
//1 - Tabuada                          3 Fatorial 
//2 - input validator             4 sair (se selecionado sair do programa)

int opcao;
do
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Tabuada");
    Console.WriteLine("2 - Input Validator");
    Console.WriteLine("3 - Fatorial");
    Console.WriteLine("4 - Sair");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        //Calcule e exiba a tabuada do 2  do 0 ate o 20;

        // 2 x 0 = 0
        // 2 x 1 = 2
        // 2 x 2 = 4 
        //...
        // 2 x 20 = 40

        int tabuada = 0;

        while (tabuada <= 20)
        {
            Console.WriteLine($"2 x {tabuada} =  {tabuada * 2}");
            tabuada++;
        }



    }
    else if (opcao == 2)
    {

        // Crie um validador de entrada de dados 
        // enquanto o usuario não digitar um numero de entre 1 e 10 
        // peça para ele digitar novamente e indique opção errada .

        int num = 0;
        Console.WriteLine(" Digite um numero ente 1 e 10");
        num = int.Parse(Console.ReadLine());
        while (num < 1 || num > 10)
        {
            Console.WriteLine("Numero errado, Digite um numero ente 1 e 10");
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("o numero digitado foi " + num);


        //Otimizada 
        num = 0;
        bool jaErrou = false;
        while (num < 1 || num > 10)
        {
            if (jaErrou)
            {
                Console.Write("Numero inválido!! ");
            }
            Console.WriteLine("Digite um numero ente 1 e 10");
            num = int.Parse(Console.ReadLine());
            jaErrou = true;
        }
        Console.WriteLine("o numero digitado foi " + num);

        ///Validação completa de input 


        Console.WriteLine("Digite um numero:");
        bool ehNumero = int.TryParse(Console.ReadLine(), out num);
        while (!ehNumero)
        {
            Console.WriteLine("Valor invalido, Digite um numero: ");
            ehNumero = int.TryParse(Console.ReadLine(), out num);
        }
    }
    else if (opcao == 3)
    {

        //Calcule o fatorial de  N (obtido do usuario) 
        // utilizando estruturas de repetição 
        // (Multiplicar todos os numeros antessesores positivos)

        // 5 = 5*4*3*2*1  = 120


        //receber o valor;

        Console.WriteLine("Digite um numero para calcular o fatorial: ");
        int fatorial = int.Parse(Console.ReadLine());


        //while 
        int fatorialWhile = fatorial;
        int resultadoWhile = 1;
        while (fatorialWhile > 1)
        {
            resultadoWhile = resultadoWhile * fatorialWhile;
            fatorialWhile--;
        }
        Console.WriteLine("resultado do fatorial de " + fatorial + "  é " + resultadoWhile);

        //do while 
        int doFatorial = fatorial;
        int doResultado = 1;

        do
        {
            doResultado = doResultado * doFatorial;
            doFatorial--;

        } while (doFatorial > 1);
        Console.WriteLine("resultado do fatorial de " + fatorial + "  é " + doResultado);


        //for 
        int forResultado = 1;
        for (int forFatorial = fatorial; forFatorial > 1; forFatorial--)
        {
            forResultado = forResultado * forFatorial;
        }
        Console.WriteLine("resultado do fatorial de " + fatorial + "  é " + forResultado);


        //for 

        int resultado = 1;
        for (int i = 1; i <= fatorial; i++)
        {
            resultado = resultado * i;
        }
        Console.WriteLine("resultado do fatorial de " + fatorial + "  é " + resultado);



        // 5     5*4*3*2*1
        // resultado  *5  
        // resultado *4 
        //


        // 4 - fatorial com "for" -- Codigo de referencia! Logica esta diferente porem bem otimizada.
        Console.WriteLine("Informe um número inteiro para ver seu fatorial: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        fatorial = numero;
        for (int i = 1; i < numero; i++)
        {
            fatorial *= i;
        }
        Console.WriteLine($"O resultado de {numero}! é igual a {fatorial}");




    }
    else if (opcao == 4)
    {
        Console.WriteLine("Saindo do programa...");
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
    }

} while (opcao != 4);





// int i = 0; 
// while (i < 30)
// {
//     i += 1; 
//     Console.WriteLine(i);
// }


// Console.WriteLine("O numero digitado foi " + num);
// //While valida e depois executa o bloco. 

// //Do While primeiro executa o bloco e depois valida 
// int num2; 
// do 
// {
//     Console.WriteLine(" Digite um numero: ");
//     ehNumero =  int.TryParse(Console.ReadLine(), out num2);
// }while (!ehNumero);

// Console.WriteLine("O numero digitado foi " + num2);


// for ele tem o objeto de interar e ja tem a estrututa enchuta. 

// for (int i = 0; i<30; i++)
// {
//     Console.WriteLine(i);
// }




// for(int i = 0 ;  i <= 20 ; i++) // (i++) == (i = i + 1)  == (i +=1 )
// {
//     Console.WriteLine($"2 x {i} =  {i *2 }");
// }

