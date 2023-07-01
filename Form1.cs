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

            try
            {
                

                IWebElement emailInput = driver.FindElement(By.CssSelector("input[autocomplete='username']"));//kullanýcý adý ve þifreyi al
                IWebElement pass = driver.FindElement(By.CssSelector("input[autocomplete='current-password']"));
                IWebElement button = driver.FindElement(By.ClassName("black-btn"));

                emailInput.SendKeys(textBox1.Text);
                pass.SendKeys(textBox2.Text);
                
                MessageBox.Show("Captcha'yý Tamamladýktan Sonra 'Tamam' Tuþuna Basýn");//kullanýcýnýn captchayý tamamlamasýný bekle
                button.Click();

                driver.Navigate().GoToUrl(textBox3.Text);
                Thread.Sleep(2000);

                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("window.scrollBy(0, 500);");


                Thread.Sleep(2000);

                





                IWebElement satin_al = driver.FindElement(By.CssSelector("button.red-btn[type='button']"));
                satin_al.Click();


                //BU KISIMA KADAR KOD ÇALIÞIYOR 01.07.23
                
                
                jsExecutor.ExecuteScript("window.scrollBy(0, -100);");


                //Thread.Sleep(500);


                //IWebElement comboBox = driver.FindElement(By.CssSelector("select.form-control"));


                //SelectElement selectElement = new SelectElement(comboBox);
                //selectElement.SelectByText("General Sales");



            }

            catch(Exception ex)
            {
                driver.Quit();
                Application.Exit(); 
                
            }






        }
    }
}