public class Goals
{
     protected bool isChecked = false;
      protected string _name;

      protected string _type;

      protected int _point;



   public Goals(string name, string type, int point)
   {
      
      _name = name;
      _point = point;
      _type = type;
   }

   public virtual void Display(int i)
   {
      
   }
   

   public virtual int CompletedGoals()
   {
      if(isChecked == false)
      {
         isChecked = true;
         return _point;
         
      }
      else
      {
         return 0;

      }
   }

   public virtual string Saveformat()
   {
      return "";
   }


   
}