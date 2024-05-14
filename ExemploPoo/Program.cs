using ExemploPoo.Models;
// Conta c1 = new Conta();
// c1.saldo = 10;
// c1.ExibirSaldo();

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();


//Iniciando classe abstrata que tem como objetivo ser um modelo a ser herdado, 
//portanto a mesma não pode ser instanciada

//então eu posso implementar metodos ou deixa-los a cargo de quem herdar essa classe abstrata
//a nossa classe abstrata se chamara "conta"


// Aluno a1 = new Aluno();
// a1.Nome = "Nome aluno1";
// a1.Idade = 10;
// a1.Email = "fulano@gmail.com";


// a1.Apresentar();
























// ContaCorrente c1 = new ContaCorrente(123, 1000);

// //c1.saldo = 5; //impossivel acessar pois o .saldo é privado na minha 
// //classe conta corrente


// c1.ExibirSaldo(); //chamandoo metodo que faz o print do saldo
// c1.Sacar(5000);
// c1.ExibirSaldo();













//inicio poo abstração
// Pessoa p1 = new Pessoa();

// p1.Nome = "John";
// p1.Idade = 20;

// p1.Apresentar();
