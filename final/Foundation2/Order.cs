public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _shippingCost;
    private double _totalCost;

    public Order()
    {
    }

    public void SetCostumer(Customer costumer)
    {
        _customer = costumer;
    }

    public string GetTotalCost()
    {
        return _totalCost.ToString();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void CalculateShippingCost()
    {
        if(_customer.LiveInUsa() == true)
        {
           _shippingCost = 5.00;
        }
        else if(_customer.LiveInUsa() == false)
        {
            _shippingCost = 35.00;
        }
    }

    public void CalculateTotalCost()
    {
        _totalCost = _shippingCost;
        foreach(Product product in _products)
        {
           _totalCost += product.GetPrice();
        }
    }

    public string ReturnPackingLabel()
    {
        string packingLabel = "";
        foreach(Product product in _products)
        {
           packingLabel += $"product name: {product.GetName()} - Id: {product.GetId()}\n";
        }
        return packingLabel;
    }

    public string ReturnShippingLabel()
    {
        string shippingLabel = $"costumer name: {_customer.GetName()}\n";
        shippingLabel += "street // city // state // country\n";
        shippingLabel += $"{_customer.GetAddress()}.\n";
        return shippingLabel;
    }
}