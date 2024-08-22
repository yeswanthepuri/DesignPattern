using System.Xml.Serialization;

namespace Adapter
{
    [XmlRoot("note")]
    public class Note
    {
        [XmlElement("to")]
        public string To { get; set; }

        [XmlElement("from")]
        public string From { get; set; }

        [XmlElement("heading")]
        public string Heading { get; set; }

        [XmlElement("body")]
        public string Body { get; set; }

        public override string ToString()
        {
            return $"To: {To}\nFrom: {From}\nHeading: {Heading}\nBody: {Body}";
        }
    }
}
