public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }

        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string DisplayPackingLabel()
    {
        string label = "~~~~~Packing Label~~~~~\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetPackingLabel()}\n";
        }
        
        return label;
    }

    public string DisplayShippingLabel()
    {
        return $"~~~~~Shipping Label~~~~~\n  -{_customer.GetName()}-\n{_customer.DisplayAddress()}";
    }
}