using Config.Models;
using DataBase.Models.MongoDB;
using IRepository.MongoDB;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Repository.MongoDB
{
    public class BookRepository: IBookRepository
    {
        private readonly IMongoCollection<Book> _books;

        public BookRepository(IOptions<MongodbSettings> settingsOption)
        {
            var setting = settingsOption.Value;
            var client = new MongoClient(setting.ConnectionString);
            var database = client.GetDatabase(setting.DatabaseName);

            _books = database.GetCollection<Book>(setting.BooksCollectionName);
        }
        public List<Book> Get() =>
            _books.Find(book => true).ToList();

        public Book Get(string id) =>
            _books.Find<Book>(book => book.Id == id).FirstOrDefault();

        public Book Create(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        public void Update(string id, Book bookIn) =>
            _books.ReplaceOne(book => book.Id == id, bookIn);

        public void Remove(Book bookIn) =>
            _books.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) =>
            _books.DeleteOne(book => book.Id == id);
    }
}
