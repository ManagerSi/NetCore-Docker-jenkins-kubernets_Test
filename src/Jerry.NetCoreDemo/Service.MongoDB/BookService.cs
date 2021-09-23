using DataBase.Models.MongoDB;
using IRepository.MongoDB;
using IService.MongoDB;
using System;
using System.Collections.Generic;

namespace Service.MongoDB
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public List<Book> Get()
        {
            return _repository.Get();
        }

        public Book Get(string id)
        {
            return _repository.Get(id);
        }

        public void Remove(Book bookIn)
        {
            _repository.Remove(bookIn);
        }

        public void Remove(string id)
        {
            _repository.Remove(id);
        }

        public void Update(string id, Book bookIn)
        {
            _repository.Update(id, bookIn);
        }
    }
}
