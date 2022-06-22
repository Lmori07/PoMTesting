using NUnit.Framework;

namespace NUnitPoMProject;


public class SignInTest
{
     IWebDriver driver = new ChromeDriver();

    [SetUp]
    public void Setup()
    { 
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
    }

    [Test]
    public void ClickSignInTest()
    {
        HomePage homePage = new HomePage(driver);
        homePage.ClickSigIn();
    }

}