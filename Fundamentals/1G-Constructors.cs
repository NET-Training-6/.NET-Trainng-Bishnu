// Managed and unmanaged code
// Memrory management

class Animal
{
    public string animalName;
    public int noOfLegs;
    public bool isDomestic;

    // Default parameterless constructor
    public Animal()
    {        
    }

    // Parameterized constructor
    public Animal(string name, bool isDomestic)
    {
        animalName = name;
        this.isDomestic = isDomestic;
    }

    public Animal(string name, bool isDomestic, int legs)
    {
        animalName = name;
        this.isDomestic = isDomestic;
        noOfLegs = legs;
    }
}

class Test
{
    void Test1()
    {
        Animal animal1 = new Animal("Dog", true);
        Animal animal2 = new Animal();
    }
}