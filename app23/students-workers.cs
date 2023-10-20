using validate;

public abstract class Human
{
    protected string firstName;
    protected string lastName;

    public Human()
    {
        this.firstName = "Phantom";
        this.lastName = "Tomov";
    }

    public Human(string firstName, string lastName)
    {
        Validate.isString(firstName);
        Validate.isString(lastName);
        
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
    }

    public abstract string ToString();
}

public class Student : Human
{
    private int grade;

    public int Grade
    {
        get
        {
            return this.grade;
        }
    }

    public Student (): base()
    {
        this.grade = 0;
    }

    public Student (string firstName, string lastName, int grade ) : base(firstName, lastName)
    {
        Validate.isGrade(grade);
        this.grade = grade;
    }

    public override string ToString()
    {
        return FirstName + " " + LastName + " " + Grade;
    }
}

public class Worker : Human
{
    private int weekSalary;
    private int workHoursPerDay ;

    public int WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
    }

    public int WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
    }

    public Worker (): base()
    {
        this.weekSalary = 0;
        this.workHoursPerDay = 0;
    }

    public Worker (string firstName, string lastName, int weekSalary, int workHoursPerDay) : base(firstName, lastName)
    {
        Validate.isPositive(weekSalary);
        Validate.isPositive(workHoursPerDay);

        this.weekSalary = weekSalary;
        this.workHoursPerDay = workHoursPerDay;
    }

    public double MoneyPerHour()
    {
        double money = this.WeekSalary/(this.WorkHoursPerDay * 7);

        return money ;
    }

    public override string ToString()
    {
        return FirstName + " " + LastName + " Salary: " + WeekSalary.ToString() + " Hours: " + WorkHoursPerDay.ToString() ;
    }
}
