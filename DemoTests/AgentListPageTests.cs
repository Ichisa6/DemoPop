using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Model;

namespace Demo.Pages.Tests
{
    [TestClass()]
    public class AgentListPageTests
    {
        [TestMethod()]
        public void AddPageTest()
        {

            PoprigynchickDBEntities db = new PoprigynchickDBEntities();
            string Title = "Насвай";
            string Description = "класс";
            int ProductionWorkshopNumber = 3333;



            Product product = new Product { Title = Title, Description = Description, ProductionWorkshopNumber = ProductionWorkshopNumber };
            db.Product.Add(product);
            db.SaveChanges();
            var logincheck2 = db.Product.Where(x => x.Title == Title).FirstOrDefault();

            Assert.IsTrue(logincheck2 != null);
        }

        [TestMethod()]
        public void AddEditPageTest()
        {
            PoprigynchickDBEntities db = new PoprigynchickDBEntities();
            string Title = "Насвай";
            string buffer = "Снюс";


            var logincheck = db.Product.Where(x => x.Title == Title).FirstOrDefault();
            logincheck.Title = buffer;
            db.SaveChanges();
            var logincheck2 = db.Product.Where(x => x.Title == Title).FirstOrDefault();

            Assert.IsTrue(logincheck2.Title == buffer);
        }

        [TestMethod()]
        public void DeleteTest()
        {

            PoprigynchickDBEntities db = new PoprigynchickDBEntities();
            string Title = "Насвай";

            var logincheck = db.Product.Where(x => x.Title == Title).FirstOrDefault();
            db.Product.Remove(logincheck);
            db.SaveChanges();
            var logincheck2 = db.Product.Where(x => x.Title == Title).FirstOrDefault();

            Assert.IsTrue(logincheck2 == null);
        }
    }
}
