using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DemoQASite;

namespace Interactions
{
    class Sortable:Selenium_Base
    {
        public void ListSort(IWebDriver Driver)
        {
            open("https://demoqa.com/interaction");
            wait(500);

            scrollPage(0, 700);
            wait(500);

            click(FindXPath("//span[text()='Sortable']"));
            wait(2000);

            scrollPage(0, 200);

            WebElement destination6 = (WebElement)FindXPath("//div[@class='vertical-list-container mt-4']//div[text()='Six']");
            WebElement destination5 = (WebElement)FindXPath("//div[@class='vertical-list-container mt-4']//div[text()='Five']");
            WebElement destination4 = (WebElement)FindXPath("//div[@class='vertical-list-container mt-4']//div[text()='Four']");
            WebElement destination3 = (WebElement)FindXPath("//div[@class='vertical-list-container mt-4']//div[text()='Three']");
            WebElement destination2 = (WebElement)FindXPath("//div[@class='vertical-list-container mt-4']//div[text()='Two']");
            WebElement destination1 = (WebElement)FindXPath("//div[@class='vertical-list-container mt-4']//div[text()='One']");
            

            dragAndDrop(destination2, destination6);
            wait(2000);
            dragAndDrop(destination3, destination5);
            wait(2000);
            dragAndDrop(destination1, destination4);
            wait(2000);
            dragAndDrop(destination5, destination3);
            wait(2000);
            dragAndDrop(destination4, destination2);
            wait(2000);
            dragAndDrop(destination6, destination1);
            wait(2000);
            

        }

        public void GridSort(IWebDriver Driver)
        {
            click(FindXPath("//a[@id='demo-tab-grid']"));
            wait(2000);

            WebElement destination9 = (WebElement)FindXPath("//div[@class='create-grid']//div[text()='Nine']");
            WebElement destination8 = (WebElement)FindXPath("//div[@class='create-grid']//div[text()='Eight']");
            WebElement destination7 = (WebElement)FindXPath("//div[@class='create-grid']//div[text()='Seven']");
            WebElement destination6 = (WebElement)FindXPath("//div[@class='create-grid']//div[text()='Six']");
            WebElement destination5 = (WebElement)FindXPath("//div[@class='create-grid']//div[text()='Five']");
            WebElement destination4 = (WebElement)FindXPath("//div[@class='create-grid']//div[text()='Four']");
            WebElement destination3 = (WebElement)FindXPath("//div[@class='create-grid']//div[text()='Three']");
            WebElement destination2 = (WebElement)FindXPath("//div[@class='create-grid']//div[text()='Two']");
            WebElement destination1 = (WebElement)FindXPath("//div[@class='create-grid']//div[text()='One']");
            

            dragAndDrop(destination8, destination6);
            wait(2000);
            dragAndDrop(destination3, destination5);
            wait(2000);
            dragAndDrop(destination1, destination4);
            wait(2000);
            dragAndDrop(destination5, destination8);
            wait(2000);
            dragAndDrop(destination4, destination2);
            wait(2000);
            dragAndDrop(destination7, destination2);
            wait(2000);
            dragAndDrop(destination4, destination7);
            wait(2000);
            dragAndDrop(destination2, destination9);
            wait(2000);
            dragAndDrop(destination9, destination1);
            wait(2000);

            close();

        }
    }
}
