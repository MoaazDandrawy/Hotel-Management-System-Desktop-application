using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Hotel.DataBase;

namespace Hotel
{
    internal class HotelDBContext : DbContext
    {
        public HotelDBContext() : base("name=HotelDB")
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Type> Types { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<DataReport> DataReport { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().ToTable("Customer");

            modelBuilder.Entity<Room>().ToTable("Room");

            modelBuilder.Entity<Type>().ToTable("Type");

            modelBuilder.Entity<User>().ToTable("User");

            modelBuilder.Entity<Booking>().ToTable("Booking");


        }




    }
}
