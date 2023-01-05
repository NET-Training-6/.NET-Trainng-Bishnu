class A
{
    public int x;
}

class B: A // Single, A is base/parent/super and B is derived/child/sub
{
    public string y;
}

class C: B      // Multi-Level
{
    public byte z;
    public void Test(){}
}

interface ID
{

}


// Multiple
class E: B, ID   // Class E inherits B and implements ID
{

}
