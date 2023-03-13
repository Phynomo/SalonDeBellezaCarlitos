using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class CargoViewModel
    {
        [Display(Name = "Id")]
        public int carg_Id { get; set; }
        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public string carg_Descripcion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime carg_FechaCreacion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int carg_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? carg_FechaModificacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public int? carg_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool? carg_Estado { get; set; }

    }
}
