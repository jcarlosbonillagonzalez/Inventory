using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
//Agregar la libreria clic derecho en dependencias y seleccionar ManageNuget Packages e instalar entity framework net core ultima version
namespace DataAcces
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOputEntity> InOut { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        //Instalar en dependencias el complemento en nugets de sqlserver
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured)
            {
                //options.UseSqlServer("Server= SERVERPERSONAL; Database=Inventorydb; User=sa; Password=QWaszx12*;");

                options.UseSqlServer("Server=DESKTOP-DSJLN4R; Database=Inventorydb; User=sa; Password=QWaszx12;");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<CategoryEntity>().HasData(
        //        new CategoryEntity { AliasCategory = "ASH", CategoryName="Aseo Hogar"},
        //        new CategoryEntity { AliasCategory = "ASP", CategoryName = "Aseo Personal" },
        //        new CategoryEntity { AliasCategory = "HGR", CategoryName = "Hogar" },
        //        new CategoryEntity { AliasCategory = "PRF", CategoryName = "Perfumeria" },
        //        new CategoryEntity { AliasCategory = "SLD", CategoryName = "Salud" },
        //        new CategoryEntity { AliasCategory = "VDJ", CategoryName = "Video Juegos" }
        //        );
        //    modelBuilder.Entity<WarehouseEntity>().HasData
        //        (
        //            new WarehouseEntity(){ WarehouseName = "Bodega Central",
        //                WarehouseAddress = "932 Pallet Street, La Grange (Dutchess), NY 12540"},
        //            new WarehouseEntity(){WarehouseName = "Bodega Norte",
        //                WarehouseAddress = "4447 Dane Street, Yakima, WA 98908"},
        //            new WarehouseEntity(){WarehouseName = "Bodega Sur",
        //                WarehouseAddress = "3003 Arrowood Drive, Jacksonville, FL 32257"}
        //        );
        //}

    }
}
