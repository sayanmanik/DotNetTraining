using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ContactSerialization
{
    //[XmlRoot(ElementName ="ContactInfo")]
    [Serializable()]
    public class Contact
    {
        private int contactNo;
        private string contactName;
        private string cellNo;

        public Contact()
        {

        }
        public Contact(int contactNo, string contactName, string cellNo)
        {
            this.contactNo = contactNo;
            this.ContactName = contactName;
            this.cellNo = cellNo;

        }

        //[XmlElement(ElementName = "ContactNo")]
        public int ContactNo
        {
            get
            {
                return contactNo;
            }
            set
            {

                contactNo = value;
            }
        }

        //[XmlElement(ElementName = "ContactName")]
        public string ContactName
        {
            get
            {
                return contactName;
            }

            set
            {
                contactName = value;
            }
        }

        //[XmlElement(ElementName ="CellNo")]
        public string CellNo
        {
            get
            {
                return cellNo;
            }
            set
            {
                cellNo = value;
            }
        }
    }
}
