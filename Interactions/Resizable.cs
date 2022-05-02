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
    class Resizable:Selenium_Base
    {
        public void LimitedReseize(IWebDriver Driver)
        {
            open("https://demoqa.com/interaction");
            wait(500);

            scrollPage(0, 700);
            wait(500);

            click(FindXPath("//span[text()='Resizable']"));
            wait(2000);

            scrollPage(0, 200);
            wait(500);

            var LimitResize = FindXPath("//div[@id='resizableBoxWithRestriction']//span[@class='react-resizable-handle react-resizable-handle-se']");

            getAction().MoveToElement(LimitResize)
               .ClickAndHold()
               .MoveByOffset(300, 300)
               .MoveByOffset(-450, -450)
               .MoveByOffset(100, 200)
               .MoveByOffset(200, 100)
               .Release()
               .Build()
               .Perform();
            
            wait(2000);

        }

        public void Reseize(IWebDriver Driver)
        {
            scrollPage(0, 600);
            wait(500);

            var Resize = FindXPath("//div[@id='resizable']//span[@class='react-resizable-handle react-resizable-handle-se']");

            getAction().MoveToElement(Resize)
                .ClickAndHold()
                .MoveByOffset(200, 200)
                .Release()
                .Build()
                .Perform();

            wait(2000);

            close();
        }
    }
}
