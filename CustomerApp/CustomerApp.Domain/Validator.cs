namespace CustomerApp.Domain
{
    public class Validator
    {
        public bool ValidateCustomer(Customer customer)
        {
            //Need to Validate the Customer Object
            if (string.IsNullOrEmpty(customer.Name)) throw new ArgumentException("Name can't be null or empty");
            if (string.IsNullOrEmpty(customer.Email)) throw new ArgumentException("Email can't be null or empty");
            if (string.IsNullOrEmpty(customer.MobileNumber)) throw new ArgumentException("MobileNumber can't be null or empty");
            if (string.IsNullOrEmpty(customer.Address)) throw new ArgumentException("Address can't be null or empty");
            return true;
        }
    }
}