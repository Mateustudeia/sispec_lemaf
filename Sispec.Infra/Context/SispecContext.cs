﻿using Microsoft.EntityFrameworkCore;
using Sispec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sispec.Infra.Context
{
    class SispecContext : DbContext
    {
        public DbSet<Palestra> Palestra { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Local> Local { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host = localhost; Database = dbsispec; Username = tudeia; Password = 123456");
        

    }
}
