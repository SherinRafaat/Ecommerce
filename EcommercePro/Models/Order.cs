using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercePro.Models
{
    public class Order
    {
        public int Id { set; get; }
        public int Quentity { set; get; }
        public string Status { set; get; }//Inprocessing - completed

        [ForeignKey("product")]
        public int productId { set; get; }

        public Product? product { set; get; }

        [ForeignKey("User")]
        public string UserId { set; get; }
        public ApplicationUser? User { get; set; }

        [ForeignKey("Payment")]
        public int PaymentId { set; get; }
        public Payment? Payment { set; get; }

        public DateOnly? CreatedDate { get; set; }
    }
}
