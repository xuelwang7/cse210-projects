public class Product
{
      private string _name;
      private int _productId;
      private float _price;
      private int _quantity;

    public Product(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float TotalPrice()
    {
        return _price * _quantity;
    }
}

    
