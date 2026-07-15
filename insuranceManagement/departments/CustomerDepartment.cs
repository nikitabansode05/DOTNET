public class CustomerDepartment
{
    public void OnCustomerRegistered(Customer customer)
    {
        CustomerRepository customerRepository = new CustomerRepository();
        List<Customer> customers = customerRepository.Deserialize();
        customers.Add(customer);
        customerRepository.Serialize(customers);
    }
}