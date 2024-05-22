namespace Technology
{
    public class Computer
    {
        // field(s)/prop(s)
        public double Ram {get;set;}
        public double Storage {get; set;}
        public readonly bool hasKeyboard;
        // constructor(s)
        public Computer(double ram, double storage, bool hasKeyboard)
        {
            Ram = ram;
            Storage = storage;
            this.hasKeyboard = hasKeyboard;
        }
        // override(s)
        // method(s)
        public double IncreaseRam(double extraRam)
        {
            return Ram+=extraRam;
        }
        public double IncreaseStorage(double extraStorage)
        {
            return Storage += extraStorage;
        }
    }
}