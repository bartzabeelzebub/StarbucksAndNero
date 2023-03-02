using StarbucksAndNero.Abstract;
using StarbucksAndNero.Adapters;
using StarbucksAndNero.Concrete;
using StarbucksAndNero.Entities;

namespace StarbucksAndNero
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = new DateTime(2004, 3, 28), FirstName = "Baran", LastName = "Gülaçar", NationalityId= "13262382692"});
            Console.ReadLine();
        }
    }

    

}