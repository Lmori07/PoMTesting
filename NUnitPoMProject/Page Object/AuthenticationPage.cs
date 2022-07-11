namespace NUnitPoMProject;


public class AutPage
{
    //Constructor que me permitira utilizar los metodos del WebDriver
    public AutPage(IWebDriver driver)
    {
        Driver = driver;   
    }

    private IWebDriver Driver{get;}

    //Preparo el locator del elemento que estoy buscando.
    public IWebElement txtbEmail => Driver.FindElement(By.Id("email_create"));
    public IWebElement btnCreate => Driver.FindElement(By.Id("SubmitCreate"));

    //Ejecuto las operaciones sobre el elemeneto en cuestion.
    public void clickOnEmailTxtBox() => txtbEmail.Click();
    public void setValidMail()=> txtbEmail.SendKeys("testaaa@testaaa.com");
    public void clickOnBtnCreate()=> btnCreate.Click();
    


}