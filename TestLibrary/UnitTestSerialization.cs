using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortableLibrary;
using PortableLibrary.Serialization;

namespace TestLibrary
{
    [TestClass]
    public class UnitTestSerializer
    {
        [TestMethod]
        public void TestMethodSerialize()
        {
            var model = new DataModel();
            model.Authors = new List<Author>
            {
                new Author()
                {
                    Name = "Bob",
                    Country = "UK",
                    Books = new List<Book>
                    {
                        new Book() { Author = "Bob", Description = "asdadasd", Title = "Hello World" }
                    }
                }
            };
            model.Books = new List<Book>
            {
                new Book() { Author = "Bob", Description = "asdadasd", Title = "Hello World" }
            };
            model.Readers = new List<Reader>
            {
                new Reader()
                {
                    Age = 22,
                    Email = "rob@gmail.com",
                    Name = "Rob"
                }
            };
            DataSerializer.SerializeData(@"E:\ДЗ\КПЗ\lab2\organizer.dat", model);

        }

        [TestMethod]
        public void TestMethodDeserialize()
        {
            var model = DataSerializer.DeserializeItem(@"E:\ДЗ\КПЗ\lab2\organizer.dat");
        }
    }
}
