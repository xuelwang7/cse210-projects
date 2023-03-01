public class address
{
      private string _street;
      private string _city;

      private string _state;

      private int _postalCode;
      bool _validated;

      public address(string street, string city, string state,int postalCode)
      {
        _street = street;
        _city = city;
        _state =state;
        _postalCode = postalCode; 
      }

      public void DisplayAddress()
      {
            Console.WriteLine($"Label{_street},{_city},{_state},{_postalCode}");
      }

} 