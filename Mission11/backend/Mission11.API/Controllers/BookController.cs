using Microsoft.AspNetCore.Mvc;
using Mission11.API.Data;

namespace Mission11.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : Controller
{
    private BookstoreDbContext _dbContext; // Allows instance of dbContext to be visible in all methods
    
    public BookController(BookstoreDbContext temp) // CONSTRUCTOR (creates instance of dbcontext)
    {
        _dbContext = temp;
    }
    
    [HttpGet("AllBooks")]
    public IEnumerable<Book> GetProjects() // Enumerable list of books
    {
        return _dbContext.Books.ToList();
    }
}