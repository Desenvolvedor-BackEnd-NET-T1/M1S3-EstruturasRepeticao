

// int i = 0; 
// while (i < 30)
// {
//     i += 1; 
//     Console.WriteLine(i);
// }

//Calcule e exiba a tabuada do 2  do 0 ate o 20;

// 2 x 0 = 0
// 2 x 1 = 2
// 2 x 2 = 4 
//...
// 2 x 20 = 40

using System.Reflection;

int tabuada = 0; 

while(tabuada <= 20)
{
    Console.WriteLine($"2 x {tabuada} =  {tabuada *2 }");
    tabuada++; 
}


// Crie um validador de entrada de dados 
// enquanto o usuario não digitar um numero de entre 1 e 10 
// peça para ele digitar novamente e indique opção errada .

// int num = 0; 
// Console.WriteLine(" Digite um numero ente 1 e 10");
// num = int.Parse(Console.ReadLine());
// while (num < 1 || num > 10)
// {
//     Console.WriteLine("Numero errado, Digite um numero ente 1 e 10");
//     num = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("o numero digitado foi " + num );


//Otimizada 
// int num = 0; 
// bool jaErrou = false; 
// while (num < 1 || num > 10)
// {
//     if (jaErrou)
//     {
//         Console.Write("Numero inválido!! ");
//     }
//     Console.WriteLine("Digite um numero ente 1 e 10");
//     num = int.Parse(Console.ReadLine());
//     jaErrou = true; 
// }
// Console.WriteLine("o numero digitado foi " + num );

///Validação completa de input 


Console.WriteLine("Digite um numero:");
bool ehNumero =  int.TryParse(Console.ReadLine(), out int num);
while (!ehNumero)
{
    Console.WriteLine("Valor invalido, Digite um numero: ");
    ehNumero =  int.TryParse(Console.ReadLine(), out num);
}

Console.WriteLine("O numero digitado foi " + num);