﻿using Microsoft.EntityFrameworkCore;

namespace costnotebook_backend.Models.Seeders;
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        //Department
        modelBuilder.Entity<User>()
            .HasData(
               new User { UserID = 1,
                   FirstName = "Jakub",
                   Password = "pass123",
                   UserEmail="jakukprzybyl@gmail.com" },
                new User
                {
                    UserID = 2,
                    FirstName = "Krzysztof",
                    Password = "pass123",
                    UserEmail = "krzychudobrz@gmail.com"
                },
                new User
                {
                    UserID = 3,
                    FirstName = "Łukasz",
                    Password = "pass123",
                    UserEmail = "lukaszprzybyl@gmail.com"
                },
                 new User
                 {
                     UserID = 4,
                     FirstName = "Admin",
                     Password = "admin",
                     UserEmail = "admin@admin.com"
                 }
        );

        modelBuilder.Entity<Transaction>().HasData(new Transaction
        {
            TransactionId = 1,
            Description = "IKEA",
            Data = new DateTime(2021, 5, 12, 12, 52, 12),
            Category = CategoryTransaction.FoodAndHouseholdChemistry,
            Amount = -50.68,
            UserId = 4,
        });
    }
}
