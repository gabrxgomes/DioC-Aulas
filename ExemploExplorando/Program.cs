using System.Globalization;


CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt_BR");



//TRABALHANDO COM MOEDAS

decimal valorMonetario = 1582.40M;

//Console.WriteLine($"{valorMonetario:C}");

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

