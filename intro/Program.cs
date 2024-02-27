using intro.Business;
using intro.DataAccess.Concretes;
using intro.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string message1 = "Krediler";
        int term = 12;
        double amount = 100000;

        //variables --> camelCase
        bool isAuthenticated = true;
        Console.WriteLine(message1);

        //conditon
        if (isAuthenticated)
        {
            Console.WriteLine("Buton --> Hoşgeldin Kullanıcı ");

        }
        else
        {
            Console.WriteLine("Buton --> Sisteme Giriş Yap!");

        }

        string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; // Db'den Gelecek
                                                                                         
        //string[] loans2 = new string[6];
        //loans2[0] = "Kredi 1 ";



        //start     //condition       //increment
        for (int i = 0; i < loans.Length; i++)
        {
            Console.WriteLine(loans[i]);
        }



        CourseManager courseManager = new(new EfCourseDal());
        List<Course> courses2 = courseManager.GetAll();
        for (int i = 0; i < courses2.Count; i++)
        {
            Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
        }

        Console.WriteLine("Kod bitti");

        IndividualCustomer customer1 = new();
        customer1.Id = 1;
        customer1.NationalIdentity = "1234567890";
        customer1.FirsName = "Olcay";
        customer1.LastName = "Deniz";
        customer1.CustomerNumber = "123456";

        IndividualCustomer customer2 = new();
        customer2.Id = 2;
        customer2.NationalIdentity = "2234567890";
        customer2.FirsName = "Engin";
        customer2.LastName = "Demiroğ";
        customer2.CustomerNumber = "123455";

        CorporateCustomer customer3 = new();
        customer3.Id = 3;
        customer3.Name = "Kodlamaio";
        customer3.CustomerNumber = "456789";
        customer3.TaxNumber = "1234567890";

        CorporateCustomer customer4 = new();
        customer4.Id = 4;
        customer4.Name = "Abc";
        customer4.CustomerNumber = "456777";
        customer4.TaxNumber = "1234567899";

        //values types --> int,bool,double...
        //reference types --> arry , class, interface..

        BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

        //polymorphism
        foreach (BaseCustomer customer in customers)
        {
            Console.WriteLine(customer.CustomerNumber);
        }
    }
}