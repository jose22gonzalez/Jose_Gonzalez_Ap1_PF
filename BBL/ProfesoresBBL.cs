using System.Linq.Expressions;
using  Microsoft.EntityFrameworkCore;
using Jose_Gonzalez_Ap1_PF.DAL;
using Jose_Gonzalez_Ap1_PF.Entidades;

namespace Jose_Gonzalez_Ap1_PF.BBL
{
    public class ProfesoresBBL
    {
        private Contexto _contexto;
        public ProfesoresBBL(Contexto contexto)
        {
            _contexto = contexto;
        }

        private bool Existe(int ProfesorId)
        {
            bool paso = false;

            try
            {
                paso = _contexto.Profesor.Any(p => p.ProfesorId == ProfesorId);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

     

        private bool Insertar(Profesores profesores)
        {
            bool paso = false;
            try
            {
                _contexto.Profesor.Add(profesores);
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Modificar(Profesores profesores)
        {
            bool paso = false;

            try
            {
                _contexto.Entry(profesores).State = EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public bool Guardar(Profesores profesores)
        {
            if (Existe(profesores.ProfesorId))
                return Modificar(profesores);
            else
                return Insertar(profesores);
        }

        public Profesores? Buscar(int ProfesorId)
        {
            Profesores? profesores = new Profesores();

            try
            {
                profesores = _contexto.Profesor.Find(ProfesorId);
            }
            catch (Exception)
            {
                throw;
            }

            return profesores;
        }
       

        public bool Eliminar(int ProfesorId)
        {
            bool paso = false;

            try
            {
                var profesor = _contexto.Profesor.Find(ProfesorId);
                if (profesor != null)
                {
                    _contexto.Profesor.Remove(profesor);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public List<Profesores> GetList(Expression<Func<Profesores, bool>> criterio)
        {
            List<Profesores> lista = new List<Profesores>();
            try
            {
                lista = _contexto.Profesor.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
    }
}