using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(250)]
        public string Apellido { get; set; }
        [Required]
        [MaxLength(11)]
        public string Cedula { get; set; }
        [Required]
        public string Edad { get; set; }
        [Required]
        [MaxLength(250)]
        public string CorreoElectronico { get; set; }
        [MaxLength(250)]
        public string Direccion { get; set; }
        [Required]
        [MaxLength(1)]
        public string Sexo { get; set; }
        [MaxLength(250)]
        public string LugarNacimiento { get; set; }
        [MaxLength(15)]
        public string Status { get; set; }


    }
}
