using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class VWServicioxproductoViewModel
    {
        [Display(Name = "ID")]
        public int spro_Id { get; set; }
        [Display(Name = "Servicio")]
        public int? serv_Id { get; set; }
        [Display(Name = "Nombre del servicio")]
        public string serv_Nombre { get; set; }
        [Display(Name = "Descripcion del servicio")]
        public string serv_Descripcion { get; set; }
        [Display(Name = "Precio del servicio")]
        public decimal serv_Precio { get; set; }
        [Display(Name = "Producto")]
        public int? prod_Id { get; set; }
        [Display(Name = "Nombre del producto")]
        public string prod_Nombre { get; set; }
        [Display(Name = "Precio del producto")]
        public decimal prod_Precio { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime spro_FechaCreacion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int spro_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? spro_FechaModificacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public int? spro_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool spro_Estado { get; set; }
    }
}
