export class Transaction
{
    id!: number
    date: string 
    description: string
    category: TransactionCategory
  amount: number

  constructor(date : string,description: string, category: TransactionCategory, amount: number) {
    this.date = date,this.description = description, this.category = category, this.amount = amount
  }
}
export enum TransactionCategory {
  "FoodAndHouseholdChemistry" = 0,
  "Crossings" = 1,
  "Influences" = 2,
  "AccessoriesEquipment" = 3,
  "EatingOut" = 4,
  "Uncategorized" =5,
  'OutingsAndEvents' =6,
  'Current' =7,
  'GiftsAndSupport' = 8,
  'Renumeration' = 9,
  'RegularSaving' = 10,
  'Flue' = 11,
  'RenovationAndGarden' =12,
  'MultimediaBooksAndPress' = 13,
  'ClothingFootwear' =14,
  'TvInternetTelephone' = 15
}
