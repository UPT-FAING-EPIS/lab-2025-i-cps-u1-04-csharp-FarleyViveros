namespace CustomerApp.Domain
{
    public class DataAccessLayer
    {
        public List<Customer> Customers { get; set; }
        public DataAccessLayer()
        {
            Customers = new List<Customer>();
        }
        public bool SaveCustomer(Customer customer)
        {
            Customers.Add(customer);
            return true;
        }        
    }
}