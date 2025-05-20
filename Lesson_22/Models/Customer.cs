using System.Xml.Serialization;

namespace Lesson_22.Models
{
    [XmlRoot("CUSTOMER")]
    public class Customer
    {
        [XmlElement("ID")]
        public int Id { get; set; }

        [XmlElement("FIRSTNAME")]
        public string FirstName { get; set; } = "";

        [XmlElement("LASTNAME")]
        public string LastName { get; set; } = "";

        [XmlElement("STREET")]
        public string Street { get; set; } = "";

        [XmlElement("CITY")]
        public string City { get; set; } = "";
    }
}
