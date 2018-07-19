using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Application.Dto;
using Vueling.Application.Services.Contracts;
using Vueling.Common.Layer;
using Vueling.Domain.Entities;
using Vueling.Infraestructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.Repository;

namespace Vueling.Application.Services.Services
{
    public class AlumnoService : IService<AlumnoDto>
    {
        private readonly IRepositiry<AlumnoEntity> alumnoRepository;
        public AlumnoService():this (new AlumnoRepository())
        {
        }

        public AlumnoService(AlumnoRepository alumnoRepository)
        {
            this.alumnoRepository = alumnoRepository;
        }

        public AlumnoDto Add(AlumnoDto alumnoDto)
        {
            AlumnoEntity alumnoEntity = new AlumnoEntity();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AlumnoDto, AlumnoEntity>()

                 .ForMember(dest => dest.Edad, sou => sou.ResolveUsing(entity => DateTime.Today.AddTicks(-entity.FechaNacimiento.Ticks).Year - 1)));

            IMapper iMapper = config.CreateMapper();

            alumnoEntity = iMapper.Map<AlumnoDto, AlumnoEntity>(alumnoDto);
            try
            {
                alumnoRepository.Add(alumnoEntity);
            }
            catch (VuelingException ex)
            {
                throw;
            }

            return alumnoDto;

        }

        public List<AlumnoDto> GetAll()
        {
            List<AlumnoDto> alumnoDto = new List<AlumnoDto>();
            return alumnoDto;
        }

        public AlumnoDto GetTById(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public AlumnoDto Update(Task model)
        {
            throw new NotImplementedException();
        }
    }
}
