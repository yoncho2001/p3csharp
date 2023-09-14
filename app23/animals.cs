using validate;

interface ISound
{
    void Voice();
}

public abstract class Animal
{
    protected string name;
    protected int age;
    protected bool sex;

    public Animal()
    {
        this.name = "animal";
        this.age = 0;
        this.sex = false;
    }

    public Animal(string name, int age, bool sex)
    {
        Validate.isString(name);
        Validate.isPositive(age);

        this.name = name;
        this.age = age;
        this.sex = sex;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
    }

    public bool Sex
    {
        get
        {
            return this.sex;
        }
    }

    public abstract string ToString();
}

public class Dog : Animal, ISound
{
    public Dog() : base()
    {
        this.name = "dog";
    }

    public Dog(string name, int age, bool sex) :
     base(name, age, sex)
    { }

    public void Voice()
    {
        Console.WriteLine("Bark");
    }
    public override string ToString()
    {
        return "Name: " + Name + "Age: " + Age.ToString() + "Sex: " + Sex.ToString();
    }
}

public class Frog : Animal, ISound
{
    public Frog() : base()
    {
        this.name = "frog";
    }

    public Frog(string name, int age, bool sex) :
     base(name, age, sex)
    { }

    public void Voice()
    {
        Console.WriteLine("Rrrrabit");
    }
    public override string ToString()
    {
        return "Name: " + Name + "Age: " + Age.ToString() + "Sex: " + Sex.ToString();
    }
}

public class Cat : Animal, ISound
{
    public Cat() : base()
    {
        this.name = "cat";
    }
    public Cat(string name, int age, bool sex) :
     base(name, age, sex)
    { }

    public virtual void Voice()
    {
        Console.WriteLine("Meow");
    }
    public override string ToString()
    {
        return "Name: " + Name + " Age: " + Age.ToString() + " Sex: " + Sex.ToString();
    }
}

public class Kitten : Cat
{
    public Kitten() : base() { }

    public override void Voice()
    {
        Console.WriteLine("Meooow");
    }

    public Kitten(string name, int age) :
     base(name, age, true)
    { }
}

public class Tomcat : Cat
{
    public Tomcat() : base() { }

    public override void Voice()
    {
        Console.WriteLine("Meowww");
    }

    public Tomcat(string name, int age) :
     base(name, age, false)
    { }
}

static class Calculate<T>where T : Animal
{
    public static int AvarageAge(List<T> listOfAnimals)
    {
        int sum = 0;

        for (int i = 0; i < listOfAnimals.Count; i++)
        {
            sum += listOfAnimals[i].Age;
        }

        return sum / listOfAnimals.Count;
    }
}
