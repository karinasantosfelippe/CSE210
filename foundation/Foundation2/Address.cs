namespace Foundation2;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsUSAAddress() => _country == "US";

    public string GetFullAddress()
    {
        string fullAddress = $"Street: {_street}\nCity: {_city}\nState/Province: {_stateOrProvince}\nCountry: {_country}";
        return fullAddress;
    }
}