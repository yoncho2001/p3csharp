using validate;

interface ICloneable
{
    object Clone();
}

public class Student : ICloneable
{
    public enum University
    {
        SU,
        TU,
        LSG,
        PU,
        BTU
    }

    public enum Specialty
    {
        InformationSistems,
        SoftuerIngenering,
        ComputerSience
    }

    public enum Faculty
    {
        FMI,
        FHF,
        FFF
    }
    private string firstName;
    private string middleName;
    private string lastName;

    private string ssn;
    private string phone;
    private string eMail;
    private int course;
    private Specialty specialty;
    private University university;
    private Faculty faculty;

    public string SSN
    {
        get
        {
            return this.ssn;
        }
    }

    public string Phone
    {
        get
        {
            return this.phone;
        }
    }

    public string EMail
    {
        get
        {
            return this.eMail;
        }
    }

    public int Course
    {
        get
        {
            return this.course;
        }
        set
        {
            this.course = value;
        }
    }

    public Specialty GetSpecialty
    {
        get
        {
            return this.specialty;
        }
    }

    public University GetUniversity
    {
        get
        {
            return this.university;
        }
    }

    public Faculty GetFaculty
    {
        get
        {
            return this.faculty;
        }
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
    }

    public string MiddleName
    {
        get
        {
            return this.middleName;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
    }

    public Student()
    {
        this.firstName = "Phantom";
        this.middleName = "Popov";
        this.lastName = "Tomov";
        this.ssn = "null";
        this.phone = "null";
        this.eMail = "null";
        this.course = 0;
        this.specialty = default(Specialty);
        this.university = default(University);
        this.faculty = default(Faculty);
    }

    public Student(string firstName, string middleName, string lastName, string ssn, string phone, string eMail, int course
        , Specialty specialty, University university, Faculty faculty)
    {
        Validate.isString(firstName);
        Validate.isString(middleName);
        Validate.isString(lastName);
        Validate.isString(ssn);
        Validate.isString(phone);
        Validate.isString(eMail);
        Validate.isPositive(course);

        this.firstName = firstName;
        this.middleName = middleName;
        this.lastName = lastName;
        this.ssn = ssn;
        this.phone = phone;
        this.eMail = eMail;
        this.course = course;
        this.specialty = specialty;
        this.university = university;
        this.faculty = faculty;
    }

    public override bool Equals(object? objekt)
    {
        if ((objekt == null) || this.GetType() != objekt.GetType())
        {
            return false;
        }
        else
        {
            Student tempObject = (Student)objekt;
            return (this.FirstName == tempObject.FirstName) || (this.MiddleName == tempObject.MiddleName) || (this.LastName == tempObject.LastName)
            || (this.SSN == tempObject.SSN) || (this.Phone == tempObject.Phone) || (this.EMail == tempObject.EMail) || (this.Course == tempObject.Course)
            || (this.GetSpecialty == tempObject.GetSpecialty) || (this.GetUniversity == tempObject.GetUniversity) || (this.GetFaculty == tempObject.GetFaculty);
        }
    }

    public override string ToString()
    {
        return "Name: " + FirstName + " " + MiddleName + " " + LastName + "\n"
        + "Data:\n" + "SSN: " + SSN + " Phone: " + Phone + " E-Mail: " + EMail + "\n"
        + "University data:\n" + "Course: " + Course.ToString() + " University: " + GetUniversity.ToString() 
        + " Faculty: " + GetFaculty.ToString() + " Specialty: " + GetSpecialty.ToString() + "\n";
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash ^ (this.FirstName != null ? FirstName.GetHashCode() : 0);
        hash = hash ^ (this.MiddleName != null ? MiddleName.GetHashCode() : 0);
        hash = hash ^ (this.LastName != null ? LastName.GetHashCode() : 0);
        hash = hash ^ (this.SSN != null ? SSN.GetHashCode() : 0);
        hash = hash ^ (this.Phone != null ? Phone.GetHashCode() : 0);
        hash = hash ^ (this.EMail != null ? EMail.GetHashCode() : 0);
        hash = hash ^ this.Course.GetHashCode();
        hash = hash ^ this.GetSpecialty.GetHashCode();
        hash = hash ^ this.GetUniversity.GetHashCode();
        hash = hash ^ this.GetFaculty.GetHashCode();

        return hash;
    }

    public static bool operator== (Student objekt1, Student objekt2)
    {
        return objekt1.Equals(objekt2);
    }

    public static bool operator!= (Student objekt1, Student objekt2)
    {
        return !objekt1.Equals(objekt2);
    }

    public object Clone()
    {
        Student clonedStudent = new Student(this.FirstName,this.MiddleName,this.LastName
            ,this.SSN,this.Phone, this.EMail,this.Course
            ,this.GetSpecialty,this.GetUniversity ,this.GetFaculty);
         
        return clonedStudent;       
    }
}