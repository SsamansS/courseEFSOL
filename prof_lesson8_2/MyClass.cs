using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace prof_lesson8_2
{
    [XmlRoot("Classs")]
    public class MyClass
    {
        string stringField2 = "blb";
        int intField = 1;
        string stringField = "str";
        List<int> listField = new List<int>();

        [XmlAttribute("intt")]
        public int IntField
        {
            get { return intField; }
            set { intField = value; }
        }
        [XmlIgnore]
        public string StringField
        {
            get { return stringField; }
            set { stringField = value; }
        }
        [XmlAttribute("string2")]
        public string StringField2
        {
            get { return stringField2; }
            set { stringField2 = value; }
        }
        [XmlArrayItem("num")]
        public List<int> ListField
        {
            get { return listField; }
            set { listField = value; }
        }
    }
}
