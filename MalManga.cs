using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace anilist
{
    public class MalManga
    {
        public static void Manga()
        {
            Console.Write("Digite o numero do manga: ");
            int anilist = int.Parse(Console.ReadLine());
            string site = "https://myanimelist.net/manga/" + anilist;
            var chromeOptions = new ChromeOptions();

            chromeOptions.AddArgument("headless");
            chromeOptions.AddArgument("Access-Control-Allow-Origin");
            var driver = new ChromeDriver(chromeOptions);

            driver.Navigate().GoToUrl(site);
            var janame = driver.FindElement(By.CssSelector(".h1-title > span:nth-child(1)")).Text;
            var desc = driver.FindElement(By.CssSelector(".rightside > table:nth-child(5) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > span:nth-child(3)")).Text;
            var gen2 = driver.FindElement(By.XPath("//*[@id='content']/ table/tbody/tr/td[1]/div/div[14]")).Text;

            Console.Clear();
            Console.WriteLine($"Japanese Name: {janame}");

            try
            {
                var enname = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div[1]/div/div[1]/div/p")).Text;
                Console.WriteLine($"English Name: {enname}\n");
            }
            catch
            {

            }
            Console.WriteLine($"Synopsis:\n{desc}");
            Console.WriteLine(gen2);
            driver.Close();
        }
    }
}
