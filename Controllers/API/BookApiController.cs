using AutoMapper;
using LibApp_Gr3.Models;
using LibApp_Gr3.Models.DTO;
using LibApp_Gr3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LibApp_Gr3.Controllers.API
{
    [Route("api/book")]
    [ApiController]
    public class BookApiController : ControllerBase
    {
        protected BookService BookService { get; }
        protected IMapper Mapper { get; }
        public BookApiController(BookService bookService, IMapper mapper)
        {
            BookService = bookService;
            Mapper = mapper;
        }

        [HttpGet("get-list")]
        public ActionResult<List<BookDTO>> GetList()
        {
            var _bookList = BookService.GetList();

            if (_bookList == null || _bookList.Count() == 0)
                return NotFound();

            return Ok(Mapper.Map<IEnumerable<Book>, IEnumerable<BookDTO>>(_bookList));
        }
    }
}
