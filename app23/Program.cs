using System;
using System.Linq;
using validate;

static class Program
{
    static void Main()
    {
        /*List<Student> dataStudents = new List<Student>();
        dataStudents.Add(new Student("John", "Smith", 5));
        dataStudents.Add(new Student("Sarah", "Johnson", 6));
        dataStudents.Add(new Student("Michael ", "Brown", 1));
        dataStudents.Add(new Student("Jennifer", "Williams", 5));
        dataStudents.Add(new Student("David", "Jones", 9));
        dataStudents.Add(new Student("Emily", "Davis", 7));
        dataStudents.Add(new Student("Robert", "Anderson", 8));
        dataStudents.Add(new Student("Jessica", "Martinez", 4));
        dataStudents.Add(new Student("William", "Wilson", 7));
        dataStudents.Add(new Student("Elizabeth", "Taylor", 3));

        dataStudents.Sort((x, y) => x.Grade.CompareTo(y.Grade));

        List<Worker> dataWorkers = new List<Worker>();
        dataWorkers.Add(new Worker("James", "Harris", 1230,8));
        dataWorkers.Add(new Worker("William", "Wilson", 16598,4));
        dataWorkers.Add(new Worker("Daniel", "Walker", 6486,6));
        dataWorkers.Add(new Worker("Amanda", "Rodriguez", 487,8));
        dataWorkers.Add(new Worker("Richard", "Turner", 64984,8));
        dataWorkers.Add(new Worker("Nicole", "Lewis", 6584,6));
        dataWorkers.Add(new Worker("Christopher", "Wright", 85498,8));
        dataWorkers.Add(new Worker("Michelle", "White", 6547,8));
        dataWorkers.Add(new Worker("Matthew", "Adams", 6547,6));
        dataWorkers.Add(new Worker("Samantha", "Scott", 6547,4));

        dataWorkers.Sort((x, y) => x.MoneyPerHour().CompareTo(y.MoneyPerHour()));

        List<Human> sorted3 = new List<Human>();
        sorted3.AddRange(dataWorkers);
        sorted3.AddRange(dataStudents);
        sorted3 = sorted3.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

        string output = "";

        for (int i = 0; i < sorted3.Count; i++)
        {
            output += sorted3[i].ToString() + "\n";
        }
        Console.WriteLine(output);*/

        List<Dog> dogs = new List<Dog>();
        dogs.Add(new Dog("James", 12,false));
        dogs.Add(new Dog("William",8,false));
        dogs.Add(new Dog("Daniele", 6,true));
        dogs.Add(new Dog("Amanda", 7,true));

        List<Cat> cats = new List<Cat>();
        cats.Add(new Cat("John", 5, false));
        cats.Add(new Cat("Sarah", 6,true));
        cats.Add(new Cat("Michael ", 1,false));
        cats.Add(new Kitten("Jennifer", 5));
        cats.Add(new Kitten("Dani",9));
        cats.Add(new Tomcat("Emilio", 7));
        cats.Add(new Tomcat("Robert", 8));

        string output = "";

        for (int i = 0; i < cats.Count; i++)
        {
            output += cats[i].ToString() + "\n";
        }
        Console.WriteLine(output);

        Console.WriteLine(Calculate<Dog>.AvarageAge(dogs));
    }
}