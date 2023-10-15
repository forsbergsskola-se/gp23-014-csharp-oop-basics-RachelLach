class food // Parent class 
{
    public string smoothie; // Food field
    public void Vitamins() // Food method
    {
        Console.WriteLine("Vitamins give you energy!");
    }
}
class Apple : food // Child class
{
    public string type = "fruit";
}

class Banana : food
{
    public string type = "fruit";
}

class Pear : food
{
    public string type = "fruit";
}

class Program
{
    void main(string[] args)
    {
        Apple apple = new Apple(); // Create a Apple object
        apple.Vitamins(); // Call the Vitamins
        Console.WriteLine(apple.smoothie +"fruit"+apple.type);
        Banana banana = new Banana();
        banana.Vitamins();
        Console.WriteLine(banana.smoothie +"fruit"+banana.type);
        Pear pear = new Pear();
        pear.Vitamins();
        Console.WriteLine(pear.smoothie +"fruit"+pear.type);
    }
}

class selfdefense
{
    public string carry;
    public void Object()
    {
        Console.WriteLine("You can protect your self!");
    }
}

class Sword : selfdefense
{
    public string type = "armor";
}

class Axe : selfdefense
{
    public string type = "armor";
}
class Shield : selfdefense
{
    public string type = "armor";
}
class Spear : selfdefense
{
    public string type = "armor";
}

{ 
class Program
{
    void main(string[] args);
    
    


public class Tree
{
    
}

public class Gorilla
{
    
}

public class Champanzee
{
    
}

public class Sparrow
{
    
}

public class Pigeon
{
    
}

public class Hawk
{
    
}