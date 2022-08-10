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
                           Password = "pass123",
                           UserEmail = "jakukprzybyl@gmail.com"
                       },
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
                        Date = new DateTime(2021, 5, 12, 12, 52, 12),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -50.68,
                        UserId = 4,
                    }, new Transaction
                    {
                        TransactionId = 2,
                        Description = "JMP S.A BIEDRONKA 1862",
                        Date = new DateTime(2021, 5, 12, 16, 11, 20),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -75.89,
                        UserId = 4,
                    }, new Transaction
                    {
                        TransactionId = 3,
                        Description = "JMP S.A BIEDRONKA 1862",
                        Date = new DateTime(2021, 5, 12, 16, 11, 20),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -75.89,
                        UserId = 4,
                    }, new Transaction
                    {
                        TransactionId = 4,
                        Description = "ZABKA Z8235 K.1",
                        Date = new DateTime(2021, 5, 12, 20, 32, 48),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -21.29,
                        UserId = 4,
                    }, new Transaction
                    {
                        TransactionId = 5,
                        Description = "BOLT.EU/R/236296201",
                        Date = new DateTime(2021, 5, 12, 22, 13, 27),
                        Category = CategoryTransaction.Crossings,
                        Amount = -10.78,
                        UserId = 4,
                    }, new Transaction
                    {
                        TransactionId = 6,
                        Description = "IKEA Retail Sp. z o",
                        Date = new DateTime(2021, 5, 13, 17, 32, 43),
                        Category = CategoryTransaction.RenovationAndGarden,
                        Amount = -180.90,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 7,
                        Description = "KAPSEL",
                        Date = new DateTime(2021, 5, 13, 20, 42, 12),
                        Category = CategoryTransaction.EatingOut,
                        Amount = -75.64,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 8,
                        Description = "KOMFORT",
                        Date = new DateTime(2021, 5, 14, 14, 40, 20),
                        Category = CategoryTransaction.AccessoriesAndEquipment,
                        Amount = -209.90,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 9,
                        Description = "JAN KOWALSKI-MONEY TRANSFER",
                        Date = new DateTime(2021, 5, 14, 20, 40, 20),
                        Category = CategoryTransaction.Uncategorized,
                        Amount = -100,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 10,
                        Description = "SERWUS BABKI SP. 12301",
                        Date = new DateTime(2021, 5, 15, 20, 43, 12),
                        Category = CategoryTransaction.OutingsAndEvents,
                        Amount = -18,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 11,
                        Description = "ENERGA-MONEY TRANSFER",
                        Date = new DateTime(2021, 5, 15, 21, 52, 20),
                        Category = CategoryTransaction.Current,
                        Amount = -24.90,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 12,
                        Description = "JMP S.A BIEDRONKA 1862",
                        Date = new DateTime(2021, 5, 16, 8, 42, 32),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -209.90,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 13,
                        Description = "DEV-COMPANY",
                        Date = new DateTime(2021, 5, 16, 14, 53, 23),
                        Category = CategoryTransaction.Renumeration,
                        Amount = 5670,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 14,
                        Description = "BIURO PRZEWODNICKIE PIERN",
                        Date = new DateTime(2021, 5, 16, 19, 27, 49),
                        Category = CategoryTransaction.GiftsAndSupport,
                        Amount = -58.00,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 15,
                        Description = "ZABKA Z8235 K.1",
                        Date = new DateTime(2021, 5, 16, 21, 32, 20),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -7.98,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 16,
                        Description = "ZAHIRE KEBAB TORUN O",
                        Date = new DateTime(2021, 5, 17, 19, 42, 57),
                        Category = CategoryTransaction.OutingsAndEvents,
                        Amount = -7.98,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 17,
                        Description = "BOLT.EU/R/2134363",
                        Date = new DateTime(2021, 5, 17, 23, 27, 23),
                        Category = CategoryTransaction.OutingsAndEvents,
                        Amount = -7.98,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 18,
                        Description = "JMP S.A BIEDRONKA 1862",
                        Date = new DateTime(2021, 5, 18, 7, 39, 20),
                        Category = CategoryTransaction.FoodAndHouseholdChemistry,
                        Amount = -48.90,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 19,
                        Description = "BLIK P2P-INCOMING",
                        Date = new DateTime(2021, 5, 18, 17, 32, 24),
                        Category = CategoryTransaction.Influences,
                        Amount = 20,
                        UserId = 4
                    }, new Transaction
                    {
                        TransactionId = 20,
                        Description = "ORLEN",
                        Date = new DateTime(2021, 5, 18, 20, 45, 21),
                        Category = CategoryTransaction.Flue,
                        Amount = -309.80,
                        UserId = 4
                    });
    }
    #endregion
}
