using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.DTO;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MangaController : ControllerBase
    {
        protected ResponseDto response;
        private readonly IMangaRepository _mangaRepository;
        public MangaController(IMangaRepository mangaRepository)
        {
            _mangaRepository = mangaRepository;
            response = new ResponseDto();
        }

        [HttpGet]
        public async Task<object> GetList()
        {
            try
            {
                var res = await _mangaRepository.GetList();
                response.Result = res;
                response.IsSuccess = true;
            }
            catch (Exception e)
            {
                response.ErrorMessages.Add(e.Message);
                response.IsSuccess = false;
            }
            return response;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> GetById(int id)
        {
            try
            {
                var res = await _mangaRepository.GetById(id);
                response.Result = res;
                response.IsSuccess = true;
            }
            catch (Exception e)
            {
                response.ErrorMessages.Add(e.Message);
                response.IsSuccess = false;
            }
            return response;
        }

        [HttpPost]
        public async Task<object> Create([FromBody] MangaDto mangaDto)
        {
            try
            {
                var res = await _mangaRepository.CreateUpdate(mangaDto);
                response.Result = res;
                response.IsSuccess = true;
            }
            catch (Exception e)
            {
                response.ErrorMessages.Add(e.Message);
                response.IsSuccess = false;
            }
            return response;
        }

        [HttpPut]
        public async Task<object> Update([FromBody] MangaDto mangaDto)
        {
            try
            {
                var res = await _mangaRepository.CreateUpdate(mangaDto);
                response.Result = res;
                response.IsSuccess = true;
            }
            catch (Exception e)
            {
                response.ErrorMessages.Add(e.Message);
                response.IsSuccess = false;
            }
            return response;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<object> Delete(int id)
        {
            try
            {
                var res = await _mangaRepository.Delete(id);
                response.Result = res;
                response.IsSuccess = true;
            }
            catch (Exception e)
            {
                response.ErrorMessages.Add(e.Message);
                response.IsSuccess = false;
            }
            return response;
        }
    }
}
