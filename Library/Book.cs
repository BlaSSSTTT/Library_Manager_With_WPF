using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PortableLibrary
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public BookStatus Status { get; set; }

    }
    [DataContract]
    public enum BookStatus
    {
        [EnumMember]
        AVAILABLE, 
        [EnumMember]
        BORROWED,
        [EnumMember]
        RESERVED,
        [EnumMember]
        LOST
    }
}
