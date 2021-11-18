using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("ExpenseName")]
        public string ExpenseName { get; set; }
        public int Amount { get; set; }   
    }
}