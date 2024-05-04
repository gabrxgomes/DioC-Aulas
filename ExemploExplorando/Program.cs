using System.Globalization;


CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt_BR");
//use this if you are completly decided that your code in full culture



//TRABALHANDO COM MOEDAS

decimal valorMonetario = 1582.40M;

//Console.WriteLine($"{valorMonetario:C}");

Console.WriteLine(valorMonetario.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));

//case i use just C or C2 set my value in 2 decimal cases, just C1 one deciamal case


