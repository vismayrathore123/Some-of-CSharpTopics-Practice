using System;

public class MyClass
{
    // Fields or properties
    public int MyProperty { get; set; }
    public string MyString { get; set; }

    // Parameterized constructor
    public MyClass(int myProperty, string myString)
    {
        MyProperty = myProperty;
        MyString = myString;
    }

    // Default constructor
    public MyClass()
    {
        // Initialize fields or properties with default values
        MyProperty = 0;
        MyString = "Default";
    }

    // Method to display information about the object
    public void DisplayInfo()
    {
        Console.WriteLine($"MyProperty: {MyProperty}, MyString: {MyString}");
    }
}

class Program
{
    static void Main()
    {
        // Using the parameterized constructor
        MyClass obj1 = new MyClass(42, "Hello");
        obj1.DisplayInfo();  // Output: MyProperty: 42, MyString: Hello

        // Using the default constructor
        MyClass obj2 = new MyClass();
        obj2.DisplayInfo();  // Output: MyProperty: 0, MyString: Default
    }
}
