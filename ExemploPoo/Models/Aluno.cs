using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Aluno : Pessoa //this is polimorfismo ! estou herdando os atributos
    //da classe Pessoa na minha classe aluno (: classe_que_vc_quer_herdar)
    {
        public double Nota { get; set; }
    }
}