public class Address
{
    private string _street;
    private string _city;
    private string _state_province;
    private string _country;

    public Address(string street, string city, string s_p, string country)
    {
        _street = street;
        _city = city;
        _state_province = s_p;
        _country = country;
    }

    public bool CheckIfUSA() //Double check this later
    {
        return _country.ToUpper() == "USA";
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_state_province}\n{_country}";
    }
}
