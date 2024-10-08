namespace Foundation2;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool LiveInUSA() => _address.IsUSAAddress();

    public string GetName() => _name;

    public string GetFullAddress() => _address.GetFullAddress();
}