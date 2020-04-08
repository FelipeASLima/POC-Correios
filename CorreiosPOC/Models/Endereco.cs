using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorreiosPOC.Models
{
    [Table("Endereco")]
    public class Endereco
    {        
        public int Id { get; set;}
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }  
        public string complemento { get; set; }
        public string endereco { get; set; }
        public string uf { get; set; }

    }
}
