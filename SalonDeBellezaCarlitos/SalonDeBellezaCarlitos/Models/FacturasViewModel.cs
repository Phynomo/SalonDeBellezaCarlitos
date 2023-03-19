using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class FacturasViewModel
    {
        [Display(Name = "Id")]
        public int fact_Id { get; set; }
        [Display(Name = "Cliente")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public int clie_Id { get; set; }
        [Display(Name = "Estilista")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public int empl_Id_Atendido { get; set; }
        [Display(Name = "Cajero")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public int empl_Id_Caja { get; set; }
        [Display(Name = "Metodo de Pago")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public int metp_Id { get; set; }
        [Display(Name = "Fecha De Factura")]
        public DateTime fact_Fecha { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime fact_FechaCreacion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int fact_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? fact_FechaModificacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public int? fact_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool? fact_Estado { get; set; }

        [Display(Name = "Detalle")]
        public int fade_Id { get; set; }
        [Display(Name = "Producto")]
        public int? prod_Id { get; set; }
        [Display(Name = "Servicio")]
        public int? serv_Id { get; set; }
        [Display(Name = "Cantidad")]
        public int fade_Cantidad { get; set; }
        [Display(Name = "Precio Unitario")]
        public decimal fade_Precio { get; set; }
        [Display(Name = "FC")]
        public DateTime fade_FechaCreacion { get; set; }
        [Display(Name = "UC")]
        public int fade_UsuarioCreacion { get; set; }
        [Display(Name = "FM")]
        public DateTime? fade_FechaModificacion { get; set; }
        [Display(Name = "UM")]
        public int? fade_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool? fade_Estado { get; set; }

    }
}
