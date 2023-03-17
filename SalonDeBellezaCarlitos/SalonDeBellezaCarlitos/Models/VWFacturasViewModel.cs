using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class VWFacturasViewModel
    {
        [Display(Name = "ID")]
        public int fact_Id { get; set; }
        [Display(Name = "Clinte")]
        public int clie_Id { get; set; }
        [Display(Name = "Nombre del Cliente")]
        public string clie_Nombre { get; set; }
        [Display(Name = "Apellido del Cliente")]
        public string clie_Apellido { get; set; }
        [Display(Name = "Telefono del Cliente")]
        public string clie_Telefono { get; set; }
        [Display(Name = "Estilista Id")]
        public int empl_Id_Atendido { get; set; }
        [Display(Name = "Nombre del estilista")]
        public string NombreAtendido { get; set; }
        [Display(Name = "Apellido del estilista")]
        public string ApellidoAtendido { get; set; }
        [Display(Name = "telefono del estilista")]
        public string TelefonoAtendido { get; set; }
        [Display(Name = "Cajero Id")]
        public int empl_Id_Caja { get; set; }
        [Display(Name = "Nombre del Cajero")]
        public string NombreCaja { get; set; }
        [Display(Name = "Apellido del cajero")]
        public string ApellidoCaja { get; set; }
        [Display(Name = "Telefono del cajero")]
        public string TelefonoCaja { get; set; }
        [Display(Name = "Metodo de pago Id")]
        public int metp_Id { get; set; }
        [Display(Name = "Metodo de pago")]
        public string metp_Descripcion { get; set; }
        [Display(Name = "Fecha de facturacion")]
        public DateTime fact_Fecha { get; set; }
        [Display(Name = "Creacion")]
        public DateTime fact_FechaCreacion { get; set; }
        [Display(Name = "UsuarioC")]
        public int fact_UsuarioCreacion { get; set; }
        [Display(Name = "Modificacion")]
        public DateTime? fact_FechaModificacion { get; set; }
        [Display(Name = "UsuarioM")]
        public int? fact_UsuarioModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool fact_Estado { get; set; }

    }
}
