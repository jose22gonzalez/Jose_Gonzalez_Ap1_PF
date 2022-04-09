using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Jose_Gonzalez_Ap1_PF.DAL;
using Jose_Gonzalez_Ap1_PF.Entidades;

namespace Jose_Gonzalez_Ap1_PF.BBL
{
    public class GruposBBL
    {
        private Contexto _contexto;
        public GruposBBL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int GrupoId)
        {
            bool paso = false;

            try
            {
                paso = _contexto.Grupo.Any(p => p.GrupoId == GrupoId);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        public bool Existe(string descripcion)
        {
            bool paso = false;

            try
            {
                paso = _contexto.Grupo.Any(p => p.DescripcionCurso == descripcion);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }




        private bool Insertar(Grupos grupos)
        {
            bool paso = false;
            try
            {
                _contexto.Grupo.Add(grupos);
                paso = _contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Modificar(Grupos grupos)
        {
            bool paso = false;

            try
            {
                _contexto.Entry(grupos).State = EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public bool Guardar(Grupos grupos)
        {
            if (Existe(grupos.GrupoId))
                return Modificar(grupos);
            else
                return Insertar(grupos);

        }

        public Grupos? Buscar(int grupoId)
        {
            Grupos? grupos = new Grupos();

            try
            {
                grupos = _contexto.Grupo.Find(grupoId);
            }
            catch (Exception)
            {
                throw;
            }

            return grupos;
        }


        public bool Eliminar(int grupoId)
        {
            bool paso = false;

            try
            {
                var grupo = _contexto.Grupo.Find(grupoId);
                if (grupo != null)
                {
                    _contexto.Grupo.Remove(grupo);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public List<Grupos> GetList(Expression<Func<Grupos, bool>> criterio)
        {
            List<Grupos> lista = new List<Grupos>();
            try
            {
                lista = _contexto.Grupo.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

    }
}