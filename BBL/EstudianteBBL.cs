using System.Linq.Expressions;
using  Microsoft.EntityFrameworkCore;
using Jose_Gonzalez_Ap1_PF.DAL;
using Jose_Gonzalez_Ap1_PF.Entidades;

namespace Jose_Gonzalez_Ap1_PF.BBL
{
    public class EstudianteBBL
    {
          private Contexto _contexto;
        public EstudianteBBL(Contexto contexto)
        {
            _contexto = contexto;
        }

         public List<Estudiante> GetList(Expression<Func<Estudiante, bool>> criterio)
        {
            List<Estudiante> lista = new List<Estudiante>();
            try
            {
                lista = _contexto.Estudiantes.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
    }
    
}