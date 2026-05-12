using System;
using CustomerProductClasses;

namespace CustomerProductTests
{
    class Program
    {
        static void Main(string[] args)
        {

            TestProductConstructors();
            TestProductToString();
            TestProductPropertyGetters();
            TestCustomerConstructors();
            TestCustomerToString();
            TestCustomerPropertyGetters();
            TestCustomerPropertySetters();
        }

        static void TestProductConstructors()
        {
            Product p1 = new Product();
            Product p2 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + p1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting 1, T100, 100, This is a test product, 10 " + p2.ToString());
            Console.WriteLine();
        }

        static void TestProductToString()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting 1, T100, 100, This is a test product, 10 " + p1.ToString());
            Console.WriteLine("Expecting 1, T100, 100, This is a test product, 10 " + p1);
            Console.WriteLine();
        }

        static void TestProductPropertyGetters()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing getters");
            Console.WriteLine("Id.  Expecting 1. " + p1.Id);
            Console.WriteLine("Code.  Expecting T100. " + p1.Code);
            Console.WriteLine("Description.  Expecting This is a test product. " + p1.Description);
            Console.WriteLine("Price.  Expecting 100. " + p1.UnitPrice);
            Console.WriteLine("Quantity.  Expecting 10. " + p1.QuantityOnHand);
            Console.WriteLine();
        }

        static void TestProductPropertySetters()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing setters");
            p1.Id = 2;
            p1.Code = "T000";
            p1.Description = "First product";
            p1.UnitPrice = 200;
            p1.QuantityOnHand = 20;
            Console.WriteLine("Expecting 2, T000, 200, First product, 20 " + p1);
            Console.WriteLine();
        }

        static void TestCustomerConstructors()
        {
            Customer p1 = new Customer();
            Customer p2 = new Customer("linker@email.com", "First", 1256, "Name", "123-456-7890");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + p1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting linker@email.com, First, 1256, Name, 123-456-7890 " + p2.ToString());
            Console.WriteLine();
        }

        static void TestCustomerToString()
        {
            Customer p1 = new Customer("linker@email.com", "First", 1256, "Name", "123-456-7890");

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting 1, T100, 100, This is a test product, 10 " + p1.ToString());
            Console.WriteLine("Expecting 1, T100, 100, This is a test product, 10 " + p1);
            Console.WriteLine();
        }

        static void TestCustomerPropertyGetters()
        {
            Customer p1 = new Customer("linker@email.com", "First", 1256, "Name", "123-456-7890");

            Console.WriteLine("Testing getters");
            Console.WriteLine("email.  Expecting linker@email.com. " + p1.Email);
            Console.WriteLine("firstName.  Expecting First. " + p1.FirstName);
            Console.WriteLine("customerId.  Expecting 1256 " + p1.Id);
            Console.WriteLine("lastName.  Expecting Name. " + p1.LastName);
            Console.WriteLine("phone.  Expecting 123-456-7890 " + p1.Phone);
            Console.WriteLine();
        }

        static void TestCustomerPropertySetters()
        {
            Customer p1 = new Customer("linker@email.com", "First", 1256, "Name", "123-456-7890");

            Console.WriteLine("Testing setters");
            p1.Email = "linked@email.com";
            p1.FirstName = "Second";
            p1.Id = 1265;
            p1.LastName = "Third";
            p1.Phone = "321-654-0987";
            Console.WriteLine("Expecting linked@email.com, Second, 1265, Third, 321-654-0987 " + p1);
            Console.WriteLine();
        }
    }
}
