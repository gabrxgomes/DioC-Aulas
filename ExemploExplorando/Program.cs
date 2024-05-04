using System.Globalization;


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


DateTime date =  DateTime.Now;


Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm"));


// Formating date time ! in under comment

