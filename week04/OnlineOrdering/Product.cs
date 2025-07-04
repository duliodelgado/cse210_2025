// Product.cs – clase Producto
public class Product
{
    private string _name;
    private string _id;
    private double _price;    // precio por unidad
    private int    _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name     = name;
        _id       = id;
        _price    = price;
        _quantity = quantity;
    }

    // Costo total = precio × cantidad
    public double TotalCost() => _price * _quantity;

    // Texto para la etiqueta de empaque
    public string GetPackingInfo() => $"{_name} (ID: {_id})  x{_quantity}";
}