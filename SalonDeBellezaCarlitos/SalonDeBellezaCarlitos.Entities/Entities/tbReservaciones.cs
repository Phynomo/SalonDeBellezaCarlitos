﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SalonDeBellezaCarlitos.Entities.Entities
{
    public partial class tbReservaciones
    {
        public int rese_Id { get; set; }
        public int clie_Id { get; set; }
        public int sucu_Id { get; set; }
        public DateTime rese_DiaReservado { get; set; }
        public TimeSpan rese_HoraInicio { get; set; }
        public TimeSpan rese_HoraFin { get; set; }
        public DateTime rese_FechaCreacion { get; set; }
        public int rese_UsuarioCreacion { get; set; }
        public DateTime? rese_FechaModificacion { get; set; }
        public int? rese_UsuarioModificacion { get; set; }
        public bool? rese_Estado { get; set; }

        public virtual tbClientes clie { get; set; }
        public virtual tbUsuarios rese_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios rese_UsuarioModificacionNavigation { get; set; }
        public virtual tbSucursales sucu { get; set; }
    }
}