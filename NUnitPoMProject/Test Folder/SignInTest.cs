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
        Thread.Sleep(3000);
        homePage.ClickSigIn();
        Thread.Sleep(3000);

        AutPage AP = new AutPage(driver);
        AP.clickOnEmailTxtBox();
        AP.setValidMail();
        AP.clickOnBtnCreate();
        Thread.Sleep(3000);

        CreatePage CP = new CreatePage(driver);
        CP.selectTitle();
        CP.Setfn("Jose Prueba");
        CP.Setln("Preuba Test");
        CP.Setemail("testaaa@testaaa.com");
        CP.Setpassword("test@1");
        #region DoB
        CP.getddDays("7");
        CP.getddMonth("8");
        CP.getddYear("1987");
        #endregion
        CP.selectNewsletter();
        CP.selectSpecialOffer();
        CP.Setpfna("Jose Prueba");
        CP.Setplna("Preuba Test");
        CP.Setca("Corporate");
        CP.Setla("C/ 5ta");
        CP.Setla2("Sante III, Madre Vieja Sur");
        CP.Setca2("Pelusa");
        CP.getddState("50");
        CP.Setzip("10034");
        CP.getddCountry("21");
        CP.Setaf("Testing Purpose.");
        CP.Setphone("987-654-3210");
        CP.Setmobile("765-735-1500");
        CP.Setalias("N/A");
        //Continuar Video 50:10
    }

}
