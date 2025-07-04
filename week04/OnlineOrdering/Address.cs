// Address.cs – clase Dirección
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street  = street;
        _city    = city;
        _state   = state;
        _country = country;
    }

    // ¿Está en EE. UU.?
    public bool IsUSA() => _country.Trim().ToUpper() == "USA";

    // Dirección completa en varias líneas
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}