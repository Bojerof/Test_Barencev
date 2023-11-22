using System;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Work_6.Work
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager) { }

        //Создание нового номера телефона
        public ContactHelper CreateNewNumberPhone(ContactData phone)
        {
            Type(By.Name("firstname"), phone.Fistname);
            Type(By.Name("middlename"), phone.Middlename);
            Type(By.Name("lastname"), phone.Lastname);
            Type(By.Name("nickname"), phone.Nickname);
            Type(By.Name("title"), phone.Title);
            Type(By.Name("company"), phone.Company);
            Type(By.Name("address"), phone.Address);
            Type(By.Name("home"), phone.Homephone);
            Type(By.Name("mobile"), phone.Mobilephone);
            Type(By.Name("work"), phone.Workphone);
            Type(By.Name("fax"), phone.Fax);
            Type(By.Name("email"), phone.Email);
            Type(By.Name("email2"), phone.Email2);
            Type(By.Name("email3"), phone.Email3);
            Type(By.Name("homepage"), phone.Homepage);
            driver.FindElement(By.Name("bday")).Click();
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(phone.Bday);
            driver.FindElement(By.Name("bmonth")).Click();
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(phone.Bmonth);
            Type(By.Name("byear"), phone.Byear);
            driver.FindElement(By.Name("aday")).Click();
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText(phone.Aday);
            driver.FindElement(By.Name("amonth")).Click();
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText(phone.Amonth);
            Type(By.Name("ayear"), phone.Ayear);
            Type(By.Name("address2"), phone.Adress);
            Type(By.Name("phone2"), phone.Phone2);
            Type(By.Name("notes"), phone.Notes);
            return this;
        }

        private List<ContactData> phoneCache = null;

        //Получение списка контактов
        public List<ContactData> GetPhoneList()
        {
            if (phoneCache == null)
            {
                phoneCache = new List<ContactData>();
                manager.Navigator.GotoHomePage();
                ICollection<IWebElement> elements = driver.FindElements(By.XPath("//td[2]"));
                foreach (IWebElement element in elements)
                {
                    phoneCache.Add(new ContactData(element.Text));
                }
            }
            return new List<ContactData>(phoneCache);
        }

        //Метод добавления нового номера
        public ContactHelper CreatePhone(ContactData phone)
        {
            manager.Navigator.GoToAddNew();
            CreateNewNumberPhone(phone);
            SubmitContactCreate();
            manager.Navigator.GotoHomePage();
            return this;
        }

        //Метод удаления номера
        public ContactHelper RemovePhone(int index)
        {
            manager.Navigator.GotoHomePage();
            InitContact(index);
            SubmitContactRemove();
            manager.Navigator.GotoHomePage();
            return this;
        }

        //Метод изменения номера
        public ContactHelper ModifyPhone(int index, ContactData phone)
        {
            manager.Navigator.GotoHomePage();
            InitContact(index);
            CreateNewNumberPhone(phone);
            SubmitContactModify();
            manager.Navigator.GotoHomePage();
            return this;
        }

        //Кнопка изменения номера
        private ContactHelper SubmitContactModify()
        {
            driver.FindElement(By.XPath("//*[@value=\"Update\"]")).Click();
            phoneCache = null;
            return this;
        }

        //Выбор номера
        private ContactHelper InitContact(int index)
        {
            driver.FindElement(By.XPath($"//*[@name='entry'][{index + 1}]/*[@class='center'][3]")).Click();
            return this;
        }

        //Удаление номера на странице изменений 
        private ContactHelper SubmitContactRemove()
        {
            driver.FindElement(By.XPath("//*[@value=\"Delete\"]")).Click();
            phoneCache = null;
            return this;
        }

        //Кнопка добавления номера
        private ContactHelper SubmitContactCreate()
        {
            driver.FindElement(By.XPath("//*[@value=\"Enter\"]")).Click();
            phoneCache = null;
            return this;
        }

        public ContactData GetContactInformationFromEditForm(int index)
        {
            manager.Navigator.GotoHomePage();
            InitContact(index);
            string firstName = driver.FindElement(By.Name("firstname")).GetAttribute("value");
            string lastName = driver.FindElement(By.Name("lastname")).GetAttribute("value");
            string adress = driver.FindElement(By.Name("address")).GetAttribute("value");

            string homePhone = driver.FindElement(By.Name("home")).GetAttribute("value");
            string mobilePhone = driver.FindElement(By.Name("mobile")).GetAttribute("value");
            string workPhone = driver.FindElement(By.Name("work")).GetAttribute("value");
            string phone2 = driver.FindElement(By.Name("phone2")).GetAttribute("value");
            return new ContactData(firstName)
            {
                Lastname = lastName,
                Adress = adress,
                Homephone = homePhone,
                Workphone = workPhone,
                Mobilephone = mobilePhone,
                Phone2 = phone2
            };
        }

        public ContactData GetContactInformationFromTable(int index)
        {
            manager.Navigator.GotoHomePage();
            IList<IWebElement> cells = driver.FindElements(By.Name("entry"))[index]
                .FindElements(By.TagName("td"));
            string lastName = cells[1].Text;
            string firstName = cells[2].Text;
            string adress = cells[3].Text;
            string allPhone = cells[5].Text;
            return new ContactData(firstName)
            {
                Lastname = lastName,
                Adress = adress,
                AllPhones = allPhone

            };
        }

        public int GetNumberSearchResults()
        {
            manager.Navigator.GotoHomePage();
            string text = driver.FindElement(By.TagName("span")).Text;
            
            return Int32.Parse(text);
        }

        public ContactData GetContactInfomationFromInfoTable(int index)
        {
            manager.Navigator.GotoHomePage();
            driver.FindElement(By.XPath($"//*[@name='entry'][{index + 1}]/*[@class='center'][2]")).Click();
            string[] titles = driver.FindElement(By.Id("content")).FindElement(By.TagName("b")).Text.Split(" ");
            IList<IWebElement> adressAndPhones = driver.FindElement(By.Id("content")).FindElements(By.TagName("br"));

            string firstName = titles[0];
            string lastName = titles[2];
            string adress = adressAndPhones[1].Text;
            string homePhone = adressAndPhones[2].Text;
            string mobilePhone = adressAndPhones[3].Text;
            string workPhone = adressAndPhones[4].Text;
            string phone2 = adressAndPhones[10].Text;

            return new ContactData(firstName)
            {
                Lastname = lastName,
                Adress = adress,
                Homephone = homePhone,
                Workphone = workPhone,
                Mobilephone = mobilePhone,
                Phone2 = phone2
            };
        }
    }       
}

