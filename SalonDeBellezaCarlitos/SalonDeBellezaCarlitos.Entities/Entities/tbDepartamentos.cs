﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SalonDeBellezaCarlitos.Entities.Entities
{
    public partial class tbDepartamentos
    {
        public tbDepartamentos()
        {
            tbMunicipios = new HashSet<tbMunicipios>();
        }

        public int depa_Id { get; set; }
        public string depa_Descripcion { get; set; }
        public string depa_Codigo { get; set; }
        public DateTime depa_FechaCreacion { get; set; }
        public int depa_UsuarioCreacion { get; set; }
        public DateTime? depa_FechaModificacion { get; set; }
        public int? depa_UsuarioModificacion { get; set; }
        public bool? depa_Estado { get; set; }

        public virtual tbUsuarios depa_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios depa_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMunicipios> tbMunicipios { get; set; }
    }
}