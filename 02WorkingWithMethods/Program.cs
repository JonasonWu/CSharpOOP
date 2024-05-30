namespace _02WorkingWithMethods
{
    // Base Class 
    public class My_Parent
    {

        public void show()
        {
            Console.WriteLine("This is my parent class.");
        }

        public virtual void VM()
        {
            Console.WriteLine("Calling my parent virtual");
        }
    }

    // Derived Class 
    public class My_Child : My_Parent
    {

        // Hide the method of base class 
        // Using new keyword 
        public new void show()
        {

            Console.WriteLine("This is my child class.");
        }

        public override void VM() {
        Console.WriteLine("Calling my child virtual");
            }
    }

    public class Next_Child : My_Child {

        public new void show() {
            Console.WriteLine("This is the lower child.");
        }
        public override void VM()
        {
            Console.WriteLine("Calling next child virtual");
        }
    }

    public class GFG
    {

        // Main method 
        static public void Main()
        {

            // Creating the object of  
            // the derived class 
            My_Child obj = new My_Child();
            My_Parent obj2 = new My_Child();
            My_Parent obj3 = new Next_Child();

            // Access the method of derived class 
            obj.show();
            obj2.show();
            obj3.show();

            obj.VM();
            obj2.VM();
            obj3.VM();

        }
    }
}