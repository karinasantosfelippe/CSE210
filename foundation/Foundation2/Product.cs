namespace Foundation2;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    
    public Product(string name, string productId, double price){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = 1;
    }

    public double GetTotalCost() => _price * _quantity;

    public string GetName() => _name;

    public string GetProductId() => _productId;
}