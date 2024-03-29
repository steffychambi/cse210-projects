public class Product
{
    private string _productName;
    private int _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string productName, int productId, double pricePerUnit, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public int GetId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _pricePerUnit*_quantity;
    }
}