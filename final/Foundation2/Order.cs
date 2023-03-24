public class Order
{
    private List<Product> _products = new List<Product>();
    private Costumer _costumer;
    private double _shippingCost;
    private double _totalCost;

    public Order()
    {
    }

    public void SetCostumer(Costumer costumer)
    {
        _costumer = costumer;
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
        if(_costumer.LiveInUsa() == true)
        {
           _shippingCost = 5.00;
        }
        else if(_costumer.LiveInUsa() == false)
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
        string inf = "";
        foreach(Product product in _products)
        {
           inf = $"product name: {product.GetName()}, product Id: {product.GetId()}";
           inf += "";
        }
        return inf;
    }

    public string ReturnShippingLabel()
    {
        string inf = "";
        inf = $"costumer name: {_costumer.GetName()}, costumer address: {_costumer.GetAddress()}";
        inf += "";
        return inf;
    }
}