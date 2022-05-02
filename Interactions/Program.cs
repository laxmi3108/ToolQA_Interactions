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
    class Program : Selenium_Base
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = null;

            Sortable sortable = new Sortable();
            sortable.ListSort(Driver);


            sortable.GridSort(Driver);

            Selectable selectable = new Selectable();
            selectable.ListSelect(Driver);

            selectable.GridSelect(Driver);

            Resizable resizable = new Resizable();

            resizable.LimitedReseize(Driver);

            resizable.Reseize(Driver);

            Droppable droppable = new Droppable();

            droppable.SimpleDropp(Driver);

            droppable.AcceptDropp(Driver);

            droppable.PreventPropogationDropp(Driver);

            droppable.RevertDropp(Driver);

            Dragable dragable = new Dragable();

            dragable.SimpleDrag(Driver);
            
            dragable.AxisRectrictedDrag(Driver);

            dragable.ContainerRectrictedDrag(Driver);

            dragable.CursorStyleDrag(Driver);

        }
    }
}
