using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Pessoa
    {
        //Declaração dos Atributos da Classe: Pessoa
        public int Codigo { get; set; }
        public string Nome  { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
    }
}
