namespace Task1
{
    internal class Book
    {
        private string _title;
        public string Title
        {
            get { return _title; }  
            set { _title = value; } 
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        private int _pages;
        public int Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }

        public Book()
        {
            _title = "Unknown";
            _author = "Unknown";
            _pages = 0;
        }

        public Book(string _title, string _author, int _pages)
        {
            Title = _title;   
            Author = _author;
            Pages = _pages;
        }

        public void GetDescription()
        {
            Console.WriteLine($"Название: {_title}, Автор: {_author}, Страниц: {_pages}");
        }

        public void GetNewBook()
        {
            Console.WriteLine("Теперь добавьте свою книгу");
            Console.WriteLine("Введите название книги:");
            _title = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(_title))
            {
                Console.WriteLine("Некорректное значение");
                _title = Console.ReadLine();
            }

            Console.WriteLine("Введите автора книги:");
            _author = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(_author) || _author.Any(char.IsDigit))
            {
                Console.WriteLine("Некорректное значение");
                _author = Console.ReadLine();
            }

            Console.Write("Введите количество страниц:");
            while (!int.TryParse(Console.ReadLine(), out _pages) || _pages <= 0)
            {
                Console.WriteLine("Некорректное значение");
            }
        }
    }
}
