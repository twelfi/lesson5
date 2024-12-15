namespace Task1;
internal class Program
{
    static void Main(string[] args)
    {
        Book DefaultBook = new Book();
        DefaultBook.GetDescription();
        Book MyBook = new Book("Преступление и наказание", "Фёдор Достоевский", 672); 
        MyBook.GetDescription();
        Book YourBook = new Book();
        YourBook.GetNewBook();
        YourBook.GetDescription();
    }
}
