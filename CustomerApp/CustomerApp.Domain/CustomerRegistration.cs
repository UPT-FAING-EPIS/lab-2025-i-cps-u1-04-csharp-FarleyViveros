using CustomerApp.Domain;

public class CustomerRegistration
{
    public bool RegisterCustomer(Customer customer)
    {
        //Step1: Validate the Customer
        Validator validator = new Validator();
        bool IsValid = validator.ValidateCustomer(customer);
        //Step1: Save the Customer Object into the database
        DataAccessLayer customerDataAccessLayer = new DataAccessLayer();
        bool IsSaved = customerDataAccessLayer.SaveCustomer(customer);
        //Step3: Send the Registration Email to the Customer
        EmailService email = new EmailService();
        email.SendRegistrationEmail(customer);
        return true;
    }
}