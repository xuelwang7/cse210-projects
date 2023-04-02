public class RunningActivity:Activity
{
      

      public RunningActivity(DateTime date, int length, float distance) : base(date, length,distance)
      {
           this.distance= distance; 
           _name = "Running";
      }


      public override float getDistance()
      {
            // Console.WriteLine((_distance / _length) * 60);
            return distance;
      }

      public override float GetPace()
      {
           return   _length/distance;
      }

      public override float GetSpeed()
      {
           return   (distance/_length)*60;
      }


}