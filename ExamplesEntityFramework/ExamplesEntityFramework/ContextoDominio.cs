using ExamplesEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesEntityFramework
{
    //[DbConfigurationType(typeof(ContextoConfiguracion))]
    public class ContextoDominio : DbContext
    {
        public ContextoDominio() : base("entity_framework_examples")
        {

        }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }

    //Custom convention primary key
    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    modelBuilder.Properties<int>()
    //                .Where(p => p.Name.EndsWith("Key"))
    //                .Configure(p => p.IsKey());

    //    modelBuilder.Conventions.Add(new DateTime2Convention());
    //}
}
