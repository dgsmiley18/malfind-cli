using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace anilist
{
    public class MALFind
    {
        //Menu
        enum Option { anime = 1, manga = 2, sair = 3 };
        public static void Main(String[] args)
        {
            Console.WriteLine("Bem vindo ao Scraper do MyAnimeList!!\nEscolha uma opção:");
            Console.WriteLine("1 = Anime\n2 = Manga");
            Option index = (Option)int.Parse(Console.ReadLine());
            Console.Clear();

            switch (index)
            {
                case Option.anime:
                    MalAnime.Anime();
                    break;
                case Option.manga:
                    MalManga.Manga();
                    break;
            }
        }
    }
}
