public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.CheckIfUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string DisplayAddress()
    {
        return _address.GetAddress();
    }
}