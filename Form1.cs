using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.CodeDom.Compiler;

namespace Passo_Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.passo.com.tr/en/login");
            /*
            try
            {
              */  

                IWebElement emailInput = driver.FindElement(By.CssSelector("input[autocomplete='username']"));//kullan�c� ad� ve �ifreyi al
                IWebElement pass = driver.FindElement(By.CssSelector("input[autocomplete='current-password']"));
                IWebElement button = driver.FindElement(By.ClassName("black-btn"));

                emailInput.SendKeys(textBox1.Text);
                pass.SendKeys(textBox2.Text);
                
                MessageBox.Show("Captcha'y� Tamamlad�ktan Sonra 'Tamam' Tu�una Bas�n");//kullan�c�n�n captchay� tamamlamas�n� bekle
                button.Click();

                driver.Navigate().GoToUrl(textBox3.Text);
                Thread.Sleep(3000);

                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("window.scrollBy(0, 500);");


                Thread.Sleep(4000);

                





                IWebElement satin_al = driver.FindElement(By.CssSelector("button.red-btn[type='button']"));
                satin_al.Click();


                //BU KISIMA KADAR KOD �ALI�IYOR 01.07.23
                
                
                

                IJavaScriptExecutor javaN = (IJavaScriptExecutor)driver;
                javaN.ExecuteScript("window.scrollBy(0, 500);");


                Thread.Sleep(1000);

            // Dropdown elementini bulma
            IWebElement dropdown = driver.FindElement(By.CssSelector(".form-control"));

            // Dropdown'� a�mak i�in t�kla
            dropdown.Click();

            // Bekleme yap
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            By optionSelector = By.CssSelector(".form-control option[value='1: Object']");
            wait.Until(driver => driver.FindElement(optionSelector).Displayed);

            // Se�ene�i bulma ve t�klama
            IWebElement option = driver.FindElement(optionSelector);
            option.Click();



            /*
                IWebElement dropdown = driver.FindElement(By.ClassName("form-control"));

                // Dropdown elementini se�me
                SelectElement select = new SelectElement(dropdown);

                // Metne g�re se�im yapma
                select.SelectByText("General Sales"); // General Sales se�ildi
              */

            //}

            /*catch(Exception ex)
            {
                
                
            }
            */






        }
    }
}