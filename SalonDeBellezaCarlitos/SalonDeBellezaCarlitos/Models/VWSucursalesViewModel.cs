using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class VWSucursalesViewModel
    {
        public int sucu_Id { get; set; }
        public string sucu_Descripcion { get; set; }
        public int? muni_Id { get; set; }
        public string muni_Codigo { get; set; }
        public string muni_Descripcion { get; set; }
        public int depa_Id { get; set; }
        public string depa_Codigo { get; set; }
        public string depa_Descripcion { get; set; }
        public string sucu_DireccionExacta { get; set; }
        public DateTime sucu_FechaCreacion { get; set; }
        public int sucu_UsuarioCreacion { get; set; }
        public DateTime? sucu_FechaModificacion { get; set; }
        public int? sucu_UsuarioModificacion { get; set; }
        public bool sucu_Estado { get; set; }

    }
}
