using validate;

public abstract class Customer
{
    private string name;
    private string phoneNumber;

    public string Name
    {
        get
        {
            return this.name;
        }
    }

    public string PhoneNumber
    {
        get
        {
            return this.phoneNumber;
        }
    }

    public Customer()
    {
        this.name = "Phantom";
        this.phoneNumber = "null";
    }

    public Customer(string name, string phoneNumber)
    {
        Validate.isString(name);
        Validate.isPhone(phoneNumber);
        this.name = name;
        this.phoneNumber = phoneNumber;
    }

    public abstract string ToString();
}

public class Individual : Customer
{
    private string egn;

    public string EGN
    {
        get
        {
            return this.egn;
        }
    }

    public Individual()
    {
        this.egn = "null";
    }

    public Individual(string name, string phoneNumber, string egn) : base(name, phoneNumber)
    {
        Validate.isEGN(egn);
        this.egn = egn;
    }

    public override string ToString()
    {
        return "Name: " + Name + " PhoneNumber: " + PhoneNumber + " EGN: " + EGN ;
    }
}

public class Compani : Customer
{
    private string eik;

    public string EIK
    {
        get
        {
            return this.eik;
        }
    }

    public Compani()
    {
        this.eik = "null";
    }

    public Compani(string name, string phoneNumber, string eik) : base(name, phoneNumber)
    {
        Validate.isEIK(eik);
        this.eik = eik;
    }

    public override string ToString()
    {
        return "Name: " + Name + " PhoneNumber: " + PhoneNumber + " EGN: " + EIK;
    }
}

public abstract class Acount
{
    protected Customer customer;
    protected double balance;
    protected double interest;

    public Customer Customer
    {
        get
        {
            return this.customer;
        }
    }

    public double Balance
    {
        get
        {
            return this.balance;
        }
    }

    public double Interest
    {
        get
        {
            return this.interest;
        }
    }

    public Acount()
    {
        this.customer = null;
        this.balance = 0;
        this.interest = 0;
    }

    public Acount(Customer customer, double balance, double interest)
    {
        Validate.isPositive(balance);
        Validate.isPositive(interest);
        Validate.isNotNull(customer);

        this.customer = customer;
        this.balance = balance;
        this.interest = interest;
    }

    public abstract void DepositMoney(double input);

    public abstract void DrawMoney(double draw);

    public abstract double CalculateInterest(int numberOfMonts);

    public abstract string ToString();
}

public class Deposit : Acount
{
    public Deposit() :
    base()
    { }

    public Deposit(Customer customer, double balance, double interest) :
    base(customer, balance, interest)
    { }

    public override void DepositMoney(double input)
    {
        Validate.isPositive(input);

        this.balance += input;
    }

    public override void DrawMoney(double draw)
    {
        Validate.isPositive(draw);
        if (draw < this.balance)
        {
            this.balance -= draw;
        }
        else
        {
            Console.WriteLine("You dont have money :(");
        }
    }

    public override double CalculateInterest(int numberOfMonts)
    {
        if (balance > 1000)
        {
            return this.interest * numberOfMonts;
        }
        else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        return "Customer: \n" + Customer.ToString() + "\nBalance: " + Balance.ToString() + " Interest: " + Interest.ToString() + "\n";
    }
}

public class Loan : Acount
{
    public Loan() :
    base()
    { }

    public Loan(Customer customer, double balance, double interest) :
    base(customer, balance, interest)
    { }

    public override void DepositMoney(double input)
    {
        Validate.isPositive(input);

        this.balance -= input;

        if (input < 0)
        {
            Console.WriteLine("Congratulations, you have paid off your loan.");
        }
    }

    public override void DrawMoney(double draw)
    {
        Console.WriteLine("You cant draw money from this acount.");
    }

    public override double CalculateInterest(int numberOfMonts)
    {
        double output = 0;

        if (this.customer.GetType() == typeof(Individual))
        {
            output = numberOfMonts > 3 ? this.interest * (numberOfMonts - 3) : 0;
        }
        else
        {
            output = numberOfMonts > 2 ? this.interest * (numberOfMonts - 2) : 0;
        }

        return Math.Round(output,2);
    }

    public override string ToString()
    {
        return "Customer: \n" + Customer.ToString() + "\nBalance: " + Balance.ToString() + " Interest: " + Interest.ToString() + "\n";
    }
}

public class Mortgage : Acount
{
    public Mortgage() :
    base()
    { }

    public Mortgage(Customer customer, double balance, double interest) :
    base(customer, balance, interest)
    { }

    public override void DepositMoney(double input)
    {
        Validate.isPositive(input);

        this.balance -= input;

        if (input < 0)
        {
            Console.WriteLine("Congratulations, you have paid off your mortgage.");
        }
    }

    public override void DrawMoney(double draw)
    {
        Console.WriteLine("You cant draw money from this acount.");
    }

    public override double CalculateInterest(int numberOfMonts)
    {
        if (this.customer.GetType() == typeof(Individual))
        {
            return numberOfMonts > 6 ? this.interest * (numberOfMonts - 6) : 0;
        }
        else
        {
            return numberOfMonts > 12 ? (this.interest * (numberOfMonts - 12)) + ((this.interest / 2) * 12) : (this.interest / 2) * numberOfMonts;
        }
    }

    public override string ToString()
    {
        return "Customer: \n" + Customer.ToString() + "\nBalance: " + Balance.ToString() + " Interest: " + Interest.ToString() + "\n";
    }
}

public class Bank
{
    protected List<Acount> acounts;

    public List<Acount> Acounts
    {
        get
        {
            return this.acounts;
        }
    }

    public Bank()
    {
        this.acounts = new List<Acount>();
    }

    public Bank(List<Acount> input)
    {
        Validate.isNotNull(input);

        this.acounts = acounts;
    }

    public void AddAcount(Acount input)
    {
        this.acounts.Add(input);
    }

    public override string ToString()
    {
        string output = "";

        for (int i = 0; i < this.acounts.Count; i++)
        {
            output += i.ToString() + " " + this.acounts[i].ToString();
        }

        return output;
    }
}