using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainTest;



namespace DomainUnitTesting
{
    [TestClass]
    public class CustomerUnitTests
    {
        [TestInitialize]
        public void TestInit()
        {
            //place all code required to execute tests
            string test = "hola";
        }


        [TestMethod]
        public void TestCustomerSum()
        {
            string name = TestFactory.GetRandomString();
            string lastName = TestFactory.GetRandomString();

            Customer customer = TestFactory.CreateCustomer(name, lastName);

            int result = customer.Sum(10, 20);

            Assert.AreEqual(30, result);

        }



        [TestMethod]
        public void TestCustomerConstructor()
        {
            Customer customer = TestFactory.CreateCustomer("pepito", "martinez");

            Assert.AreEqual("pepito", customer.Name);
            Assert.AreEqual("martinez", customer.LastName);

        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestCustomerConstructorWithNameBlank()
        {
            Customer customer = TestFactory.CreateCustomer(null, "martinez");
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestCustomerConstructorWithLastNameBlank()
        {
            Customer customer = TestFactory.CreateCustomer("pepito", null);
        }


        [TestMethod]
        public void TestCustomerServiceCustomerAddedToDbContextAndSaveChanges()
        {
            const string custName = "Pepito";
            const string custLastName = "Martinez";

            DBContextFake ctxFake = new DBContextFake();

            CustomerService customerSvc = new CustomerService(ctxFake);
            customerSvc.CreateCustomer(new CreateCustomerCommand()
            {
                Name = custName,
                LastName = custLastName
            });


            Assert.IsTrue(ctxFake.saveChangesCalled);

            Customer customer = ctxFake.elementAdded as Customer;

            Assert.IsNotNull(customer);
            Assert.AreEqual(custName, customer.Name);
            Assert.AreEqual(custLastName, customer.LastName);
        }


        [TestMethod]
        public void TestCustomerFullName()
        {
            Customer customer = TestFactory.CreateCustomer("pepito", "martinez");

            Assert.AreEqual("pepito martinez", customer.FullName);

        }


        [TestMethod]
        public void TestCustomerCreateDateIsSet()
        {
            Customer customer = TestFactory.CreateCustomer("pepito", "martinez");

            Assert.AreNotEqual(DateTime.MinValue, customer.CreateDate);


        }




    }



    public class DBContextFake : IDbContext
    {
        public object elementAdded { get; private set; }
        public bool saveChangesCalled { get; private set; }


        public void Add<T>(T element)
        {
            this.elementAdded = element;
        }

        public void SaveChanges()
        {
            this.saveChangesCalled = true;
        }
    }

}
