using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebG3.Web.Models;

namespace WebG3.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Animal> Animales { get; set; }
        public virtual DbSet<Ciudad> Ciudades { get; set; }
        public virtual DbSet<Enfermedad> Enfermedades { get; set; }
        public virtual DbSet<Raza> Razas { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<Historia> Historias { get; set; }
    }
}
