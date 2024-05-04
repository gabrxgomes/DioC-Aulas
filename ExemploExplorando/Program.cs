using System.Globalization;




string[] line =  File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//eu adicionei o nosso arquivo num array, pois ja que queremos fazer um processamento
// que percorra o arquivo lendo as linhas no nosso cenário autal


//o line local var é definida e recebe cada lineLocalVar de line
foreach (string lineLocalVar in line) // PARA LINHA EM LINHA QUE É O MEU ARRAY, PRINT A MINHA LINHA
{
    Console.WriteLine(lineLocalVar);
}























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



