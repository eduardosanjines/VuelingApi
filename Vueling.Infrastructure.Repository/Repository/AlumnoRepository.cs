using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Resources;
using System.Threading.Tasks;
using Vueling.Common.Layer;
using Vueling.Domain.Entities;
using Vueling.Infraestructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.Properties;

namespace Vueling.Infrastructure.Repository.Repository
{
    public class AlumnoRepository : IRepositiry<AlumnoEntity>
    {
        public AlumnoRepository Add(AlumnoRepository alumnoRepository)
        {

  
            return alumnoRepository;
            //throw new NotImplementedException();

        }

        public AlumnoEntity Add(AlumnoEntity model)
        {
            try
            {
                Console.WriteLine();
            }
            catch (DbUpdateException ex)
            {
                // ex.Message
                //You Must LOG 
                throw new VuelingException(ResAlumno.Update, ex);
               // ex.InnerException.Message;
            }
            catch (NotSupportedException ex)
            {
                //You Must LOG
                throw new VuelingException(ResAlumno.Support, ex);
                // ex.InnerException.Message;
            }
            catch (ObjectDisposedException ex)
            {
                //You Must LOG
                throw new VuelingException(ResAlumno.Object, ex);
            }
            catch (InvalidOperationException ex)
            {
                //You Must LOG
                throw new VuelingException("", ex);
            }

            return model;
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
