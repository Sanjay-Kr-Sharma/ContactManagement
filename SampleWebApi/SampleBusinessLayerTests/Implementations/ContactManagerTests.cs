using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleDataLayer;

namespace SampleBusinessLayer.Tests
{
    [TestClass()]
    public class ContactManagerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var mockSet = new Mock<DbSet<Contact>>();
            var mockContext = new Mock<ContactModel>();
            mockContext.Setup(c => c.Contacts).Returns(mockSet.Object);

            var contactManager = new ContactManager(mockContext.Object);
            var contact = new Contact()
            {
                FirstName = "Sanjay",
                PrimaryEmail = "sanjay@gmail.com",
                PrimaryPhone = 123456789
            };
            contactManager.Add(contact);

            mockSet.Verify(m => m.Add(It.IsAny<Contact>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod()]
        public void GetTest()
        {
            var data = new List<Contact>
            {
                new Contact {
                    FirstName = "Sanjay",
                    PrimaryEmail = "sanjay@gmail.com",
                    PrimaryPhone = 123456789
                }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Contact>>();
            mockSet.As<IQueryable<Contact>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Contact>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Contact>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Contact>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ContactModel>();
            mockContext.Setup(c => c.Contacts).Returns(mockSet.Object);

            var list = new ContactManager(mockContext.Object).Get();
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual("Shivam", list[0].FirstName);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            
            Assert.Fail();
        }
    }
}