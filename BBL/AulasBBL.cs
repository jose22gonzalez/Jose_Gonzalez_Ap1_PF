using System.Linq.Expressions;
using  Microsoft.EntityFrameworkCore;
using Jose_Gonzalez_Ap1_PF.DAL;
using Jose_Gonzalez_Ap1_PF.Entidades;

namespace Jose_Gonzalez_Ap1_PF.BBL
{
    public class AulasBBL
    {
        private Contexto _contexto;
        public AulasBBL(Contexto contexto)
        {
            _contexto = contexto;
        }
        
        public List<Aulas> GetList(Expression<Func<Aulas, bool>> criterio)
        {
            List<Aulas> lista = new List<Aulas>();
            try
            {
                lista = _contexto.Aulas.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

        public Aulas Buscar(int aulaid)
        {
            Aulas aulas = new Aulas();
            try
            {
                aulas = _contexto.Aulas.Find(aulaid);
            }
            catch(Exception)
            {
                throw;
            }

            return aulas;
        }

    
    }
}