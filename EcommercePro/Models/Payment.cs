namespace EcommercePro.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        //payment method
        public int CardNumber { set; get; }
        public int cvv { set; get; }
        public int Exp_Month { get; set; }
        public int Exp_Year { get; set; }







    }
}
