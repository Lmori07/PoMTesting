namespace NUnitPoMProject;


public class HomePage
{
    public HomePage(IWebDriver driver)
    {
        Driver = driver;   
    }

    private IWebDriver Driver{get;}

    public IWebElement lnkSigIn => Driver.FindElement(By.ClassName("login"));

    public void ClickSigIn() => lnkSigIn.Click();

}