using System;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleAsInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article article = new Article(articleAsInput[0], articleAsInput[1], articleAsInput[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");
                string command = commands[0];

                switch (command)
                {
                    case "Edit":
                        article.Edit(commands[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(commands[1]);
                        break;
                    case "Rename":
                        article.Rename(commands[1]);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string Rename(string title) => Title = title;

        public string Edit(string content) => Content = content;

        public string ChangeAuthor(string author) => Author = author;

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
