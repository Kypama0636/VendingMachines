﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VendingMachine
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VendingMachinesEntities : DbContext
    {
        public VendingMachinesEntities()
            : base("name=VendingMachinesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Coins> Coins { get; set; }
        public virtual DbSet<Drinks> Drinks { get; set; }
        public virtual DbSet<VendingMachineCoins> VendingMachineCoins { get; set; }
        public virtual DbSet<VendingMachineDrinks> VendingMachineDrinks { get; set; }
        public virtual DbSet<VendingMachines> VendingMachines { get; set; }
    }
}
