namespace costnotebook_backend.Models.Dto
{
    public class TransactionDto
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public CategoryTransaction Category { get; set; }
        public double Amount { get; set; }
    }
}
