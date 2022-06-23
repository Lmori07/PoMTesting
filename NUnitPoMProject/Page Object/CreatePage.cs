namespace NUnitPoMProject;


public class CreatePage
{
    //Constructor que me permitira utilizar los metodos del WebDriver
    public CreatePage(IWebDriver driver)
    {
        Driver = driver;   
    }

    private IWebDriver Driver{get;}

    //Preparo el locator de loselemento que estoy buscando.
    public IWebElement rdoBtnGender => Driver.FindElement(By.Id("id_gender1"));
    public IWebElement txtBoxFirstName => Driver.FindElement(By.Id("customer_firstname"));
    public IWebElement txtBoxLastName => Driver.FindElement(By.Id("customer_lastname"));
    public IWebElement txtBoxEmail => Driver.FindElement(By.Id("email"));
    public IWebElement txtBoxPassword => Driver.FindElement(By.Id("passwd"));
    public IWebElement ddDays => Driver.FindElement(By.Id("days"));
    public IWebElement ddMonths => Driver.FindElement(By.Id("months"));
    public IWebElement ddYears => Driver.FindElement(By.Id("years"));
    public IWebElement chkBoxNewsletter => Driver.FindElement(By.Id("newsletter"));
    public IWebElement chkBoxSpecialOffer => Driver.FindElement(By.Id("optin"));
    public IWebElement txtBoxFirstNameAddress => Driver.FindElement(By.Id("firstname"));
    public IWebElement txtBoxLastNameAddress => Driver.FindElement(By.Id("lastname"));
    public IWebElement txtBoxCompany => Driver.FindElement(By.Id("company"));
    public IWebElement txtBoxAddress => Driver.FindElement(By.Id("address1"));
    public IWebElement txtBoxAddress2 => Driver.FindElement(By.Id("address2"));
    public IWebElement txtBoxCity => Driver.FindElement(By.Id("city"));
    public IWebElement ddStates => Driver.FindElement(By.Id("uniform-id_state"));
    public IWebElement txtBoxZipCode => Driver.FindElement(By.Id("postcode"));
    public IWebElement ddCounty => Driver.FindElement(By.Id("id_country"));
    public IWebElement txtBoxAdditionalInformation => Driver.FindElement(By.Id("other"));
    public IWebElement txtBoxPhone => Driver.FindElement(By.Id("phone"));
    public IWebElement txtBoxMobile => Driver.FindElement(By.Id("phone_mobile"));
    public IWebElement txtBoxAddressAlias => Driver.FindElement(By.Id("alias"));
    public IWebElement btnRegister => Driver.FindElement(By.Id("submitAccount"));

    //Ejecuto las operaciones sobre el elemeneto en cuestion.
   // public void clickOnEmailTxtBox() => txtbEmail.Click();
   // public void sendValidMail()=> txtbEmail.SendKeys("prueba@prueba.com");
   // public void clickOnBtnCreate()=> btnCreate.Click();
    


}