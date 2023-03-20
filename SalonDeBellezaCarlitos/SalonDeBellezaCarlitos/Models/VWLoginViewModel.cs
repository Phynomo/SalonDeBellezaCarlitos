using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class VWLoginViewModel
    {
        public int usur_Id { get; set; }
        public string usur_Usuario { get; set; }
        public string usur_Contrasenia { get; set; }
        public int empl_Id { get; set; }
        public string empl_NombreCompleto { get; set; }
        public string empl_Nombre { get; set; }
        public string empl_Apellido { get; set; }
        public int sucu_Id { get; set; }
        public int carg_Id { get; set; }
        public string carg_Descripcion { get; set; }
        public int usur_UsuarioCreacion { get; set; }
        public DateTime usur_FechaCreacion { get; set; }
        public int? usur_UsuarioModificacion { get; set; }
        public DateTime? usur_FechaModificacion { get; set; }
        public bool usur_Estado { get; set; }
    }
}
