using System;
using System.ComponentModel.DataAnnotations;

namespace COVID19.Models
{
    public class Usuarios
    {
        [Key]
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Sexo { get; set; }

        public string TipoSanguineo { get; set; }

         public string Estado { get; set; }

         public string Cidade { get; set; }
        

    }
}