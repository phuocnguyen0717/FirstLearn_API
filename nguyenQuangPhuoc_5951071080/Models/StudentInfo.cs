using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace nguyenQuangPhuoc_5951071080.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        
         [DataMember(Name = "MSV")]
         public double MSV { get; set; }

        [DataMember (Name = "Age")]
        public int Age { get; set; }
    }
}