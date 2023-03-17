﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Models
{
    public class VWFacturaDetallesViewModel
    {
        public int fade_Id { get; set; }
        public int fact_Id { get; set; }
        public int? prod_Id { get; set; }
        public int? serv_Id { get; set; }
        public string prod_Nombre { get; set; }
        public string serv_Nombre { get; set; }
        public int fade_Cantidad { get; set; }
        public decimal fade_Precio { get; set; }
        public DateTime fade_FechaCreacion { get; set; }
        public int fade_UsuarioCreacion { get; set; }
        public DateTime? fade_FechaModificacion { get; set; }
        public int? fade_UsuarioModificacion { get; set; }
        public bool fade_Estado { get; set; }

    }
}
