﻿using Microsoft.EntityFrameworkCore;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class CategoriaRepository : IRepository<tbCategorias>
    {
        public int Delete(tbCategorias item)
        {
            throw new NotImplementedException();
        }

        public tbCategorias find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbCategorias.Find(id);
            return listado;
        }

        public int Insert(tbCategorias item)
        {
            using var db = new SalonCarlitosContext();
            db.tbCategorias.Add(item);
            return item.cate_Id;
        }

        public IEnumerable<tbCategorias> List()
        {
            using var db = new SalonCarlitosContext();
            return db.tbCategorias.ToList();
        }

        public int Update(tbCategorias item)
        {
            using var db = new SalonCarlitosContext();
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return item.cate_Id;
        }
    }
}