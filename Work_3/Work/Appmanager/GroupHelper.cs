using System.Numerics;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Work_3.Work
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager) : base(manager) { }


        public GroupHelper Create(GroupDate group)
        {
            manager.Navigator.GotoGroupsPage();

            InitNewGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        //метод добавления нового номера
        public GroupHelper CreatePhone(PhoneDate phone)
        {
            manager.Navigator.GoToAddNew();
            CreateNewNumberPhone(phone);
            manager.Navigator.GotoHomePage();
            return this;
        }

        public GroupHelper InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper Remove(int index)
        {
            manager.Navigator.GotoGroupsPage();
            SelectGroup(index);
            RemoveGroup();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper FillGroupForm(GroupDate group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }

        public GroupHelper Modify(int index, GroupDate newData)
        {
            manager.Navigator.GotoGroupsPage();
            SelectGroup(index);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnToGroupsPage();
            return this;

        }

        private GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        private GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath($"//div[@id='content']/form/span[{index}]/input")).Click();
            return this;

        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }

        //Homework
        public GroupHelper CreateNewNumberPhone(PhoneDate phone)
        {
            Type(By.Name("firstname"), phone.Fistname);
            Type(By.Name("middlename"), phone.Middlename);
            Type(By.Name("lastname"), phone.Lastname);
            Type(By.Name("nickname"), phone.Nickname);
            Type(By.Name("title"), phone.Title);
            Type(By.Name("company"), phone.Company);
            Type(By.Name("address"), phone.Address);
            Type(By.Name("home"), phone.Home);
            Type(By.Name("mobile"), phone.Mobile);
            Type(By.Name("work"), phone.Work);
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
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }

    }
}

