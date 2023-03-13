using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class ProductoViewModel
    {
        [Display(Name = "Id")]
        public int prod_Id { get; set; }
        [Required(ErrorMessage = "El Campo {0} es necesaria!")]
        [Display(Name = "Nombre")]
        public string prod_Nombre { get; set; }
        [Required(ErrorMessage = "El Campo {0} es necesaria!")]
        [Display(Name = "Precio")]
        public decimal prod_Precio { get; set; }
        [Required(ErrorMessage = "El Campo {0} es necesaria!")]
        [Display(Name = "Categoria")]
        public int cate_Id { get; set; }
        [Required(ErrorMessage = "El Campo {0} es necesaria!")]
        [Display(Name = "Stock")]
        public int prod_Stock { get; set; }
        [Required(ErrorMessage = "El Campo {0} es necesaria!")]
        [Display(Name = "Proveedor")]
        public int? prov_id { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime prod_FechaCreacion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int prod_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? prod_FechaModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public int? prod_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool? prod_Estado { get; set; }
    }
}