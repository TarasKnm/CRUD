using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Item
    {
        [Key] //primary key
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }
        public string ItemName { get; set; }

    }
}
