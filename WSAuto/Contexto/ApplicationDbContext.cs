
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSAuto.Models;


namespace WSAuto.Contexto
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        //Acá van las tablas        
        public DbSet<Auto> Autos { get; set; }
    }
}
