using  System;
using System.ComponentModel.DataAnnotations;

namespace JordyP1_Apl.Entidades{

    public class Ciudades{
        [Key]

        public int CiudadesId { get; set; }

        public string Nombre { get; set; }
    }
}