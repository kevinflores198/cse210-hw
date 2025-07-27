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
    public double CalculateTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCostProduct();
        }
        if (_customer.FromUSAOrNot())
            total += 5;
        else
            total += 35;

        return total;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetID()})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().DisplayAddress()}";
    }

}