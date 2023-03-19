using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class VWUsuariosViewModel
    {
        [Display(Name = "Id")]
        public int usur_Id { get; set; }
        [Display(Name = "Usuario")]
        public string usur_Usuario { get; set; }
        [Display(Name = "Contraseña")]
        public string usur_Contrasenia { get; set; }
        [Display(Name = "Empleado")]
        public int empl_Id { get; set; }
        [Display(Name = "Nombre del empleado")]
        public string empl_Nombre { get; set; }
        [Display(Name = "Apellido del empleado")]
        public string empl_Apellido { get; set; }
        [Display(Name = "Usuario creacion")]
        public int usur_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha crecion")]
        public DateTime usur_FechaCreacion { get; set; }
        [Display(Name = "Usuario modificacion")]
        public int? usur_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha modificacion")]
        public DateTime? usur_FechaModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool usur_Estado { get; set; }
    }
}
