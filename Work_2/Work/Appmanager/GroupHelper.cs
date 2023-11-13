using OpenQA.Selenium;

namespace Work_2.Work
{
	public class GroupHelper : HelperBase
	{
        public GroupHelper(IWebDriver driver) : base(driver) { }
       

        public void InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        public void FillGroupForm(GroupDate groupDate)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(groupDate.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(groupDate.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(groupDate.Footer);
        }

        public void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        public void SelectGroup(int index)
        {
            driver.FindElement(By.XPath($"//div[@id='content']/form/span[{index}]/input")).Click();

        }

        public void RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }
    }
}

