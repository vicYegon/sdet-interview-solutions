using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        // Set up the Chrome WebDriver
        IWebDriver driver = new ChromeDriver();

        // Navigate to the login page
        driver.Navigate().GoToUrl("file:///C:/Users/vkosg/source/repos/ConsoleApp1/ConsoleApp1/login.html");

        // Find the username and password input fields and enter your credentials
        IWebElement usernameField = driver.FindElement(By.Id("username"));
        IWebElement passwordField = driver.FindElement(By.Id("password"));

        usernameField.SendKeys("enter username");
        passwordField.SendKeys("enter password");

        // Find and click the login button
        IWebElement loginButton = driver.FindElement(By.Id("loginButton"));
        loginButton.Click();

        // Wait for the login process to check for an element that indicates a successful login
        bool loginSuccessful = false;
        try
        {
           
            IWebElement successElement = driver.FindElement(By.Id("store"));

            // If element is found, consider the login successful
            loginSuccessful = true;
        }
        catch (NoSuchElementException)
        {
            // If element is not found, the login has failed
            loginSuccessful = false;
        }


        // if element is found, loginsuccessful becomes true thus prints the message
        if (loginSuccessful)
        {
            Console.WriteLine("Login successful!");
        }

        // else login fails
        else
        {
            Console.WriteLine("Login failed.");
        }

    }
}
