namespace NUnitPoMProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;

public class WrapperBase
{
     private IWebDriver driver;


    //Constructor del wrapper
    public WrapperBase(IWebDriver driver)
    {
        this.driver = driver;
    }

    public IWebDriver ChromeDriverConnection(){
        // Instancio el Chromebrowser que utilizaremos para navegar.
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        return driver;
    }
    //Seteamos el metodo que nos permitira visitar la url en cuestion.
    public void Visit(String Url){
        driver.Navigate().GoToUrl(Url);
    }

    public IWebElement findElement(By locator){
        return findElement(locator);
    }

    public List<IWebElement> findElements(By locator){
        return findElements(locator);
    }

    //Metodo para obtener el texto de un elemento.
    public String getText(IWebElement element){
        return element.Text;
    }

    //Overload del metodo anterior.
    public String getText(By locator){
        return driver.FindElement(locator).Text;
    }

    //Metodo para escribir en un textbox.
    public void setText(String text, By locator){
        driver.FindElement(locator).SendKeys(text);
    }

    public void Clicking(By locator){
        driver.FindElement(locator).Click();
    }

    public Boolean isPresent(By locator){
        try{    
           return driver.FindElement(locator).Displayed;
        }
        catch(OpenQA.Selenium.NoSuchElementException e){
            return false;
        }
    }
}