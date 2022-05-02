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
    class Dragable : Selenium_Base
    {
        public void SimpleDrag(IWebDriver Driver)
        {
            open("https://demoqa.com/interaction");
            wait(500);

            scrollPage(0, 700);
            wait(500);

            click(FindXPath("//span[text()='Dragabble']"));
            wait(1000);

            scrollPage(0, 200);
            wait(1000);

            var movable = FindXPath("//div[@id='dragBox']");

            dragAndDropOffset(movable, 200, 150);
            wait(2000);
            
        }

        public void AxisRectrictedDrag(IWebDriver Driver)
        {
            click(FindXPath("//a[@id='draggableExample-tab-axisRestriction']"));
            wait(2000);

            var movable1 = FindXPath("//div[@id='restrictedX']");
            var movable2= FindXPath("//div[@id='restrictedY']");


            dragAndDropOffset(movable1, 100, 0);
            wait(2000);

            dragAndDropOffset(movable2, 0, 200);
            wait(2000);
        }

        public void ContainerRectrictedDrag(IWebDriver Driver)
        {
            click(FindXPath("//a[@id='draggableExample-tab-containerRestriction']"));
            wait(2000);

            var movable1 = FindXPath("//div[@class='draggable ui-widget-content ui-draggable ui-draggable-handle']");
            var movable2 = FindXPath("//span[@class='ui-widget-header ui-draggable ui-draggable-handle']");


            dragAndDropOffset(movable1, 200, 100);
            wait(2000);

            dragAndDropOffset(movable2, 10, 30);
            wait(2000);
        }

        public void CursorStyleDrag(IWebDriver Driver)
        {
            click(FindXPath("//a[@id='draggableExample-tab-cursorStyle']"));
            wait(2000);

            var movable1 = FindXPath("//div[@id='cursorCenter']");
            var movable2 = FindXPath("//div[@id='cursorTopLeft']");
            var movable3 = FindXPath("//span[text()='My cursor is at bottom']");

            dragAndDropOffset(movable1, 100, 50);
            wait(2000);

            scrollPage(0, 300);
            wait(1000);

            dragAndDropOffset(movable2, 60, 20);
            wait(2000);

            dragAndDropOffset(movable3, 0, 100);
            wait(2000);

            close();

        }
    }
}
