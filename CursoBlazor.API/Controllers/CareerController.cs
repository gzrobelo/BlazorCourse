using CursoBlazor.Core.DTOs;
using CursoBlazor.API.Services.Contracts;
using CursoBlazor.Application.Interfaces;
using CursoBlazor.Core.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CursoBlazor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareerController : ControllerBase
    {
        public ICareerService _careerService { get; set; }
        private readonly ILogger<CareerController> _logger;


        public CareerController(ICareerService careerService, ILogger<CareerController> logger)
        {
            _careerService = careerService;
            _logger = logger;
        }


        // GET: api/<CareerController>
        /// <summary>
        /// This endpoint returns all Careers from the repository
        /// </summary>
        /// <returns>List of career objects</returns>
        [HttpGet(Name = "Careers")]
        public async Task<IEnumerable<Career>> GetAll()
        {
            return await _careerService.GetAll();

        }


        // GET api/<CareerController>/5
        /// <summary>
        /// This endpoint returns a single career by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Carrer object</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var searchCareer = await _careerService.GetByCareerId(id);

                if (searchCareer == null)
                {
                    return NotFound();
                }

                return Ok(searchCareer);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            
        }

        // POST api/<CareerController>
        [HttpPost]
        public async Task<ActionResult<Career>> Add([FromBody] CareerDto careerToAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (careerToAdd == null)
            {
                return BadRequest(careerToAdd);
            }

            try
            {
                var createResult = await _careerService.AddCareer(careerToAdd);

                return Ok(createResult);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        // PUT api/<CareerController>/5
        //[HttpPut("{id}")]
        [HttpPut]
        public async Task<IActionResult> Update(Guid id, [FromBody] CareerDto careerToUpdate)
        {
            if (careerToUpdate == null || id != careerToUpdate.Id)
            {
                return BadRequest(careerToUpdate);
            }

            var careerUpdate = await _careerService.Update(careerToUpdate);

            if (careerToUpdate.Id == Guid.Empty)
            {
                return NoContent();
            }

            return Ok(careerUpdate);
        }

        //[HttpPatch]
        //public async Task<IActionResult> UpdatePartial(Guid id, JsonPatchDocument<CareerDto> careerToPatch)
        //{
        //    if (careerToPatch == null || id == Guid.Empty)
        //    {
        //        return BadRequest(careerToPatch);
        //    }

        //    var searchCareerToPatch = await _careerService.GetByCareerId(id);

        //    careerToPatch.ApplyTo(searchCareerToPatch,ModelState);

        //    if (careerToUpdate.Id == Guid.Empty)
        //    {
        //        return NoContent();
        //    }

        //    return Ok(careerUpdate);
        //}

        //// DELETE api/<CareerController>/5
        //[HttpDelete("{id}")]
        ////[HttpDelete]
        //public async Task<IActionResult> Delete(Guid id)
        //{
        //    var data = await _unitOfWork.Careers.DeleteAsync(id);

        //    return Ok(data);
        //}
    }
}
