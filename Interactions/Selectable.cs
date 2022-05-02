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
    class Selectable: Selenium_Base
    {
        public void ListSelect(IWebDriver Driver)
        {
            open("https://demoqa.com/interaction");
            wait(500);

            scrollPage(0, 700);
            wait(500);

            click(FindXPath("//span[text()='Selectable']"));
            wait(2000);

            scrollPage(0, 200);
            wait(500);

            click(FindXPath("//li[text()='Cras justo odio']"));
            wait(2000);

            click(FindXPath("//li[text()='Dapibus ac facilisis in']"));
            wait(2000);
            click(FindXPath("//li[text()='Porta ac consectetur ac']"));
            wait(2000);
            click(FindXPath("//li[text()='Dapibus ac facilisis in']"));
            wait(2000);
            click(FindXPath("//li[text()='Cras justo odio']"));
            wait(2000);
            click(FindXPath("//li[text()='Porta ac consectetur ac']"));
            wait(2000);
            

        }

        public void GridSelect(IWebDriver Driver)
        {

            click(FindXPath("//a[@id='demo-tab-grid']"));
            wait(2000);

            click(FindXPath("//li[text()='One']"));
            wait(2000);

            click(FindXPath("//li[text()='Three']"));
            wait(2000);
            click(FindXPath("//li[text()='Seven']"));
            wait(2000);
            click(FindXPath("//li[text()='Nine']"));
            wait(2000);
            click(FindXPath("//li[text()='Five']"));
            wait(2000);
            click(FindXPath("//li[text()='One']"));
            wait(2000);

            click(FindXPath("//li[text()='Three']"));
            wait(2000);
            click(FindXPath("//li[text()='Seven']"));
            wait(2000);
            click(FindXPath("//li[text()='Nine']"));
            wait(2000);
            click(FindXPath("//li[text()='Five']"));
            wait(2000);

            close();
        }
    }
}
