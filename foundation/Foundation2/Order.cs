namespace Foundation2;
public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products){
        _customer = customer;
        _products = products;
    }
    
    public Order(Customer customer, Product product){
        _customer = customer;
        _products = [];
        _products.Add(product);
    }
    
    public Order(Customer customer){
        _customer = customer;
        _products = [];
    }

    public void AddProduct(Product product) => _products.Add(product);

    public double CalculateTotalCost(){
        double total = 0;
        foreach (Product product in _products)
            total += product.GetTotalCost();
        
        if (_customer.LiveInUSA())
            //If the customer lives in the USA: shipping cost is $5.
            total += 5;
        else // If the customer does not live in the USA: shipping cost is $35.
            total += 35;

        return total;
    }

    public string PackingLabel(){
        string label = "";
        for (int i = 0; i < _products.Count; i++)
            label += $"{i+1}. {_products[i].GetProductId()} - {_products[i].GetName()}\n";
        
        return label;
    }

    public string ShippingLabel()
        => $"Name: {_customer.GetName()}\n{_customer.GetFullAddress()}";
}