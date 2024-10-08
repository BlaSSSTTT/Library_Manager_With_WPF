using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using PortableLibrary.Serialization;

namespace PortableLibrary
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Author> Authors { get; set; }
        [DataMember]
        public IEnumerable<Book> Books { get; set; }
        [DataMember]
        public IEnumerable<Reader> Readers { get; set; }

        public DataModel()
        {
            Books = new List<Book>() { new Book() { Author = "Bob", Description = "abc", Title = "Book", Status  = BookStatus.AVAILABLE} };
            Authors = new List<Author>() { new Author() };
            Readers = new List<Reader>() { new Reader() };
        }

        public static string DataPath = "library.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }

            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }

    }
    
}
