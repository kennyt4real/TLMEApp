using System;
using System.Collections.Generic;
using System.Text;

namespace TLMEApp.Model.Users
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string StateOfOrigin { get; set; }
        public string Lga { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Addeess { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public string Religion { get; set; }
        public string Gender { get; set; }
        public string Tribe { get; set; }
        public bool Active { get; set; }
        public bool IsEnabled { get; set; }
        public byte[] Passport { get; set; }

        public string UserName
        {
            get { return $"{LastName} {FirstName}"; }
            set { }
        }

        public string FullName
        {
            get { return $"{LastName} {FirstName} {MiddleName}"; }
            set { }
        }

        public int Age
        {
            get
            {
                if (DateOfBirth != null)
                {
                    var t = DateTime.Now - Convert.ToDateTime(DateOfBirth);
                    return Age = t.Days / 365;
                }
                return 0;
            }
            set { }
        }
    }
}
