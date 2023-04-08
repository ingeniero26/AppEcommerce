using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AppEcommerce.Models
{
    public class EcommerceContext :DbContext
    {
        public EcommerceContext() : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        //metodo para cerrar la conexion a la base de datos
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public System.Data.Entity.DbSet<AppEcommerce.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<AppEcommerce.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<AppEcommerce.Models.DocumentType> DocumentTypes { get; set; }
    }
}