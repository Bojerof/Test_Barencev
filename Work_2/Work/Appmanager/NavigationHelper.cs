﻿using OpenQA.Selenium;

namespace Work_2.Work
{
	public class NavigationHelper : HelperBase
	{
        
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        public void GotoGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void GotoHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }

        //Homework
        public void GoToAddNew()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
    }
}

