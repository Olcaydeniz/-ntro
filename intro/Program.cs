// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.Entities;

Console.WriteLine("Hello, World!");
string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);

//conditon
if(isAuthenticated)
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
        //start     condition       //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}
// -----------------------------------------------------------
// class mantığı  vt gelen classları ekrana yazdırma  (şuanki işlem manuel olarak verilen veriler bunlar vt'dan gelecek!!)
//Course course1 = new Course();
//course1.Id = 1 ;
//course1.Name = "C#";
//course1.Description = "c#  güncel kurs";
//course1.Price = 150.2;


//Course course2 = new Course();
//course2.Id = 2;
//course2.Name = "Java";
//course2.Description = "java  güncel kurs";
//course2.Price = 0;

//Course[] courses = { course1, course2 };
//for (int i = 0; i < courses.Length; i++)   //Length  eleman sayısı demektir.  'i' indeks kavramından gelir   'i++' bir bir arttır.
//{
//Console.WriteLine(courses[i].Name + " / " + courses[i].Description + " / " + courses[i].Price);
//}

// -----------------------------------------------------------
// listeleme  tutucu ve operasyon tutucu  iki  seçenecek vardır listeme vt  olan bilgiyi çektirir  operasyon da ise   vt'nı manipülasyonu yapılır 
// CourseManager courseManager = new CourseManager();  // eski syntax
CourseManager courseManager = new();  // bir class'ı kullana bilmek için onu newlemek gerekmektedir. // yeni syntax ile  sadece new() belirtmek yeterlidir.
//class name    //değişken     //veriler //getall methodu
Course[]       courses2 =courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)   
{                                        
  Console.WriteLine(courses2[i].Name + " / " + courses2[i].Description + " / " + courses2[i].Price);                                         
}
//-------------------------------------------------------------
    Console.WriteLine("Kod bitti");
//2.Gün  
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
//​​dotnet tool install --global NArchitecture.Gen --version 1.0.1