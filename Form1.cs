using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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
            

                IWebElement emailInput = driver.FindElement(By.CssSelector("input[autocomplete='username']"));//kullan�c� ad� ve �ifreyi al
                IWebElement pass = driver.FindElement(By.CssSelector("input[autocomplete='current-password']"));
                IWebElement button = driver.FindElement(By.ClassName("black-btn"));

                emailInput.SendKeys(textBox1.Text);
                pass.SendKeys(textBox2.Text);
                
                MessageBox.Show("Captcha'y� Tamamlad�ktan Sonra 'Tamam' Tu�una Bas�n");//kullan�c�n�n captchay� tamamlamas�n� bekle
                button.Click();

                driver.Navigate().GoToUrl(textBox3.Text);
                Thread.Sleep(3000);
                /*
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("window.scrollBy(0, 500);");
                */
                IWebElement footer = driver.FindElement(By.TagName("footer"));
                //int deltaY = footer.Location.Y;
                new Actions(driver)
                    .ScrollByAmount(0, 500)
                    .Perform();



                Thread.Sleep(4000);

                





                IWebElement satin_al = driver.FindElement(By.CssSelector("button.red-btn[type='button']"));
                satin_al.Click();


              

            //Bu k�s�mdan sonras� deneysel.
            /*
            // �lk dropdown elementini bulmak i�in bekleme yap
            By dropdownSelector1 = By.CssSelector("select.form-control.ng-valid.ng-dirty.ng-touched");
            IWebElement dropdown1 = driver.FindElement(dropdownSelector1);

            // �lk dropdownu se�mek i�in t�klama
            dropdown1.Click();

            // Bekleme yap
            Thread.Sleep(1000); // 1 saniye bekleme

            // �lk dropdown i�in se�ene�i bulma ve t�klama
            By optionSelector1 = By.CssSelector("select.form-control.ng-valid.ng-dirty.ng-touched option[value='1: Object']");
            IWebElement option1 = driver.FindElement(optionSelector1);
            option1.Click();

            // �kinci dropdown elementini bulmak i�in bekleme yap
            By dropdownSelector2 = By.CssSelector("select.form-control[style='width: 27%']");
            IWebElement dropdown2 = driver.FindElement(dropdownSelector2);

            // �kinci dropdownu se�mek i�in t�klama
            dropdown2.Click();

            // Bekleme yap
            Thread.Sleep(1000); // 1 saniye bekleme

            // �kinci dropdown i�in se�ene�i bulma ve t�klama
            By optionSelector2 = By.CssSelector("select.form-control[style='width: 27%'] option[value='1']");
            IWebElement option2 = driver.FindElement(optionSelector2);
            option2.Click();
            */















        }
    }
}