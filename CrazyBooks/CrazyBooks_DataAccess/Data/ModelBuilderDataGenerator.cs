using CrazyBooks_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_DataAccess.Data
{
    public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {
            #region Données Subject
                builder.Entity<Subject>().HasData(new Subject() { Id = 1, Name = "Policier" });
                builder.Entity<Subject>().HasData(new Subject() { Id = 2, Name = "Drame" });
                builder.Entity<Subject>().HasData(new Subject() { Id = 3, Name = "Biographie" });
                builder.Entity<Subject>().HasData(new Subject() { Id = 4, Name = "Science Fiction" });
            #endregion


            #region Données Publisher
            builder.Entity<Publisher>().HasData(new Publisher() { Id = 1, Name = "Ada" });
            builder.Entity<Publisher>().HasData(new Publisher() { Id = 2, Name = "J'ai lu" });
            #endregion
        }
    }
}
