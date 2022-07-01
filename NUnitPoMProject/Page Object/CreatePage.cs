namespace NUnitPoMProject;

public class CreatePage
{
    //Constructor que me permitira utilizar los metodos del WebDriver
    public CreatePage(IWebDriver driver, SelectElement selectDay)
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
    public IWebElement ddStates => Driver.FindElement(By.Id("uniform-id_state"));
    public IWebElement txtBoxZipCode => Driver.FindElement(By.Id("postcode"));
    public IWebElement ddCounty => Driver.FindElement(By.Id("id_country"));
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
    public void clearingFirstNameTbox() => txtBoxFirstName.Clear();
    public void writtingFirstNameTbox() => txtBoxFirstName.SendKeys("");
    #endregion

    #region Last Name TextBox
    public void clearingLastNameTbox() => txtBoxLastName.Clear();
    public void writtingLastNameTbox() => txtBoxLastName.SendKeys("");
    #endregion

    #region Email TextBox
    public void clearingEmailTbox() => txtBoxEmail.Clear();
    public void writtingEmailTbox() => txtBoxEmail.SendKeys("");
    #endregion

    #region Password TextBox
    public void clearingPasswordTbox() => txtBoxPassword.Clear();
    public void writtingPasswordTbox() => txtBoxPassword.SendKeys("");
    #endregion

    #region Date of Birth
    //Generando la lista de los elementos de cada dropdowns
    //dayElements.

    SelectElement selectDay = new SelectElement(ddDays);
    SelectElement selectMonth = new SelectElement(ddMonths);
    SelectElement selectYear = new SelectElement()ddYears;
    public void selectingDay() => selectDay.SelectByValue("7");
    public void selectingMonth() => selectMonth.SelectByValue("August");
    public void selectingYear() => selectYear.SelectByValue("1987");
    #endregion

    #region Newsletter and Special Offers
    public void selectNewsletter() => chkBoxNewsletter.Click();
    public void selectSpecialOffer() => chkBoxSpecialOffer.Click();
    #endregion

    #region First Name Address
    public void clearingFirstNameTboxAddress() => txtBoxFirstNameAddress.Clear();
    public void writtingFirstNameTboxAddress() => txtBoxFirstNameAddress.SendKeys("");
    #endregion

    #region Last Name Address
    public void clearingLastNameTboxAddress() => txtBoxLastNameAddress.Clear();
    public void writtingLastNameTboxAddress() => txtBoxLastNameAddress.SendKeys("");
    #endregion

    #region Company Address
    public void clearingCompanyTboxAddress() => txtBoxCompany.Clear();
    public void writtingCompanyTboxAddress() => txtBoxCompany.SendKeys("");
    #endregion

    #region Location Address
    public void clearingLocationTboxAddress() => txtBoxAddress.Clear();
    public void writtingLocationTboxAddress() => txtBoxAddress.SendKeys("");
    #endregion

    #region Location2 Address
    public void clearingLocation2TboxAddress() => txtBoxAddress2.Clear();
    public void writtingLocation2TboxAddress() => txtBoxAddress2.SendKeys("");
    #endregion

    #region City Address
    public void clearingCityTboxAddress() => txtBoxCity.Clear();
    public void writtingCityTboxAddress() => txtBoxCity.SendKeys("");
    #endregion

    #region State Address
   //SelectElement stateElements = new SelectElement(ddStates);
    #endregion

    #region ZipCode Address
    public void clearingZipCodeTboxAddress() => txtBoxZipCode.Clear();
    public void writtingZipCodeTboxAddress() => txtBoxZipCode.SendKeys("");
    #endregion

    #region Country Address
    
    #endregion

    #region Additional Infromation
    public void clearingAdditionalInformationTboxAddress() => txtBoxAdditionalInformation.Clear();
    public void writtingAdditionalInformationTboxAddress() => txtBoxAdditionalInformation.SendKeys("");
    #endregion

    #region Phone
    public void clearingPhoneTboxAddress() => txtBoxPhone.Clear();
    public void writtingPhoneTboxAddress() => txtBoxPhone.SendKeys("");
    #endregion

    #region Mobile
    public void clearingMobileTboxAddress() => txtBoxMobile.Clear();
    public void writtingMobileTboxAddress() => txtBoxMobile.SendKeys("");
    #endregion

    #region Address Alias
    public void clearingAddressAliasTboxAddress() => txtBoxAddressAlias.Clear();
    public void writtingAddressAliasTboxAddress() => txtBoxAddressAlias.SendKeys("");
    #endregion

    #region Submit Button
    public void ClickSubmit() => btnRegister.Click();
    #endregion
}

