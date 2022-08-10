export class Transaction
{
    TransactionId: any 
    DataTime!: Date 
    Description!: string
    Category!: TransactionCategory
    Amount!: number
}
enum TransactionCategory {
  FoodAndHouseholdChemistry = "Food And Household Chemistry",
  Crossings = "Crossings",
  Influences = "Influences",
  AccessoriesAndEquipment = "Accessories And Equipment",
  EatingOut = "Eating Out",
  Uncategorized ="Uncategorized",
  OutingsAndEvents ="Outings And Events",
  Current ="Current",
  GiftsAndSupport = "Gifts And Suppor",
  Renumeration = "Renumeration",
  RegularSaving = "Regular Saving",
  Flue = "Flue",
  RenovationAndGarden ="Renovation And Garden",
  MultimediaBooksAndPress = "Multimedia Books And Press",
  ClothingAndFootwear ="Clothing And Footwear",
  TvInternetTelephone = "Tv Internet Telephone"
}
