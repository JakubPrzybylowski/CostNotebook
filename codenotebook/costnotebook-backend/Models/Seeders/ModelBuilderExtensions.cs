using Microsoft.EntityFrameworkCore;

namespace costnotebook_backend.Models.Seeders;
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        GetUsers(modelBuilder);
        GetTransactions(modelBuilder);
    }

    #region GetUsers
    private static void GetUsers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
                    .HasData(
                       new User
                       {
                           UserID = 1,
                           FirstName = "Jakub",
                           LastName = "Przy",
                           Password = "pass123",
                           UserEmail = "jakukprzybyl@gmail.com"
                       },
                        new User
                        {
                            UserID = 2,
                            FirstName = "Krzysztof",
                            LastName = "Dob",
                            Password = "pass123",
                            UserEmail = "krzychudobrz@gmail.com"
                        },
                        new User
                        {
                            UserID = 3,
                            FirstName = "Łukasz",
                            LastName = "Przy",
                            Password = "pass123",
                            UserEmail = "lukaszprzybyl@gmail.com"
                        },
                         new User
                         {
                             UserID = 4,
                             FirstName = "Admin",
                             LastName = "Admin",
                             Password = "admin",
                             UserEmail = "admin@admin.com"
                         }
                );
    }
    #endregion

    #region GetTransactions
    private static void GetTransactions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transaction>().HasData(
                    new Transaction
                    {
                        TransactionId = 1,
                        Description = "IKEA",
                        Date = new DateTime(2021, 5, 12),
                        Category = CategoryTransaction.RenovationAndGarden,
                        Amount = -50.68,
                        UserId = 4,
                    }, new Transaction
                    {
                        TransactionId = 2,
                        Description = "JMP S.A BIEDRONKA 1862",
                        Date = new DateTime(2021, 5, 12),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -75.89,
                        UserId = 4,
                    }, new Transaction
                    {
                        TransactionId = 3,
                        Description = "JMP S.A BIEDRONKA 1862",
                        Date = new DateTime(2021, 5, 12),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -75.89,
                        UserId = 4,
                    }, new Transaction
                    {
                        TransactionId = 4,
                        Description = "ZABKA Z8235 K.1",
                        Date = new DateTime(2021, 5, 12),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -21.29,
                        UserId = 4,
                    }, new Transaction
                    {
                        TransactionId = 5,
                        Description = "BOLT.EU/R/236296201",
                        Date = new DateTime(2021, 5, 12),
                        Category = CategoryTransaction.Crossings,
                        Amount = -10.78,
                        UserId = 4,
                    }, new Transaction
                    {
                        TransactionId = 6,
                        Description = "IKEA Retail Sp. z o",
                        Date = new DateTime(2021, 5, 13),
                        Category = CategoryTransaction.RenovationAndGarden,
                        Amount = -180.90,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 7,
                        Description = "KAPSEL",
                        Date = new DateTime(2021, 5, 13),
                        Category = CategoryTransaction.EatingOut,
                        Amount = -75.64,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 8,
                        Description = "KOMFORT",
                        Date = new DateTime(2021, 5, 14),
                        Category = CategoryTransaction.AccessoriesAndEquipment,
                        Amount = -209.90,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 9,
                        Description = "JAN KOWALSKI-MONEY TRANSFER",
                        Date = new DateTime(2021, 5, 14),
                        Category = CategoryTransaction.Uncategorized,
                        Amount = -100,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 10,
                        Description = "SERWUS BABKI SP. 12301",
                        Date = new DateTime(2021, 5, 15),
                        Category = CategoryTransaction.OutingsAndEvents,
                        Amount = -18,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 11,
                        Description = "ENERGA-MONEY TRANSFER",
                        Date = new DateTime(2021, 5, 15),
                        Category = CategoryTransaction.Current,
                        Amount = -24.90,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 12,
                        Description = "JMP S.A BIEDRONKA 1862",
                        Date = new DateTime(2021, 5, 16),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -209.90,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 13,
                        Description = "DEV-COMPANY",
                        Date = new DateTime(2021, 5, 16),
                        Category = CategoryTransaction.Renumeration,
                        Amount = 5670,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 14,
                        Description = "BIURO PRZEWODNICKIE PIERN",
                        Date = new DateTime(2021, 5, 16),
                        Category = CategoryTransaction.GiftsAndSupport,
                        Amount = -58.00,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 15,
                        Description = "ZABKA Z8235 K.1",
                        Date = new DateTime(2021, 5, 16),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -7.98,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 16,
                        Description = "ZAHIRE KEBAB TORUN O",
                        Date = new DateTime(2021, 5, 17),
                        Category = CategoryTransaction.OutingsAndEvents,
                        Amount = -7.98,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 17,
                        Description = "BOLT.EU/R/2134363",
                        Date = new DateTime(2021, 5, 17),
                        Category = CategoryTransaction.OutingsAndEvents,
                        Amount = -7.98,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 18,
                        Description = "JMP S.A BIEDRONKA 1862",
                        Date = new DateTime(2021, 5, 18),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -48.90,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 19,
                        Description = "BLIK P2P-INCOMING",
                        Date = new DateTime(2021, 5, 18),
                        Category = CategoryTransaction.Influences,
                        Amount = 20,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 20,
                        Description = "ORLEN",
                        Date = new DateTime(2021, 5, 18),
                        Category = CategoryTransaction.Flue,
                        Amount = -309.80,
                        UserId = 4
                    });
    }
    #endregion
}
