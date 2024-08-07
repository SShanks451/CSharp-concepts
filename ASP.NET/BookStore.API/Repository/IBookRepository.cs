﻿using BookStore.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBookByIdAsync(int bookId);
        Task<int> AddBookAsync(BookModel bookModel);
        Task UpdatBookAsync(int bookId, BookModel bookModel);
        Task UpdatBookPatchAsync(int bookId, JsonPatchDocument bookModel);
        Task DeleteBookAsync(int bookId);
    }
}
