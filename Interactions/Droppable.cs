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
    class Droppable : Selenium_Base
    {
        public void SimpleDropp(IWebDriver Driver)
        {
            open("https://demoqa.com/interaction");
            wait(500);

            scrollPage(0, 700);
            wait(500);

            click(FindXPath("//span[text()='Droppable']"));

            var movable = FindXPath("//div[@id='draggable']");
            var container = FindXPath("//div[@id='droppable']");

            dragAndDrop(movable, container);
            wait(2000);

        }

        public void AcceptDropp(IWebDriver Driver)
        {
            click(FindXPath("//a[@id='droppableExample-tab-accept']"));

            var movable1 = FindXPath("//div[@id='acceptable']");
            var container1 = FindXPath("//div[@class='accept-drop-container']//div[@id='droppable']");

            dragAndDrop(movable1, container1);
            wait(2000);

            var movable2 = FindXPath("//div[@id='notAcceptable']");
            var container2 = FindXPath("//div[@class='accept-drop-container']//div[@id='droppable']");

            dragAndDrop(movable2, container2);
            wait(2000);
        }

        public void PreventPropogationDropp(IWebDriver Driver)
        {
            click(FindXPath("//a[@id='droppableExample-tab-preventPropogation']"));

            scrollPage(0, 300);

            var movable1 = FindXPath("//div[@id='dragBox']");
            var container1 = FindXPath("//div[@id='notGreedyDropBox']//p[text()='Outer droppable']");
            var container2 = FindXPath("//div[@id='notGreedyInnerDropBox']");
            var container3 = FindXPath("//div[@id='greedyDropBox']//p[text()='Outer droppable']");
            var container4 = FindXPath("//div[@id='greedyDropBoxInner']");

            dragAndDrop(movable1, container1);
            wait(2000);

            dragAndDrop(movable1, container2);
            wait(2000);

            dragAndDrop(movable1, container3);
            wait(2000);

            dragAndDrop(movable1, container4);
            wait(2000);
        }

        public void RevertDropp(IWebDriver Driver)
        {
            click(FindXPath("//a[@id='droppableExample-tab-revertable']"));

            var movable = FindXPath("//div[@id='notRevertable']");
            var container = FindXPath("//div[@class='revertable-drop-container']//div[@id='droppable']");

            dragAndDrop(movable, container);
            wait(2000);

            close();

        }
    }
}
