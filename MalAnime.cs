using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace anilist
{
    public class MalAnime
    {
        public static void Anime()
        {
            Console.Write("Digite o numero do anime: ");
            int anilist = int.Parse(Console.ReadLine());
            string site = "https://myanimelist.net/anime/" + anilist;
            var chromeOptions = new ChromeOptions();

            chromeOptions.AddArgument("headless");
            chromeOptions.AddArgument("Access-Control-Allow-Origin");
            var driver = new ChromeDriver(chromeOptions);

            driver.Navigate().GoToUrl(site);
            Console.Clear();

            var janame = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div[1]/div/div[1]/div/h1")).Text;
            var desc = driver.FindElement(By.XPath("//*[@id='content']/ table/tbody/tr/td[2]/div[1]/table/tbody/tr[1]/td/p")).Text;
            var gen1 = driver.FindElement(By.XPath("//*[@id='content']/ table/tbody/tr/td[1]/div/div[19]")).Text;

            Console.WriteLine($"Japanese Name: {janame}");
            try
            {
                var enname = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div[1]/div/div[1]/div/p")).Text;
                Console.WriteLine($"English Name: {enname}\n");
            }
            catch
            {

            }

            Console.WriteLine($"Synopsis: \n {desc}");
            Console.WriteLine(gen1);
            driver.Close();
        }
    }
}
