﻿using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

//Homework
namespace Work_5.Work
{
    [TestFixture]
    public class PhoneCreationTests : AuthTestBase
    {

        [Test]
        public void PhoneCreationTest()
        {
            ContactData phone = new ContactData();
            phone.Fistname = "Tomas";
            phone.Lastname = "Tomich";
            phone.Middlename = "Andreevich";
            phone.Nickname = "Tom";
            phone.Title = "aaa";
            phone.Company = "Microsoft";
            phone.Address = "Alley 8";
            phone.Homephone = "896725";
            phone.Mobilephone = "89477758392";
            phone.Workphone = "342356";
            phone.Fax = "876543";
            phone.Email = "kjhg@oiu.com";
            phone.Bday = "2";
            phone.Bmonth = "March";
            phone.Byear = "1992";
            phone.Aday = "2";
            phone.Amonth = "March";
            phone.Ayear = "1992";
            phone.Adress = "as";
            phone.Phone2 = "12345";
            phone.Notes = ";lkjhgfgbnm";

            List<ContactData> oldPhone = app.Contacts.GetPhoneList();
            
            app.Contacts.CreatePhone(phone);

            List<ContactData> newPhone = app.Contacts.GetPhoneList();
            oldPhone.Add(phone);
            oldPhone.Sort();
            newPhone.Sort();

            Assert.AreEqual(oldPhone, newPhone);
        }

        [Test]
        public void PhoneSecondCreationTest()
        {
            ContactData phone = new ContactData();
            phone.Fistname = "Bob";
            phone.Lastname = "Fedotov";
            phone.Middlename = "Anatolievich";
            phone.Nickname = "Bob";
            phone.Title = "aba";
            phone.Company = "Kode";
            phone.Address = "Frunze 8";
            phone.Homephone = "866425";
            phone.Mobilephone = "89471348198";
            phone.Workphone = "322353";
            phone.Fax = "874523";
            phone.Email = "kjhjg@oiu.com";
            phone.Bday = "3";
            phone.Bmonth = "March";
            phone.Byear = "1997";
            phone.Aday = "1";
            phone.Amonth = "March";
            phone.Ayear = "1999";
            phone.Adress = "ae";
            phone.Phone2 = "654321";
            phone.Notes = ";lkjtrebnm";

            List<ContactData> oldPhone = app.Contacts.GetPhoneList();
            app.Contacts.CreatePhone(phone);


            List<ContactData> newPhone = app.Contacts.GetPhoneList();
            oldPhone.Add(phone);
            oldPhone.Sort();
            newPhone.Sort();

            Assert.AreEqual(oldPhone, newPhone);
        }
    }
}