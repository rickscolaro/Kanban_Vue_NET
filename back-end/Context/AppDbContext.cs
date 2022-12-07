using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace back_end.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {

            // mb.Entity<Cliente>().HasData(
            //     new Cliente
            //     {
            //         ClienteId = 1,
            //         Descricao = "Apple",
            //     },
            //      new Cliente
            //     {
            //         ClienteId = 2,
            //         Descricao = "Microsoft",
            //     }
            // );
            // mb.Entity<Produto>().HasData(
            //     new Produto
            //     {
            //        ProdutoId =1,
            //        Descricao= "Chip",
            //        Quantidade = 5000,
            //        ClienteId =1
            //     },
            //      new Produto
            //     {
            //        ProdutoId =2,
            //        Descricao= "SmartPhone",
            //        Quantidade = 1000,
            //        ClienteId =2
            //     }
            // );
        }

    }



}