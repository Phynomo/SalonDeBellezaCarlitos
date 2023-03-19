using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class VWReservacionesViewModel
    {
        [Display(Name = "Id")]
        public int rese_Id { get; set; }
        [Display(Name = "Clinte")]
        public int clie_Id { get; set; }
        [Display(Name = "Nombre del cliente")]
        public string clie_Nombre { get; set; }
        [Display(Name = "Apellido del cliente")]
        public string clie_Apellido { get; set; }
        [Display(Name = "Telefono")]
        public string clie_Telefono { get; set; }
        [Display(Name = "Sucursal")]
        public int sucu_Id { get; set; }
        [Display(Name = "Descripcion")]
        public string sucu_Descripcion { get; set; }
        [Display(Name = "Direccion exacta")]
        public string sucu_DireccionExacta { get; set; }
        [Display(Name = "Dia reservado")]
        public DateTime rese_DiaReservado { get; set; }
        [Display(Name = "Hora inicio")]
        public TimeSpan rese_HoraInicio { get; set; }
        [Display(Name = "Hora fin")]
        public TimeSpan rese_HoraFin { get; set; }
        [Display(Name = "Fecha de creacion")]
        public DateTime rese_FechaCreacion { get; set; }
        [Display(Name = "Usuario creacion")]
        public int rese_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha modificacion")]
        public DateTime? rese_FechaModificacion { get; set; }
        [Display(Name = "Usuario modificacion")]
        public int? rese_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool rese_Estado { get; set; }

    }
}
