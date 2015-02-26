using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UIHarness.Models
{
    public class Person2 : Person
    {
        //Added properties in V2
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }
    }
}