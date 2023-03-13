using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class MetodoPagoViewModel
    {
        [Display(Name = "Id")]
        public int metp_Id { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public string metp_Descripcion { get; set; }
        [Display(Name = "Fecha creacion")]
        public DateTime metp_FechaCreacion { get; set; }
        [Display(Name = "Usuario creacion")]
        public int metp_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha modificacion")]
        public DateTime? metp_FechaModificacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public int? metp_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool? metp_Estado { get; set; }
    }
}
