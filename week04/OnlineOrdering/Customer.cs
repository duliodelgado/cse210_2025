// Customer.cs – clase Cliente
public class Customer
{
    private string  _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name    = name;
        _address = address;
    }

    public bool LivesInUSA()     => _address.IsUSA();
    public string  GetName()     => _name;
    public Address GetAddress()  => _address;
}