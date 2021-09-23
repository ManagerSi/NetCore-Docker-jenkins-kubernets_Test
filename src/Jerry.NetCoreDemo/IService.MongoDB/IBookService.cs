using DataBase.Models.MongoDB;
using System;
using System.Collections.Generic;

namespace IService.MongoDB
{
    public interface IBookService
    {
        List<Book> Get();

        Book Get(string id);

        Book Create(Book book);

        void Update(string id, Book bookIn);

        void Remove(Book bookIn);

        void Remove(string id);
    }
}
