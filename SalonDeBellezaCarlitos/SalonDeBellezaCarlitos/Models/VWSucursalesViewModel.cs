using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class VWSucursalesViewModel
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public int sucu_Id { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public string sucu_Descripcion { get; set; }
        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public int? muni_Id { get; set; }
        [Display(Name = "Codigo del municipio")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public string muni_Codigo { get; set; }
        [Display(Name = "Municipio")]
        public string muni_Descripcion { get; set; }
        [Display(Name = "Departamento")]
        public int depa_Id { get; set; }
        [Display(Name = "Codigo del departamento")]
        public string depa_Codigo { get; set; }
        [Display(Name = "Departamento")]
        public string depa_Descripcion { get; set; }
        [Display(Name = "Dirección Exacta")]
        [Required(ErrorMessage = "El Campo {0} es necesario!")]
        public string sucu_DireccionExacta { get; set; }
        [Display(Name = "FC")]
        public DateTime sucu_FechaCreacion { get; set; }
        [Display(Name = "UC")]
        public int sucu_UsuarioCreacion { get; set; }
        [Display(Name = "FM")]
        public DateTime? sucu_FechaModificacion { get; set; }
        [Display(Name = "Um")]
        public int? sucu_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool sucu_Estado { get; set; }

    }
}
