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
            

                IWebElement emailInput = driver.FindElement(By.CssSelector("input[autocomplete='username']"));//kullanýcý adý ve þifreyi al
                IWebElement pass = driver.FindElement(By.CssSelector("input[autocomplete='current-password']"));
                IWebElement button = driver.FindElement(By.ClassName("black-btn"));

                emailInput.SendKeys(textBox1.Text);
                pass.SendKeys(textBox2.Text);
                
                MessageBox.Show("Captcha'yý Tamamladýktan Sonra 'Tamam' Tuþuna Basýn");//kullanýcýnýn captchayý tamamlamasýný bekle
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


              

            //Bu kýsýmdan sonrasý deneysel.
            /*
            // Ýlk dropdown elementini bulmak için bekleme yap
            By dropdownSelector1 = By.CssSelector("select.form-control.ng-valid.ng-dirty.ng-touched");
            IWebElement dropdown1 = driver.FindElement(dropdownSelector1);

            // Ýlk dropdownu seçmek için týklama
            dropdown1.Click();

            // Bekleme yap
            Thread.Sleep(1000); // 1 saniye bekleme

            // Ýlk dropdown için seçeneði bulma ve týklama
            By optionSelector1 = By.CssSelector("select.form-control.ng-valid.ng-dirty.ng-touched option[value='1: Object']");
            IWebElement option1 = driver.FindElement(optionSelector1);
            option1.Click();

            // Ýkinci dropdown elementini bulmak için bekleme yap
            By dropdownSelector2 = By.CssSelector("select.form-control[style='width: 27%']");
            IWebElement dropdown2 = driver.FindElement(dropdownSelector2);

            // Ýkinci dropdownu seçmek için týklama
            dropdown2.Click();

            // Bekleme yap
            Thread.Sleep(1000); // 1 saniye bekleme

            // Ýkinci dropdown için seçeneði bulma ve týklama
            By optionSelector2 = By.CssSelector("select.form-control[style='width: 27%'] option[value='1']");
            IWebElement option2 = driver.FindElement(optionSelector2);
            option2.Click();
            */















        }
    }
}