// Order.cs – clase Pedido
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer      _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product p) => _products.Add(p);

    // Precio total = suma productos + envío
    public double GetTotalCost()
    {
        double subtotal = 0;
        foreach (Product p in _products)
            subtotal += p.TotalCost();

        double shipping = _customer.LivesInUSA() ? 5 : 35;
        return subtotal + shipping;
    }

    // Etiqueta de empaque
    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Product p in _products)
            sb.AppendLine(p.GetPackingInfo());
        return sb.ToString();
    }

    // Etiqueta de envío
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}