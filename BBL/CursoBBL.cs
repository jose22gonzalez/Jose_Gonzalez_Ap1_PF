using System.Linq.Expressions;
using  Microsoft.EntityFrameworkCore;
using Jose_Gonzalez_Ap1_PF.DAL;
using Jose_Gonzalez_Ap1_PF.Entidades;

namespace Jose_Gonzalez_Ap1_PF.BBL
{
    public class CursoBBL
    {
        private Contexto _contexto;
        public CursoBBL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<Cursos> GetList(Expression<Func<Cursos, bool>> criterio)
        {
            List<Cursos> lista = new List<Cursos>();
            try
            {
                lista = _contexto.Cursos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

        public Cursos Buscar(int cursoid)
        {
            Cursos curso = new Cursos();
            try
            {
                curso = _contexto.Cursos.Find(cursoid);
            }
            catch(Exception)
            {
                throw;
            }

            return curso;
        }
    }
}