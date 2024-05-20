using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TestRecord.Models
{
    public record Pessoa
    (
        int Id,
        String Name,
        bool AccountPremium
        
    ){
        public void Apresentar()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"AccountPremium: {AccountPremium}");
        }
    }
    

   
    
}