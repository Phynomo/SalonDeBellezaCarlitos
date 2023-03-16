using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class VWMunicipiosViewModel
    {
        [Display(Name = "Id")]
        public int muni_Id { get; set; }
        [Display(Name = "Nombre del municipio")]
        public string muni_Descripcion { get; set; }
        [Display(Name = "Codigo del municipio")]
        public string muni_Codigo { get; set; }
        [Display(Name = "departamen Id")]
        public int depa_Id { get; set; }
        [Display(Name = "Codigo del departamento")]
        public string depa_Codigo { get; set; }
        [Display(Name = "Nombre del departamento")]
        public string depa_Descripcion { get; set; }
        [Display(Name = "Fecha de creacion")]
        public DateTime muni_FechaCreacion { get; set; }
        [Display(Name = "Usuario Creador")]
        public int muni_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha de modificacion")]
        public DateTime? muni_FechaModificacion { get; set; }
        [Display(Name = "Usuario modificador")]
        public int? muni_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool muni_Estado { get; set; }
    }
}
