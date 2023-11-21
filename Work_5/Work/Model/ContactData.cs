using System;
using System.Text.RegularExpressions;

namespace Work_5.Work
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string allPhones;

        public string Fistname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Nickname { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Homephone { get; set; }
        public string Mobilephone { get; set; }
        public string Workphone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Homepage { get; set; }
        public string Bday { get; set; }
        public string Bmonth { get; set; }
        public string Byear { get; set; }
        public string Aday { get; set; }
        public string Amonth { get; set; }
        public string Ayear { get; set; }
        public string Adress { get; set; }
        public string Phone2 { get; set; }
        public string Notes { get; set; }
        public string AllPhones
        {
            get
            {
                if (allPhones != null)
                {
                    return allPhones;
                }
                else
                {
                    return (Cleanup(Homephone) + Cleanup(Mobilephone) + Cleanup(Workphone) + Cleanup(Phone2)).Trim();
                }
            }
            set => allPhones = value;
        }

        private string Cleanup(string phone)
        {
            if (phone == null || phone == "") return "";
            return Regex.Replace(phone, "[ -()]", "") + "\n";

        }

        public ContactData(string lastName)
        {
            Lastname = lastName;
        }
        public ContactData() { }

        public override string ToString()
        {
            return $"LastName = {Lastname}";
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null)) return false;
            if (Object.ReferenceEquals(this, other)) return true;
            return Lastname == other.Lastname;
        }

        public override int GetHashCode()
        {
            return Lastname.GetHashCode();
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null)) return 1;
            return Lastname.CompareTo(other.Lastname);
        }
    }
}

