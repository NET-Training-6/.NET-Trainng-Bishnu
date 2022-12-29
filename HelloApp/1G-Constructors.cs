// Managed and unmanaged code
// Memrory management

class Animal
{
    // Default parameterless constructor
    public Animal()
    {        
    }

    // Parameterized constructor
    public Animal(string an, bool id)
    {
        animalName = an;
        isDomestic = id;
    }

    public string animalName;
    public int noOfLegs;
    public bool isDomestic;
}

class Test
{
    void Test1()
    {
        Animal animal1 = new Animal("Dog", true);
        Animal animal2 = new Animal();
    }
}