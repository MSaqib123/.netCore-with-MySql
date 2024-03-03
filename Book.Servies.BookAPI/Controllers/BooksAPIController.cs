using AutoMapper;
using Book.Servies.BookAPI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Book.Servies.BookAPI.Models;
using Book.Servies.BookAPI.Models.Dto;
using Book.Services.CouponAPI.Models.Dto;

namespace Book.Servies.BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public BooksAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<BookModel> objList = _db.BooksModel.ToList();
                _response.Result = _mapper.Map<IEnumerable<BookDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                BookModel obj = _db.BooksModel.First(u => u.Id == id);
                _response.Result = _mapper.Map<BookDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        
        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        public ResponseDto Post([FromBody] BookDto couponDto)
        {
            try
            {
                BookModel obj = _mapper.Map<BookModel>(couponDto);
                _db.BooksModel.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<BookDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }


        [HttpPut]
        [Authorize(Roles = "ADMIN")]
        public ResponseDto Put([FromBody] BookDto couponDto)
        {
            try
            {
                BookModel obj = _mapper.Map<BookModel>(couponDto);
                _db.BooksModel.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<BookDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("{id:int}")]
        [Authorize(Roles = "ADMIN")]
        public ResponseDto Delete(int id)
        {
            try
            {
                BookModel obj = _db.BooksModel.First(u => u.Id == id);
                _db.BooksModel.Remove(obj);
                _db.SaveChanges();


                //var service = new Stripe.BookModelService();
                //service.Delete(obj.BookModelCode);


            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
