using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class ReservacionesViewModel
    {
        [Display(Name = "Id")]
        public int rese_Id { get; set; }
        [Display(Name = "Cliente Id")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public int clie_Id { get; set; }
        [Display(Name = "Sucursal Id")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public int sucu_Id { get; set; }
        [Display(Name = "Día Reservado")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public DateTime rese_DiaReservado { get; set; }
        [Display(Name = "Hora Inicio")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public TimeSpan rese_HoraInicio { get; set; }
        [Display(Name = "Hora Fin")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public TimeSpan rese_HoraFin { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime rese_FechaCreacion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int rese_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? rese_FechaModificacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public int? rese_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool? rese_Estado { get; set; }
    }
}
