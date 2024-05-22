namespace Technology;
public class SmartPhone : Computer
{
   public int NumberOfSelfies { get; set; }
   public SmartPhone(int ram, int storage, bool hasKeyboard, int numberOfSelfies)
   : base(ram, storage, hasKeyboard)
   {
      NumberOfSelfies = numberOfSelfies;
   }
   
   public void TakeSelfie()
   {
      NumberOfSelfies++;
   }
}