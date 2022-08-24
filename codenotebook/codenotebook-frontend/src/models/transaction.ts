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
  "Food And Household Chemistry" = 0,
  "Crossings" = 1,
  "Influences" = 2,
  "Accessories & Equipment" = 3,
  "Eating Out" = 4,
  "Uncategorized" =5,
  'Outings And Events' =6,
  'Current' =7,
  'Gifts And Support' = 8,
  'Renumeration' = 9,
  'Regular Saving' = 10,
  'Flue' = 11,
  'Renovation And Garden' =12,
  'Multimedia,Books and Press' = 13,
  'Clothing & Footwear' =14,
  'Tv,Internet,Telephone' = 15
}
