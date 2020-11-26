using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfExercise
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookID { get; set; }
        [DataMember]
        public string BookName { get; set; }
        [DataMember]
        public int AvailableCopies { get; set; }
        [DataMember]
        public string description { get; set; }
    }
}