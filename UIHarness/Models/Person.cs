using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UIHarness.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return String.Format("{0}, {1}", LastName, FirstName);
            }
        }

        public string Url { get; set; }
    }
}