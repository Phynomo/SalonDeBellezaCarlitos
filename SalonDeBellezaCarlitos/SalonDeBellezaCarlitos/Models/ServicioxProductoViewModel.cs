using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class ServicioxProductoViewModel
    {
        [Display(Name = "ID")]
        public int spro_Id { get; set; }
        [Display(Name = "Servicio")]
        public int? serv_Id { get; set; }
        [Display(Name = "Producto")]
        public int? prod_Id { get; set; }
        [Display(Name = "Fecha creacion")]
        public DateTime spro_FechaCreacion { get; set; }
        [Display(Name = "Usuario creacion")]
        public int spro_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha modificacion")]
        public DateTime? spro_FechaModificacion { get; set; }
        [Display(Name = "Usuario modificacion")]
        public int? spro_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool? spro_Estado { get; set; }
    }
}
