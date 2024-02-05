namespace ComputerStore_Models.Requests
{
    public class GetComputersByCustomerRequest
    {
        public int CustomerId { get; set; }

        public DateTime AfterDate { get; set; }
    }
}
