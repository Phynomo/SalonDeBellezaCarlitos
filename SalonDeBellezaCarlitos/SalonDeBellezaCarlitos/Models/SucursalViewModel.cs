using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class SucursalViewModel
    {
        [Display(Name = "ID")]
        public int sucu_Id { get; set; }
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public string sucu_Descripcion { get; set; }
        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public int? muni_Id { get; set; }
        [Display(Name = "Dirección Exacta")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public string sucu_DireccionExacta { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime sucu_FechaCreacion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int sucu_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? sucu_FechaModificacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public int? sucu_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool? sucu_Estado { get; set; }
        [Display(Name = "Departamento")]
        public int depa_Id { get; set; }
    }
}
