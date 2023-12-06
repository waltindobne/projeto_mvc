using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace catalogo_carros.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
