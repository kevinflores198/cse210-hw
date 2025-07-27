using System.Security.AccessControl;

public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantityEachProduct;

    public Product(string name, string id, double price, int quantityEachProduct)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantityEachProduct = quantityEachProduct;
    }

    public double TotalCostProduct()
    {
        return _price * _quantityEachProduct;
    }

    public string GetName() => _name;
    public string GetID() => _id;
    public int GetQuantity() => _quantityEachProduct;
    public double GetPrice() => _price;

}