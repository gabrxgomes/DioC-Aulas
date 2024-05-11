using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//adicionamos o nosso pacote do nuget
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Venda1
    {

        //caso o nosso json venha com seu identificador diferente do padrao do
        //nome da nossa variavel na classe como nesse aqui, podemos 
        //adicionar um atributo a nossa leitura JSON
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")]//passmos esse nome caso o nome do atributo no json seja diferente do
        //que nossas variaveis aqui !
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}