﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiBook_1.BusinessLayer.Abstract;
using MyApiBook_1.EntityLayer.Concrete;

namespace MyApiBook_1.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriterController : ControllerBase
    {
        private readonly IWriterService _writerService;

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [HttpGet]
        public IActionResult WriterList()
        {
            var values = _writerService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateWriter(Writer writer)
        {
            _writerService.TInsert(writer);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteWriter(int id)
        {
            _writerService.TDelete(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateWriter(Writer writer)
        {
            _writerService.TUpdate(writer);
            return Ok("Güncelleme Başarıılı");
        }

        [HttpGet("GetWriter")]
        public IActionResult GetWriter(int id)
        {
            var value = _writerService.TGetById(id);
            return Ok(value);
        }
    }
}
