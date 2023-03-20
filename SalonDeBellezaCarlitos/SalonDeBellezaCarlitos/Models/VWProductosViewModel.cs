using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class VWProductosViewModel
    {
        [Display(Name = "ID")]
        public int prod_Id { get; set; }
        [Display(Name = "Nombre del producto")]
        public string prod_Nombre { get; set; }
        [Display(Name = "Precio")]
        public decimal prod_Precio { get; set; }
        [Display(Name = "Categoria")]
        public int cate_Id { get; set; }
        [Display(Name = "Categoria")]
        public string cate_Descripcion { get; set; }
        [Display(Name = "Stock")]
        public int prod_Stock { get; set; }
        [Display(Name = "Proveedor")]
        public int? prov_id { get; set; }
        [Display(Name = "Proveedor")]
        public string prov_NombreEmpresa { get; set; }
        [Display(Name = "Fecha creacion")]
        public DateTime prod_FechaCreacion { get; set; }
        [Display(Name = "Usuario creacion")]
        public int prod_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha modifiacion")]
        public DateTime? prod_FechaModificacion { get; set; }
        [Display(Name = "Usuario modificacion")]
        public int? prod_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool prod_Estado { get; set; }
    }
}
