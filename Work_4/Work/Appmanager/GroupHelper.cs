using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Work_4.Work
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager) : base(manager) { }


        public GroupHelper CreateGroup(GroupData group)
        {
            manager.Navigator.GotoGroupsPage();

            InitNewGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }
                      
        public GroupHelper InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper RemoveGroup(int index)
        {
            manager.Navigator.GotoGroupsPage();
            SelectGroup(index);
            SubmitGroupRemove();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }

        public GroupHelper ModifyGroup(int index, GroupData newData)
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
            groupCache = null;
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
            groupCache = null;
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath($"//div[@id='content']/form/span[{index + 1}]/input")).Click();
            return this;

        }

        private GroupHelper SubmitGroupRemove()
        {
            driver.FindElement(By.Name("delete")).Click();
            groupCache = null;
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }


        private List<GroupData> groupCache = null;

        public List<GroupData> GetGroupList()
        {
            if (groupCache == null)
            {
                groupCache = new List<GroupData>();
                manager.Navigator.GotoHomePage();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
                foreach (var element in elements)
                {
                    groupCache.Add(new GroupData(element.Text)
                    {
                        Id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });

                }
            }
            return new List<GroupData>(groupCache);
        }

        public int GetGroupCounte()
        {
            return driver.FindElements(By.CssSelector("span.group")).Count;
        }

        //Создание нового номера телефона
        public GroupHelper CreateNewNumberPhone(ContactData phone)
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
            return this;
        }

        private List<ContactData> phoneCache = null;

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
        public GroupHelper CreatePhone(ContactData phone)
        {
            manager.Navigator.GoToAddNew();
            CreateNewNumberPhone(phone);
            SubmitPhoneCreate();
            manager.Navigator.GotoHomePage();
            return this;
        }

        //Метод удаления номера
        public GroupHelper RemovePhone(int index)
        {
            manager.Navigator.GotoHomePage();
            SelectPhone(index);
            SubmitPhoneRemove();
            manager.Navigator.GotoHomePage();
            return this;
        }

        //Метод изменения номера
        public GroupHelper ModifyPhone(int index, ContactData phone)
        {
            manager.Navigator.GotoHomePage();
            SelectPhone(index);
            CreateNewNumberPhone(phone);
            SubmitPhoneModify();
            manager.Navigator.GotoHomePage();
            return this;
        }

        //Кнопка изменения номера
        private GroupHelper SubmitPhoneModify()
        {
            driver.FindElement(By.XPath("//*[@value=\"Update\"]")).Click();
            phoneCache = null;
            return this;
        }

        //Выбор номера
        private GroupHelper SelectPhone(int index)
        {
            driver.FindElement(By.XPath($"//*[@name='entry'][{index + 1}]/*[@class='center'][3]")).Click();
            return this;
        }

        //Удаление номера на странице изменений 
        private GroupHelper SubmitPhoneRemove()
        {
            driver.FindElement(By.XPath("//*[@value=\"Delete\"]")).Click();
            phoneCache = null;
            return this;
        }

        //Кнопка добавления номера
        private GroupHelper SubmitPhoneCreate()
        {
            driver.FindElement(By.XPath("//*[@value=\"Enter\"]")).Click();
            phoneCache = null;
            return this;
        }
    }
}

