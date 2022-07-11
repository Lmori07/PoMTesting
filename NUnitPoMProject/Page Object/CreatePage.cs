namespace NUnitPoMProject;

public class CreatePage
{
    //Constructor que me permitira utilizar los metodos del WebDriver
    public CreatePage(IWebDriver driver)
    {
        Driver = driver;
    }

    private IWebDriver Driver{get;}

    #region Locators
    //Preparo el locator de los elemento que estoy buscando.
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
    public IWebElement ddStates => Driver.FindElement(By.Id("id_state"));
    public IWebElement txtBoxZipCode => Driver.FindElement(By.Id("postcode"));
    public IWebElement ddCountry => Driver.FindElement(By.Id("id_country"));
    public IWebElement txtBoxAdditionalInformation => Driver.FindElement(By.Id("other"));
    public IWebElement txtBoxPhone => Driver.FindElement(By.Id("phone"));
    public IWebElement txtBoxMobile => Driver.FindElement(By.Id("phone_mobile"));
    public IWebElement txtBoxAddressAlias => Driver.FindElement(By.Id("alias"));
    public IWebElement btnRegister => Driver.FindElement(By.Id("submitAccount"));
    #endregion

    //Ejecuto las operaciones sobre el elemeneto en cuestion.
    #region Select Title
    public void selectTitle() => rdoBtnGender.Click();
    #endregion

    #region First Name TextBox
    public void  Setfn(String text)
    {
       txtBoxFirstName.Clear();
       txtBoxFirstName.SendKeys(text);
    }
    #endregion

    #region Last Name TextBox
    public void  Setln(String text)
    {
       txtBoxLastName.Clear();
       txtBoxLastName.SendKeys(text);
    }
    #endregion

    #region Email TextBox
    public void  Setemail(String text)
    {
       txtBoxEmail.Clear();
       txtBoxEmail.SendKeys(text);
    }
    #endregion

    #region Password TextBox
    public void  Setpassword(String text)
    {
       txtBoxPassword.Clear();
       txtBoxPassword.SendKeys(text);
    }
    #endregion

    #region Date of Birth
    //Generando la lista de los elementos de cada dropdowns
    //dayElements.
    public void  getddDays(String text)
    {
      SelectElement  dropdown = new SelectElement(ddDays);
       dropdown.SelectByValue(text);
    }
    public void  getddMonth(String text)
    {
      SelectElement  dropdown = new SelectElement(ddMonths);
       dropdown.SelectByValue(text);
    }
    public void  getddYear(String text)
    {
      SelectElement  dropdown = new SelectElement(ddYears);
       dropdown.SelectByValue(text);
    }
  //  SelectElement selectDay = new SelectElement(ddDays);
   // SelectElement selectMonth = new SelectElement(ddMonths);
  //  SelectElement selectYear = new SelectElement(ddYears);	
   // public void selectingDay() => selectDay.SelectByValue("7");
   // public void selectingMonth() => selectMonth.SelectByValue("August");
   // public void selectingYear() => selectYear.SelectByValue("1987");
    #endregion

    #region Newsletter and Special Offers
    public void selectNewsletter() => chkBoxNewsletter.Click();
    public void selectSpecialOffer() => chkBoxSpecialOffer.Click();
    #endregion

    #region First Name Address
    public void  Setpfna(String text)
    {
       txtBoxFirstNameAddress.Clear();
       txtBoxFirstNameAddress.SendKeys(text);
    }
    #endregion

    #region Last Name Address
    public void  Setplna(String text)
    {
       txtBoxLastNameAddress.Clear();
       txtBoxLastNameAddress.SendKeys(text);
    }
    #endregion

    #region Company Address
    public void  Setca(String text)
    {
       txtBoxCompany.Clear();
       txtBoxCompany.SendKeys(text);
    }
    #endregion

    #region Location Address
    public void  Setla(String text)
    {
       txtBoxAddress.Clear();
       txtBoxAddress.SendKeys(text);
    }
    #endregion

    #region Location2 Address
    public void  Setla2(String text)
    {
       txtBoxAddress2.Clear();
       txtBoxAddress2.SendKeys(text);
    }
    #endregion

    #region City Address
     public void  Setca2(String text)
    {
       txtBoxCity.Clear();
       txtBoxCity.SendKeys(text);
    }
    #endregion

    #region State Address
   public void  getddState(String text)
    {
      SelectElement  dropdown = new SelectElement(ddStates);
       dropdown.SelectByValue(text);
    }
    #endregion

    #region ZipCode Address
    public void  Setzip(String text)
    {
      txtBoxZipCode.Clear();
      txtBoxZipCode.SendKeys(text);
    }
    #endregion

    #region Country Address
    public void  getddCountry(String text)
    {
      SelectElement  dropdown = new SelectElement(ddCountry);
       dropdown.SelectByValue(text);
    }
    #endregion

    #region Additional Infromation
    public void  Setaf(String text)
    {
      txtBoxAdditionalInformation.Clear();
      txtBoxAdditionalInformation.SendKeys(text);
    }
    #endregion

    #region Phone
    public void  Setphone(String text)
    {
      txtBoxPhone.Clear();
      txtBoxPhone.SendKeys(text);
    }
    #endregion

    #region Mobile
     public void  Setmobile(String text)
    {
      txtBoxMobile.Clear();
      txtBoxMobile.SendKeys(text);
    }
    #endregion

    #region Address Alias
    public void  Setalias(String text)
    {
      txtBoxAddressAlias.Clear();
      txtBoxAddressAlias.SendKeys(text);
    }
    #endregion

    #region Submit Button
    public void ClickSubmit() => btnRegister.Click();
    #endregion
}

