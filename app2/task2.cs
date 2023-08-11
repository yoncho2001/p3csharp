namespace task2
{
    public class CompanyInfo
    {
        public static void Result()
        {
            string companyName = validate(Console.ReadLine());
            string companyAddress = validate(Console.ReadLine());
            string phoneNumber = validate(Console.ReadLine());
            string faxNumber = validate(Console.ReadLine());
            string webSite = validate(Console.ReadLine());
            string managerFirstName = validate(Console.ReadLine());
            string managerLastName = validate(Console.ReadLine());
            string manaderAge = validate(Console.ReadLine());
            string managerPhone = validate(Console.ReadLine());

            string output = companyName + "\n"
                            + "Addres: " + companyAddress + "\n"
                            + "Tel. " + phoneNumber + "\n"
                            + "Fax: " + faxNumber + "\n"
                            + "Web site: " + webSite + "\n"
                            + "Manader: " + managerFirstName + " " + managerLastName + " (ade: " + manaderAge + ", tel: " + managerPhone + ")";

            Console.WriteLine(output);
        }

        public static string validate(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                input = "empty info";
            }

            return input;
        }
    }
}