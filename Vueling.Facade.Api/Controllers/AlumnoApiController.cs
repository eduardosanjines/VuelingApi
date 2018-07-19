using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using System.Web.Http.Description;
using Vueling.Application.Dto;
using Vueling.Application.Services.Contracts;
using Vueling.Application.Services.Services;
using Vueling.Common.Layer;

namespace Vueling.Facade.Api.Controllers
{
    public class AlumnoApiController : ApiController
    {
        private readonly IService<AlumnoDto> alumnoService;
        
        public AlumnoApiController() : this(new AlumnoService())
        {
        }

        public AlumnoApiController(AlumnoService alumnoService)
        {
            this.alumnoService = alumnoService;
        }

        // GET: api/AlumnoApi
        public IEnumerable<AlumnoDto> Get()
        {
            List<AlumnoDto> alumnoDto = new List<AlumnoDto>();
            return alumnoDto;

        }

        // GET: api/AlumnoApi/5
        public IHttpActionResult Get(int id)
        {



            throw new NotImplementedException("Method not implemented yet");
        }

        // POST: api/AlumnoApi
        [ResponseType(typeof(AlumnoDto))]
        public IHttpActionResult AlumnoDto(AlumnoDto alumnoDto)
        {
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create("http://localhost:41137/");
            httpReq.AllowAutoRedirect = false;
            HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            AlumnoDto alumnoDtoInserted = null;
            try
            {
                alumnoDtoInserted = alumnoService.Add(alumnoDto);
            }
            catch (VuelingException ex)
            {
                if (httpRes.StatusCode == HttpStatusCode.Moved)
                {
                    // Code for moved resources goes here.
                }
                else {

                   // ex.Message;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = alumnoDtoInserted.Id }, alumnoDtoInserted);

        }

        // PUT: api/AlumnoApi/5
        public IHttpActionResult Put(int id, AlumnoDto alumnoDto)
        {
            //Devolver un id (Sin AutoMapper)
            throw new NotImplementedException("Method not implemented yet");

        }

        // DELETE: api/AlumnoApi/5
        public IHttpActionResult Delete(int id)
        {
            throw new NotImplementedException("Method not implemented yet");
        }
    }
}
