using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vueling.Domain.Entities;
using Vueling.Infraestructure.Repository.Contracts;

namespace Vueling.Infrastructure.Repository.Repository
{
    public class AlumnoRepository : IRepositiry<AlumnoEntity>
    {
        public AlumnoRepository Add(AlumnoRepository model)
        {
            throw new NotImplementedException();
        }

        public AlumnoEntity Add(AlumnoEntity model)
        {
            throw new NotImplementedException();
        }

        public List<AlumnoRepository> gestAll()
        {
            throw new NotImplementedException();
        }

        public AlumnoRepository GetTById(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public AlumnoRepository Update(Task model)
        {
            throw new NotImplementedException();
        }

        List<AlumnoEntity> IRepositiry<AlumnoEntity>.gestAll()
        {
            throw new NotImplementedException();
        }

        AlumnoEntity IRepositiry<AlumnoEntity>.GetTById(int id)
        {
            throw new NotImplementedException();
        }

        AlumnoEntity IRepositiry<AlumnoEntity>.Update(Task model)
        {
            throw new NotImplementedException();
        }
    }
}
