using MvcEfApp.Models;
using System;
using Microsoft.EntityFrameworkCore;
namespace MvcEfApp.Models
{
        public class HospitalDbContext : DbContext
        {
            public DbSet<Doctor> Doctors { get; set; }
            public DbSet<Patient> Patients { get; set; }
            public DbSet<Appointment> Appointments { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                String constring = @"server=200411LTP2726\SQLEXPRESS;database=HospitalDB;
                   integrated security=true;Encrypt=false;";
                options.UseSqlServer(constring);
            }
        //migration folder-initializecreate
        //dotnet ef migrations add InitialCreate
        //dotnet ef database update
    }
}
