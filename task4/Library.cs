using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*5. 	Создать класс Library и структуру Book
	Класс Library должен содержать массив типа Book
	Класс Library должен предоставлять методы:
		• Добавление книги 
			void AddBook(string bookName) 
			void AddBook(Book book)
		• Удаление книги
			void RemoveBook(string bookName)
			void RemoveBook(Book book)
		• Вывод на экран названий всех книг, который на данный момент есть в библиотеке
			void ShowBooks()
		• Метод поиска книги 
			bool IsBookExist(string bookName)
			bool IsBookExist(Book book)*/

namespace Lection4
{
    class Library
    {
		private List<Book> libraryBooks;

		public Library() : this(new List<Book>())
        {

        }

		public Library(List<Book> books)
        {
			libraryBooks = books;
		}

		public List<Book> LibraryBooks
        {
			get
            {
				return libraryBooks;
            }

            set
            {
				libraryBooks = value;
            }
        }

		public void AddBook(string bookName)
        {
			libraryBooks.Add(new Book(bookName));
        }

		public void AddBook(Book book)
		{
			libraryBooks.Add(book);
		}

		public void RemoveBook(string bookName)
		{
			libraryBooks.RemoveAll(book => book.BookName == bookName);
		}

		public void RemoveBook(Book book)
		{
			libraryBooks.Remove(book);
		}

		public void ShowBooks()
        {
			Console.WriteLine("\nCurrent library books: ");
			foreach(var book in libraryBooks)
            {
				Console.WriteLine(book.BookName);
            }
        }

		public bool IsBookExist(string bookName)
        {
			return libraryBooks.Any(book => book.BookName == bookName);
		}

		public bool IsBookExist(Book book)
		{
			return libraryBooks.Contains(book);
		}
	}

	struct Book
    {
		private string bookName;

		public Book(string bookName)
        {
			this.bookName = bookName;
        }

		public string BookName
        {
            get
            {
				return bookName;
            }

            set
            {
				bookName = value;
            }
        }
	}
}
