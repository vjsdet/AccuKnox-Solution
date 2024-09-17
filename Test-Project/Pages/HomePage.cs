using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Utils;

namespace Test_Project.Pages
{
    public class HomePage : BasePage
    {
            public override string PageURL => $"{BaseURL}";

            // Page Elements
            public IWebElement BackendText => driver.FindElementWhenVisible(() => By.XPath("//h1[contains(text(),'Hello from the Backend!')]"));


            public bool ValidateBackendText()
            {

                return BackendText.IsElementVisibleAndEnabled();

            }

        }
    }

