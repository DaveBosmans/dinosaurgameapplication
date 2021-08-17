using DinosaurAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinosaurAPI.DatabaseContext
{
    public class DinoDBContext : DbContext
    {
        public DinoDBContext(DbContextOptions<DinoDBContext> options) : base(options)
        {

        }
        public DbSet<DinoModel> Dinosaurs { get; set; }
    }
}
