using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class PrEntryPoint
{
    // IWebDriver and IWebElement must be static if decalred outside the method.

    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;
    static IWebElement checkBox;

    static void Main()
    {
        // E L E M E N T  S E L E C T O R S

        /// <summary>
        /// Sample code to access an element on a page by element name. If the name isn't found
        /// Selenium will throw a NoSuchElementException therefore the FindElement expression
        /// is contained within a try catch block and the exception is handled.
        /// </summary>

        string url = "http://testing.todorvachev.com/selectors/name";
        driver.Navigate().GoToUrl(url);
        Thread.Sleep(3000);

        try
        {
            IWebElement element = driver.FindElement(By.Name("myName"));

            if (element.Displayed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Element name seen...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        catch (WebDriverException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("WebDriverException {0} ", e);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Sample code to access an element on a page by element id. If the id isn't found
        /// Selenium will throw a NoSuchElementException therefore the FindElement expression
        /// is contained within a try catch block and the exception is handled.
        /// </summary>

        url = "http://testing.todorvachev.com/selectors/id";
        driver.Navigate().GoToUrl(url);
        Thread.Sleep(3000);

        try
        {
            IWebElement element = driver.FindElement(By.Id("testImage"));

            if (element.Displayed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Element id seen...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        catch (WebDriverException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("WebDriverException {0} ", e);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Sample code to access an element on a page by class name. This can be used for grabbing text.
        /// If the class name isn't found Selenium will throw a NoSuchElementException therefore the 
        /// FindElement expression is contained within a try catch block and the exception is handled.
        /// </summary>

        url = "http://testing.todorvachev.com/selectors/class-name";
        driver.Navigate().GoToUrl(url);
        Thread.Sleep(3000);

        try
        {
            IWebElement element = driver.FindElement(By.ClassName("testClass"));
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(element.Text);
            Console.ForegroundColor = ConsoleColor.White;

        }
        catch (WebDriverException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("WebDriverException {0} ", e);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Sample code to access elements using CSS path and X path. If the path name isn't found 
        /// Selenium will throw a NoSuchElementException therefore the FindElement expression is 
        /// contained within a try catch block and the exception is handled.
        /// </summary>

        url = "http://testing.todorvachev.com/selectors/css-path";
        string cssPath = "#post-108 > div > figure > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        driver.Navigate().GoToUrl(url);
        Thread.Sleep(3000);

        try
        {
            IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

            if (cssPathElement.Displayed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("CSS path element seen...");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (xPathElement.Displayed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("X path element seen...");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        catch (WebDriverException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("WebDriverException {0} ", e);
            Console.ForegroundColor = ConsoleColor.White;
        }

        // S P E C I A L  E L E M E N T S

        // Text Input Field

        url = "http://testing.todorvachev.com/special-elements/text-input-field";
        driver.Navigate().GoToUrl(url);
        Thread.Sleep(3000);

        try
        {
            textBox = driver.FindElement(By.Name("username"));
            textBox.Clear();
            textBox.SendKeys("Test Text");
            Thread.Sleep(3000);
            
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(textBox.GetAttribute("value"));
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(3000);
        }
        catch (WebDriverException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("WebDriverException {0} ", e);
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Check Box

        url = "http://testing.todorvachev.com/special-elements/check-button-test-3";
        driver.Navigate().GoToUrl(url);
        Thread.Sleep(3000);

        try
        {
            checkBox = driver.FindElement(By.CssSelector(""));
        }
        catch (WebDriverException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("WebDriverException {0} ", e);
            Console.ForegroundColor = ConsoleColor.White;
        }

        driver.Quit();

    }
}
