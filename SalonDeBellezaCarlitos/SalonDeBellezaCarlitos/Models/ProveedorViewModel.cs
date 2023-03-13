using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class ProveedorViewModel
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public int prov_Id { get; set; }
        [Display(Name = "Nombre de la empresa")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public string prov_NombreEmpresa { get; set; }
        [Display(Name = "Nombre del contacto")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public string prov_NombreContacto { get; set; }
        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public int muni_Id { get; set; }
        [Display(Name = "Direccion Exacta")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public string prov_DireccionExacta { get; set; }
        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "El campo {0} es necesario!")]
        public string prov_Telefono { get; set; }
        [Display(Name = "Fecha creacion")]
        public DateTime prov_FechaCreacion { get; set; }
        [Display(Name = "Usuario creacion")]
        public int prov_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha creacion")]
        public DateTime? prov_FechaModificacion { get; set; }
        [Display(Name = "Usuario creacion")]
        public int? prov_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool? prov_Estado { get; set; }

    }
}
