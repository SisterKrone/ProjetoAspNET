using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COVID19.Models
{
    public class Usuarios
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Sexo { get; set; }

        public string TipoSanguineo { get; set; }

         public string Estado { get; set; }

         public string Cidade { get; set; }
        

    }
}