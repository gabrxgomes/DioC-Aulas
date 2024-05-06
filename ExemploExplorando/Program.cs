﻿using System.Globalization;
using ExemploExplorando.Models;

//o primeiro a entrar é o ultimo a sair 

Stack<int> pilha = new Stack<int>();


//lembrando que na pilha o primeiro elemento é o ultimo da pilha, é o metodo de empilhar
pilha.Push(4);//4
pilha.Push(6);//3
pilha.Push(8);//2
pilha.Push(10);//1


foreach (var item in pilha)//posso usar assim //para percorrer a nossa pilha
//ou assim foreach (int item in pilha)
{
    Console.WriteLine(item);
    
}

Console.WriteLine($"Removendo o item do topo da pilha: {pilha.Pop()}");
// o meu pilha pop me retorna direto o item removido com a função


//Console.WriteLine($"Adicionando o elemento 20 no lugar do elemento 10 pois trata-se de uma pilha: {pilha.Push(20)}");
// Console.WriteLine($"Adicionando o elemento 20 no lugar do elemento 10, pois trata-se de uma pilha: {pilha.Push(20)}");


pilha.Push(20);
Console.WriteLine("Adicionando o valor 20 ao topo da fila");

foreach (var item in pilha)
{
    Console.WriteLine(item);
}






























// Queue<int> fila = new Queue<int> ();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine($"First: {fila.Peek()}");

// Console.WriteLine($"Dequeue, removing a element from queue: {fila.Dequeue()}");

// //eu posso simplesmente adiconar um novo elemento a queue 

// fila.Enqueue(10);
// //preste bem a atenção na fila de situações, após eu chamar o metodo dequeue eu acrescendo um novo elemento a fila


// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }





















// //usando o Throw error

// new ExemploExcecao().Metodo1();































// // string[] lineExemple =  File.ReadAllLines("Arquivos1/arquivoLeituras.txt");

// try
// {   
//     string[] line =  File.ReadAllLines("Arquivo/arquivoLeituras.txt");//erro de folder
//     string[] line =  File.ReadAllLines("Arquivos/arquivoLeitura.txt");//erro de file
//     //eu adicionei o nosso arquivo num array, pois ja que queremos fazer um processamento
//     // que percorra o arquivo lendo as linhas no nosso cenário autal


//     //o line local var é definida e recebe cada lineLocalVar de line
//     foreach (string lineLocalVar in line) // PARA LINHA EM LINHA QUE É O MEU ARRAY, PRINT A MINHA LINHA
//     {
//         Console.WriteLine(lineLocalVar);
//     }
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Could not open a folder, especifit error ! {ex.Message}");
// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Could not open file, especifit error ! {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"An Generic error as apaered! Message from try catch method. {ex.Message}");
// }
// finally // o finally é uma função que está ali sempre pra ser executada no fim de nossa execução de erros
// //independente de ter acontecido erros ou não 
// {
//     Console.WriteLine("Chegou até aqui !");
// }
























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt_BR");
//use this if you are completly decided that your code in full culture



//TRABALHANDO COM MOEDAS

// decimal valorMonetario = 1582.40M;

//Console.WriteLine($"{valorMonetario:C}");

// Console.WriteLine(valorMonetario.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));

//case i use just C or C2 set my value in 2 decimal cases, just C1 one deciamal case


//Console.WriteLine(valorMonetario.ToString("N2", CultureInfo.CreateSpecificCulture("en-US")));

// if you using "N" just print solo number excluding the money identificator
//1,582.40



//printing percent value

// double percent = .3421;

// Console.WriteLine(percent.ToString("P1"));

//34.21%            
//printing percent value formating your exit 



//processo inicial de se formatar datas ou numeros de maneira mais semântica

// int number = 123456;

// Console.Write(number.ToString("##-##-##"));




//date time format


// DateTime date =  DateTime.Now;


// Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm"));


// Formating date time ! in under comment

// Console.WriteLine(date.ToShortDateString());

// this function return to me a little short date time format, printin jus date!



//case you prefer using parse to format a date time this works !

// DateTime date = DateTime.Parse("17/04/2022 18:00");// this works but if it is a valid date ---  invalid date "32/04/2022"

// Console.WriteLine(date);


// // other exemple the invalid date format

// string  dateString = "2022-13-17 18:00";

// DateTime date1 = DateTime.Parse(dateString);

// Console.WriteLine(date1);



//consisious datetime format with hard format


// string dateString =  "2022-13-17 18:00";

// bool sucess = DateTime.TryParseExact(dateString, "yyyy-MM-dd HH:mm",
//                                     CultureInfo.InvariantCulture,
//                                     DateTimeStyles.None, out DateTime date );



// if (sucess)
// {
//     Console.WriteLine($"Sucess convertion ! Date: {date}");
// }

// else {
//     Console.WriteLine($"{dateString} is not valid date.");
// }

//finish method



