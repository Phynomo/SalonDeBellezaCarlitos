﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SalonDeBellezaCarlitos.Entities.Entities
{
    public partial class VW_tbMunicipios_View
    {
        public int muni_Id { get; set; }
        public string muni_Descripcion { get; set; }
        public string muni_Codigo { get; set; }
        public int depa_Id { get; set; }
        public string depa_Codigo { get; set; }
        public string depa_Descripcion { get; set; }
        public DateTime muni_FechaCreacion { get; set; }
        public int muni_UsuarioCreacion { get; set; }
        public DateTime? muni_FechaModificacion { get; set; }
        public int? muni_UsuarioModificacion { get; set; }
        public bool muni_Estado { get; set; }
    }
}