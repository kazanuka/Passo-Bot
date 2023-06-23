using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            /*
            int targetHour = Convert.ToInt32(hour.Text);
            int targetMinute = Convert.ToInt32(minute.Text);

            int currentHour = DateTime.Now.Hour;
            int currentMinute = DateTime.Now.Minute;

            // Hedef saat ve dakika ile �u anki saat ve dakikay� kar��la�t�r�n
            if (currentHour < targetHour || (currentHour == targetHour && currentMinute < targetMinute))
            {
                // Hedef saatine kadar bekleyin
                DateTime targetTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, targetHour, targetMinute, 0);
                TimeSpan waitTime = targetTime - DateTime.Now;
                Thread.Sleep(waitTime);
            }
            */

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.passo.com.tr/en/login");
           
            IWebElement emailInput = driver.FindElement(By.CssSelector("input[autocomplete='username']"));//kullan�c� ad� ve �ifreyi al
            IWebElement pass = driver.FindElement(By.CssSelector("input[autocomplete='current-password']"));
            IWebElement button = driver.FindElement(By.ClassName("black-btn"));
            
            emailInput.SendKeys(textBox1.Text);
            pass.SendKeys(textBox2.Text);

            MessageBox.Show("Captcha'y� Tamamlad�ktan Sonra 'Tamam' Tu�una Bas�n");//kullan�c�n�n captchay� tamamlamas�n� bekle
            button.Click();

            IWebElement futbol = driver.FindElement(By.CssSelector("a[href='/en/category/football-match-ticket/4615']"));//futbol k�sm�na giri� yap
            futbol.Click();
            //IWebElement adanaButon = driver.FindElement(By.XPath("//div[contains(text(), 'Adana Demirspor A.�.')]"));
            //adanaButon.Click();

        }
    }
}