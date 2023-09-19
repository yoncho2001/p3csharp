using validate;

public class Person
{
    private string name;

    private int age;

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }
    }

    public Person()
    {
        this.name = "Phantom";
        this.age = 0;
    }

    public Person(string name, int age)
    {
        Validate.isString(name);
        Validate.isPositive(age);

        this.name = name;
        this.age = age;
    }

    public Person(string name)
    {
        Validate.isString(name);
        Validate.isPositive(age);

        this.name = name;
        this.age = 0;
    }

    public void Grow()
    {
        Age++;
    }

    public override string ToString()
    {
        if (this.Age == 0)
        {
            return "Name: " + Name + " Age: is not born yet" + "\n";
        }
        else
        {
            return "Name: " + Name + " Age: " + Age.ToString() + "\n";
        }
    }
}