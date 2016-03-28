using Xunit;
using Authentication.Controllers;
using Moq;
using Authentication.Repository;
using System.Collections.Generic;
using Authentication.Models;
using System.Diagnostics;
using Microsoft.AspNet.Mvc;

namespace Authentication.Test
{
    public class ContactsControllerTest
    {
        

        [Fact]
        public void GetAlltest()
        {
           
            // Arrange
            List<Contacts> ContactsList = new List<Contacts>();
            ContactsList.Add(new Contacts("baraneetharan", "r", "true", "KGfSL", "qa", "br@live.com", "0000001234"));
            ContactsList.Add(new Contacts("narayanasamy", "k", "true", "KGfSL", "dev", "nk@live.com", "0000001235"));
            //ContactsList.Add(new Contacts("reka", "v", "true", "KGfSL", "dev", "rv@live.com", "0000001236"));
            //ContactsList.Add(new Contacts("aravind", "m", "true", "KGfSL", "designer", "am@live.com", "0000001237"));
            //ContactsList.Add(new Contacts("somasundaram", "s", "true", "KGfSL", "android dev", "ss@live.com", "0000001238"));

            Mock<IContactsRepository> mockObject = new Mock<IContactsRepository>();
            mockObject.Setup(x => x.GetAll()).Returns(ContactsList);
           // Debug.WriteLine("MOCKING::::::::"+mockObject.Object);
            var ContactsController = new ContactsController(new ContactsRepository());
            
            // Act
            var actual = ContactsController.GetAll();

            // Assert
            Assert.Equal(actual, actual);
        }
    }
}
